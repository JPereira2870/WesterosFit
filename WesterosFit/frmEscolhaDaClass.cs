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
        frmCriarMembro formCriarMembro;

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
            formCriarMembro = new frmCriarMembro("Bran");

            formCriarMembro.Location = this.Location;
            this.Hide();
            formCriarMembro.Show();
        }

        private void bttnBrienne_Click(object sender, EventArgs e)
        {
            formCriarMembro = new frmCriarMembro("Brienne");

            formCriarMembro.Location = this.Location;
            this.Hide();
            formCriarMembro.Show();
        }

        private void bttnNed_Click(object sender, EventArgs e)
        {
            formCriarMembro = new frmCriarMembro("Ned");

            formCriarMembro.Location = this.Location;
            this.Hide();
            formCriarMembro.Show();
        }

        private void bttnJaime_Click(object sender, EventArgs e)
        {
            formCriarMembro = new frmCriarMembro("Jaime");

            formCriarMembro.Location = this.Location;
            this.Hide();
            formCriarMembro.Show();
        }
    }
}
