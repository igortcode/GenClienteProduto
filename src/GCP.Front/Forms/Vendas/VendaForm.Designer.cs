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
            tabAdd = new TabPage();
            btnRemoverCliente = new Button();
            gbVenda = new GroupBox();
            label6 = new Label();
            label2 = new Label();
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
            tabList = new TabPage();
            btnRelatorio = new Button();
            btnPesquisa = new Button();
            txtPesquisa = new TextBox();
            dtGridVenda = new DataGridView();
            tabEdit = new TabPage();
            gbAlterar = new GroupBox();
            btnVoltar = new Button();
            groupBox3 = new GroupBox();
            label16 = new Label();
            txtDataVisualizar = new TextBox();
            txtTotalItensVisualizar = new TextBox();
            txtValorTotalVisualizar = new TextBox();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            dataGridVisualizar = new DataGridView();
            button4 = new Button();
            label20 = new Label();
            groupBox2 = new GroupBox();
            lbEmailVisualizar = new Label();
            lbEnderecoVisualizar = new Label();
            lbNomeClienteVisualizar = new Label();
            label10 = new Label();
            label13 = new Label();
            label14 = new Label();
            tabControlVenda.SuspendLayout();
            tabAdd.SuspendLayout();
            gbVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridItensVenda).BeginInit();
            groupBox1.SuspendLayout();
            tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridVenda).BeginInit();
            tabEdit.SuspendLayout();
            gbAlterar.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVisualizar).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlVenda
            // 
            tabControlVenda.Controls.Add(tabAdd);
            tabControlVenda.Controls.Add(tabList);
            tabControlVenda.Controls.Add(tabEdit);
            tabControlVenda.Location = new Point(12, 17);
            tabControlVenda.Name = "tabControlVenda";
            tabControlVenda.SelectedIndex = 0;
            tabControlVenda.Size = new Size(979, 567);
            tabControlVenda.SizeMode = TabSizeMode.FillToRight;
            tabControlVenda.TabIndex = 1;
            // 
            // tabAdd
            // 
            tabAdd.Controls.Add(btnRemoverCliente);
            tabAdd.Controls.Add(gbVenda);
            tabAdd.Controls.Add(groupBox1);
            tabAdd.Controls.Add(btnPesquisarCliente);
            tabAdd.Location = new Point(4, 24);
            tabAdd.Name = "tabAdd";
            tabAdd.Padding = new Padding(3);
            tabAdd.Size = new Size(971, 539);
            tabAdd.TabIndex = 1;
            tabAdd.Text = "PDV";
            tabAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemoverCliente
            // 
            btnRemoverCliente.Location = new Point(819, 83);
            btnRemoverCliente.Name = "btnRemoverCliente";
            btnRemoverCliente.Size = new Size(140, 23);
            btnRemoverCliente.TabIndex = 19;
            btnRemoverCliente.Text = "Remover";
            btnRemoverCliente.UseVisualStyleBackColor = true;
            btnRemoverCliente.Click += btnRemoverCliente_Click;
            // 
            // gbVenda
            // 
            gbVenda.Controls.Add(label6);
            gbVenda.Controls.Add(label2);
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(362, 25);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 24;
            label6.Text = "Ex: Qtd x Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 393);
            label2.Name = "label2";
            label2.Size = new Size(260, 15);
            label2.TabIndex = 22;
            label2.Text = "*Clique na linha duas vezes para remover o item";
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
            dataGridItensVenda.ReadOnly = true;
            dataGridItensVenda.Size = new Size(743, 318);
            dataGridItensVenda.TabIndex = 13;
            dataGridItensVenda.RowHeaderMouseDoubleClick += dataGridItensVenda_RowHeaderMouseDoubleClick;
            // 
            // btnPesquisaProduto
            // 
            btnPesquisaProduto.Location = new Point(755, 314);
            btnPesquisaProduto.Name = "btnPesquisaProduto";
            btnPesquisaProduto.Size = new Size(198, 30);
            btnPesquisaProduto.TabIndex = 3;
            btnPesquisaProduto.Text = "Consultar Produtos";
            btnPesquisaProduto.UseVisualStyleBackColor = true;
            btnPesquisaProduto.Click += btnPesquisaProduto_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(755, 350);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(198, 29);
            btnFinalizar.TabIndex = 4;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(755, 385);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(198, 29);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(362, 43);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(387, 23);
            txtCodigo.TabIndex = 2;
            txtCodigo.KeyUp += txtCodigo_KeyUp;
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
            groupBox1.Controls.Add(lbEmail);
            groupBox1.Controls.Add(lbEndereco);
            groupBox1.Controls.Add(lbNmCliente);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(801, 100);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Cliente";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(61, 44);
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
            label4.Location = new Point(22, 44);
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
            btnPesquisarCliente.Location = new Point(819, 17);
            btnPesquisarCliente.Name = "btnPesquisarCliente";
            btnPesquisarCliente.Size = new Size(140, 23);
            btnPesquisarCliente.TabIndex = 1;
            btnPesquisarCliente.Text = "Selecionar Cliente";
            btnPesquisarCliente.UseVisualStyleBackColor = true;
            btnPesquisarCliente.Click += btnPesquisarCliente_Click;
            // 
            // tabList
            // 
            tabList.Controls.Add(btnRelatorio);
            tabList.Controls.Add(btnPesquisa);
            tabList.Controls.Add(txtPesquisa);
            tabList.Controls.Add(dtGridVenda);
            tabList.Location = new Point(4, 24);
            tabList.Name = "tabList";
            tabList.Padding = new Padding(3);
            tabList.Size = new Size(971, 539);
            tabList.TabIndex = 0;
            tabList.Text = "Vendas";
            tabList.UseVisualStyleBackColor = true;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Location = new Point(843, 491);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(122, 31);
            btnRelatorio.TabIndex = 4;
            btnRelatorio.Text = "Relatório";
            btnRelatorio.UseVisualStyleBackColor = true;
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
            // dtGridVenda
            // 
            dtGridVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridVenda.Location = new Point(6, 61);
            dtGridVenda.Name = "dtGridVenda";
            dtGridVenda.ReadOnly = true;
            dtGridVenda.Size = new Size(959, 413);
            dtGridVenda.TabIndex = 0;
            dtGridVenda.RowHeaderMouseDoubleClick += dtGridVenda_RowHeaderMouseDoubleClick;
            // 
            // tabEdit
            // 
            tabEdit.Controls.Add(gbAlterar);
            tabEdit.Location = new Point(4, 24);
            tabEdit.Name = "tabEdit";
            tabEdit.Padding = new Padding(3);
            tabEdit.Size = new Size(971, 539);
            tabEdit.TabIndex = 2;
            tabEdit.Text = "Visualizar";
            tabEdit.UseVisualStyleBackColor = true;
            // 
            // gbAlterar
            // 
            gbAlterar.Controls.Add(btnVoltar);
            gbAlterar.Controls.Add(groupBox3);
            gbAlterar.Controls.Add(groupBox2);
            gbAlterar.Enabled = false;
            gbAlterar.Location = new Point(6, 6);
            gbAlterar.Name = "gbAlterar";
            gbAlterar.Size = new Size(959, 511);
            gbAlterar.TabIndex = 0;
            gbAlterar.TabStop = false;
            gbAlterar.Text = "Dados Venda";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(854, 13);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(91, 23);
            btnVoltar.TabIndex = 18;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(txtDataVisualizar);
            groupBox3.Controls.Add(txtTotalItensVisualizar);
            groupBox3.Controls.Add(txtValorTotalVisualizar);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(dataGridVisualizar);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(label20);
            groupBox3.Enabled = false;
            groupBox3.Location = new Point(6, 137);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(939, 368);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "PDV";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 393);
            label16.Name = "label16";
            label16.Size = new Size(260, 15);
            label16.TabIndex = 22;
            label16.Text = "*Clique na linha duas vezes para remover o item";
            // 
            // txtDataVisualizar
            // 
            txtDataVisualizar.Enabled = false;
            txtDataVisualizar.Location = new Point(771, 174);
            txtDataVisualizar.Name = "txtDataVisualizar";
            txtDataVisualizar.ReadOnly = true;
            txtDataVisualizar.Size = new Size(104, 23);
            txtDataVisualizar.TabIndex = 21;
            // 
            // txtTotalItensVisualizar
            // 
            txtTotalItensVisualizar.Enabled = false;
            txtTotalItensVisualizar.Location = new Point(771, 114);
            txtTotalItensVisualizar.Name = "txtTotalItensVisualizar";
            txtTotalItensVisualizar.ReadOnly = true;
            txtTotalItensVisualizar.Size = new Size(145, 23);
            txtTotalItensVisualizar.TabIndex = 20;
            // 
            // txtValorTotalVisualizar
            // 
            txtValorTotalVisualizar.Enabled = false;
            txtValorTotalVisualizar.Location = new Point(771, 53);
            txtValorTotalVisualizar.Name = "txtValorTotalVisualizar";
            txtValorTotalVisualizar.ReadOnly = true;
            txtValorTotalVisualizar.Size = new Size(145, 23);
            txtValorTotalVisualizar.TabIndex = 19;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(771, 96);
            label17.Name = "label17";
            label17.Size = new Size(63, 15);
            label17.TabIndex = 18;
            label17.Text = "Total Itens:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(771, 156);
            label18.Name = "label18";
            label18.Size = new Size(34, 15);
            label18.TabIndex = 17;
            label18.Text = "Data:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(771, 35);
            label19.Name = "label19";
            label19.Size = new Size(67, 15);
            label19.TabIndex = 16;
            label19.Text = "Valor Total: ";
            // 
            // dataGridVisualizar
            // 
            dataGridVisualizar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVisualizar.Location = new Point(6, 37);
            dataGridVisualizar.Name = "dataGridVisualizar";
            dataGridVisualizar.ReadOnly = true;
            dataGridVisualizar.Size = new Size(743, 307);
            dataGridVisualizar.TabIndex = 13;
            // 
            // button4
            // 
            button4.Location = new Point(755, 385);
            button4.Name = "button4";
            button4.Size = new Size(198, 29);
            button4.TabIndex = 5;
            button4.Text = "Cancelar";
            button4.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(6, 19);
            label20.Name = "label20";
            label20.Size = new Size(75, 15);
            label20.TabIndex = 11;
            label20.Text = "Lista de Itens";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbEmailVisualizar);
            groupBox2.Controls.Add(lbEnderecoVisualizar);
            groupBox2.Controls.Add(lbNomeClienteVisualizar);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.Location = new Point(6, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(939, 100);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados Cliente";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lbEmailVisualizar
            // 
            lbEmailVisualizar.AutoSize = true;
            lbEmailVisualizar.Location = new Point(61, 44);
            lbEmailVisualizar.Name = "lbEmailVisualizar";
            lbEmailVisualizar.Size = new Size(0, 15);
            lbEmailVisualizar.TabIndex = 18;
            // 
            // lbEnderecoVisualizar
            // 
            lbEnderecoVisualizar.AutoSize = true;
            lbEnderecoVisualizar.Location = new Point(87, 71);
            lbEnderecoVisualizar.Name = "lbEnderecoVisualizar";
            lbEnderecoVisualizar.Size = new Size(0, 15);
            lbEnderecoVisualizar.TabIndex = 17;
            // 
            // lbNomeClienteVisualizar
            // 
            lbNomeClienteVisualizar.AutoSize = true;
            lbNomeClienteVisualizar.Location = new Point(71, 19);
            lbNomeClienteVisualizar.Name = "lbNomeClienteVisualizar";
            lbNomeClienteVisualizar.Size = new Size(0, 15);
            lbNomeClienteVisualizar.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 44);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 15;
            label10.Text = "Email:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(22, 71);
            label13.Name = "label13";
            label13.Size = new Size(59, 15);
            label13.TabIndex = 14;
            label13.Text = "Endereço:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(22, 20);
            label14.Name = "label14";
            label14.Size = new Size(43, 15);
            label14.TabIndex = 13;
            label14.Text = "Nome:";
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
            tabAdd.ResumeLayout(false);
            gbVenda.ResumeLayout(false);
            gbVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridItensVenda).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabList.ResumeLayout(false);
            tabList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridVenda).EndInit();
            tabEdit.ResumeLayout(false);
            gbAlterar.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVisualizar).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlVenda;
        private TabPage tabList;
        private Button btnPesquisa;
        private TextBox txtPesquisa;
        private DataGridView dtGridVenda;
        private TabPage tabAdd;
        private Label label5;
        private TextBox txtCodigo;
        private Button btnCancelar;
        private Button btnFinalizar;
        private TabPage tabEdit;
        private GroupBox gbAlterar;
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
        private Label label2;
        private Label label6;
        private GroupBox groupBox3;
        private Label label16;
        private TextBox txtTotalItensVisualizar;
        private TextBox txtValorTotalVisualizar;
        private Label label17;
        private Label label19;
        private DataGridView dataGridVisualizar;
        private Button button4;
        private Label label20;
        private GroupBox groupBox2;
        private Label lbEmailVisualizar;
        private Label lbEnderecoVisualizar;
        private Label lbNomeClienteVisualizar;
        private Label label10;
        private Label label13;
        private Label label14;
        private Button btnRelatorio;
        private TextBox txtDataVisualizar;
        private Label label18;
        private Button btnVoltar;
    }
}