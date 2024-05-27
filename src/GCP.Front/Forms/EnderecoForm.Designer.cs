namespace GCP.Front.Forms
{
    partial class EnderecoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnderecoForm));
            Cep = new Label();
            mkCep = new MaskedTextBox();
            txtLogradouro = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtBairro = new TextBox();
            label3 = new Label();
            txtNumero = new TextBox();
            label4 = new Label();
            txtCidade = new TextBox();
            label5 = new Label();
            cbEstado = new ComboBox();
            btnSalvar = new Button();
            btnFechar = new Button();
            label6 = new Label();
            txtComplemento = new TextBox();
            pbLoading = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLoading).BeginInit();
            SuspendLayout();
            // 
            // Cep
            // 
            Cep.AutoSize = true;
            Cep.Location = new Point(25, 27);
            Cep.Name = "Cep";
            Cep.Size = new Size(28, 15);
            Cep.TabIndex = 1;
            Cep.Text = "Cep";
            // 
            // mkCep
            // 
            mkCep.Location = new Point(25, 45);
            mkCep.Mask = "00,000-000";
            mkCep.Name = "mkCep";
            mkCep.Size = new Size(80, 23);
            mkCep.TabIndex = 2;
            mkCep.KeyUp += mkCep_KeyUp;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Enabled = false;
            txtLogradouro.Location = new Point(25, 103);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(334, 23);
            txtLogradouro.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 85);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 4;
            label1.Text = "Logradouro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 140);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "Bairro";
            // 
            // txtBairro
            // 
            txtBairro.Enabled = false;
            txtBairro.Location = new Point(25, 158);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(213, 23);
            txtBairro.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(260, 140);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 8;
            label3.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Enabled = false;
            txtNumero.Location = new Point(260, 158);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(99, 23);
            txtNumero.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 196);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 10;
            label4.Text = "Cidade";
            // 
            // txtCidade
            // 
            txtCidade.Enabled = false;
            txtCidade.Location = new Point(25, 214);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(161, 23);
            txtCidade.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(260, 196);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 12;
            label5.Text = "Estado";
            // 
            // cbEstado
            // 
            cbEstado.Enabled = false;
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(260, 214);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(73, 23);
            cbEstado.TabIndex = 13;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(296, 333);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(215, 333);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 15;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 255);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 17;
            label6.Text = "Complemento";
            // 
            // txtComplemento
            // 
            txtComplemento.Enabled = false;
            txtComplemento.Location = new Point(25, 273);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(334, 23);
            txtComplemento.TabIndex = 16;
            // 
            // pbLoading
            // 
            pbLoading.Image = (Image)resources.GetObject("pbLoading.Image");
            pbLoading.InitialImage = (Image)resources.GetObject("pbLoading.InitialImage");
            pbLoading.Location = new Point(111, 45);
            pbLoading.Name = "pbLoading";
            pbLoading.Size = new Size(24, 23);
            pbLoading.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLoading.TabIndex = 18;
            pbLoading.TabStop = false;
            pbLoading.Click += pbLoading_Click;
            // 
            // EnderecoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 368);
            Controls.Add(pbLoading);
            Controls.Add(label6);
            Controls.Add(txtComplemento);
            Controls.Add(btnFechar);
            Controls.Add(btnSalvar);
            Controls.Add(cbEstado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtCidade);
            Controls.Add(label3);
            Controls.Add(txtNumero);
            Controls.Add(label2);
            Controls.Add(txtBairro);
            Controls.Add(label1);
            Controls.Add(txtLogradouro);
            Controls.Add(mkCep);
            Controls.Add(Cep);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "EnderecoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Endereço";
            ((System.ComponentModel.ISupportInitialize)pbLoading).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Cep;
        private MaskedTextBox mkCep;
        private TextBox txtLogradouro;
        private Label label1;
        private Label label2;
        private TextBox txtBairro;
        private Label label3;
        private TextBox txtNumero;
        private Label label4;
        private TextBox txtCidade;
        private Label label5;
        private ComboBox cbEstado;
        private Button btnSalvar;
        private Button btnFechar;
        private Label label6;
        private TextBox txtComplemento;
        private PictureBox pbLoading;
    }
}