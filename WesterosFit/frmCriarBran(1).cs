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
    public partial class frmCriarBran : Form
    {
        public frmCriarBran()
        {
            InitializeComponent();
        }
        frmEscolhaDaClass formClasses;
        frmJanelaInicial formInicial;




        private void bttnVoltarInicial_Click(object sender, EventArgs e)
        {
            if (formInicial == null)
                formInicial = new frmJanelaInicial();

            formInicial.Location = this.Location;
            this.Hide();
            formInicial.Show();
        }

        private void bttnVoltarClasses_Click(object sender, EventArgs e)
        {
            if (formClasses == null)
                formClasses = new frmEscolhaDaClass();

            formClasses.Location = this.Location;
            this.Hide();
            formClasses.Show();
        }

        private void btnCriarUtilizador_Click(object sender, EventArgs e)
        {         
            if (txtIdadeBran.Text== "" || txtNomeBran.Text == "")
            {
                MessageBox.Show("Tem que preencher os Campos Obrigatórios!");
            }
            else
            {
                string nome = txtNomeBran.Text;
                int idade = Convert.ToInt32(txtIdadeBran.Text);

                VariaveisBD.membros.Add(new Bran(nome, idade));
                MessageBox.Show("Membro Criado!");
            }
            
        }

        private void frmCriarBran_Load(object sender, EventArgs e)
        {

        }
    }
}
