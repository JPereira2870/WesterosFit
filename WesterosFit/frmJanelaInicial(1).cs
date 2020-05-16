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
    public partial class frmJanelaInicial : Form
    {
        public frmJanelaInicial()
        {
            InitializeComponent();
        }
        frmEscolhaDaClass formClasses;
        frmConsultarMembro formConsulta;
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (formClasses == null)
                formClasses = new frmEscolhaDaClass();

            formClasses.Location = this.Location;
            this.Hide();
            formClasses.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bttnConsultarMembro_Click(object sender, EventArgs e)
        {
            if (formConsulta == null)
                formConsulta = new frmConsultarMembro();

            formConsulta.Location = this.Location;
            this.Hide();
            formConsulta.Show();
        }
    }
}
