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
    public partial class frmEscolhaDaClass : Form
    {
        public frmEscolhaDaClass()
        {
            InitializeComponent();
        }
        frmJanelaInicial formInicial;
        frmCriarBran formBran;
        frmCriarBrienne formBrienne;
        frmCriarNed formNed;
        frmCriarJaime formJaime;

        private void bttnVoltarInicial_Click(object sender, EventArgs e)
        {
            if (formInicial == null)
                formInicial = new frmJanelaInicial();

            formInicial.Location = this.Location;
            this.Hide();
            formInicial.Show();
        }

        private void bttnBran_Click(object sender, EventArgs e)
        {
            formBran = new frmCriarBran();

            formBran.Location = this.Location;
            this.Hide();
            formBran.Show();
        }

        private void bttnBrienne_Click(object sender, EventArgs e)
        {
            formBrienne = new frmCriarBrienne();

            formBrienne.Location = this.Location;
            this.Hide();
            formBrienne.Show();
        }

        private void bttnNed_Click(object sender, EventArgs e)
        {
            formNed = new frmCriarNed();

            formNed.Location = this.Location;
            this.Hide();
            formNed.Show();
        }

        private void bttnJaime_Click(object sender, EventArgs e)
        {
            formJaime = new frmCriarJaime();

            formJaime.Location = this.Location;
            this.Hide();
            formJaime.Show();
        }

        private void frmEscolhaDaClass_Load(object sender, EventArgs e)
        {

        }
    }
}
