namespace GCP.Front.Forms
{
    partial class VendaForm
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
            tabControlVenda = new TabControl();
            tabList = new TabPage();
            btnAtualizarList = new Button();
            btnPesquisa = new Button();
            txtPesquisa = new TextBox();
            btnIrCadastrar = new Button();
            dtGridVenda = new DataGridView();
            tabAdd = new TabPage();
            gbVenda = new GroupBox();
            txtData = new TextBox();
            txtTotalItens = new TextBox();
            txtTotal = new TextBox();
            label12 = new Label();
            label11 = new Label();
            lbValorTotal = new Label();
            dataGridItensVenda = new DataGridView();
            btnPesquisaProduto = new Button();
            btnFinalizar = new Button();
            btnCancelar = new Button();
            txtCodigo = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            lbEmail = new Label();
            lbEndereco = new Label();
            lbNmCliente = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnPesquisarCliente = new Button();
            tabEdit = new TabPage();
            cBAlterar = new CheckBox();
            gbAlterar = new GroupBox();
            btnRemover = new Button();
            btnSalvar = new Button();
            btnVoltarEdit = new Button();
            btnRemoverCliente = new Button();
            tabControlVenda.SuspendLayout();
            tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridVenda).BeginInit();
            tabAdd.SuspendLayout();
            gbVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridItensVenda).BeginInit();
            groupBox1.SuspendLayout();
            tabEdit.SuspendLayout();
            gbAlterar.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlVenda
            // 
            tabControlVenda.Controls.Add(tabList);
            tabControlVenda.Controls.Add(tabAdd);
            tabControlVenda.Controls.Add(tabEdit);
            tabControlVenda.Location = new Point(12, 17);
            tabControlVenda.Name = "tabControlVenda";
            tabControlVenda.SelectedIndex = 0;
            tabControlVenda.Size = new Size(979, 567);
            tabControlVenda.SizeMode = TabSizeMode.FillToRight;
            tabControlVenda.TabIndex = 1;
            // 
            // tabList
            // 
            tabList.Controls.Add(btnAtualizarList);
            tabList.Controls.Add(btnPesquisa);
            tabList.Controls.Add(txtPesquisa);
            tabList.Controls.Add(btnIrCadastrar);
            tabList.Controls.Add(dtGridVenda);
            tabList.Location = new Point(4, 24);
            tabList.Name = "tabList";
            tabList.Padding = new Padding(3);
            tabList.Size = new Size(971, 539);
            tabList.TabIndex = 0;
            tabList.Text = "Vendas";
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
            btnIrCadastrar.Text = "Vender";
            btnIrCadastrar.UseVisualStyleBackColor = true;
            // 
            // dtGridVenda
            // 
            dtGridVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridVenda.Location = new Point(6, 46);
            dtGridVenda.Name = "dtGridVenda";
            dtGridVenda.ReadOnly = true;
            dtGridVenda.Size = new Size(959, 427);
            dtGridVenda.TabIndex = 0;
            // 
            // tabAdd
            // 
            tabAdd.Controls.Add(gbVenda);
            tabAdd.Controls.Add(groupBox1);
            tabAdd.Location = new Point(4, 24);
            tabAdd.Name = "tabAdd";
            tabAdd.Padding = new Padding(3);
            tabAdd.Size = new Size(971, 539);
            tabAdd.TabIndex = 1;
            tabAdd.Text = "PDV";
            tabAdd.UseVisualStyleBackColor = true;
            // 
            // gbVenda
            // 
            gbVenda.Controls.Add(txtData);
            gbVenda.Controls.Add(txtTotalItens);
            gbVenda.Controls.Add(txtTotal);
            gbVenda.Controls.Add(label12);
            gbVenda.Controls.Add(label11);
            gbVenda.Controls.Add(lbValorTotal);
            gbVenda.Controls.Add(dataGridItensVenda);
            gbVenda.Controls.Add(btnPesquisaProduto);
            gbVenda.Controls.Add(btnFinalizar);
            gbVenda.Controls.Add(btnCancelar);
            gbVenda.Controls.Add(txtCodigo);
            gbVenda.Controls.Add(label5);
            gbVenda.Enabled = false;
            gbVenda.Location = new Point(6, 112);
            gbVenda.Name = "gbVenda";
            gbVenda.Size = new Size(959, 420);
            gbVenda.TabIndex = 16;
            gbVenda.TabStop = false;
            gbVenda.Text = "PDV";
            // 
            // txtData
            // 
            txtData.Enabled = false;
            txtData.Location = new Point(778, 209);
            txtData.Name = "txtData";
            txtData.Size = new Size(104, 23);
            txtData.TabIndex = 21;
            // 
            // txtTotalItens
            // 
            txtTotalItens.Enabled = false;
            txtTotalItens.Location = new Point(778, 149);
            txtTotalItens.Name = "txtTotalItens";
            txtTotalItens.Size = new Size(145, 23);
            txtTotalItens.TabIndex = 20;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(778, 88);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(145, 23);
            txtTotal.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(778, 131);
            label12.Name = "label12";
            label12.Size = new Size(63, 15);
            label12.TabIndex = 18;
            label12.Text = "Total Itens:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(778, 191);
            label11.Name = "label11";
            label11.Size = new Size(34, 15);
            label11.TabIndex = 17;
            label11.Text = "Data:";
            // 
            // lbValorTotal
            // 
            lbValorTotal.AutoSize = true;
            lbValorTotal.Location = new Point(778, 70);
            lbValorTotal.Name = "lbValorTotal";
            lbValorTotal.Size = new Size(67, 15);
            lbValorTotal.TabIndex = 16;
            lbValorTotal.Text = "Valor Total: ";
            // 
            // dataGridItensVenda
            // 
            dataGridItensVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridItensVenda.Location = new Point(6, 72);
            dataGridItensVenda.Name = "dataGridItensVenda";
            dataGridItensVenda.Size = new Size(743, 342);
            dataGridItensVenda.TabIndex = 13;
            // 
            // btnPesquisaProduto
            // 
            btnPesquisaProduto.Location = new Point(675, 34);
            btnPesquisaProduto.Name = "btnPesquisaProduto";
            btnPesquisaProduto.Size = new Size(75, 23);
            btnPesquisaProduto.TabIndex = 15;
            btnPesquisaProduto.Text = "Produtos";
            btnPesquisaProduto.UseVisualStyleBackColor = true;
            btnPesquisaProduto.Click += btnPesquisaProduto_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(755, 350);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(198, 29);
            btnFinalizar.TabIndex = 6;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(755, 385);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(198, 29);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(361, 34);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(308, 23);
            txtCodigo.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 54);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 11;
            label5.Text = "Lista de Itens";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRemoverCliente);
            groupBox1.Controls.Add(lbEmail);
            groupBox1.Controls.Add(lbEndereco);
            groupBox1.Controls.Add(lbNmCliente);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnPesquisarCliente);
            groupBox1.Location = new Point(78, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(810, 100);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Cliente";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(464, 20);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(0, 15);
            lbEmail.TabIndex = 18;
            // 
            // lbEndereco
            // 
            lbEndereco.AutoSize = true;
            lbEndereco.Location = new Point(87, 71);
            lbEndereco.Name = "lbEndereco";
            lbEndereco.Size = new Size(0, 15);
            lbEndereco.TabIndex = 17;
            // 
            // lbNmCliente
            // 
            lbNmCliente.AutoSize = true;
            lbNmCliente.Location = new Point(71, 19);
            lbNmCliente.Name = "lbNmCliente";
            lbNmCliente.Size = new Size(0, 15);
            lbNmCliente.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(464, 19);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 15;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 71);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 14;
            label3.Text = "Endereço:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 13;
            label1.Text = "Nome:";
            // 
            // btnPesquisarCliente
            // 
            btnPesquisarCliente.Location = new Point(551, 71);
            btnPesquisarCliente.Name = "btnPesquisarCliente";
            btnPesquisarCliente.Size = new Size(140, 23);
            btnPesquisarCliente.TabIndex = 12;
            btnPesquisarCliente.Text = "Selecionar Cliente";
            btnPesquisarCliente.UseVisualStyleBackColor = true;
            btnPesquisarCliente.Click += btnPesquisarCliente_Click;
            // 
            // tabEdit
            // 
            tabEdit.Controls.Add(cBAlterar);
            tabEdit.Controls.Add(gbAlterar);
            tabEdit.Controls.Add(btnVoltarEdit);
            tabEdit.Location = new Point(4, 24);
            tabEdit.Name = "tabEdit";
            tabEdit.Padding = new Padding(3);
            tabEdit.Size = new Size(971, 539);
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
            gbAlterar.Controls.Add(btnRemover);
            gbAlterar.Controls.Add(btnSalvar);
            gbAlterar.Enabled = false;
            gbAlterar.Location = new Point(6, 36);
            gbAlterar.Name = "gbAlterar";
            gbAlterar.Size = new Size(959, 481);
            gbAlterar.TabIndex = 0;
            gbAlterar.TabStop = false;
            gbAlterar.Text = "Dados Venda";
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
            // btnRemoverCliente
            // 
            btnRemoverCliente.Location = new Point(700, 71);
            btnRemoverCliente.Name = "btnRemoverCliente";
            btnRemoverCliente.Size = new Size(104, 23);
            btnRemoverCliente.TabIndex = 19;
            btnRemoverCliente.Text = "Remover";
            btnRemoverCliente.UseVisualStyleBackColor = true;
            btnRemoverCliente.Click += btnRemoverCliente_Click;
            // 
            // VendaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 585);
            Controls.Add(tabControlVenda);
            Name = "VendaForm";
            Text = "VendaForm";
            tabControlVenda.ResumeLayout(false);
            tabList.ResumeLayout(false);
            tabList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridVenda).EndInit();
            tabAdd.ResumeLayout(false);
            gbVenda.ResumeLayout(false);
            gbVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridItensVenda).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabEdit.ResumeLayout(false);
            tabEdit.PerformLayout();
            gbAlterar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlVenda;
        private TabPage tabList;
        private Button btnAtualizarList;
        private Button btnPesquisa;
        private TextBox txtPesquisa;
        private Button btnIrCadastrar;
        private DataGridView dtGridVenda;
        private TabPage tabAdd;
        private Label label5;
        private TextBox txtCodigo;
        private Button btnCancelar;
        private Button btnFinalizar;
        private TabPage tabEdit;
        private CheckBox cBAlterar;
        private GroupBox gbAlterar;
        private Button btnRemover;
        private Button btnSalvar;
        private Button btnVoltarEdit;
        private DataGridView dataGridItensVenda;
        private Button btnPesquisarCliente;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label1;
        private GroupBox gbVenda;
        private Button btnPesquisaProduto;
        private TextBox txtData;
        private TextBox txtTotalItens;
        private TextBox txtTotal;
        private Label label12;
        private Label label11;
        private Label lbValorTotal;
        private Label lbEmail;
        private Label lbEndereco;
        private Label lbNmCliente;
        private Button btnRemoverCliente;
    }
}