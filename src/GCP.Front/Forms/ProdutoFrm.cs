using GCP.App.Interfaces.Services;

namespace GCP.Front.Forms
{
    public partial class ProdutoFrm : Form
    {
        private IProdutoServices _produtoServices;

        public ProdutoFrm(IProdutoServices produtoServices)
        {
            _produtoServices = produtoServices;
            InitializeComponent();
        }
    }
}
