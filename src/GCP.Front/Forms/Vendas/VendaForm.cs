using GCP.App.DTO.Clientes;
using GCP.App.DTO.Venda;
using GCP.App.Interfaces.Services;
using GCP.Front.Forms.Vendas;

namespace GCP.Front.Forms
{
    public partial class VendaForm : Form
    {
        private readonly IClienteServices _clienteServices;
        private readonly IProdutoServices _produtoServices;
        private ClienteDTO _clienteDto;
        private ClienteVendaForm _frmClienteVenda;
        private IList<ProdutoXVendaDTO> _produtosVendaDto;
        private ProdutoVendaForm _frmProdutoVenda;

        public VendaForm(IClienteServices clienteServices, IProdutoServices produtoServices)
        {
            _clienteServices = clienteServices;
            _produtoServices = produtoServices;
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

                txtData.Text = DateTime.Now.Date.ToString();
                
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
                    txtTotal.Text = $"R$ {_produtosVendaDto.Sum(a => (a.Preco* a.Quantidade))}";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Não foi possível buscar os produtos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoverCliente_Click(object sender, EventArgs e)
        {
            lbEmail.Text = string.Empty;
            lbEndereco.Text = string.Empty;
            lbNmCliente.Text = string.Empty;

            _clienteDto = new ClienteDTO();

        }
    }
}
