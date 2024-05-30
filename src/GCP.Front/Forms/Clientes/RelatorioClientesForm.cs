using GCP.App.Interfaces.Services;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCP.Front.Forms.Clientes
{
    public partial class RelatorioClientesForm : Form
    {
        private readonly IClienteServices _clienteServices;

        public RelatorioClientesForm(IClienteServices clienteServices)
        {
            _clienteServices = clienteServices;
            InitializeComponent();

            var dt = _clienteServices.GetDataTable();

            relatorioClientes.LocalReport.ReportEmbeddedResource = "GCP.Front.Report.ClienteReport.rdlc";

            relatorioClientes.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            relatorioClientes.LocalReport.DisplayName = $"{DateTime.Now.Ticks}_RClientes";

            relatorioClientes.RefreshReport();
        }
    }
}
