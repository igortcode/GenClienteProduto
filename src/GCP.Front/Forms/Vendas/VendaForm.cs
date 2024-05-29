using GCP.App.DTO.Clientes;
using GCP.App.DTO.Venda;
using GCP.App.Interfaces.Services;
using GCP.Core.Validations.CustomExceptions;
using GCP.Front.Forms.Vendas;

namespace GCP.Front.Forms
{
    public partial class VendaForm : Form
    {
        private readonly IClienteServices _clienteServices;
        private readonly IProdutoServices _produtoServices;
        private readonly IVendaServices _vendaServices;
        private ClienteDTO _clienteDto;
        private ClienteVendaForm _frmClienteVenda;
        private IList<ProdutoXVendaDTO> _produtosVendaDto;
        private ProdutoVendaForm _frmProdutoVenda;
        private TipoPagamentoForm _tipoPagamento;

        public VendaForm(IClienteServices clienteServices, IProdutoServices produtoServices, IVendaServices vendaServices)
        {
            _clienteServices = clienteServices;
            _produtoServices = produtoServices;
            _vendaServices = vendaServices;
            InitializeComponent();
            _clienteDto = new ClienteDTO();
            _produtosVendaDto = new List<ProdutoXVendaDTO>();
            DataBind();
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            if (_frmClienteVenda == null || _frmClienteVenda.IsDisposed)
            {
                _frmClienteVenda = new ClienteVendaForm(_clienteServices, _clienteDto, lbNmCliente, lbEmail, lbEndereco, gbVenda);
                _frmClienteVenda.Show();
            }
            else
            {
                _frmClienteVenda.BringToFront();
            }
        }

        private void btnPesquisaProduto_Click(object sender, EventArgs e)
        {
            if (_frmProdutoVenda == null || _frmProdutoVenda.IsDisposed)
            {
                _frmProdutoVenda = new ProdutoVendaForm(_produtoServices, _produtosVendaDto, this);
                _frmProdutoVenda.Show();
            }
            else
            {
                _frmProdutoVenda.BringToFront();
            }
        }

