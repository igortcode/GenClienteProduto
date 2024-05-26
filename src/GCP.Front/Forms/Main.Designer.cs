
namespace GCP.Front
{
    partial class Main
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
            SuspendLayout();
            // 
            // btnProduto
            // 
            btnProduto.BackColor = SystemColors.Control;
            btnProduto.Location = new Point(12, 27);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(143, 73);
            btnProduto.TabIndex = 0;
            btnProduto.Text = "Produtos";
            btnProduto.UseVisualStyleBackColor = false;
            btnProduto.Click += btnProduto_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = SystemColors.Control;
            mainPanel.Location = new Point(178, 27);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(811, 487);
            mainPanel.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1001, 526);
            Controls.Add(mainPanel);
            Controls.Add(btnProduto);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GCP - Gerenciador de Clientes e Produtos";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProduto;
        private Panel mainPanel;
    }
}
