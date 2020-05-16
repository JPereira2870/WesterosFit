namespace WesterosFit
{
    partial class frmConsultarMembro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarMembro));
            this.bttnVoltarInicial = new System.Windows.Forms.Button();
            this.dgvTabela = new System.Windows.Forms.DataGridView();
            this.Classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnVoltarInicial
            // 
            this.bttnVoltarInicial.AllowDrop = true;
            this.bttnVoltarInicial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnVoltarInicial.BackgroundImage")));
            this.bttnVoltarInicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttnVoltarInicial.Location = new System.Drawing.Point(3, 3);
            this.bttnVoltarInicial.Name = "bttnVoltarInicial";
            this.bttnVoltarInicial.Size = new System.Drawing.Size(59, 57);
            this.bttnVoltarInicial.TabIndex = 23;
            this.bttnVoltarInicial.UseVisualStyleBackColor = true;
            this.bttnVoltarInicial.Click += new System.EventHandler(this.bttnVoltarInicial_Click_1);
            // 
            // dgvTabela
            // 
            this.dgvTabela.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Classe});
            this.dgvTabela.Location = new System.Drawing.Point(12, 79);
            this.dgvTabela.Name = "dgvTabela";
            this.dgvTabela.Size = new System.Drawing.Size(776, 346);
            this.dgvTabela.TabIndex = 24;
            // 
            // Classe
            // 
            this.Classe.HeaderText = "Classe";
            this.Classe.Name = "Classe";
            this.Classe.ReadOnly = true;
            // 
            // frmConsultarMembro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTabela);
            this.Controls.Add(this.bttnVoltarInicial);
            this.Name = "frmConsultarMembro";
            this.Text = "frmConsultarUtilizador1";
            this.Load += new System.EventHandler(this.frmConsultarMembro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bttnVoltarInicial;
        private System.Windows.Forms.DataGridView dgvTabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classe;
    }
}