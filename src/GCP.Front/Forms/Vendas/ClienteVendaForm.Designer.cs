namespace GCP.Front.Forms.Vendas
{
    partial class ClienteVendaForm
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
            btnPesquisa = new Button();
            txtPesquisa = new TextBox();
            dtGridCliente = new DataGridView();
            btnSelecionar = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtGridCliente).BeginInit();
            SuspendLayout();
            // 
            // btnPesquisa
            // 
            btnPesquisa.Location = new Point(531, 6);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(94, 32);
            btnPesquisa.TabIndex = 6;
            btnPesquisa.Text = "Pesquisar";
            btnPesquisa.UseVisualStyleBackColor = true;
            btnPesquisa.Click += btnPesquisa_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(269, 12);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(256, 23);
            txtPesquisa.TabIndex = 5;
            // 
            // dtGridCliente
            // 
            dtGridCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridCliente.Location = new Point(12, 55);
            dtGridCliente.Name = "dtGridCliente";
            dtGridCliente.ReadOnly = true;
            dtGridCliente.Size = new Size(614, 333);
            dtGridCliente.TabIndex = 4;
            dtGridCliente.RowHeaderMouseDoubleClick += dtGridCliente_RowHeaderMouseDoubleClick;
            // 
            // btnSelecionar
            // 
            btnSelecionar.Location = new Point(550, 410);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(75, 23);
            btnSelecionar.TabIndex = 7;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(469, 410);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // ClienteVendaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 445);
            Controls.Add(button2);
            Controls.Add(btnSelecionar);
            Controls.Add(btnPesquisa);
            Controls.Add(txtPesquisa);
            Controls.Add(dtGridCliente);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ClienteVendaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)dtGridCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPesquisa;
        private TextBox txtPesquisa;
        private DataGridView dtGridCliente;
        private Button btnSelecionar;
        private Button button2;
    }
}