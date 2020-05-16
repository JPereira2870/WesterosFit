using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WesterosFit
{
    public partial class frmConsultarMembro : Form
    {
        public frmConsultarMembro()
        {
            InitializeComponent();
        }
        frmJanelaInicial formInicial;


        private void bttnVoltarInicial_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void frmConsultarMembro_Load(object sender, EventArgs e)
        {
            dgvTabela.DataSource = VariaveisBD.membros;
            dgvTabela.Columns["Nivel"].Visible = false;
            dgvTabela.Columns["Experiencia"].Visible = false;
            dgvTabela.Columns["Presencas"].Visible = false;
            dgvTabela.Columns["NumeroDiasUltimaPresenca"].Visible = false;
            dgvTabela.Columns["Desconto"].Visible = false;
            dgvTabela.Columns["SPA"].Visible = false;
            dgvTabela.Columns["Ativo"].Visible = false;
            dgvTabela.Columns["Infracoes"].Visible = false;
            dgvTabela.Columns["Idade"].ReadOnly = true;
            dgvTabela.Columns["Nome"].ReadOnly = true;
        }

        private void bttnVoltarInicial_Click_1(object sender, EventArgs e)
        {
            if (formInicial == null)
                formInicial = new frmJanelaInicial();

            formInicial.Location = this.Location;
            this.Hide();
            formInicial.Show();
        }

        
    }
}
