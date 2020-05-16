namespace WesterosFit
{
    partial class frmCriarNed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCriarNed));
            this.gbNed = new System.Windows.Forms.GroupBox();
            this.txtNomeNed = new System.Windows.Forms.TextBox();
            this.txtIdadeNed = new System.Windows.Forms.TextBox();
            this.lblNomeNed = new System.Windows.Forms.Label();
            this.lblIdadeNed = new System.Windows.Forms.Label();
            this.bttnVoltarClasses = new System.Windows.Forms.Button();
            this.bttnVoltarInicial = new System.Windows.Forms.Button();
            this.pbNed = new System.Windows.Forms.PictureBox();
            this.btnCriarUtilizador = new System.Windows.Forms.Button();
            this.gbDadosAdicionaisNed = new System.Windows.Forms.GroupBox();
            this.lblNExerciciosNed = new System.Windows.Forms.Label();
            this.txtNExerciciosNed = new System.Windows.Forms.TextBox();
            this.cbSPANed = new System.Windows.Forms.CheckBox();
            this.lblCamposObrigatorios = new System.Windows.Forms.Label();
            this.gbNed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNed)).BeginInit();
            this.gbDadosAdicionaisNed.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNed
            // 
            this.gbNed.Controls.Add(this.lblCamposObrigatorios);
            this.gbNed.Controls.Add(this.txtNomeNed);
            this.gbNed.Controls.Add(this.txtIdadeNed);
            this.gbNed.Controls.Add(this.lblNomeNed);
            this.gbNed.Controls.Add(this.lblIdadeNed);
            this.gbNed.Location = new System.Drawing.Point(361, 67);
            this.gbNed.Name = "gbNed";
            this.gbNed.Size = new System.Drawing.Size(368, 168);
            this.gbNed.TabIndex = 27;
            this.gbNed.TabStop = false;
            this.gbNed.Text = "Dados Pessoais";
            // 
            // txtNomeNed
            // 
            this.txtNomeNed.Location = new System.Drawing.Point(37, 53);
            this.txtNomeNed.Name = "txtNomeNed";
            this.txtNomeNed.Size = new System.Drawing.Size(325, 20);
            this.txtNomeNed.TabIndex = 3;
            // 
            // txtIdadeNed
            // 
            this.txtIdadeNed.Location = new System.Drawing.Point(40, 121);
            this.txtIdadeNed.Name = "txtIdadeNed";
            this.txtIdadeNed.Size = new System.Drawing.Size(59, 20);
            this.txtIdadeNed.TabIndex = 4;
            // 
            // lblNomeNed
            // 
            this.lblNomeNed.AutoSize = true;
            this.lblNomeNed.Location = new System.Drawing.Point(37, 29);
            this.lblNomeNed.Name = "lblNomeNed";
            this.lblNomeNed.Size = new System.Drawing.Size(42, 13);
            this.lblNomeNed.TabIndex = 1;
            this.lblNomeNed.Text = "*Nome:";
            // 
            // lblIdadeNed
            // 
            this.lblIdadeNed.AutoSize = true;
            this.lblIdadeNed.Location = new System.Drawing.Point(37, 94);
            this.lblIdadeNed.Name = "lblIdadeNed";
            this.lblIdadeNed.Size = new System.Drawing.Size(41, 13);
            this.lblIdadeNed.TabIndex = 2;
            this.lblIdadeNed.Text = "*Idade:";
            // 
            // bttnVoltarClasses
            // 
            this.bttnVoltarClasses.Location = new System.Drawing.Point(630, 358);
            this.bttnVoltarClasses.Margin = new System.Windows.Forms.Padding(2);
            this.bttnVoltarClasses.Name = "bttnVoltarClasses";
            this.bttnVoltarClasses.Size = new System.Drawing.Size(99, 38);
            this.bttnVoltarClasses.TabIndex = 28;
            this.bttnVoltarClasses.Text = "Voltar";
            this.bttnVoltarClasses.UseVisualStyleBackColor = true;
            this.bttnVoltarClasses.Click += new System.EventHandler(this.bttnVoltarClasses_Click);
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
            this.bttnVoltarInicial.TabIndex = 29;
            this.bttnVoltarInicial.UseVisualStyleBackColor = true;
            this.bttnVoltarInicial.Click += new System.EventHandler(this.bttnVoltarInicial_Click);
            // 
            // pbNed
            // 
            this.pbNed.Image = ((System.Drawing.Image)(resources.GetObject("pbNed.Image")));
            this.pbNed.Location = new System.Drawing.Point(12, 67);
            this.pbNed.Name = "pbNed";
            this.pbNed.Size = new System.Drawing.Size(304, 349);
            this.pbNed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNed.TabIndex = 26;
            this.pbNed.TabStop = false;
            this.pbNed.Click += new System.EventHandler(this.pbBrienne_Click);
            // 
            // btnCriarUtilizador
            // 
            this.btnCriarUtilizador.Location = new System.Drawing.Point(361, 358);
            this.btnCriarUtilizador.Name = "btnCriarUtilizador";
            this.btnCriarUtilizador.Size = new System.Drawing.Size(99, 38);
            this.btnCriarUtilizador.TabIndex = 30;
            this.btnCriarUtilizador.Text = "Criar Utilizador";
            this.btnCriarUtilizador.UseVisualStyleBackColor = true;
            this.btnCriarUtilizador.Click += new System.EventHandler(this.btnCriarUtilizador_Click);
            // 
            // gbDadosAdicionaisNed
            // 
            this.gbDadosAdicionaisNed.Controls.Add(this.lblNExerciciosNed);
            this.gbDadosAdicionaisNed.Controls.Add(this.txtNExerciciosNed);
            this.gbDadosAdicionaisNed.Controls.Add(this.cbSPANed);
            this.gbDadosAdicionaisNed.Location = new System.Drawing.Point(361, 252);
            this.gbDadosAdicionaisNed.Name = "gbDadosAdicionaisNed";
            this.gbDadosAdicionaisNed.Size = new System.Drawing.Size(368, 100);
            this.gbDadosAdicionaisNed.TabIndex = 31;
            this.gbDadosAdicionaisNed.TabStop = false;
            this.gbDadosAdicionaisNed.Text = "Dados Adicionais";
            // 
            // lblNExerciciosNed
            // 
            this.lblNExerciciosNed.AutoSize = true;
            this.lblNExerciciosNed.Location = new System.Drawing.Point(219, 40);
            this.lblNExerciciosNed.Name = "lblNExerciciosNed";
            this.lblNExerciciosNed.Size = new System.Drawing.Size(110, 13);
            this.lblNExerciciosNed.TabIndex = 2;
            this.lblNExerciciosNed.Text = "Numero de Exercicios";
            // 
            // txtNExerciciosNed
            // 
            this.txtNExerciciosNed.Location = new System.Drawing.Point(222, 56);
            this.txtNExerciciosNed.Name = "txtNExerciciosNed";
            this.txtNExerciciosNed.Size = new System.Drawing.Size(100, 20);
            this.txtNExerciciosNed.TabIndex = 1;
            // 
            // cbSPANed
            // 
            this.cbSPANed.AutoSize = true;
            this.cbSPANed.Location = new System.Drawing.Point(28, 56);
            this.cbSPANed.Name = "cbSPANed";
            this.cbSPANed.Size = new System.Drawing.Size(47, 17);
            this.cbSPANed.TabIndex = 0;
            this.cbSPANed.Text = "SPA";
            this.cbSPANed.UseVisualStyleBackColor = true;
            // 
            // lblCamposObrigatorios
            // 
            this.lblCamposObrigatorios.AutoSize = true;
            this.lblCamposObrigatorios.Location = new System.Drawing.Point(251, 152);
            this.lblCamposObrigatorios.Name = "lblCamposObrigatorios";
            this.lblCamposObrigatorios.Size = new System.Drawing.Size(111, 13);
            this.lblCamposObrigatorios.TabIndex = 32;
            this.lblCamposObrigatorios.Text = "* Campos Obrigatórios";
            // 
            // frmCriarNed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbDadosAdicionaisNed);
            this.Controls.Add(this.btnCriarUtilizador);
            this.Controls.Add(this.bttnVoltarInicial);
            this.Controls.Add(this.bttnVoltarClasses);
            this.Controls.Add(this.gbNed);
            this.Controls.Add(this.pbNed);
            this.Name = "frmCriarNed";
            this.Text = "frmCriarNed";
            this.Load += new System.EventHandler(this.frmCriarNed_Load);
            this.gbNed.ResumeLayout(false);
            this.gbNed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNed)).EndInit();
            this.gbDadosAdicionaisNed.ResumeLayout(false);
            this.gbDadosAdicionaisNed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNed;
        private System.Windows.Forms.TextBox txtNomeNed;
        private System.Windows.Forms.TextBox txtIdadeNed;
        private System.Windows.Forms.Label lblNomeNed;
        private System.Windows.Forms.Label lblIdadeNed;
        private System.Windows.Forms.PictureBox pbNed;
        private System.Windows.Forms.Button bttnVoltarInicial;
        private System.Windows.Forms.Button bttnVoltarClasses;
        private System.Windows.Forms.Button btnCriarUtilizador;
        private System.Windows.Forms.GroupBox gbDadosAdicionaisNed;
        private System.Windows.Forms.Label lblNExerciciosNed;
        private System.Windows.Forms.TextBox txtNExerciciosNed;
        private System.Windows.Forms.CheckBox cbSPANed;
        private System.Windows.Forms.Label lblCamposObrigatorios;
    }
}