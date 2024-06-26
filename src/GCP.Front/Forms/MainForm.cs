using GCP.App.Interfaces.Services;
using GCP.Front.Forms;

namespace GCP.Front
{
    public partial class MainForm : Form
    {
        private readonly IProdutoServices _produtoServices;
        private readonly IClienteServices _clienteServices;
        private readonly IVendaServices _vendaServices;
        private ProdutoForm _formProduto;
        private ClientForm _formCliente;
        private VendaForm _formVenda;

        public MainForm(IProdutoServices produtoServices, IClienteServices clienteServices, IVendaServices vendaServices)
        {
            _produtoServices = produtoServices;
            _clienteServices = clienteServices;
            _vendaServices = vendaServices;
            InitializeComponent();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            if (_formProduto == null)
            {
                _formProduto = new ProdutoForm(_produtoServices);
                _formProduto.TopLevel = false;
                _formProduto.FormBorderStyle = FormBorderStyle.None;
                mainPanel.Controls.Add(_formProduto);
                _formProduto.Show();
                _formProduto.BringToFront();
            }
            else
            {
                _formProduto?.BringToFront();
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (_formCliente == null)
            {
                _formCliente = new ClientForm(_clienteServices);
                _formCliente.TopLevel = false;
                _formCliente.FormBorderStyle = FormBorderStyle.None;
                mainPanel.Controls.Add(_formCliente);
                _formCliente.Show();
                _formCliente.BringToFront();
            }
            else
            {
                _formCliente?.BringToFront();
            }
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            if (_formVenda == null)
            {
                _formVenda = new VendaForm(_clienteServices, _produtoServices, _vendaServices);
                _formVenda.TopLevel = false;
                _formVenda.FormBorderStyle = FormBorderStyle.None;
                mainPanel.Controls.Add(_formVenda);
                _formVenda.Show();
                _formVenda.BringToFront();
            }
            else
            {
                _formVenda?.BringToFront();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tem certeza que deseja fechar a aplica��o?",
            "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
