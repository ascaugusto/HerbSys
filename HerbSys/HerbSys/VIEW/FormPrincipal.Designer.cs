namespace HerbSys
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCadastrarCliente = new System.Windows.Forms.ToolStripButton();
            this.stbCadastrarProduto = new System.Windows.Forms.ToolStripButton();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tsbRegistraVenda = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCadastrarCliente,
            this.stbCadastrarProduto,
            this.tsbRegistraVenda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(395, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbCadastrarCliente
            // 
            this.tsbCadastrarCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCadastrarCliente.Image = ((System.Drawing.Image)(resources.GetObject("tsbCadastrarCliente.Image")));
            this.tsbCadastrarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCadastrarCliente.Name = "tsbCadastrarCliente";
            this.tsbCadastrarCliente.Size = new System.Drawing.Size(23, 22);
            this.tsbCadastrarCliente.Text = "Cadastrar Cliente";
            this.tsbCadastrarCliente.Click += new System.EventHandler(this.tsbCadastrarCliente_Click);
            // 
            // stbCadastrarProduto
            // 
            this.stbCadastrarProduto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stbCadastrarProduto.Image = ((System.Drawing.Image)(resources.GetObject("stbCadastrarProduto.Image")));
            this.stbCadastrarProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbCadastrarProduto.Name = "stbCadastrarProduto";
            this.stbCadastrarProduto.Size = new System.Drawing.Size(23, 22);
            this.stbCadastrarProduto.Text = "Cadastrar Produto";
            this.stbCadastrarProduto.Click += new System.EventHandler(this.stbCadastrarProduto_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.InitialImage")));
            this.pbLogo.Location = new System.Drawing.Point(46, 43);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(300, 180);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // tsbRegistraVenda
            // 
            this.tsbRegistraVenda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRegistraVenda.Image = ((System.Drawing.Image)(resources.GetObject("tsbRegistraVenda.Image")));
            this.tsbRegistraVenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRegistraVenda.Name = "tsbRegistraVenda";
            this.tsbRegistraVenda.Size = new System.Drawing.Size(23, 22);
            this.tsbRegistraVenda.Text = "Registrar Venda";
            this.tsbRegistraVenda.Click += new System.EventHandler(this.tooltsbRegistraVenda_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 251);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormPrincipal";
            this.Text = "HerbSys";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbCadastrarCliente;
        private System.Windows.Forms.ToolStripButton stbCadastrarProduto;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ToolStripButton tsbRegistraVenda;
    }
}