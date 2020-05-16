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
        frmConsultarEditarMembro formConsulta;
        

        private void bttnAdicionarMembro_Click(object sender, EventArgs e)
        {
            if (formClasses == null)
                formClasses = new frmEscolhaDaClass();

            formClasses.Location = this.Location;
            this.Hide();
            formClasses.Show();
        }

        private void bttnConsultarEditarMembro_Click(object sender, EventArgs e)
        {
            if(BDMembros.listaDeMembros.Count == 0)
            {
                MessageBox.Show("Para utilizar esta funcionalidade, é necessário a existência de pelo menos um membro!");
                btnConsultareEditarMembro.Enabled = false;
            }
            else
            {
                if (formConsulta == null)
                    formConsulta = new frmConsultarEditarMembro();

                formConsulta.Location = this.Location;
                this.Hide();
                formConsulta.Show();
            }            
        }
    }
}
