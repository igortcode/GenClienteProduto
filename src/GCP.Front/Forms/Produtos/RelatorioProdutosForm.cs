using GCP.App.Interfaces.Services;
using Microsoft.Reporting.WinForms;

namespace GCP.Front.Forms.Produtos
{
    public partial class RelatorioProdutosForm : Form
    {
        private readonly IProdutoServices _produtoServices;

        public RelatorioProdutosForm(IProdutoServices produtoServices)
        {
            _produtoServices = produtoServices;
            InitializeComponent();

            var dt = _produtoServices.GetDataTable();

            reportProdutos.LocalReport.ReportEmbeddedResource = "GCP.Front.Report.ProdutoReport.rdlc";

            reportProdutos.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            reportProdutos.LocalReport.DisplayName = $"{DateTime.Now.Ticks}_RProdutos";

            reportProdutos.RefreshReport();
        }

        private void RelatorioProdutosForm_Load(object sender, EventArgs e)
        {

        }
    }
}
