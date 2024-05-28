namespace GCP.Front.Forms.Vendas
{
    partial class ProdutoVendaForm
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
            dtGridProduto = new DataGridView();
            txtNmProduto = new TextBox();
            label1 = new Label();
            nUQtd = new NumericUpDown();
            label2 = new Label();
            btnSelecionar = new Button();
            btnCancelar = new Button();
            nUPreco = new NumericUpDown();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtGridProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUQtd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPreco).BeginInit();
            SuspendLayout();
            // 
            // btnPesquisa
            // 
            btnPesquisa.Location = new Point(577, 12);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(82, 23);
            btnPesquisa.TabIndex = 6;
            btnPesquisa.Text = "Pesquisar";
            btnPesquisa.UseVisualStyleBackColor = true;
            btnPesquisa.Click += btnPesquisa_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(334, 13);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(228, 23);
            txtPesquisa.TabIndex = 5;
            // 
            // dtGridProduto
            // 
            dtGridProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridProduto.Location = new Point(12, 55);
            dtGridProduto.Name = "dtGridProduto";
            dtGridProduto.ReadOnly = true;
            dtGridProduto.Size = new Size(644, 291);
            dtGridProduto.TabIndex = 4;
            dtGridProduto.RowHeaderMouseClick += dtGridProduto_RowHeaderMouseClick;
            // 
            // txtNmProduto
            // 
            txtNmProduto.Enabled = false;
            txtNmProduto.Location = new Point(12, 373);
            txtNmProduto.Name = "txtNmProduto";
            txtNmProduto.Size = new Size(249, 23);
            txtNmProduto.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 356);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 8;
            label1.Text = "Produto";
            // 
            // nUQtd
            // 
            nUQtd.DecimalPlaces = 2;
            nUQtd.Location = new Point(506, 373);
            nUQtd.Maximum = new decimal(new int[] { 30000, 0, 0, 0 });
            nUQtd.Name = "nUQtd";
            nUQtd.Size = new Size(150, 23);
            nUQtd.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(506, 355);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 10;
            label2.Text = "Quantidade";
            // 
            // btnSelecionar
            // 
            btnSelecionar.Location = new Point(550, 452);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(109, 23);
            btnSelecionar.TabIndex = 11;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(427, 452);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(106, 23);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // nUPreco
            // 
            nUPreco.DecimalPlaces = 2;
            nUPreco.Enabled = false;
            nUPreco.Location = new Point(305, 373);
            nUPreco.Maximum = new decimal(new int[] { 30000, 0, 0, 0 });
            nUPreco.Name = "nUPreco";
            nUPreco.Size = new Size(150, 23);
            nUPreco.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(305, 354);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 14;
            label3.Text = "Preço";
            // 
            // ProdutoVendaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 482);
            Controls.Add(label3);
            Controls.Add(nUPreco);
            Controls.Add(btnCancelar);
            Controls.Add(btnSelecionar);
            Controls.Add(label2);
            Controls.Add(nUQtd);
            Controls.Add(label1);
            Controls.Add(txtNmProduto);
            Controls.Add(btnPesquisa);
            Controls.Add(txtPesquisa);
            Controls.Add(dtGridProduto);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ProdutoVendaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)dtGridProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUQtd).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPreco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPesquisa;
        private TextBox txtPesquisa;
        private DataGridView dtGridProduto;
        private TextBox txtNmProduto;
        private Label label1;
        private NumericUpDown nUQtd;
        private Label label2;
        private Button btnSelecionar;
        private Button btnCancelar;
        private NumericUpDown nUPreco;
        private Label label3;
    }
}