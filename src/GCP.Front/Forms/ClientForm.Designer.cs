
namespace GCP.Front.Forms
{
    partial class ClientForm
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
            dtGridCliente = new DataGridView();
            tabAdd = new TabPage();
            btnEndereco = new Button();
            txtFullEndereco = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            mkTelefone = new MaskedTextBox();
            mkCpf = new MaskedTextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNome = new TextBox();
            btnVotarCad = new Button();
            btnCadastrar = new Button();
            tabEdit = new TabPage();
            cBAlterar = new CheckBox();
            gbAlterar = new GroupBox();
            btnEnderecoAlt = new Button();
            txtFullEnderecoAlt = new TextBox();
            label6 = new Label();
            txtEmailAlt = new TextBox();
            label7 = new Label();
            mkTelefoneAlt = new MaskedTextBox();
            mkCpfAlt = new MaskedTextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtNomeAlt = new TextBox();
            btnRemover = new Button();
            btnSalvar = new Button();
            btnVoltarEdit = new Button();
            tabControlProduto.SuspendLayout();
            tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridCliente).BeginInit();
            tabAdd.SuspendLayout();
            tabEdit.SuspendLayout();
            gbAlterar.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlProduto
            // 
            tabControlProduto.Controls.Add(tabList);
            tabControlProduto.Controls.Add(tabAdd);
            tabControlProduto.Controls.Add(tabEdit);
            tabControlProduto.Location = new Point(12, 17);
            tabControlProduto.Name = "tabControlProduto";
            tabControlProduto.SelectedIndex = 0;
            tabControlProduto.Size = new Size(979, 551);
            tabControlProduto.SizeMode = TabSizeMode.FillToRight;
            tabControlProduto.TabIndex = 1;
            // 
            // tabList
            // 
            tabList.Controls.Add(btnAtualizarList);
            tabList.Controls.Add(btnPesquisa);
            tabList.Controls.Add(txtPesquisa);
            tabList.Controls.Add(btnIrCadastrar);
            tabList.Controls.Add(dtGridCliente);
            tabList.Location = new Point(4, 24);
            tabList.Name = "tabList";
            tabList.Padding = new Padding(3);
            tabList.Size = new Size(971, 523);
            tabList.TabIndex = 0;
            tabList.Text = "Clientes";
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
            // 
            // btnPesquisa
            // 
            btnPesquisa.Location = new Point(871, 6);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(94, 32);
            btnPesquisa.TabIndex = 3;
            btnPesquisa.Text = "Pesquisar";
            btnPesquisa.UseVisualStyleBackColor = true;
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
            // 
            // dtGridCliente
            // 
            dtGridCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridCliente.Location = new Point(6, 46);
            dtGridCliente.Name = "dtGridCliente";
            dtGridCliente.ReadOnly = true;
            dtGridCliente.Size = new Size(959, 427);
            dtGridCliente.TabIndex = 0;
            // 
            // tabAdd
            // 
            tabAdd.Controls.Add(btnEndereco);
            tabAdd.Controls.Add(txtFullEndereco);
            tabAdd.Controls.Add(label4);
            tabAdd.Controls.Add(txtEmail);
            tabAdd.Controls.Add(label3);
            tabAdd.Controls.Add(mkTelefone);
            tabAdd.Controls.Add(mkCpf);
            tabAdd.Controls.Add(label5);
            tabAdd.Controls.Add(label2);
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
            // btnEndereco
            // 
            btnEndereco.Location = new Point(411, 284);
            btnEndereco.Name = "btnEndereco";
            btnEndereco.Size = new Size(107, 23);
            btnEndereco.TabIndex = 19;
            btnEndereco.Text = "Add Endereço";
            btnEndereco.UseVisualStyleBackColor = true;
            btnEndereco.Click += btnEndereco_Click;
            // 
            // txtFullEndereco
            // 
            txtFullEndereco.Enabled = false;
            txtFullEndereco.Location = new Point(31, 284);
            txtFullEndereco.Name = "txtFullEndereco";
            txtFullEndereco.Size = new Size(361, 23);
            txtFullEndereco.TabIndex = 18;
            txtFullEndereco.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(273, 119);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 17;
            label4.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(31, 137);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(178, 23);
            txtEmail.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 119);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 15;
            label3.Text = "Email";
            // 
            // mkTelefone
            // 
            mkTelefone.Location = new Point(273, 137);
            mkTelefone.Mask = "(00) 00000-0000";
            mkTelefone.Name = "mkTelefone";
            mkTelefone.Size = new Size(95, 23);
            mkTelefone.TabIndex = 14;
            // 
            // mkCpf
            // 
            mkCpf.Location = new Point(576, 66);
            mkCpf.Mask = "000,000,000-00";
            mkCpf.Name = "mkCpf";
            mkCpf.Size = new Size(83, 23);
            mkCpf.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 255);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 11;
            label5.Text = "Endereço";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(576, 48);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 5;
            label2.Text = "CPF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 51);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(28, 66);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(490, 23);
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
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(873, 491);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(92, 29);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
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
            cBAlterar.Location = new Point(907, 16);
            cBAlterar.Name = "cBAlterar";
            cBAlterar.Size = new Size(61, 19);
            cBAlterar.TabIndex = 1;
            cBAlterar.Text = "Alterar";
            cBAlterar.UseVisualStyleBackColor = true;
            // 
            // gbAlterar
            // 
            gbAlterar.Controls.Add(btnEnderecoAlt);
            gbAlterar.Controls.Add(txtFullEnderecoAlt);
            gbAlterar.Controls.Add(label6);
            gbAlterar.Controls.Add(txtEmailAlt);
            gbAlterar.Controls.Add(label7);
            gbAlterar.Controls.Add(mkTelefoneAlt);
            gbAlterar.Controls.Add(mkCpfAlt);
            gbAlterar.Controls.Add(label8);
            gbAlterar.Controls.Add(label9);
            gbAlterar.Controls.Add(label10);
            gbAlterar.Controls.Add(txtNomeAlt);
            gbAlterar.Controls.Add(btnRemover);
            gbAlterar.Controls.Add(btnSalvar);
            gbAlterar.Enabled = false;
            gbAlterar.Location = new Point(6, 36);
            gbAlterar.Name = "gbAlterar";
            gbAlterar.Size = new Size(959, 481);
            gbAlterar.TabIndex = 0;
            gbAlterar.TabStop = false;
            gbAlterar.Text = "Dados Cliente";
            // 
            // btnEnderecoAlt
            // 
            btnEnderecoAlt.Location = new Point(416, 284);
            btnEnderecoAlt.Name = "btnEnderecoAlt";
            btnEnderecoAlt.Size = new Size(107, 23);
            btnEnderecoAlt.TabIndex = 35;
            btnEnderecoAlt.Text = "Endereço";
            btnEnderecoAlt.UseVisualStyleBackColor = true;
            // 
            // txtFullEnderecoAlt
            // 
            txtFullEnderecoAlt.Enabled = false;
            txtFullEnderecoAlt.Location = new Point(36, 284);
            txtFullEnderecoAlt.Name = "txtFullEnderecoAlt";
            txtFullEnderecoAlt.Size = new Size(361, 23);
            txtFullEnderecoAlt.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(278, 119);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 33;
            label6.Text = "Telefone";
            // 
            // txtEmailAlt
            // 
            txtEmailAlt.Location = new Point(36, 137);
            txtEmailAlt.Name = "txtEmailAlt";
            txtEmailAlt.Size = new Size(178, 23);
            txtEmailAlt.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 119);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 31;
            label7.Text = "Email";
            // 
            // mkTelefoneAlt
            // 
            mkTelefoneAlt.Location = new Point(278, 137);
            mkTelefoneAlt.Mask = "(00) 00000-0000";
            mkTelefoneAlt.Name = "mkTelefoneAlt";
            mkTelefoneAlt.Size = new Size(95, 23);
            mkTelefoneAlt.TabIndex = 30;
            // 
            // mkCpfAlt
            // 
            mkCpfAlt.Location = new Point(581, 66);
            mkCpfAlt.Mask = "000,000,000-00";
            mkCpfAlt.Name = "mkCpfAlt";
            mkCpfAlt.Size = new Size(83, 23);
            mkCpfAlt.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 255);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 28;
            label8.Text = "Endereço";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(581, 48);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 27;
            label9.Text = "CPF";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(36, 51);
            label10.Name = "label10";
            label10.Size = new Size(40, 15);
            label10.TabIndex = 26;
            label10.Text = "Nome";
            // 
            // txtNomeAlt
            // 
            txtNomeAlt.Location = new Point(33, 66);
            txtNomeAlt.Name = "txtNomeAlt";
            txtNomeAlt.Size = new Size(490, 23);
            txtNomeAlt.TabIndex = 25;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(754, 446);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(100, 30);
            btnRemover.TabIndex = 24;
            btnRemover.Text = "Excluir";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(860, 446);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(93, 29);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnVoltarEdit
            // 
            btnVoltarEdit.Location = new Point(760, 6);
            btnVoltarEdit.Name = "btnVoltarEdit";
            btnVoltarEdit.Size = new Size(91, 30);
            btnVoltarEdit.TabIndex = 1;
            btnVoltarEdit.Text = "Voltar";
            btnVoltarEdit.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 585);
            Controls.Add(tabControlProduto);
            Name = "ClientForm";
            Text = "ClientForm";
            tabControlProduto.ResumeLayout(false);
            tabList.ResumeLayout(false);
            tabList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridCliente).EndInit();
            tabAdd.ResumeLayout(false);
            tabAdd.PerformLayout();
            tabEdit.ResumeLayout(false);
            tabEdit.PerformLayout();
            gbAlterar.ResumeLayout(false);
            gbAlterar.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private TabControl tabControlProduto;
        private TabPage tabList;
        private Button btnAtualizarList;
        private Button btnPesquisa;
        private TextBox txtPesquisa;
        private Button btnIrCadastrar;
        private DataGridView dtGridCliente;
        private TabPage tabAdd;
        private Label label5;
        private Label label2;
        private Label label1;
        private TextBox txtNome;
        private Button btnVotarCad;
        private Button btnCadastrar;
        private TabPage tabEdit;
        private CheckBox cBAlterar;
        private GroupBox gbAlterar;
        private Button btnRemover;
        private Button btnSalvar;
        private Button btnVoltarEdit;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private MaskedTextBox mkTelefone;
        private MaskedTextBox mkCpf;
        private TextBox txtFullEndereco;
        private Button btnEndereco;
        private Button btnEnderecoAlt;
        private TextBox txtFullEnderecoAlt;
        private Label label6;
        private TextBox txtEmailAlt;
        private Label label7;
        private MaskedTextBox mkTelefoneAlt;
        private MaskedTextBox mkCpfAlt;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtNomeAlt;
    }
}