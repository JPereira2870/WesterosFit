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
    public partial class frmCriarBrienne : Form
    {
        public frmCriarBrienne()
        {
            InitializeComponent();
        }
        frmEscolhaDaClass formClasses;
        frmJanelaInicial formInicial;


        private void bttnVoltarClasses_Click(object sender, EventArgs e)
        {
            if (formClasses == null)
                formClasses= new frmEscolhaDaClass();

            formClasses.Location = this.Location;
            this.Hide();
            formClasses.Show();
        }

        private void bttnVoltarInicial_Click(object sender, EventArgs e)
        {
            if (formInicial == null)
                formInicial = new frmJanelaInicial();

            formInicial.Location = this.Location;
            this.Hide();
            formInicial.Show();
        }

        private void btnCriarUtilizador_Click(object sender, EventArgs e)
        {         
            if (txtIdadeBrienne.Text == "" || txtNomeBrienne.Text == "")
            {
                MessageBox.Show("Tem que preencher os Campos Obrigatórios!");
            }
            else
            {
                string nome = txtNomeBrienne.Text;
                int idade = Convert.ToInt32(txtIdadeBrienne.Text);
                

                if (txtNExerciciosBrienne.Text == "")
                {
                    VariaveisBD.membros.Add(new Brienne(nome, idade));
                    MessageBox.Show("Membro Criado!");
                }
                else
                {
                    int nExercicios = Convert.ToInt32(txtNExerciciosBrienne.Text);
                    Membro NovoMembro = new Brienne(nome, idade, nExercicios);
                    MessageBox.Show("Membro Criado!");
                }
            }               
        }
    }
}
