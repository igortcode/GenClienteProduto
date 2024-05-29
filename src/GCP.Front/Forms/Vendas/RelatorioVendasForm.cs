using GCP.App.Interfaces.Services;
using Microsoft.Reporting.WinForms;

namespace GCP.Front.Forms.Vendas
{
    public partial class RelatorioVendasForm : Form
    {
        private readonly IVendaServices _vendaServices;

        public RelatorioVendasForm(IVendaServices vendaServices)
        {
            _vendaServices = vendaServices;
            InitializeComponent();

            relatorioVendas.LocalReport.ReportEmbeddedResource = "GCP.Front.Report.VendaReport.rdlc";

            var dt = _vendaServices.GetDataTableWithClienteRelations();

            relatorioVendas.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            relatorioVendas.LocalReport.DisplayName = $"{DateTime.Now.Ticks}_RVendas";

            relatorioVendas.RefreshReport();
        }
    }
}
