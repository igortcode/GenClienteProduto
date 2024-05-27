using GCP.App.Interfaces.Services;
using GCP.Front.Forms;

namespace GCP.Front
{
    public partial class Main : Form
    {
        private readonly IProdutoServices _produtoServices;
        private readonly IClienteServices _clienteServices;
        private ProdutoFrm? _formProduto;
        private ClientForm? _formCliente;

        public Main(IProdutoServices produtoServices, IClienteServices clienteServices)
        {
            _produtoServices = produtoServices;
            _clienteServices = clienteServices; 
            InitializeComponent();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            if (_formProduto == null)
            {
                _formProduto = new ProdutoFrm(_produtoServices);
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
    }
}
