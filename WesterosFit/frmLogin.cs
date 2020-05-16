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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        frmJanelaInicial formJanelaInicial;

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            string ID = Convert.ToString(txtID.Text);
            string PW = Convert.ToString(txtPW.Text);
            if (ID == "bom" && PW == "natal")
            {
                formJanelaInicial = new frmJanelaInicial();

                formJanelaInicial.Location = this.Location;
                this.Hide();
                formJanelaInicial.Show();
            }
            else
                MessageBox.Show("Dados Incorretos! Tente outra vez.");


        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
