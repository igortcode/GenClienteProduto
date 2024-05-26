using GCP.App.Interfaces.Services;
using GCP.Front.Forms;

namespace GCP.Front
{
    public partial class Main : Form
    {
        private readonly IProdutoServices _produtoServices;
        private ProdutoFrm? _formProduto;

        public Main(IProdutoServices produtoServices)
        {
            _produtoServices = produtoServices;
            InitializeComponent();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            if(_formProduto == null)
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

    }
}
