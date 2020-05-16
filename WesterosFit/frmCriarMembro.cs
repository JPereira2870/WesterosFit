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
    public partial class frmCriarMembro : Form
    {
        public frmCriarMembro(string classe) // funciona como qualquer outro construtor // Para Saber qual a classe o utilziador pretende criar
        {
            InitializeComponent();

            if( classe == "Ned" )
            {
                pbNed.Visible = true;
                pbBran.Visible = false;
                pbJaime.Visible = false;
                pbBrienne.Visible = false;
                lblNumeroDeExercicios.Visible = true;
                txtNumeroDeExercicios.Visible = true;
                cbProblemasCardiacos.Visible = false;
                btnCriarNed.Visible = true;
                btnCriarJaime.Visible = false;
                btnCriarBrienne.Visible = false;
                btnCriarBran.Visible = false;
            }
            else if (classe == "Jaime")
            {
                pbNed.Visible = false;
                pbJaime.Visible = true;
                pbBran.Visible = false;
                pbBrienne.Visible = false;
                lblNumeroDeExercicios.Visible = false;
                txtNumeroDeExercicios.Visible = false;
                cbProblemasCardiacos.Visible = true;
                btnCriarNed.Visible = false;
                btnCriarJaime.Visible = true;
                btnCriarBrienne.Visible = false;
                btnCriarBran.Visible = false;
            }
            else if (classe == "Brienne")
            {
                pbNed.Visible = false;
                pbBrienne.Visible = true;
                pbBran.Visible = false;
                pbJaime.Visible = false;
                txtNumeroDeExercicios.Visible = true;
                lblNumeroDeExercicios.Visible = true;
                cbProblemasCardiacos.Visible = false;
                btnCriarNed.Visible = false;
                btnCriarJaime.Visible = false;
                btnCriarBrienne.Visible = true;
                btnCriarBran.Visible = false;
            }
            else //Bran
            {
                pbNed.Visible = false;
                pbBran.Visible = true;
                pbJaime.Visible = false;
                pbBrienne.Visible = false;
                txtNumeroDeExercicios.Visible = false;
                lblNumeroDeExercicios.Visible = false;
                cbProblemasCardiacos.Visible = true;
                btnCriarNed.Visible = false;
                btnCriarJaime.Visible = false;
                btnCriarBrienne.Visible = false;
                btnCriarBran.Visible = true;
            }
        }

        frmEscolhaDaClass formClasses;
        frmJanelaInicial formInicial;


        private void btnCriarNed_Click(object sender, EventArgs e)
        {
            if (!verificarCamposObrigatorios())
            {
                MessageBox.Show("Tem que preencher os Campos Obrigatórios!");
            }
            else
            {
                string nome = txtNome.Text;
                int idade = Convert.ToInt32(txtIdade.Text);

                if (idade > 0)
                {
                    if (txtNumeroDeExercicios.Text == "")
                    {
                        BDMembros.listaDeMembros.Add(new Ned(nome, idade)); // Casting
                        MessageBox.Show("Membro Criado!");
                        LimparCampos();

                    }
                    else
                    {
                        int numeroDeExercicios = Convert.ToInt32(txtNumeroDeExercicios.Text);
                        if (numeroDeExercicios > 0)
                        {
                            BDMembros.listaDeMembros.Add(new Ned(nome, idade, numeroDeExercicios));
                            MessageBox.Show("Membro Criado!");
                            LimparCampos();
                        }
                        else
                            MessageBox.Show("No caso de querer adicionar o nº de exercícios esse valor tem de ser maior que 0!");
                    }
                }
                else
                    MessageBox.Show("Insira uma idade válida!");

            }
        }
            
        
        private void btnCriarJaime_Click(object sender, EventArgs e)
        {
            if (!verificarCamposObrigatorios())
            {
                MessageBox.Show("Tem que preencher os Campos Obrigatórios!");
            }
            else
            {
                string nome = txtNome.Text;
                int idade = Convert.ToInt32(txtIdade.Text);
                bool problemasCardiacos = cbProblemasCardiacos.Checked;

                if (idade > 0)
                {
                    BDMembros.listaDeMembros.Add(new Jaime(nome, idade, problemasCardiacos)); // Casting
                    MessageBox.Show("Membro Criado!");
                    LimparCampos();
                }
                else
                    MessageBox.Show("Insira uma idade válida!");
            }
        }

        private void btnCriarBran_Click(object sender, EventArgs e)
        {
            if (!verificarCamposObrigatorios())
            {
                MessageBox.Show("Tem que preencher os Campos Obrigatórios!");
            }
            else
            {
                string nome = txtNome.Text;
                int idade = Convert.ToInt32(txtIdade.Text);
                bool problemasCardiacos = cbProblemasCardiacos.Checked;

                if (idade > 0)
                {
                    BDMembros.listaDeMembros.Add(new Bran(nome, idade, problemasCardiacos)); //Casting
                    MessageBox.Show("Membro Criado!");
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Insira uma idade válida!");
                }
            }
        }

        private void btnCriarBrienne_Click(object sender, EventArgs e)
        {
            if (!verificarCamposObrigatorios())
            {
                MessageBox.Show("Tem que preencher os Campos Obrigatórios!");
            }
            else
            {
                string nome = txtNome.Text;
                int idade = Convert.ToInt32(txtIdade.Text);
                if (idade > 0)
                {
                    if (txtNumeroDeExercicios.Text == "")
                    {
                        BDMembros.listaDeMembros.Add(new Brienne(nome, idade)); // Casting
                        MessageBox.Show("Membro Criado!");
                        LimparCampos();
                    }
                    else
                    {
                        if (Convert.ToInt32(txtNumeroDeExercicios.Text) > 0)
                        {
                            int nExercicios = Convert.ToInt32(txtNumeroDeExercicios.Text);
                            BDMembros.listaDeMembros.Add(new Brienne(nome, idade, nExercicios));
                            MessageBox.Show("Membro Criado!");
                            LimparCampos();
                        }
                        else
                        {
                            MessageBox.Show("No caso de querer adicionar o nº de exercícios esse valor tem de ser maior que 0!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Insira uma idade válida!");
                }
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtNumeroDeExercicios.Text = "";
            txtIdade.Text = "";
            txtNumeroDeExercicios.Text = "";
            cbProblemasCardiacos.Checked = false;
            lbNomeInvalido.Visible = false;
            lbIdadeInvalida.Visible = false;
        }

        private void frmTeste_Load(object sender, EventArgs e)
        {
            lbNomeInvalido.Visible = false;
            lbIdadeInvalida.Visible = false;
        }

        private void btnVoltarClasses_Click_1(object sender, EventArgs e)
        {
            if (formClasses == null)
                formClasses = new frmEscolhaDaClass();

            formClasses.Location = this.Location;
            this.Hide();
            formClasses.Show();
        }

        private bool verificarCamposObrigatorios()
        {
            if (txtIdade.Text == "" || txtNome.Text == "")
                return false;
            else
                return true;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
                lbNomeInvalido.Visible = true;
            else
                lbNomeInvalido.Visible = false;            
        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {
            if (txtIdade.Text == "")
                lbIdadeInvalida.Visible = true;            
            else
                lbIdadeInvalida.Visible = false;
            
        }

        private void btnVoltarInicial_Click(object sender, EventArgs e)
        {
            if (formInicial == null)
                formInicial = new frmJanelaInicial();

            formInicial.Location = this.Location;
            this.Hide();
            formInicial.Show();
        }
    }
}
