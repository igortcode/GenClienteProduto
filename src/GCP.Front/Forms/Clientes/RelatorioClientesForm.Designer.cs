namespace GCP.Front.Forms.Clientes
{
    partial class RelatorioClientesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            relatorioClientes = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // relatorioClientes
            // 
            relatorioClientes.Dock = DockStyle.Fill;
            relatorioClientes.Location = new Point(0, 0);
            relatorioClientes.Name = "ReportViewer";
            relatorioClientes.ServerReport.BearerToken = null;
            relatorioClientes.Size = new Size(800, 450);
            relatorioClientes.TabIndex = 0;
            // 
            // RelatorioClientesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(relatorioClientes);
            Name = "RelatorioClientesForm";
            Text = "Relatório de Clientes";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer relatorioClientes;
    }
}