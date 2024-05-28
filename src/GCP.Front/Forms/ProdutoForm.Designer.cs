namespace GCP.Front.Forms
{
    partial class ProdutoForm
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
            tabControlProduto = new TabControl();
            tabList = new TabPage();
            btnAtualizarList = new Button();
            btnPesquisa = new Button();
            txtPesquisa = new TextBox();
            btnIrCadastrar = new Button();
            dtGridProduto = new DataGridView();
            tabAdd = new TabPage();
            txtQtdNu = new NumericUpDown();
            txtPrecoNu = new NumericUpDown();
            label5 = new Label();
            txtDesc = new RichTextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtCodigo = new TextBox();
            label1 = new Label();
            txtNome = new TextBox();
            btnVotarCad = new Button();
            btnCadastrar = new Button();
            tabEdit = new TabPage();
            cBAlterar = new CheckBox();
            gbAlterar = new GroupBox();
            btnRemover = new Button();
            txtQtdNuAlt = new NumericUpDown();
            txtPrecoAltNu = new NumericUpDown();
            label6 = new Label();
            txtDescAlt = new RichTextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtCodigoAlt = new TextBox();
            label10 = new Label();
            txtNomeAlt = new TextBox();
            btnSalvar = new Button();
            btnVoltarEdit = new Button();
            tabControlProduto.SuspendLayout();
            tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridProduto).BeginInit();
            tabAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQtdNu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecoNu).BeginInit();
            tabEdit.SuspendLayout();
            gbAlterar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQtdNuAlt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecoAltNu).BeginInit();
            SuspendLayout();
            // 
            // tabControlProduto
            // 
            tabControlProduto.Controls.Add(tabList);
            tabControlProduto.Controls.Add(tabAdd);
            tabControlProduto.Controls.Add(tabEdit);
            tabControlProduto.Location = new Point(12, 12);
            tabControlProduto.Name = "tabControlProduto";
            tabControlProduto.SelectedIndex = 0;
            tabControlProduto.Size = new Size(979, 551);
            tabControlProduto.SizeMode = TabSizeMode.FillToRight;
            tabControlProduto.TabIndex = 0;
            // 
            // tabList
            // 
            tabList.Controls.Add(btnAtualizarList);
            tabList.Controls.Add(btnPesquisa);
            tabList.Controls.Add(txtPesquisa);
            tabList.Controls.Add(btnIrCadastrar);
            tabList.Controls.Add(dtGridProduto);
            tabList.Location = new Point(4, 24);
            tabList.Name = "tabList";
            tabList.Padding = new Padding(3);
            tabList.Size = new Size(971, 523);
            tabList.TabIndex = 0;
            tabList.Text = "Produtos";
            tabList.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarList
            // 
            btnAtualizarList.Location = new Point(782, 488);
            btnAtualizarList.Name = "btnAtualizarList";
            btnAtualizarList.Size = new Size(90, 29);
            btnAtualizarList.TabIndex = 4;
            btnAtualizarList.Text = "Atualizar";
            btnAtualizarList.UseVisualStyleBackColor = true;
            btnAtualizarList.Click += btnAtualizarList_Click;
            // 
            // btnPesquisa
            // 
            btnPesquisa.Location = new Point(871, 6);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(94, 32);
            btnPesquisa.TabIndex = 3;
            btnPesquisa.Text = "Pesquisar";
            btnPesquisa.UseVisualStyleBackColor = true;
            btnPesquisa.Click += btnPesquisa_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(609, 12);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(256, 23);
            txtPesquisa.TabIndex = 2;
            // 
            // btnIrCadastrar
            // 
            btnIrCadastrar.Location = new Point(878, 488);
            btnIrCadastrar.Name = "btnIrCadastrar";
            btnIrCadastrar.Size = new Size(87, 29);
            btnIrCadastrar.TabIndex = 1;
            btnIrCadastrar.Text = "Novo";
            btnIrCadastrar.UseVisualStyleBackColor = true;
            btnIrCadastrar.Click += btnIrCadastrar_Click;
            // 
            // dtGridProduto
            // 
            dtGridProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridProduto.Location = new Point(6, 46);
            dtGridProduto.Name = "dtGridProduto";
            dtGridProduto.ReadOnly = true;
            dtGridProduto.Size = new Size(959, 427);
            dtGridProduto.TabIndex = 0;
            dtGridProduto.RowDividerDoubleClick += dtGridProduto_RowDividerDoubleClick;
            dtGridProduto.RowHeaderMouseDoubleClick += dtGridProduto_RowHeaderMouseDoubleClick;
            // 
            // tabAdd
            // 
            tabAdd.Controls.Add(txtQtdNu);
            tabAdd.Controls.Add(txtPrecoNu);
            tabAdd.Controls.Add(label5);
            tabAdd.Controls.Add(txtDesc);
            tabAdd.Controls.Add(label4);
            tabAdd.Controls.Add(label3);
            tabAdd.Controls.Add(label2);
            tabAdd.Controls.Add(txtCodigo);
            tabAdd.Controls.Add(label1);
            tabAdd.Controls.Add(txtNome);
            tabAdd.Controls.Add(btnVotarCad);
            tabAdd.Controls.Add(btnCadastrar);
            tabAdd.Location = new Point(4, 24);
            tabAdd.Name = "tabAdd";
            tabAdd.Padding = new Padding(3);
            tabAdd.Size = new Size(971, 523);
            tabAdd.TabIndex = 1;
            tabAdd.Text = "Cadastro";
            tabAdd.UseVisualStyleBackColor = true;
            // 
            // txtQtdNu
            // 
            txtQtdNu.DecimalPlaces = 2;
            txtQtdNu.Location = new Point(373, 170);
            txtQtdNu.Maximum = new decimal(new int[] { 30000, 0, 0, 0 });
            txtQtdNu.Name = "txtQtdNu";
            txtQtdNu.RightToLeft = RightToLeft.Yes;
            txtQtdNu.Size = new Size(153, 23);
            txtQtdNu.TabIndex = 4;
            txtQtdNu.UpDownAlign = LeftRightAlignment.Left;
            // 
            // txtPrecoNu
            // 
            txtPrecoNu.DecimalPlaces = 2;
            txtPrecoNu.Location = new Point(28, 161);
            txtPrecoNu.Maximum = new decimal(new int[] { 30000, 0, 0, 0 });
            txtPrecoNu.Name = "txtPrecoNu";
            txtPrecoNu.RightToLeft = RightToLeft.Yes;
            txtPrecoNu.Size = new Size(151, 23);
            txtPrecoNu.TabIndex = 3;
            txtPrecoNu.UpDownAlign = LeftRightAlignment.Left;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 243);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 11;
            label5.Text = "Descrição";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(28, 261);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(518, 192);
            txtDesc.TabIndex = 5;
            txtDesc.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(373, 152);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 9;
            label4.Text = "Quantidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 143);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 7;
            label3.Text = "Preço";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 48);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 5;
            label2.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(373, 66);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(308, 23);
            txtCodigo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 48);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(28, 66);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(308, 23);
            txtNome.TabIndex = 1;
            // 
            // btnVotarCad
            // 
            btnVotarCad.Location = new Point(770, 491);
            btnVotarCad.Name = "btnVotarCad";
            btnVotarCad.Size = new Size(97, 29);
            btnVotarCad.TabIndex = 1;
            btnVotarCad.Text = "Voltar";
            btnVotarCad.UseVisualStyleBackColor = true;
            btnVotarCad.Click += btnVotarCad_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(873, 491);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(92, 29);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // tabEdit
            // 
            tabEdit.Controls.Add(cBAlterar);
            tabEdit.Controls.Add(gbAlterar);
            tabEdit.Controls.Add(btnVoltarEdit);
            tabEdit.Location = new Point(4, 24);
            tabEdit.Name = "tabEdit";
            tabEdit.Padding = new Padding(3);
            tabEdit.Size = new Size(971, 523);
            tabEdit.TabIndex = 2;
            tabEdit.Text = "Visualizar/Alterar";
            tabEdit.UseVisualStyleBackColor = true;
            // 
            // cBAlterar
            // 
            cBAlterar.AutoSize = true;
            cBAlterar.Location = new Point(904, 13);
            cBAlterar.Name = "cBAlterar";
            cBAlterar.Size = new Size(61, 19);
            cBAlterar.TabIndex = 1;
            cBAlterar.Text = "Alterar";
            cBAlterar.UseVisualStyleBackColor = true;
            cBAlterar.CheckedChanged += cBAlterar_CheckedChanged;
            // 
            // gbAlterar
            // 
            gbAlterar.Controls.Add(btnRemover);
            gbAlterar.Controls.Add(txtQtdNuAlt);
            gbAlterar.Controls.Add(txtPrecoAltNu);
            gbAlterar.Controls.Add(label6);
            gbAlterar.Controls.Add(txtDescAlt);
            gbAlterar.Controls.Add(label7);
            gbAlterar.Controls.Add(label8);
            gbAlterar.Controls.Add(label9);
            gbAlterar.Controls.Add(txtCodigoAlt);
            gbAlterar.Controls.Add(label10);
            gbAlterar.Controls.Add(txtNomeAlt);
            gbAlterar.Controls.Add(btnSalvar);
            gbAlterar.Enabled = false;
            gbAlterar.Location = new Point(6, 36);
            gbAlterar.Name = "gbAlterar";
            gbAlterar.Size = new Size(959, 481);
            gbAlterar.TabIndex = 0;
            gbAlterar.TabStop = false;
            gbAlterar.Text = "Dados Produto";
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(754, 446);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(100, 30);
            btnRemover.TabIndex = 24;
            btnRemover.Text = "Excluir";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // txtQtdNuAlt
            // 
            txtQtdNuAlt.DecimalPlaces = 2;
            txtQtdNuAlt.Location = new Point(370, 117);
            txtQtdNuAlt.Maximum = new decimal(new int[] { 30000, 0, 0, 0 });
            txtQtdNuAlt.Name = "txtQtdNuAlt";
            txtQtdNuAlt.RightToLeft = RightToLeft.Yes;
            txtQtdNuAlt.Size = new Size(151, 23);
            txtQtdNuAlt.TabIndex = 23;
            txtQtdNuAlt.UpDownAlign = LeftRightAlignment.Left;
            // 
            // txtPrecoAltNu
            // 
            txtPrecoAltNu.DecimalPlaces = 2;
            txtPrecoAltNu.Location = new Point(25, 108);
            txtPrecoAltNu.Maximum = new decimal(new int[] { 30000, 0, 0, 0 });
            txtPrecoAltNu.Name = "txtPrecoAltNu";
            txtPrecoAltNu.RightToLeft = RightToLeft.Yes;
            txtPrecoAltNu.Size = new Size(151, 23);
            txtPrecoAltNu.TabIndex = 22;
            txtPrecoAltNu.UpDownAlign = LeftRightAlignment.Left;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 154);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 21;
            label6.Text = "Descrição";
            // 
            // txtDescAlt
            // 
            txtDescAlt.Location = new Point(25, 172);
            txtDescAlt.Name = "txtDescAlt";
            txtDescAlt.Size = new Size(579, 272);
            txtDescAlt.TabIndex = 20;
            txtDescAlt.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(370, 99);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 19;
            label7.Text = "Quantidade";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 90);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 17;
            label8.Text = "Preço";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(370, 28);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 15;
            label9.Text = "Código";
            // 
            // txtCodigoAlt
            // 
            txtCodigoAlt.Location = new Point(370, 46);
            txtCodigoAlt.Name = "txtCodigoAlt";
            txtCodigoAlt.Size = new Size(308, 23);
            txtCodigoAlt.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(25, 28);
            label10.Name = "label10";
            label10.Size = new Size(40, 15);
            label10.TabIndex = 13;
            label10.Text = "Nome";
            // 
            // txtNomeAlt
            // 
            txtNomeAlt.Location = new Point(25, 46);
            txtNomeAlt.Name = "txtNomeAlt";
            txtNomeAlt.Size = new Size(308, 23);
            txtNomeAlt.TabIndex = 12;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(860, 446);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(93, 29);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltarEdit
            // 
            btnVoltarEdit.Location = new Point(760, 6);
            btnVoltarEdit.Name = "btnVoltarEdit";
            btnVoltarEdit.Size = new Size(91, 30);
            btnVoltarEdit.TabIndex = 1;
            btnVoltarEdit.Text = "Voltar";
            btnVoltarEdit.UseVisualStyleBackColor = true;
            btnVoltarEdit.Click += btnVoltarEdit_Click;
            // 
            // ProdutoFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 585);
            Controls.Add(tabControlProduto);
            Name = "ProdutoFrm";
            Text = "Produto";
            tabControlProduto.ResumeLayout(false);
            tabList.ResumeLayout(false);
            tabList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridProduto).EndInit();
            tabAdd.ResumeLayout(false);
            tabAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQtdNu).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecoNu).EndInit();
            tabEdit.ResumeLayout(false);
            tabEdit.PerformLayout();
            gbAlterar.ResumeLayout(false);
            gbAlterar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQtdNuAlt).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecoAltNu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlProduto;
        private TabPage tabList;
        private TabPage tabAdd;
        private TabPage tabEdit;
        private DataGridView dtGridProduto;
        private Button btnIrCadastrar;
        private Button btnCadastrar;
        private Button btnVotarCad;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtCodigo;
        private Label label1;
        private TextBox txtNome;
        private Label label5;
        private RichTextBox txtDesc;
        private CheckBox cBAlterar;
        private GroupBox gbAlterar;
        private Button btnVoltarEdit;
        private Button btnSalvar;
        private Label label6;
        private RichTextBox txtDescAlt;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtCodigoAlt;
        private Label label10;
        private TextBox txtNomeAlt;
        private Button btnPesquisa;
        private TextBox txtPesquisa;
        private NumericUpDown txtQtdNu;
        private NumericUpDown txtPrecoNu;
        private NumericUpDown txtQtdNuAlt;
        private NumericUpDown txtPrecoAltNu;
        private Button btnRemover;
        private Button btnAtualizarList;
    }
}