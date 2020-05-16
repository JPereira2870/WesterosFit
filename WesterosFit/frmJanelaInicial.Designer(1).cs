namespace WesterosFit
{
    partial class frmJanelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJanelaInicial));
            this.bttnAdicionarMembro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttnConsultarMembro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnAdicionarMembro
            // 
            this.bttnAdicionarMembro.Location = new System.Drawing.Point(11, 207);
            this.bttnAdicionarMembro.Margin = new System.Windows.Forms.Padding(2);
            this.bttnAdicionarMembro.Name = "bttnAdicionarMembro";
            this.bttnAdicionarMembro.Size = new System.Drawing.Size(154, 63);
            this.bttnAdicionarMembro.TabIndex = 0;
            this.bttnAdicionarMembro.Text = "Adicionar Membro";
            this.bttnAdicionarMembro.UseVisualStyleBackColor = true;
            this.bttnAdicionarMembro.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(596, 199);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bttnConsultarMembro
            // 
            this.bttnConsultarMembro.Location = new System.Drawing.Point(187, 208);
            this.bttnConsultarMembro.Name = "bttnConsultarMembro";
            this.bttnConsultarMembro.Size = new System.Drawing.Size(153, 63);
            this.bttnConsultarMembro.TabIndex = 2;
            this.bttnConsultarMembro.Text = "Consultar Membro";
            this.bttnConsultarMembro.UseVisualStyleBackColor = true;
            this.bttnConsultarMembro.Click += new System.EventHandler(this.bttnConsultarMembro_Click);
            // 
            // frmJanelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(600, 344);
            this.Controls.Add(this.bttnConsultarMembro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttnAdicionarMembro);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmJanelaInicial";
            this.Text = "JanelaInicial";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnAdicionarMembro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttnConsultarMembro;
    }
}