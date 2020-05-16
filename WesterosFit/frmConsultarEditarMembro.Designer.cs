namespace WesterosFit
{
    partial class frmConsultarEditarMembro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarEditarMembro));
            this.btnVoltarInicial = new System.Windows.Forms.Button();
            this.dgvMembro = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presencasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDiasUltimaPresencaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPADataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.infracoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPropriedadeExtra1 = new System.Windows.Forms.TextBox();
            this.lblPropriedadeExtra1 = new System.Windows.Forms.Label();
            this.btnVerificarDedicação = new System.Windows.Forms.Button();
            this.btnAddPresencas = new System.Windows.Forms.Button();
            this.btnReativarMembro = new System.Windows.Forms.Button();
            this.btnVerificarMensalidade = new System.Windows.Forms.Button();
            this.btnAtivarDesativarSPA = new System.Windows.Forms.Button();
            this.gbPropriedadesExtras = new System.Windows.Forms.GroupBox();
            this.lbPropriedadeExtra3 = new System.Windows.Forms.Label();
            this.txtPropriedadeExtra3 = new System.Windows.Forms.TextBox();
            this.cbPT = new System.Windows.Forms.CheckBox();
            this.cbProblemasCardiacos = new System.Windows.Forms.CheckBox();
            this.lbPropriedadeExtra2 = new System.Windows.Forms.Label();
            this.txtPropriedadeExtra2 = new System.Windows.Forms.TextBox();
            this.cbGuardiaoDaNoite = new System.Windows.Forms.CheckBox();
            this.gbMetodos = new System.Windows.Forms.GroupBox();
            this.cbDiasDesdeUltimaPresenca = new System.Windows.Forms.ComboBox();
            this.btnAddDiasDesdeDaUltimaPresenca = new System.Windows.Forms.Button();
            this.txtAddDuracaoDaAula = new System.Windows.Forms.TextBox();
            this.btnAddDuracaoDaAula = new System.Windows.Forms.Button();
            this.txtAddPesoMaximo = new System.Windows.Forms.TextBox();
            this.btnAddPesoMaximo = new System.Windows.Forms.Button();
            this.txtAddMinutosMeditacao = new System.Windows.Forms.TextBox();
            this.btnAddMinutosMeditacao = new System.Windows.Forms.Button();
            this.txtAddCaloriasPorSessao = new System.Windows.Forms.TextBox();
            this.btnAddCaloriasPorSessao = new System.Windows.Forms.Button();
            this.btnadAddExercicios = new System.Windows.Forms.Button();
            this.txtAddExercicios = new System.Windows.Forms.TextBox();
            this.cbAddPresencas = new System.Windows.Forms.ComboBox();
            this.txtAddDesconto = new System.Windows.Forms.TextBox();
            this.btnAtribuirDesconto = new System.Windows.Forms.Button();
            this.btnAtivarDesativarMembro = new System.Windows.Forms.Button();
            this.btnAtivarDesativarPersonalTrainer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membroBindingSource)).BeginInit();
            this.gbPropriedadesExtras.SuspendLayout();
            this.gbMetodos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltarInicial
            // 
            this.btnVoltarInicial.AllowDrop = true;
            this.btnVoltarInicial.AutoSize = true;
            this.btnVoltarInicial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltarInicial.BackgroundImage")));
            this.btnVoltarInicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVoltarInicial.Location = new System.Drawing.Point(12, 12);
            this.btnVoltarInicial.Name = "btnVoltarInicial";
            this.btnVoltarInicial.Size = new System.Drawing.Size(59, 57);
            this.btnVoltarInicial.TabIndex = 23;
            this.btnVoltarInicial.UseVisualStyleBackColor = true;
            this.btnVoltarInicial.Click += new System.EventHandler(this.btnVoltarInicial_Click_1);
            // 
            // dgvMembro
            // 
            this.dgvMembro.AllowUserToAddRows = false;
            this.dgvMembro.AllowUserToDeleteRows = false;
            this.dgvMembro.AllowUserToResizeColumns = false;
            this.dgvMembro.AllowUserToResizeRows = false;
            this.dgvMembro.AutoGenerateColumns = false;
            this.dgvMembro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.classeDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.idadeDataGridViewTextBoxColumn,
            this.nivelDataGridViewTextBoxColumn,
            this.experienciaDataGridViewTextBoxColumn,
            this.presencasDataGridViewTextBoxColumn,
            this.numeroDiasUltimaPresencaDataGridViewTextBoxColumn,
            this.sPADataGridViewCheckBoxColumn,
            this.ativoDataGridViewCheckBoxColumn,
            this.infracoesDataGridViewTextBoxColumn});
            this.dgvMembro.DataSource = this.membroBindingSource;
            this.dgvMembro.Location = new System.Drawing.Point(12, 75);
            this.dgvMembro.MultiSelect = false;
            this.dgvMembro.Name = "dgvMembro";
            this.dgvMembro.ReadOnly = true;
            this.dgvMembro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvMembro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvMembro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembro.Size = new System.Drawing.Size(1149, 387);
            this.dgvMembro.TabIndex = 24;
            this.dgvMembro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembro_CellClick);
            this.dgvMembro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembro_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classeDataGridViewTextBoxColumn
            // 
            this.classeDataGridViewTextBoxColumn.DataPropertyName = "Classe";
            this.classeDataGridViewTextBoxColumn.HeaderText = "Classe";
            this.classeDataGridViewTextBoxColumn.Name = "classeDataGridViewTextBoxColumn";
            this.classeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idadeDataGridViewTextBoxColumn
            // 
            this.idadeDataGridViewTextBoxColumn.DataPropertyName = "Idade";
            this.idadeDataGridViewTextBoxColumn.HeaderText = "Idade";
            this.idadeDataGridViewTextBoxColumn.Name = "idadeDataGridViewTextBoxColumn";
            this.idadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nivelDataGridViewTextBoxColumn
            // 
            this.nivelDataGridViewTextBoxColumn.DataPropertyName = "Nivel";
            this.nivelDataGridViewTextBoxColumn.HeaderText = "Nível";
            this.nivelDataGridViewTextBoxColumn.Name = "nivelDataGridViewTextBoxColumn";
            this.nivelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // experienciaDataGridViewTextBoxColumn
            // 
            this.experienciaDataGridViewTextBoxColumn.DataPropertyName = "Experiencia";
            this.experienciaDataGridViewTextBoxColumn.HeaderText = "Experiência";
            this.experienciaDataGridViewTextBoxColumn.Name = "experienciaDataGridViewTextBoxColumn";
            this.experienciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // presencasDataGridViewTextBoxColumn
            // 
            this.presencasDataGridViewTextBoxColumn.DataPropertyName = "Presencas";
            this.presencasDataGridViewTextBoxColumn.HeaderText = "Presenças";
            this.presencasDataGridViewTextBoxColumn.Name = "presencasDataGridViewTextBoxColumn";
            this.presencasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDiasUltimaPresencaDataGridViewTextBoxColumn
            // 
            this.numeroDiasUltimaPresencaDataGridViewTextBoxColumn.DataPropertyName = "NumeroDiasUltimaPresenca";
            this.numeroDiasUltimaPresencaDataGridViewTextBoxColumn.HeaderText = "Nº dias ultima presença";
            this.numeroDiasUltimaPresencaDataGridViewTextBoxColumn.Name = "numeroDiasUltimaPresencaDataGridViewTextBoxColumn";
            this.numeroDiasUltimaPresencaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sPADataGridViewCheckBoxColumn
            // 
            this.sPADataGridViewCheckBoxColumn.DataPropertyName = "SPA";
            this.sPADataGridViewCheckBoxColumn.HeaderText = "SPA";
            this.sPADataGridViewCheckBoxColumn.Name = "sPADataGridViewCheckBoxColumn";
            this.sPADataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ativoDataGridViewCheckBoxColumn
            // 
            this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
            this.ativoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // infracoesDataGridViewTextBoxColumn
            // 
            this.infracoesDataGridViewTextBoxColumn.DataPropertyName = "Infracoes";
            this.infracoesDataGridViewTextBoxColumn.HeaderText = "Infrações";
            this.infracoesDataGridViewTextBoxColumn.Name = "infracoesDataGridViewTextBoxColumn";
            this.infracoesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // membroBindingSource
            // 
            this.membroBindingSource.DataSource = typeof(WesterosFit.Membro);
            // 
            // txtPropriedadeExtra1
            // 
            this.txtPropriedadeExtra1.Enabled = false;
            this.txtPropriedadeExtra1.Location = new System.Drawing.Point(5, 41);
            this.txtPropriedadeExtra1.Margin = new System.Windows.Forms.Padding(2);
            this.txtPropriedadeExtra1.Name = "txtPropriedadeExtra1";
            this.txtPropriedadeExtra1.Size = new System.Drawing.Size(76, 20);
            this.txtPropriedadeExtra1.TabIndex = 32;
            // 
            // lblPropriedadeExtra1
            // 
            this.lblPropriedadeExtra1.AutoSize = true;
            this.lblPropriedadeExtra1.Location = new System.Drawing.Point(2, 20);
            this.lblPropriedadeExtra1.Name = "lblPropriedadeExtra1";
            this.lblPropriedadeExtra1.Size = new System.Drawing.Size(92, 13);
            this.lblPropriedadeExtra1.TabIndex = 33;
            this.lblPropriedadeExtra1.Text = "propriedadeextra1";
            // 
            // btnVerificarDedicação
            // 
            this.btnVerificarDedicação.Location = new System.Drawing.Point(24, 402);
            this.btnVerificarDedicação.Name = "btnVerificarDedicação";
            this.btnVerificarDedicação.Size = new System.Drawing.Size(174, 32);
            this.btnVerificarDedicação.TabIndex = 34;
            this.btnVerificarDedicação.Text = "Verificar Dedicação";
            this.btnVerificarDedicação.UseVisualStyleBackColor = true;
            this.btnVerificarDedicação.Click += new System.EventHandler(this.btnVerificarDedicação_Click);
            // 
            // btnAddPresencas
            // 
            this.btnAddPresencas.Location = new System.Drawing.Point(73, 20);
            this.btnAddPresencas.Name = "btnAddPresencas";
            this.btnAddPresencas.Size = new System.Drawing.Size(125, 36);
            this.btnAddPresencas.TabIndex = 35;
            this.btnAddPresencas.Text = "Adicionar Presenças";
            this.btnAddPresencas.UseVisualStyleBackColor = true;
            this.btnAddPresencas.Click += new System.EventHandler(this.btnAddPresencas_Click);
            // 
            // btnReativarMembro
            // 
            this.btnReativarMembro.Location = new System.Drawing.Point(1199, 465);
            this.btnReativarMembro.Name = "btnReativarMembro";
            this.btnReativarMembro.Size = new System.Drawing.Size(130, 44);
            this.btnReativarMembro.TabIndex = 37;
            this.btnReativarMembro.Text = "Reativar Membro Punido";
            this.btnReativarMembro.UseVisualStyleBackColor = true;
            this.btnReativarMembro.Click += new System.EventHandler(this.btnReativarMembro_Click);
            // 
            // btnVerificarMensalidade
            // 
            this.btnVerificarMensalidade.Location = new System.Drawing.Point(24, 363);
            this.btnVerificarMensalidade.Name = "btnVerificarMensalidade";
            this.btnVerificarMensalidade.Size = new System.Drawing.Size(174, 33);
            this.btnVerificarMensalidade.TabIndex = 38;
            this.btnVerificarMensalidade.Text = "Calcular Mensalidade";
            this.btnVerificarMensalidade.UseVisualStyleBackColor = true;
            this.btnVerificarMensalidade.Click += new System.EventHandler(this.btnVerificarMensalidade_Click);
            // 
            // btnAtivarDesativarSPA
            // 
            this.btnAtivarDesativarSPA.Location = new System.Drawing.Point(1199, 365);
            this.btnAtivarDesativarSPA.Name = "btnAtivarDesativarSPA";
            this.btnAtivarDesativarSPA.Size = new System.Drawing.Size(130, 44);
            this.btnAtivarDesativarSPA.TabIndex = 39;
            this.btnAtivarDesativarSPA.Text = "Ativar/Desativar SPA";
            this.btnAtivarDesativarSPA.UseVisualStyleBackColor = true;
            this.btnAtivarDesativarSPA.Click += new System.EventHandler(this.btnAdicionarRemoverSPA_Click);
            // 
            // gbPropriedadesExtras
            // 
            this.gbPropriedadesExtras.Controls.Add(this.lbPropriedadeExtra3);
            this.gbPropriedadesExtras.Controls.Add(this.txtPropriedadeExtra3);
            this.gbPropriedadesExtras.Controls.Add(this.cbPT);
            this.gbPropriedadesExtras.Controls.Add(this.cbProblemasCardiacos);
            this.gbPropriedadesExtras.Controls.Add(this.lbPropriedadeExtra2);
            this.gbPropriedadesExtras.Controls.Add(this.txtPropriedadeExtra2);
            this.gbPropriedadesExtras.Controls.Add(this.cbGuardiaoDaNoite);
            this.gbPropriedadesExtras.Controls.Add(this.txtPropriedadeExtra1);
            this.gbPropriedadesExtras.Controls.Add(this.lblPropriedadeExtra1);
            this.gbPropriedadesExtras.Location = new System.Drawing.Point(1199, 75);
            this.gbPropriedadesExtras.Name = "gbPropriedadesExtras";
            this.gbPropriedadesExtras.Size = new System.Drawing.Size(133, 234);
            this.gbPropriedadesExtras.TabIndex = 42;
            this.gbPropriedadesExtras.TabStop = false;
            this.gbPropriedadesExtras.Text = "Propriedades Extras:";
            // 
            // lbPropriedadeExtra3
            // 
            this.lbPropriedadeExtra3.AutoSize = true;
            this.lbPropriedadeExtra3.Location = new System.Drawing.Point(4, 107);
            this.lbPropriedadeExtra3.Name = "lbPropriedadeExtra3";
            this.lbPropriedadeExtra3.Size = new System.Drawing.Size(92, 13);
            this.lbPropriedadeExtra3.TabIndex = 48;
            this.lbPropriedadeExtra3.Text = "propriedadeextra3";
            // 
            // txtPropriedadeExtra3
            // 
            this.txtPropriedadeExtra3.Enabled = false;
            this.txtPropriedadeExtra3.Location = new System.Drawing.Point(5, 127);
            this.txtPropriedadeExtra3.Name = "txtPropriedadeExtra3";
            this.txtPropriedadeExtra3.Size = new System.Drawing.Size(73, 20);
            this.txtPropriedadeExtra3.TabIndex = 47;
            // 
            // cbPT
            // 
            this.cbPT.AutoSize = true;
            this.cbPT.Enabled = false;
            this.cbPT.Location = new System.Drawing.Point(7, 187);
            this.cbPT.Name = "cbPT";
            this.cbPT.Size = new System.Drawing.Size(103, 17);
            this.cbPT.TabIndex = 46;
            this.cbPT.Text = "Personal Trainer";
            this.cbPT.UseVisualStyleBackColor = true;
            // 
            // cbProblemasCardiacos
            // 
            this.cbProblemasCardiacos.AutoSize = true;
            this.cbProblemasCardiacos.Enabled = false;
            this.cbProblemasCardiacos.Location = new System.Drawing.Point(7, 165);
            this.cbProblemasCardiacos.Name = "cbProblemasCardiacos";
            this.cbProblemasCardiacos.Size = new System.Drawing.Size(127, 17);
            this.cbProblemasCardiacos.TabIndex = 45;
            this.cbProblemasCardiacos.Text = "Problemas Cardíacos";
            this.cbProblemasCardiacos.UseVisualStyleBackColor = true;
            this.cbProblemasCardiacos.CheckedChanged += new System.EventHandler(this.cbProblemasCardiacos_CheckedChanged);
            // 
            // lbPropriedadeExtra2
            // 
            this.lbPropriedadeExtra2.AutoSize = true;
            this.lbPropriedadeExtra2.Location = new System.Drawing.Point(4, 64);
            this.lbPropriedadeExtra2.Name = "lbPropriedadeExtra2";
            this.lbPropriedadeExtra2.Size = new System.Drawing.Size(92, 13);
            this.lbPropriedadeExtra2.TabIndex = 44;
            this.lbPropriedadeExtra2.Text = "propriedadeextra2";
            // 
            // txtPropriedadeExtra2
            // 
            this.txtPropriedadeExtra2.Enabled = false;
            this.txtPropriedadeExtra2.Location = new System.Drawing.Point(5, 84);
            this.txtPropriedadeExtra2.Name = "txtPropriedadeExtra2";
            this.txtPropriedadeExtra2.Size = new System.Drawing.Size(73, 20);
            this.txtPropriedadeExtra2.TabIndex = 43;
            // 
            // cbGuardiaoDaNoite
            // 
            this.cbGuardiaoDaNoite.AutoSize = true;
            this.cbGuardiaoDaNoite.Enabled = false;
            this.cbGuardiaoDaNoite.Location = new System.Drawing.Point(7, 208);
            this.cbGuardiaoDaNoite.Name = "cbGuardiaoDaNoite";
            this.cbGuardiaoDaNoite.Size = new System.Drawing.Size(112, 17);
            this.cbGuardiaoDaNoite.TabIndex = 42;
            this.cbGuardiaoDaNoite.Text = "Guardião da Noite";
            this.cbGuardiaoDaNoite.UseVisualStyleBackColor = true;
            // 
            // gbMetodos
            // 
            this.gbMetodos.Controls.Add(this.cbDiasDesdeUltimaPresenca);
            this.gbMetodos.Controls.Add(this.btnAddDiasDesdeDaUltimaPresenca);
            this.gbMetodos.Controls.Add(this.txtAddDuracaoDaAula);
            this.gbMetodos.Controls.Add(this.btnAddDuracaoDaAula);
            this.gbMetodos.Controls.Add(this.txtAddPesoMaximo);
            this.gbMetodos.Controls.Add(this.btnAddPesoMaximo);
            this.gbMetodos.Controls.Add(this.txtAddMinutosMeditacao);
            this.gbMetodos.Controls.Add(this.btnAddMinutosMeditacao);
            this.gbMetodos.Controls.Add(this.txtAddCaloriasPorSessao);
            this.gbMetodos.Controls.Add(this.btnAddCaloriasPorSessao);
            this.gbMetodos.Controls.Add(this.btnadAddExercicios);
            this.gbMetodos.Controls.Add(this.txtAddExercicios);
            this.gbMetodos.Controls.Add(this.cbAddPresencas);
            this.gbMetodos.Controls.Add(this.txtAddDesconto);
            this.gbMetodos.Controls.Add(this.btnAtribuirDesconto);
            this.gbMetodos.Controls.Add(this.btnVerificarDedicação);
            this.gbMetodos.Controls.Add(this.btnAddPresencas);
            this.gbMetodos.Controls.Add(this.btnVerificarMensalidade);
            this.gbMetodos.Location = new System.Drawing.Point(1373, 75);
            this.gbMetodos.Name = "gbMetodos";
            this.gbMetodos.Size = new System.Drawing.Size(219, 440);
            this.gbMetodos.TabIndex = 44;
            this.gbMetodos.TabStop = false;
            this.gbMetodos.Text = "Dados referentes ao ultimo mês:";
            // 
            // cbDiasDesdeUltimaPresenca
            // 
            this.cbDiasDesdeUltimaPresenca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiasDesdeUltimaPresenca.FormattingEnabled = true;
            this.cbDiasDesdeUltimaPresenca.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbDiasDesdeUltimaPresenca.Location = new System.Drawing.Point(24, 321);
            this.cbDiasDesdeUltimaPresenca.Name = "cbDiasDesdeUltimaPresenca";
            this.cbDiasDesdeUltimaPresenca.Size = new System.Drawing.Size(43, 21);
            this.cbDiasDesdeUltimaPresenca.TabIndex = 57;
            // 
            // btnAddDiasDesdeDaUltimaPresenca
            // 
            this.btnAddDiasDesdeDaUltimaPresenca.Location = new System.Drawing.Point(73, 313);
            this.btnAddDiasDesdeDaUltimaPresenca.Name = "btnAddDiasDesdeDaUltimaPresenca";
            this.btnAddDiasDesdeDaUltimaPresenca.Size = new System.Drawing.Size(125, 34);
            this.btnAddDiasDesdeDaUltimaPresenca.TabIndex = 56;
            this.btnAddDiasDesdeDaUltimaPresenca.Text = "Adicionar Dias Desde Da Ultima Presença";
            this.btnAddDiasDesdeDaUltimaPresenca.UseVisualStyleBackColor = true;
            this.btnAddDiasDesdeDaUltimaPresenca.Click += new System.EventHandler(this.btnAddDiasDesdeDaUltimaPresenca_Click);
            // 
            // txtAddDuracaoDaAula
            // 
            this.txtAddDuracaoDaAula.Location = new System.Drawing.Point(24, 283);
            this.txtAddDuracaoDaAula.Name = "txtAddDuracaoDaAula";
            this.txtAddDuracaoDaAula.Size = new System.Drawing.Size(43, 20);
            this.txtAddDuracaoDaAula.TabIndex = 55;
            // 
            // btnAddDuracaoDaAula
            // 
            this.btnAddDuracaoDaAula.Location = new System.Drawing.Point(73, 274);
            this.btnAddDuracaoDaAula.Name = "btnAddDuracaoDaAula";
            this.btnAddDuracaoDaAula.Size = new System.Drawing.Size(125, 36);
            this.btnAddDuracaoDaAula.TabIndex = 54;
            this.btnAddDuracaoDaAula.Text = "Adicionar Duração da Aula";
            this.btnAddDuracaoDaAula.UseVisualStyleBackColor = true;
            this.btnAddDuracaoDaAula.Click += new System.EventHandler(this.btnAddDuracaoDaAula_Click);
            // 
            // txtAddPesoMaximo
            // 
            this.txtAddPesoMaximo.Location = new System.Drawing.Point(24, 241);
            this.txtAddPesoMaximo.Name = "txtAddPesoMaximo";
            this.txtAddPesoMaximo.Size = new System.Drawing.Size(43, 20);
            this.txtAddPesoMaximo.TabIndex = 53;
            // 
            // btnAddPesoMaximo
            // 
            this.btnAddPesoMaximo.Location = new System.Drawing.Point(73, 232);
            this.btnAddPesoMaximo.Name = "btnAddPesoMaximo";
            this.btnAddPesoMaximo.Size = new System.Drawing.Size(125, 36);
            this.btnAddPesoMaximo.TabIndex = 52;
            this.btnAddPesoMaximo.Text = "Adicionar Peso Maximo";
            this.btnAddPesoMaximo.UseVisualStyleBackColor = true;
            this.btnAddPesoMaximo.Click += new System.EventHandler(this.btnAddPesoMaximo_Click);
            // 
            // txtAddMinutosMeditacao
            // 
            this.txtAddMinutosMeditacao.Location = new System.Drawing.Point(24, 198);
            this.txtAddMinutosMeditacao.Name = "txtAddMinutosMeditacao";
            this.txtAddMinutosMeditacao.Size = new System.Drawing.Size(43, 20);
            this.txtAddMinutosMeditacao.TabIndex = 51;
            // 
            // btnAddMinutosMeditacao
            // 
            this.btnAddMinutosMeditacao.Location = new System.Drawing.Point(73, 189);
            this.btnAddMinutosMeditacao.Name = "btnAddMinutosMeditacao";
            this.btnAddMinutosMeditacao.Size = new System.Drawing.Size(125, 36);
            this.btnAddMinutosMeditacao.TabIndex = 50;
            this.btnAddMinutosMeditacao.Text = "Adicionar Minutos de Meditação";
            this.btnAddMinutosMeditacao.UseVisualStyleBackColor = true;
            this.btnAddMinutosMeditacao.Click += new System.EventHandler(this.btnAddMinutosMeditacao_Click);
            // 
            // txtAddCaloriasPorSessao
            // 
            this.txtAddCaloriasPorSessao.Location = new System.Drawing.Point(24, 156);
            this.txtAddCaloriasPorSessao.Name = "txtAddCaloriasPorSessao";
            this.txtAddCaloriasPorSessao.Size = new System.Drawing.Size(43, 20);
            this.txtAddCaloriasPorSessao.TabIndex = 49;
            // 
            // btnAddCaloriasPorSessao
            // 
            this.btnAddCaloriasPorSessao.Location = new System.Drawing.Point(73, 147);
            this.btnAddCaloriasPorSessao.Name = "btnAddCaloriasPorSessao";
            this.btnAddCaloriasPorSessao.Size = new System.Drawing.Size(125, 36);
            this.btnAddCaloriasPorSessao.TabIndex = 48;
            this.btnAddCaloriasPorSessao.Text = "Adicionar Calorias Por Sessão";
            this.btnAddCaloriasPorSessao.UseVisualStyleBackColor = true;
            this.btnAddCaloriasPorSessao.Click += new System.EventHandler(this.btnAddCaloriasPorSessao_Click);
            // 
            // btnadAddExercicios
            // 
            this.btnadAddExercicios.Location = new System.Drawing.Point(73, 104);
            this.btnadAddExercicios.Name = "btnadAddExercicios";
            this.btnadAddExercicios.Size = new System.Drawing.Size(125, 36);
            this.btnadAddExercicios.TabIndex = 47;
            this.btnadAddExercicios.Text = "Adicionar Exercícios";
            this.btnadAddExercicios.UseVisualStyleBackColor = true;
            this.btnadAddExercicios.Click += new System.EventHandler(this.btnAddExercicios_Click);
            // 
            // txtAddExercicios
            // 
            this.txtAddExercicios.Location = new System.Drawing.Point(24, 113);
            this.txtAddExercicios.Name = "txtAddExercicios";
            this.txtAddExercicios.Size = new System.Drawing.Size(43, 20);
            this.txtAddExercicios.TabIndex = 46;
            // 
            // cbAddPresencas
            // 
            this.cbAddPresencas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddPresencas.FormattingEnabled = true;
            this.cbAddPresencas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbAddPresencas.Location = new System.Drawing.Point(24, 29);
            this.cbAddPresencas.Name = "cbAddPresencas";
            this.cbAddPresencas.Size = new System.Drawing.Size(43, 21);
            this.cbAddPresencas.TabIndex = 45;
            // 
            // txtAddDesconto
            // 
            this.txtAddDesconto.Location = new System.Drawing.Point(24, 71);
            this.txtAddDesconto.Name = "txtAddDesconto";
            this.txtAddDesconto.Size = new System.Drawing.Size(43, 20);
            this.txtAddDesconto.TabIndex = 40;
            // 
            // btnAtribuirDesconto
            // 
            this.btnAtribuirDesconto.Location = new System.Drawing.Point(73, 62);
            this.btnAtribuirDesconto.Name = "btnAtribuirDesconto";
            this.btnAtribuirDesconto.Size = new System.Drawing.Size(125, 36);
            this.btnAtribuirDesconto.TabIndex = 39;
            this.btnAtribuirDesconto.Text = "Atribuir Desconto";
            this.btnAtribuirDesconto.UseVisualStyleBackColor = true;
            this.btnAtribuirDesconto.Click += new System.EventHandler(this.btnAtribuirDesconto_Click);
            // 
            // btnAtivarDesativarMembro
            // 
            this.btnAtivarDesativarMembro.Location = new System.Drawing.Point(1199, 415);
            this.btnAtivarDesativarMembro.Name = "btnAtivarDesativarMembro";
            this.btnAtivarDesativarMembro.Size = new System.Drawing.Size(130, 44);
            this.btnAtivarDesativarMembro.TabIndex = 45;
            this.btnAtivarDesativarMembro.Text = "Ativar/Desativar Membro";
            this.btnAtivarDesativarMembro.UseVisualStyleBackColor = true;
            this.btnAtivarDesativarMembro.Click += new System.EventHandler(this.btnAtivarDesativarMembro_Click);
            // 
            // btnAtivarDesativarPersonalTrainer
            // 
            this.btnAtivarDesativarPersonalTrainer.Location = new System.Drawing.Point(1199, 315);
            this.btnAtivarDesativarPersonalTrainer.Name = "btnAtivarDesativarPersonalTrainer";
            this.btnAtivarDesativarPersonalTrainer.Size = new System.Drawing.Size(130, 44);
            this.btnAtivarDesativarPersonalTrainer.TabIndex = 46;
            this.btnAtivarDesativarPersonalTrainer.Text = "Ativar/Desativar Personal Trainer";
            this.btnAtivarDesativarPersonalTrainer.UseVisualStyleBackColor = true;
            this.btnAtivarDesativarPersonalTrainer.Click += new System.EventHandler(this.btnAtivarDesativarPersonalTrainer_Click);
            // 
            // frmConsultarEditarMembro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 527);
            this.Controls.Add(this.btnAtivarDesativarPersonalTrainer);
            this.Controls.Add(this.btnAtivarDesativarMembro);
            this.Controls.Add(this.gbMetodos);
            this.Controls.Add(this.gbPropriedadesExtras);
            this.Controls.Add(this.btnAtivarDesativarSPA);
            this.Controls.Add(this.dgvMembro);
            this.Controls.Add(this.btnVoltarInicial);
            this.Controls.Add(this.btnReativarMembro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultarEditarMembro";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar/Editar Membros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmConsultarEditarMembro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membroBindingSource)).EndInit();
            this.gbPropriedadesExtras.ResumeLayout(false);
            this.gbPropriedadesExtras.PerformLayout();
            this.gbMetodos.ResumeLayout(false);
            this.gbMetodos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVoltarInicial;
        private System.Windows.Forms.DataGridView dgvMembro;
        private System.Windows.Forms.BindingSource membroBindingSource;
        private System.Windows.Forms.TextBox txtPropriedadeExtra1;
        private System.Windows.Forms.Label lblPropriedadeExtra1;
        private System.Windows.Forms.Button btnVerificarDedicação;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presencasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDiasUltimaPresencaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sPADataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infracoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddPresencas;
        private System.Windows.Forms.Button btnReativarMembro;
        private System.Windows.Forms.Button btnVerificarMensalidade;
        private System.Windows.Forms.Button btnAtivarDesativarSPA;
        private System.Windows.Forms.GroupBox gbPropriedadesExtras;
        private System.Windows.Forms.GroupBox gbMetodos;
        private System.Windows.Forms.CheckBox cbGuardiaoDaNoite;
        private System.Windows.Forms.Label lbPropriedadeExtra2;
        private System.Windows.Forms.TextBox txtPropriedadeExtra2;
        private System.Windows.Forms.CheckBox cbPT;
        private System.Windows.Forms.CheckBox cbProblemasCardiacos;
        private System.Windows.Forms.TextBox txtAddDesconto;
        private System.Windows.Forms.Button btnAtribuirDesconto;
        private System.Windows.Forms.ComboBox cbAddPresencas;
        private System.Windows.Forms.Button btnAddCaloriasPorSessao;
        private System.Windows.Forms.Button btnadAddExercicios;
        private System.Windows.Forms.TextBox txtAddExercicios;
        private System.Windows.Forms.TextBox txtAddCaloriasPorSessao;
        private System.Windows.Forms.TextBox txtAddMinutosMeditacao;
        private System.Windows.Forms.Button btnAddMinutosMeditacao;
        private System.Windows.Forms.TextBox txtAddPesoMaximo;
        private System.Windows.Forms.Button btnAddPesoMaximo;
        private System.Windows.Forms.Button btnAtivarDesativarMembro;
        private System.Windows.Forms.TextBox txtAddDuracaoDaAula;
        private System.Windows.Forms.Button btnAddDuracaoDaAula;
        private System.Windows.Forms.Label lbPropriedadeExtra3;
        private System.Windows.Forms.TextBox txtPropriedadeExtra3;
        private System.Windows.Forms.Button btnAtivarDesativarPersonalTrainer;
        private System.Windows.Forms.Button btnAddDiasDesdeDaUltimaPresenca;
        private System.Windows.Forms.ComboBox cbDiasDesdeUltimaPresenca;
    }
}