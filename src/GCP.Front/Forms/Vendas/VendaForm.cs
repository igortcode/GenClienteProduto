using GCP.App.DTO.Clientes;
using GCP.App.DTO.Venda;
using GCP.App.Interfaces.Services;
using GCP.Core.Enums;
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
        private RelatorioVendasForm _relatorioVenadasForm;

        public VendaForm(IClienteServices clienteServices, IProdutoServices produtoServices, IVendaServices vendaServices)
        {
            _clienteServices = clienteServices;
            _produtoServices = produtoServices;
            _vendaServices = vendaServices;
            InitializeComponent();
            _clienteDto = new ClienteDTO();
            _produtosVendaDto = new List<ProdutoXVendaDTO>();
            DataBindGridItensVenda();
            DataBindGridVenda();
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

        public void DataBindGridItensVenda()
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

                    txtTotalItens.Text = _produtosVendaDto.Sum(a => a.Quantidade).ToString();
                    txtTotal.Text = $"R$ {_produtosVendaDto.Sum(a => (a.Preco * a.Quantidade))}";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Não foi possível buscar os produtos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DataBindGridVenda(IList<ObterVendaDTO> obterVendaDTOs = null)
        {
            try
            {
                if (obterVendaDTOs is null)
                    obterVendaDTOs = _vendaServices.GetAllWithClienteRelations().ToList();

                dtGridVenda.Rows.Clear();
                dtGridVenda.Columns.Clear();
                dtGridVenda.Refresh();

                dtGridVenda.Columns.Add("Id", "Id");
                dtGridVenda.Columns.Add("Cliente", "Cliente");
                dtGridVenda.Columns.Add("ValorTotal", "Valor total");
                dtGridVenda.Columns.Add("TpPagamento", "Forma Pagamento");
                dtGridVenda.Columns.Add("DataInclusao", "Data");

                dtGridVenda.Columns[0].Visible = false;
                dtGridVenda.Columns[1].Width = 300;
                dtGridVenda.Columns[2].Width = 250;
                dtGridVenda.Columns[3].Width = 200;
                dtGridVenda.Columns[4].Width = 200;

                if (obterVendaDTOs.Count() < 1)
                {
                    dtGridVenda.Rows.Add(1);
                }
                else
                {
                    dtGridVenda.Rows.Add(obterVendaDTOs.Count);

                    for (int i = 0; i < obterVendaDTOs.Count; i++)
                    {
                        dtGridVenda.Rows[i].Cells[0].Value = obterVendaDTOs[i].Id;
                        dtGridVenda.Rows[i].Cells[1].Value = obterVendaDTOs[i].NomeCliente;
                        dtGridVenda.Rows[i].Cells[2].Value = obterVendaDTOs[i].ValorTotal;
                        dtGridVenda.Rows[i].Cells[3].Value = GetTipoPagamento(obterVendaDTOs[i].TipoPagamento);
                        dtGridVenda.Rows[i].Cells[4].Value = obterVendaDTOs[i].DataInclusao.ToString("dd/MM/yyyy");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível buscar as vendas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private object GetTipoPagamento(TipoPagamento tipoPagamento)
        {
            return tipoPagamento switch
            {
                TipoPagamento.Dinheiro => "Dinheiro",
                TipoPagamento.Debito => "Débito",
                TipoPagamento.Credito => "Crédito",
                TipoPagamento.Cheque => "Cheque",
                _ => string.Empty
            };
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

                        DataBindGridItensVenda();
                    }
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


                    var dados = entradaDados.Split("*");

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

                    DataBindGridItensVenda();
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

                var dados = entradaDados.Split("*");

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

                DataBindGridItensVenda();
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
            DataBindGridItensVenda();
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPesquisa.Text))
                {
                    DataBindGridVenda();
                    return;
                }

                var result = _vendaServices.SearchWithClienteRelations(txtPesquisa.Text);

                DataBindGridVenda(result);
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível buscar as vendas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dtGridVenda_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                if (dtGridVenda.CurrentRow.Cells[0].Value != null)
                {
                    (tabEdit as Control).Enabled = true;

                    var id = (int)dtGridVenda.CurrentRow.Cells[0].Value;

                    PreencherAlterar(_vendaServices.GetById(id));

                    tabControlVenda.SelectedTab = tabEdit;
                    gbAlterar.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível buscar a venda.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencherAlterar(ObterVendaDTO obterVendaDTO)
        {
            var clienteDto = _clienteServices.GetById(obterVendaDTO.ClienteId);

            lbEmailVisualizar.Text = clienteDto.Email;
            lbEnderecoVisualizar.Text = clienteDto.Endereco.EnderecoCompleto();
            lbNomeClienteVisualizar.Text = clienteDto.Nome;

            txtValorTotalVisualizar.Text = $"R$ {obterVendaDTO.ValorTotal.ToString()}";
            txtTotalItensVisualizar.Text = obterVendaDTO.Produtos.Sum(a => a.Quantidade).ToString();
            txtDataVisualizar.Text = obterVendaDTO.DataInclusao.ToString("dd/MM/yyyy");

            DataBindGridVisualizar(obterVendaDTO.Produtos);

            gbAlterar.Enabled = false;
        }

        private void DataBindGridVisualizar(IList<ProdutoXVendaDTO> produtos)
        {
            try
            {

                dataGridVisualizar.Rows.Clear();
                dataGridVisualizar.Columns.Clear();
                dataGridVisualizar.Refresh();

                dataGridVisualizar.Columns.Add("Id", "Id");
                dataGridVisualizar.Columns.Add("Nome", "Nome");
                dataGridVisualizar.Columns.Add("Codigo", "Código");
                dataGridVisualizar.Columns.Add("Preco", "Preço");
                dataGridVisualizar.Columns.Add("Qtd", "Quantidade");

                dataGridVisualizar.Columns[0].Visible = false;
                dataGridVisualizar.Columns[1].Width = 300;
                dataGridVisualizar.Columns[2].Width = 200;
                dataGridVisualizar.Columns[3].Width = 100;
                dataGridVisualizar.Columns[4].Width = 100;


                if (produtos.Count() < 1)
                {
                    dataGridVisualizar.Rows.Add(1);
                }
                else
                {
                    dataGridVisualizar.Rows.Add(produtos.Count);

                    for (int i = 0; i < produtos.Count; i++)
                    {
                        dataGridVisualizar.Rows[i].Cells[0].Value = produtos[i].ProdutoId;
                        dataGridVisualizar.Rows[i].Cells[1].Value = produtos[i].Nome;
                        dataGridVisualizar.Rows[i].Cells[2].Value = produtos[i].Codigo;
                        dataGridVisualizar.Rows[i].Cells[3].Value = produtos[i].Preco;
                        dataGridVisualizar.Rows[i].Cells[4].Value = produtos[i].Quantidade;
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Não foi possível buscar os produtos da venda.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            LimparDadosVisualizar();

            tabControlVenda.SelectedTab = tabList;
        }

        private void LimparDadosVisualizar()
        {
            lbEmailVisualizar.Text = string.Empty;
            lbEnderecoVisualizar.Text = string.Empty;
            lbNomeClienteVisualizar.Text = string.Empty;

            txtValorTotalVisualizar.Text = string.Empty;
            txtTotalItensVisualizar.Text = string.Empty;
            txtDataVisualizar.Text = string.Empty;

            gbAlterar.Enabled = false;

            DataBindGridVisualizar(new List<ProdutoXVendaDTO>());
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            if (_relatorioVenadasForm is null || _relatorioVenadasForm.IsDisposed)
            {
                _relatorioVenadasForm = new RelatorioVendasForm(_vendaServices);
                _relatorioVenadasForm.Show();
            }
            else
            {
                _relatorioVenadasForm.BringToFront();
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtGridVenda.CurrentRow.Cells[0].Value != null)
                {
                    (tabEdit as Control).Enabled = true;

                    var id = (int)dtGridVenda.CurrentRow.Cells[0].Value;

                    PreencherAlterar(_vendaServices.GetById(id));

                    tabControlVenda.SelectedTab = tabEdit;
                    gbAlterar.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível buscar a venda.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
