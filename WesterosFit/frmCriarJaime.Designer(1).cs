namespace WesterosFit
{
    partial class frmCriarJaime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCriarJaime));
            this.gbJaime = new System.Windows.Forms.GroupBox();
            this.txtNomeJaime = new System.Windows.Forms.TextBox();
            this.txtIdadeJaime = new System.Windows.Forms.TextBox();
            this.lblNomeJaime = new System.Windows.Forms.Label();
            this.lblIdadeJaime = new System.Windows.Forms.Label();
            this.bttnVoltarInicial = new System.Windows.Forms.Button();
            this.pbJaime = new System.Windows.Forms.PictureBox();
            this.bttnVoltarClasses = new System.Windows.Forms.Button();
            this.btnCriarUtilizador = new System.Windows.Forms.Button();
            this.gbDadosAdicionaisJaime = new System.Windows.Forms.GroupBox();
            this.cbSPAJaime = new System.Windows.Forms.CheckBox();
            this.lblCamposObrigatorios = new System.Windows.Forms.Label();
            this.gbJaime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbJaime)).BeginInit();
            this.gbDadosAdicionaisJaime.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbJaime
            // 
            this.gbJaime.Controls.Add(this.lblCamposObrigatorios);
            this.gbJaime.Controls.Add(this.txtNomeJaime);
            this.gbJaime.Controls.Add(this.txtIdadeJaime);
            this.gbJaime.Controls.Add(this.lblNomeJaime);
            this.gbJaime.Controls.Add(this.lblIdadeJaime);
            this.gbJaime.Location = new System.Drawing.Point(361, 67);
            this.gbJaime.Name = "gbJaime";
            this.gbJaime.Size = new System.Drawing.Size(368, 168);
            this.gbJaime.TabIndex = 29;
            this.gbJaime.TabStop = false;
            this.gbJaime.Text = "Dados Pessoais";
            // 
            // txtNomeJaime
            // 
            this.txtNomeJaime.Location = new System.Drawing.Point(37, 53);
            this.txtNomeJaime.Name = "txtNomeJaime";
            this.txtNomeJaime.Size = new System.Drawing.Size(325, 20);
            this.txtNomeJaime.TabIndex = 3;
            // 
            // txtIdadeJaime
            // 
            this.txtIdadeJaime.Location = new System.Drawing.Point(40, 121);
            this.txtIdadeJaime.Name = "txtIdadeJaime";
            this.txtIdadeJaime.Size = new System.Drawing.Size(59, 20);
            this.txtIdadeJaime.TabIndex = 4;
            // 
            // lblNomeJaime
            // 
            this.lblNomeJaime.AutoSize = true;
            this.lblNomeJaime.Location = new System.Drawing.Point(37, 29);
            this.lblNomeJaime.Name = "lblNomeJaime";
            this.lblNomeJaime.Size = new System.Drawing.Size(42, 13);
            this.lblNomeJaime.TabIndex = 1;
            this.lblNomeJaime.Text = "*Nome:";
            // 
            // lblIdadeJaime
            // 
            this.lblIdadeJaime.AutoSize = true;
            this.lblIdadeJaime.Location = new System.Drawing.Point(37, 94);
            this.lblIdadeJaime.Name = "lblIdadeJaime";
            this.lblIdadeJaime.Size = new System.Drawing.Size(41, 13);
            this.lblIdadeJaime.TabIndex = 2;
            this.lblIdadeJaime.Text = "*Idade:";
            // 
            // bttnVoltarInicial
            // 
            this.bttnVoltarInicial.AllowDrop = true;
            this.bttnVoltarInicial.AutoSize = true;
            this.bttnVoltarInicial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnVoltarInicial.BackgroundImage")));
            this.bttnVoltarInicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttnVoltarInicial.Location = new System.Drawing.Point(12, 4);
            this.bttnVoltarInicial.Name = "bttnVoltarInicial";
            this.bttnVoltarInicial.Size = new System.Drawing.Size(58, 58);
            this.bttnVoltarInicial.TabIndex = 30;
            this.bttnVoltarInicial.UseVisualStyleBackColor = true;
            this.bttnVoltarInicial.Click += new System.EventHandler(this.bttnVoltarInicial_Click);
            // 
            // pbJaime
            // 
            this.pbJaime.Image = ((System.Drawing.Image)(resources.GetObject("pbJaime.Image")));
            this.pbJaime.Location = new System.Drawing.Point(12, 67);
            this.pbJaime.Name = "pbJaime";
            this.pbJaime.Size = new System.Drawing.Size(304, 349);
            this.pbJaime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbJaime.TabIndex = 28;
            this.pbJaime.TabStop = false;
            // 
            // bttnVoltarClasses
            // 
            this.bttnVoltarClasses.Location = new System.Drawing.Point(630, 358);
            this.bttnVoltarClasses.Margin = new System.Windows.Forms.Padding(2);
            this.bttnVoltarClasses.Name = "bttnVoltarClasses";
            this.bttnVoltarClasses.Size = new System.Drawing.Size(99, 39);
            this.bttnVoltarClasses.TabIndex = 31;
            this.bttnVoltarClasses.Text = "Voltar";
            this.bttnVoltarClasses.UseVisualStyleBackColor = true;
            this.bttnVoltarClasses.Click += new System.EventHandler(this.bttnVoltarClasses_Click);
            // 
            // btnCriarUtilizador
            // 
            this.btnCriarUtilizador.Location = new System.Drawing.Point(361, 358);
            this.btnCriarUtilizador.Name = "btnCriarUtilizador";
            this.btnCriarUtilizador.Size = new System.Drawing.Size(99, 38);
            this.btnCriarUtilizador.TabIndex = 32;
            this.btnCriarUtilizador.Text = "Criar Utilizador";
            this.btnCriarUtilizador.UseVisualStyleBackColor = true;
            this.btnCriarUtilizador.Click += new System.EventHandler(this.btnCriarUtilizador_Click);
            // 
            // gbDadosAdicionaisJaime
            // 
            this.gbDadosAdicionaisJaime.Controls.Add(this.cbSPAJaime);
            this.gbDadosAdicionaisJaime.Location = new System.Drawing.Point(361, 252);
            this.gbDadosAdicionaisJaime.Name = "gbDadosAdicionaisJaime";
            this.gbDadosAdicionaisJaime.Size = new System.Drawing.Size(368, 100);
            this.gbDadosAdicionaisJaime.TabIndex = 33;
            this.gbDadosAdicionaisJaime.TabStop = false;
            this.gbDadosAdicionaisJaime.Text = "Dados Adicionais";
            // 
            // cbSPAJaime
            // 
            this.cbSPAJaime.AutoSize = true;
            this.cbSPAJaime.Location = new System.Drawing.Point(160, 42);
            this.cbSPAJaime.Name = "cbSPAJaime";
            this.cbSPAJaime.Size = new System.Drawing.Size(47, 17);
            this.cbSPAJaime.TabIndex = 0;
            this.cbSPAJaime.Text = "SPA";
            this.cbSPAJaime.UseVisualStyleBackColor = true;
            // 
            // lblCamposObrigatorios
            // 
            this.lblCamposObrigatorios.AutoSize = true;
            this.lblCamposObrigatorios.Location = new System.Drawing.Point(251, 152);
            this.lblCamposObrigatorios.Name = "lblCamposObrigatorios";
            this.lblCamposObrigatorios.Size = new System.Drawing.Size(111, 13);
            this.lblCamposObrigatorios.TabIndex = 6;
            this.lblCamposObrigatorios.Text = "* Campos Obrigatórios";
            // 
            // frmCriarJaime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbDadosAdicionaisJaime);
            this.Controls.Add(this.btnCriarUtilizador);
            this.Controls.Add(this.bttnVoltarClasses);
            this.Controls.Add(this.bttnVoltarInicial);
            this.Controls.Add(this.gbJaime);
            this.Controls.Add(this.pbJaime);
            this.Name = "frmCriarJaime";
            this.Text = "frmCriarJaime";
            this.gbJaime.ResumeLayout(false);
            this.gbJaime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbJaime)).EndInit();
            this.gbDadosAdicionaisJaime.ResumeLayout(false);
            this.gbDadosAdicionaisJaime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbJaime;
        private System.Windows.Forms.TextBox txtNomeJaime;
        private System.Windows.Forms.TextBox txtIdadeJaime;
        private System.Windows.Forms.Label lblNomeJaime;
        private System.Windows.Forms.Label lblIdadeJaime;
        private System.Windows.Forms.PictureBox pbJaime;
        private System.Windows.Forms.Button bttnVoltarInicial;
        private System.Windows.Forms.Button bttnVoltarClasses;
        private System.Windows.Forms.Button btnCriarUtilizador;
        private System.Windows.Forms.GroupBox gbDadosAdicionaisJaime;
        private System.Windows.Forms.CheckBox cbSPAJaime;
        private System.Windows.Forms.Label lblCamposObrigatorios;
    }
}