namespace WesterosFit
{
    partial class frmCriarBran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCriarBran));
            this.pbBran = new System.Windows.Forms.PictureBox();
            this.gbBran = new System.Windows.Forms.GroupBox();
            this.txtNomeBran = new System.Windows.Forms.TextBox();
            this.txtIdadeBran = new System.Windows.Forms.TextBox();
            this.lblNomeBran = new System.Windows.Forms.Label();
            this.lblIdadeBran = new System.Windows.Forms.Label();
            this.bttnVoltarInicial = new System.Windows.Forms.Button();
            this.bttnVoltarClasses = new System.Windows.Forms.Button();
            this.btnCriarUtilizador = new System.Windows.Forms.Button();
            this.gbDadosAdicionaisBran = new System.Windows.Forms.GroupBox();
            this.cbSPABran = new System.Windows.Forms.CheckBox();
            this.lblCamposObrigatorios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBran)).BeginInit();
            this.gbBran.SuspendLayout();
            this.gbDadosAdicionaisBran.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbBran
            // 
            this.pbBran.Image = ((System.Drawing.Image)(resources.GetObject("pbBran.Image")));
            this.pbBran.Location = new System.Drawing.Point(12, 67);
            this.pbBran.Name = "pbBran";
            this.pbBran.Size = new System.Drawing.Size(304, 349);
            this.pbBran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBran.TabIndex = 6;
            this.pbBran.TabStop = false;
            // 
            // gbBran
            // 
            this.gbBran.Controls.Add(this.lblCamposObrigatorios);
            this.gbBran.Controls.Add(this.txtNomeBran);
            this.gbBran.Controls.Add(this.txtIdadeBran);
            this.gbBran.Controls.Add(this.lblNomeBran);
            this.gbBran.Controls.Add(this.lblIdadeBran);
            this.gbBran.Location = new System.Drawing.Point(361, 67);
            this.gbBran.Name = "gbBran";
            this.gbBran.Size = new System.Drawing.Size(368, 168);
            this.gbBran.TabIndex = 7;
            this.gbBran.TabStop = false;
            this.gbBran.Text = "Dados Pessoais";
            // 
            // txtNomeBran
            // 
            this.txtNomeBran.Location = new System.Drawing.Point(37, 53);
            this.txtNomeBran.Name = "txtNomeBran";
            this.txtNomeBran.Size = new System.Drawing.Size(325, 20);
            this.txtNomeBran.TabIndex = 3;
            // 
            // txtIdadeBran
            // 
            this.txtIdadeBran.Location = new System.Drawing.Point(40, 121);
            this.txtIdadeBran.Name = "txtIdadeBran";
            this.txtIdadeBran.Size = new System.Drawing.Size(59, 20);
            this.txtIdadeBran.TabIndex = 4;
            // 
            // lblNomeBran
            // 
            this.lblNomeBran.AutoSize = true;
            this.lblNomeBran.Location = new System.Drawing.Point(37, 29);
            this.lblNomeBran.Name = "lblNomeBran";
            this.lblNomeBran.Size = new System.Drawing.Size(45, 13);
            this.lblNomeBran.TabIndex = 1;
            this.lblNomeBran.Text = "*Nome: ";
            // 
            // lblIdadeBran
            // 
            this.lblIdadeBran.AutoSize = true;
            this.lblIdadeBran.Location = new System.Drawing.Point(37, 94);
            this.lblIdadeBran.Name = "lblIdadeBran";
            this.lblIdadeBran.Size = new System.Drawing.Size(41, 13);
            this.lblIdadeBran.TabIndex = 2;
            this.lblIdadeBran.Text = "*Idade:";
            // 
            // bttnVoltarInicial
            // 
            this.bttnVoltarInicial.AllowDrop = true;
            this.bttnVoltarInicial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnVoltarInicial.BackgroundImage")));
            this.bttnVoltarInicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttnVoltarInicial.Location = new System.Drawing.Point(12, 4);
            this.bttnVoltarInicial.Name = "bttnVoltarInicial";
            this.bttnVoltarInicial.Size = new System.Drawing.Size(59, 57);
            this.bttnVoltarInicial.TabIndex = 23;
            this.bttnVoltarInicial.UseVisualStyleBackColor = true;
            this.bttnVoltarInicial.Click += new System.EventHandler(this.bttnVoltarInicial_Click);
            // 
            // bttnVoltarClasses
            // 
            this.bttnVoltarClasses.Location = new System.Drawing.Point(630, 357);
            this.bttnVoltarClasses.Margin = new System.Windows.Forms.Padding(2);
            this.bttnVoltarClasses.Name = "bttnVoltarClasses";
            this.bttnVoltarClasses.Size = new System.Drawing.Size(99, 39);
            this.bttnVoltarClasses.TabIndex = 24;
            this.bttnVoltarClasses.Text = "Voltar";
            this.bttnVoltarClasses.UseVisualStyleBackColor = true;
            this.bttnVoltarClasses.Click += new System.EventHandler(this.bttnVoltarClasses_Click);
            // 
            // btnCriarUtilizador
            // 
            this.btnCriarUtilizador.Location = new System.Drawing.Point(361, 357);
            this.btnCriarUtilizador.Name = "btnCriarUtilizador";
            this.btnCriarUtilizador.Size = new System.Drawing.Size(99, 38);
            this.btnCriarUtilizador.TabIndex = 25;
            this.btnCriarUtilizador.Text = "Criar Utilizador";
            this.btnCriarUtilizador.UseVisualStyleBackColor = true;
            this.btnCriarUtilizador.Click += new System.EventHandler(this.btnCriarUtilizador_Click);
            // 
            // gbDadosAdicionaisBran
            // 
            this.gbDadosAdicionaisBran.Controls.Add(this.cbSPABran);
            this.gbDadosAdicionaisBran.Location = new System.Drawing.Point(361, 252);
            this.gbDadosAdicionaisBran.Name = "gbDadosAdicionaisBran";
            this.gbDadosAdicionaisBran.Size = new System.Drawing.Size(368, 100);
            this.gbDadosAdicionaisBran.TabIndex = 26;
            this.gbDadosAdicionaisBran.TabStop = false;
            this.gbDadosAdicionaisBran.Text = "Dados Adicionais ";
            // 
            // cbSPABran
            // 
            this.cbSPABran.AutoSize = true;
            this.cbSPABran.Location = new System.Drawing.Point(161, 44);
            this.cbSPABran.Name = "cbSPABran";
            this.cbSPABran.Size = new System.Drawing.Size(47, 17);
            this.cbSPABran.TabIndex = 0;
            this.cbSPABran.Text = "SPA";
            this.cbSPABran.UseVisualStyleBackColor = true;
            // 
            // lblCamposObrigatorios
            // 
            this.lblCamposObrigatorios.AutoSize = true;
            this.lblCamposObrigatorios.Location = new System.Drawing.Point(251, 152);
            this.lblCamposObrigatorios.Name = "lblCamposObrigatorios";
            this.lblCamposObrigatorios.Size = new System.Drawing.Size(111, 13);
            this.lblCamposObrigatorios.TabIndex = 5;
            this.lblCamposObrigatorios.Text = "* Campos Obrigatórios";
            // 
            // frmCriarBran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbDadosAdicionaisBran);
            this.Controls.Add(this.btnCriarUtilizador);
            this.Controls.Add(this.bttnVoltarClasses);
            this.Controls.Add(this.bttnVoltarInicial);
            this.Controls.Add(this.gbBran);
            this.Controls.Add(this.pbBran);
            this.Name = "frmCriarBran";
            this.Text = "frmCriarBran";
            this.Load += new System.EventHandler(this.frmCriarBran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBran)).EndInit();
            this.gbBran.ResumeLayout(false);
            this.gbBran.PerformLayout();
            this.gbDadosAdicionaisBran.ResumeLayout(false);
            this.gbDadosAdicionaisBran.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbBran;
        private System.Windows.Forms.GroupBox gbBran;
        private System.Windows.Forms.TextBox txtNomeBran;
        private System.Windows.Forms.TextBox txtIdadeBran;
        private System.Windows.Forms.Label lblNomeBran;
        private System.Windows.Forms.Label lblIdadeBran;
        private System.Windows.Forms.Button bttnVoltarInicial;
        private System.Windows.Forms.Button bttnVoltarClasses;
        private System.Windows.Forms.Button btnCriarUtilizador;
        private System.Windows.Forms.GroupBox gbDadosAdicionaisBran;
        private System.Windows.Forms.CheckBox cbSPABran;
        private System.Windows.Forms.Label lblCamposObrigatorios;
    }
}