        public void DataBind()
        {
            try
            {

                dataGridItensVenda.Rows.Clear();
                dataGridItensVenda.Columns.Clear();
                dataGridItensVenda.Refresh();

                dataGridItensVenda.Columns.Add("Id", "Id");
                dataGridItensVenda.Columns.Add("Nome", "Nome");
                dataGridItensVenda.Columns.Add("Codigo", "Código");
                dataGridItensVenda.Columns.Add("Preco", "Preço");
                dataGridItensVenda.Columns.Add("Qtd", "Quantidade");

                dataGridItensVenda.Columns[0].Visible = false;
                dataGridItensVenda.Columns[1].Width = 300;
                dataGridItensVenda.Columns[2].Width = 200;
                dataGridItensVenda.Columns[3].Width = 100;
                dataGridItensVenda.Columns[4].Width = 100;

                txtData.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");

                if (_produtosVendaDto.Count() < 1)
                {
                    dataGridItensVenda.Rows.Add(1);
                    txtTotalItens.Text = "0";
                    txtTotal.Text = "R$ 0,00";
                }
                else
                {
                    dataGridItensVenda.Rows.Add(_produtosVendaDto.Count);

                    for (int i = 0; i < _produtosVendaDto.Count; i++)
                    {
                        dataGridItensVenda.Rows[i].Cells[0].Value = _produtosVendaDto[i].ProdutoId;
                        dataGridItensVenda.Rows[i].Cells[1].Value = _produtosVendaDto[i].Nome;
                        dataGridItensVenda.Rows[i].Cells[2].Value = _produtosVendaDto[i].Codigo;
                        dataGridItensVenda.Rows[i].Cells[3].Value = _produtosVendaDto[i].Preco;
                        dataGridItensVenda.Rows[i].Cells[4].Value = _produtosVendaDto[i].Quantidade;
                    }

                    txtTotalItens.Text = _produtosVendaDto.Count.ToString();
                    txtTotal.Text = $"R$ {_produtosVendaDto.Sum(a => (a.Preco * a.Quantidade))}";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Não foi possível buscar os produtos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoverCliente_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja remover o cliente? Também será removido os itens selecionados na venda!",
                "Remover cliente ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LimparDados();            
            }

        }

        private void dataGridItensVenda_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dataGridItensVenda.CurrentRow.Cells[0].Value != null)
                {

                    var id = (int)dataGridItensVenda.CurrentRow.Cells[0].Value;

                    var result = MessageBox.Show("Tem certeza que deseja remover esse registro?",
                        "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        _produtosVendaDto.Remove(_produtosVendaDto.First(a => a.ProdutoId == id));

                        MessageBox.Show("Produto removido com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DataBind();
                    }

                    Dispose();
                }
                else
                {
                    MessageBox.Show("Selecione uma linha!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Não foi possível remover o produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    var entradaDados = txtCodigo.Text;
                    if (string.IsNullOrEmpty(entradaDados))
                        throw new DomainExceptionValidate("Insira um código!");


                    var dados = entradaDados.Split("x");

                    var qtd = 0m;
                    var codigo = string.Empty;

                    if (dados.Length > 1)
                    {
                        decimal.TryParse(dados[0], out var qtdVal);
                        qtd = qtdVal;
                        codigo = dados[1];
                    }
                    else
                    {
                        qtd = 1;
                        codigo = dados[0];
                    }

                    var produto = _produtoServices.GetByCodigo(codigo);

                    if (produto is null)
                        throw new DomainExceptionValidate("Não foi encontrado nenhum produto com esse código!");

                    if (_produtosVendaDto.Any(a => a.ProdutoId == produto.Id.Value))
                    {
                        var dto = _produtosVendaDto.First(a => a.ProdutoId == produto.Id.Value);

                        var qtdTotal = dto.Quantidade + qtd;
                        if (qtdTotal > produto.Quantidade)
                            throw new DomainExceptionValidate("Quantidade superior ao estoque deste produto! Selecione uma quantidade inferior!");

                        dto.Quantidade = qtdTotal;
                    }
                    else
                    {
                        _produtosVendaDto.Add(new ProdutoXVendaDTO
                        {
                            Codigo = produto.Codigo,
                            Nome = produto.Nome,
                            Preco = produto.Preco,
                            Quantidade = qtd,
                            ProdutoId = produto.Id.Value
                        });
                    }

                    txtCodigo.Text = string.Empty;

                    DataBind();
                }
                catch (DomainExceptionValidate dev)
                {
                    MessageBox.Show(dev.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível buscar o produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var entradaDados = txtCodigo.Text;
                if (string.IsNullOrEmpty(entradaDados))
                    throw new DomainExceptionValidate("Insira um código!");

                var dados = entradaDados.Split("x");

                var qtd = 0m;
                var codigo = string.Empty;

                if (dados.Length > 1)
                {
                    decimal.TryParse(dados[0], out var qtdVal);
                    qtd = qtdVal;
                    codigo = dados[1];
                }
                else
                {
                    qtd = 1;
                    codigo = dados[0];
                }

                var produto = _produtoServices.GetByCodigo(codigo);

                if (produto is null)
                    throw new DomainExceptionValidate("Não foi encontrado nenhum produto com esse código!");

                if (_produtosVendaDto.Any(a => a.ProdutoId == produto.Id.Value))
                {
                    var dto = _produtosVendaDto.First(a => a.ProdutoId == produto.Id.Value);

                    var qtdTotal = dto.Quantidade + qtd;
                    if (qtdTotal > produto.Quantidade)
                        throw new DomainExceptionValidate("Quantidade superior ao estoque deste produto! Selecione uma quantidade inferior!");

                    dto.Quantidade = qtdTotal;
                }
                else
                {
                    _produtosVendaDto.Add(new ProdutoXVendaDTO
                    {
                        Codigo = produto.Codigo,
                        Nome = produto.Nome,
                        Preco = produto.Preco,
                        Quantidade = qtd,
                        ProdutoId = produto.Id.Value
                    });
                }

                DataBind();
            }
            catch (DomainExceptionValidate dev)
            {
                MessageBox.Show(dev.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível buscar o produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Deseja finalizar essa venda?",
                         "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ValidaEntradaDados();

                    var vendaDto = new VendaDTO();
                    vendaDto.Produtos = _produtosVendaDto;
                    vendaDto.ClienteDTO = _clienteDto;

                    if (_tipoPagamento == null || _tipoPagamento.IsDisposed)
                    {
                        _tipoPagamento = new TipoPagamentoForm(_vendaServices, this, vendaDto);
                        _tipoPagamento.Show();
                    
                    }
                    else
                    {
                        _tipoPagamento.BringToFront();
                    }
                }
            }
            catch (DomainExceptionValidate dev)
            {
                MessageBox.Show(dev.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível finalizar a venda.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidaEntradaDados()
        {
            if (_produtosVendaDto.Count == 0) throw new DomainExceptionValidate("Insira ao menos um produto na lista!");

            if (_clienteDto is null || !_clienteDto.Id.HasValue || _clienteDto.Id.Value == 0)
                throw new DomainExceptionValidate("Selecione um cliente válido!");
        }

        public void LimparDados()
        {

            lbEmail.Text = string.Empty;
            lbEndereco.Text = string.Empty;
            lbNmCliente.Text = string.Empty;
            _clienteDto = new ClienteDTO();
            _produtosVendaDto = new List<ProdutoXVendaDTO>();
            txtTotal.Text = string.Empty;
            txtTotalItens.Text = string.Empty;
            gbVenda.Enabled = false;
            DataBind();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja cancelar a venda?",
                "Cancelar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LimparDados();

                MessageBox.Show("Venda cancelada com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
