namespace GCP.Front.Forms.Vendas
{
    partial class TipoPagamentoForm
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
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            btnFinalizar = new Button();
            cbTipoPagamento = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnFinalizar);
            groupBox1.Controls.Add(cbTipoPagamento);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(299, 235);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de Pagamento";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(6, 206);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(118, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(175, 206);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(118, 23);
            btnFinalizar.TabIndex = 1;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // cbTipoPagamento
            // 
            cbTipoPagamento.FormattingEnabled = true;
            cbTipoPagamento.Location = new Point(42, 54);
            cbTipoPagamento.Name = "cbTipoPagamento";
            cbTipoPagamento.Size = new Size(199, 23);
            cbTipoPagamento.TabIndex = 0;
            // 
            // TipoPagamentoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 259);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TipoPagamentoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selecione o tipo de pagamento";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCancelar;
        private Button btnFinalizar;
        private ComboBox cbTipoPagamento;
    }
}