
namespace GCP.Front
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnProduto = new Button();
            mainPanel = new Panel();
            btnCliente = new Button();
            btnVenda = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnProduto
            // 
            btnProduto.BackColor = SystemColors.Control;
            btnProduto.Location = new Point(12, 185);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(143, 73);
            btnProduto.TabIndex = 2;
            btnProduto.Text = "Produtos";
            btnProduto.UseVisualStyleBackColor = false;
            btnProduto.Click += btnProduto_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = SystemColors.Control;
            mainPanel.Location = new Point(178, 27);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1004, 598);
            mainPanel.TabIndex = 1;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = SystemColors.Control;
            btnCliente.Location = new Point(12, 106);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(143, 73);
            btnCliente.TabIndex = 1;
            btnCliente.Text = "Clientes";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnVenda
            // 
            btnVenda.BackColor = SystemColors.Control;
            btnVenda.Location = new Point(12, 27);
            btnVenda.Name = "btnVenda";
            btnVenda.Size = new Size(143, 73);
            btnVenda.TabIndex = 0;
            btnVenda.Text = "Vendas";
            btnVenda.UseVisualStyleBackColor = false;
            btnVenda.Click += btnVenda_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Location = new Point(12, 264);
            button3.Name = "button3";
            button3.Size = new Size(143, 73);
            button3.TabIndex = 3;
            button3.Text = "Relatórios";
            button3.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1194, 637);
            Controls.Add(button3);
            Controls.Add(btnVenda);
            Controls.Add(btnCliente);
            Controls.Add(mainPanel);
            Controls.Add(btnProduto);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GCP - Gerenciador de Clientes e Produtos";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProduto;
        private Panel mainPanel;
        private Button btnCliente;
        private Button btnVenda;
        private Button button3;
    }
}
