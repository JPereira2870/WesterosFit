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
    public partial class frmCriarNed : Form
    {
        public frmCriarNed()
        {
            InitializeComponent();
        }
        frmEscolhaDaClass formClasses;
        frmJanelaInicial formInicial;

        private void frmCriarNed_Load(object sender, EventArgs e)
        {

        }

        private void pbBrienne_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarUtilizador_Click(object sender, EventArgs e)
        {
            

            if (txtIdadeNed.Text == "" || txtNomeNed.Text == "")
            {
                MessageBox.Show("Tem que preencher os Campos Obrigatórios!");
            }
            else
            {
                string nome = txtNomeNed.Text;
                int idade = Convert.ToInt32(txtIdadeNed.Text);

                if (txtNExerciciosNed.Text == "")
                {
                    VariaveisBD.membros.Add(new Ned(nome, idade));
                    MessageBox.Show("Membro Criado!");
                }
                else
                {
                    int nExercicios = Convert.ToInt32(txtNExerciciosNed.Text);
                    VariaveisBD.membros.Add(new Ned(nome, idade, nExercicios));
                    MessageBox.Show("Membro Criado!");
                }
            }          
        }

        private void bttnVoltarClasses_Click(object sender, EventArgs e)
        {
            if (formClasses == null)
                formClasses = new frmEscolhaDaClass();

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
    }
}
