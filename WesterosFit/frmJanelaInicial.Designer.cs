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
            this.btnAdicionarMembro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConsultareEditarMembro = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionarMembro
            // 
            this.btnAdicionarMembro.Location = new System.Drawing.Point(11, 221);
            this.btnAdicionarMembro.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionarMembro.Name = "btnAdicionarMembro";
            this.btnAdicionarMembro.Size = new System.Drawing.Size(231, 63);
            this.btnAdicionarMembro.TabIndex = 0;
            this.btnAdicionarMembro.Text = "Adicionar Membro";
            this.btnAdicionarMembro.UseVisualStyleBackColor = true;
            this.btnAdicionarMembro.Click += new System.EventHandler(this.bttnAdicionarMembro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(596, 199);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnConsultareEditarMembro
            // 
            this.btnConsultareEditarMembro.Location = new System.Drawing.Point(378, 221);
            this.btnConsultareEditarMembro.Name = "btnConsultareEditarMembro";
            this.btnConsultareEditarMembro.Size = new System.Drawing.Size(231, 63);
            this.btnConsultareEditarMembro.TabIndex = 2;
            this.btnConsultareEditarMembro.Text = "Consultar/Editar Membro";
            this.btnConsultareEditarMembro.UseVisualStyleBackColor = true;
            this.btnConsultareEditarMembro.Click += new System.EventHandler(this.bttnConsultarEditarMembro_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(272, 217);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // frmJanelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(621, 296);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnConsultareEditarMembro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAdicionarMembro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmJanelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WesterosFit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarMembro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConsultareEditarMembro;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}