namespace WesterosFit
{
    partial class frmCriarMembro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCriarMembro));
            this.gbDadosAdicionaisNed = new System.Windows.Forms.GroupBox();
            this.cbProblemasCardiacos = new System.Windows.Forms.CheckBox();
            this.lblNumeroDeExercicios = new System.Windows.Forms.Label();
            this.txtNumeroDeExercicios = new System.Windows.Forms.TextBox();
            this.btnCriarNed = new System.Windows.Forms.Button();
            this.btnVoltarClasses = new System.Windows.Forms.Button();
            this.gbDadosPessoaisNed = new System.Windows.Forms.GroupBox();
            this.lbIdadeInvalida = new System.Windows.Forms.Label();
            this.lbNomeInvalido = new System.Windows.Forms.Label();
            this.lblCamposObrigatorios = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblNomeNed = new System.Windows.Forms.Label();
            this.lblIdadeNed = new System.Windows.Forms.Label();
            this.btnVoltarInicial = new System.Windows.Forms.Button();
            this.pbNed = new System.Windows.Forms.PictureBox();
            this.pbJaime = new System.Windows.Forms.PictureBox();
            this.pbBrienne = new System.Windows.Forms.PictureBox();
            this.pbBran = new System.Windows.Forms.PictureBox();
            this.btnCriarJaime = new System.Windows.Forms.Button();
            this.btnCriarBran = new System.Windows.Forms.Button();
            this.btnCriarBrienne = new System.Windows.Forms.Button();
            this.gbDadosAdicionaisNed.SuspendLayout();
            this.gbDadosPessoaisNed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJaime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrienne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBran)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDadosAdicionaisNed
            // 
            this.gbDadosAdicionaisNed.Controls.Add(this.cbProblemasCardiacos);
            this.gbDadosAdicionaisNed.Controls.Add(this.lblNumeroDeExercicios);
            this.gbDadosAdicionaisNed.Controls.Add(this.txtNumeroDeExercicios);
            this.gbDadosAdicionaisNed.Location = new System.Drawing.Point(367, 257);
            this.gbDadosAdicionaisNed.Name = "gbDadosAdicionaisNed";
            this.gbDadosAdicionaisNed.Size = new System.Drawing.Size(368, 100);
            this.gbDadosAdicionaisNed.TabIndex = 37;
            this.gbDadosAdicionaisNed.TabStop = false;
            this.gbDadosAdicionaisNed.Text = "Dados Adicionais";
            // 
            // cbProblemasCardiacos
            // 
            this.cbProblemasCardiacos.AutoSize = true;
            this.cbProblemasCardiacos.Location = new System.Drawing.Point(19, 48);
            this.cbProblemasCardiacos.Name = "cbProblemasCardiacos";
            this.cbProblemasCardiacos.Size = new System.Drawing.Size(127, 17);
            this.cbProblemasCardiacos.TabIndex = 3;
            this.cbProblemasCardiacos.Text = "Problemas Cardíacos";
            this.cbProblemasCardiacos.UseVisualStyleBackColor = true;
            // 
            // lblNumeroDeExercicios
            // 
            this.lblNumeroDeExercicios.AutoSize = true;
            this.lblNumeroDeExercicios.Location = new System.Drawing.Point(183, 49);
            this.lblNumeroDeExercicios.Name = "lblNumeroDeExercicios";
            this.lblNumeroDeExercicios.Size = new System.Drawing.Size(113, 13);
            this.lblNumeroDeExercicios.TabIndex = 2;
            this.lblNumeroDeExercicios.Text = "Número de Exercicios:";
            // 
            // txtNumeroDeExercicios
            // 
            this.txtNumeroDeExercicios.Location = new System.Drawing.Point(302, 46);
            this.txtNumeroDeExercicios.Name = "txtNumeroDeExercicios";
            this.txtNumeroDeExercicios.Size = new System.Drawing.Size(43, 20);
            this.txtNumeroDeExercicios.TabIndex = 5;
            // 
            // btnCriarNed
            // 
            this.btnCriarNed.Location = new System.Drawing.Point(367, 363);
            this.btnCriarNed.Name = "btnCriarNed";
            this.btnCriarNed.Size = new System.Drawing.Size(99, 38);
            this.btnCriarNed.TabIndex = 36;
            this.btnCriarNed.Text = "Criar Membro";
            this.btnCriarNed.UseVisualStyleBackColor = true;
            this.btnCriarNed.Click += new System.EventHandler(this.btnCriarNed_Click);
            // 
            // btnVoltarClasses
            // 
            this.btnVoltarClasses.Location = new System.Drawing.Point(636, 363);
            this.btnVoltarClasses.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltarClasses.Name = "btnVoltarClasses";
            this.btnVoltarClasses.Size = new System.Drawing.Size(99, 38);
            this.btnVoltarClasses.TabIndex = 34;
            this.btnVoltarClasses.Text = "Voltar";
            this.btnVoltarClasses.UseVisualStyleBackColor = true;
            this.btnVoltarClasses.Click += new System.EventHandler(this.btnVoltarClasses_Click_1);
            // 
            // gbDadosPessoaisNed
            // 
            this.gbDadosPessoaisNed.Controls.Add(this.lbIdadeInvalida);
            this.gbDadosPessoaisNed.Controls.Add(this.lbNomeInvalido);
            this.gbDadosPessoaisNed.Controls.Add(this.lblCamposObrigatorios);
            this.gbDadosPessoaisNed.Controls.Add(this.txtNome);
            this.gbDadosPessoaisNed.Controls.Add(this.txtIdade);
            this.gbDadosPessoaisNed.Controls.Add(this.lblNomeNed);
            this.gbDadosPessoaisNed.Controls.Add(this.lblIdadeNed);
            this.gbDadosPessoaisNed.Location = new System.Drawing.Point(367, 72);
            this.gbDadosPessoaisNed.Name = "gbDadosPessoaisNed";
            this.gbDadosPessoaisNed.Size = new System.Drawing.Size(368, 168);
            this.gbDadosPessoaisNed.TabIndex = 33;
            this.gbDadosPessoaisNed.TabStop = false;
            this.gbDadosPessoaisNed.Text = "Dados Pessoais";
            // 
            // lbIdadeInvalida
            // 
            this.lbIdadeInvalida.AutoSize = true;
            this.lbIdadeInvalida.ForeColor = System.Drawing.Color.Red;
            this.lbIdadeInvalida.Location = new System.Drawing.Point(105, 124);
            this.lbIdadeInvalida.Name = "lbIdadeInvalida";
            this.lbIdadeInvalida.Size = new System.Drawing.Size(130, 13);
            this.lbIdadeInvalida.TabIndex = 34;
            this.lbIdadeInvalida.Text = "Preenchimento obrigatório";
            // 
            // lbNomeInvalido
            // 
            this.lbNomeInvalido.AutoSize = true;
            this.lbNomeInvalido.ForeColor = System.Drawing.Color.Red;
            this.lbNomeInvalido.Location = new System.Drawing.Point(232, 37);
            this.lbNomeInvalido.Name = "lbNomeInvalido";
            this.lbNomeInvalido.Size = new System.Drawing.Size(130, 13);
            this.lbNomeInvalido.TabIndex = 33;
            this.lbNomeInvalido.Text = "Preenchimento obrigatório";
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
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(37, 53);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(325, 20);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(40, 121);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(59, 20);
            this.txtIdade.TabIndex = 4;
            this.txtIdade.TextChanged += new System.EventHandler(this.txtIdade_TextChanged);
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
            // btnVoltarInicial
            // 
            this.btnVoltarInicial.AllowDrop = true;
            this.btnVoltarInicial.AutoSize = true;
            this.btnVoltarInicial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltarInicial.BackgroundImage")));
            this.btnVoltarInicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVoltarInicial.Location = new System.Drawing.Point(18, 8);
            this.btnVoltarInicial.Name = "btnVoltarInicial";
            this.btnVoltarInicial.Size = new System.Drawing.Size(58, 58);
            this.btnVoltarInicial.TabIndex = 35;
            this.btnVoltarInicial.UseVisualStyleBackColor = true;
            this.btnVoltarInicial.Click += new System.EventHandler(this.btnVoltarInicial_Click);
            // 
            // pbNed
            // 
            this.pbNed.Image = ((System.Drawing.Image)(resources.GetObject("pbNed.Image")));
            this.pbNed.Location = new System.Drawing.Point(18, 72);
            this.pbNed.Name = "pbNed";
            this.pbNed.Size = new System.Drawing.Size(304, 349);
            this.pbNed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNed.TabIndex = 32;
            this.pbNed.TabStop = false;
            // 
            // pbJaime
            // 
            this.pbJaime.Image = ((System.Drawing.Image)(resources.GetObject("pbJaime.Image")));
            this.pbJaime.Location = new System.Drawing.Point(18, 72);
            this.pbJaime.Name = "pbJaime";
            this.pbJaime.Size = new System.Drawing.Size(304, 349);
            this.pbJaime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbJaime.TabIndex = 38;
            this.pbJaime.TabStop = false;
            // 
            // pbBrienne
            // 
            this.pbBrienne.Image = ((System.Drawing.Image)(resources.GetObject("pbBrienne.Image")));
            this.pbBrienne.Location = new System.Drawing.Point(18, 72);
            this.pbBrienne.Name = "pbBrienne";
            this.pbBrienne.Size = new System.Drawing.Size(304, 349);
            this.pbBrienne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBrienne.TabIndex = 39;
            this.pbBrienne.TabStop = false;
            // 
            // pbBran
            // 
            this.pbBran.Image = ((System.Drawing.Image)(resources.GetObject("pbBran.Image")));
            this.pbBran.Location = new System.Drawing.Point(18, 72);
            this.pbBran.Name = "pbBran";
            this.pbBran.Size = new System.Drawing.Size(304, 349);
            this.pbBran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBran.TabIndex = 40;
            this.pbBran.TabStop = false;
            // 
            // btnCriarJaime
            // 
            this.btnCriarJaime.Location = new System.Drawing.Point(368, 363);
            this.btnCriarJaime.Name = "btnCriarJaime";
            this.btnCriarJaime.Size = new System.Drawing.Size(99, 38);
            this.btnCriarJaime.TabIndex = 41;
            this.btnCriarJaime.Text = "Criar Membro";
            this.btnCriarJaime.UseVisualStyleBackColor = true;
            this.btnCriarJaime.Click += new System.EventHandler(this.btnCriarJaime_Click);
            // 
            // btnCriarBran
            // 
            this.btnCriarBran.Location = new System.Drawing.Point(368, 363);
            this.btnCriarBran.Name = "btnCriarBran";
            this.btnCriarBran.Size = new System.Drawing.Size(99, 38);
            this.btnCriarBran.TabIndex = 42;
            this.btnCriarBran.Text = "Criar Membro";
            this.btnCriarBran.UseVisualStyleBackColor = true;
            this.btnCriarBran.Click += new System.EventHandler(this.btnCriarBran_Click);
            // 
            // btnCriarBrienne
            // 
            this.btnCriarBrienne.Location = new System.Drawing.Point(368, 363);
            this.btnCriarBrienne.Name = "btnCriarBrienne";
            this.btnCriarBrienne.Size = new System.Drawing.Size(99, 38);
            this.btnCriarBrienne.TabIndex = 43;
            this.btnCriarBrienne.Text = "Criar Membro";
            this.btnCriarBrienne.UseVisualStyleBackColor = true;
            this.btnCriarBrienne.Click += new System.EventHandler(this.btnCriarBrienne_Click);
            // 
            // frmCriarMembro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(752, 418);
            this.Controls.Add(this.btnCriarBrienne);
            this.Controls.Add(this.btnCriarJaime);
            this.Controls.Add(this.btnCriarBran);
            this.Controls.Add(this.gbDadosAdicionaisNed);
            this.Controls.Add(this.btnCriarNed);
            this.Controls.Add(this.btnVoltarInicial);
            this.Controls.Add(this.btnVoltarClasses);
            this.Controls.Add(this.gbDadosPessoaisNed);
            this.Controls.Add(this.pbBran);
            this.Controls.Add(this.pbBrienne);
            this.Controls.Add(this.pbJaime);
            this.Controls.Add(this.pbNed);
            this.Name = "frmCriarMembro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Novo Membro";
            this.Load += new System.EventHandler(this.frmTeste_Load);
            this.gbDadosAdicionaisNed.ResumeLayout(false);
            this.gbDadosAdicionaisNed.PerformLayout();
            this.gbDadosPessoaisNed.ResumeLayout(false);
            this.gbDadosPessoaisNed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJaime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrienne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDadosAdicionaisNed;
        private System.Windows.Forms.Label lblNumeroDeExercicios;
        private System.Windows.Forms.TextBox txtNumeroDeExercicios;
        private System.Windows.Forms.Button btnCriarNed;
        private System.Windows.Forms.Button btnVoltarInicial;
        private System.Windows.Forms.Button btnVoltarClasses;
        private System.Windows.Forms.GroupBox gbDadosPessoaisNed;
        private System.Windows.Forms.Label lblCamposObrigatorios;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblNomeNed;
        private System.Windows.Forms.Label lblIdadeNed;
        private System.Windows.Forms.PictureBox pbNed;
        private System.Windows.Forms.CheckBox cbProblemasCardiacos;
        private System.Windows.Forms.PictureBox pbJaime;
        private System.Windows.Forms.PictureBox pbBrienne;
        private System.Windows.Forms.PictureBox pbBran;
        private System.Windows.Forms.Button btnCriarJaime;
        private System.Windows.Forms.Button btnCriarBran;
        private System.Windows.Forms.Button btnCriarBrienne;
        private System.Windows.Forms.Label lbNomeInvalido;
        private System.Windows.Forms.Label lbIdadeInvalida;
    }
}