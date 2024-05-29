namespace GCP.Front.Forms.Produtos
{
    partial class RelatorioProdutosForm
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
            reportProdutos = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // reportProdutos
            // 
            reportProdutos.Dock = DockStyle.Fill;
            reportProdutos.Location = new Point(0, 0);
            reportProdutos.Name = "ReportViewer";
            reportProdutos.ServerReport.BearerToken = null;
            reportProdutos.Size = new Size(800, 450);
            reportProdutos.TabIndex = 0;
            // 
            // RelatorioProdutosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reportProdutos);
            Name = "RelatorioProdutosForm";
            Text = "RelatorioProdutosForm";
            WindowState = FormWindowState.Maximized;
            Load += RelatorioProdutosForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportProdutos;
    }
}