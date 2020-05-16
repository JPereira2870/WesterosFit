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
    public partial class frmConsultarEditarMembro : Form
    {
        

        public frmConsultarEditarMembro()
        {
            InitializeComponent();
        }
        frmJanelaInicial formInicial;
        frmEscolhaDaClass formClasses;

        private void frmConsultarEditarMembro_Load(object sender, EventArgs e)
        {
            dgvMembro.DataSource = BDMembros.listaDeMembros;
            AlterarForm();            
        }

        private Membro membroSelecionado() // Identifica o membro selecionado na tabela
        {
            string id = dgvMembro.Rows[dgvMembro.CurrentCell.RowIndex].Cells[0].Value.ToString();
            Membro membroSelecionado = BDMembros.obterMembroPorID(Convert.ToInt32(id));

            return membroSelecionado;
        }



        private void btnVoltarInicial_Click_1(object sender, EventArgs e)
        {
            if (formInicial == null)
                formInicial = new frmJanelaInicial();

            formInicial.Location = this.Location;
            this.Hide();
            formInicial.Show();
        }

        private void btnVoltarClasses_Click(object sender, EventArgs e)
        {
            if (formClasses == null)
                formClasses = new frmEscolhaDaClass();

            formClasses.Location = this.Location;
            this.Hide();
            formClasses.Show();
        }

        private void dgvMembro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AlterarForm();
        }

        private void btnVerificarDedicação_Click(object sender, EventArgs e)
        {
            if (membroSelecionado().VerificarDedicacao())
                MessageBox.Show("O Membro FOI dedicado nos ultimos 30 dias!");
            else
                MessageBox.Show("O Membro NÃO FOI dedicado nos ultimos 30 dias!");

            AlterarForm();
        }

        private void btnAddPresencas_Click(object sender, EventArgs e)
        {
            if (membroSelecionado().Ativo)
            {
                if (cbAddPresencas.Text == "1")
                {
                    membroSelecionado().MarcarPresencas();
                    MessageBox.Show("Presença adicionada com sucesso!");
                }
                else
                {
                    int presencas = Convert.ToInt32(cbAddPresencas.Text);

                    if (presencas > 0)
                    {
                        membroSelecionado().MarcarPresencas(presencas);
                        MessageBox.Show( presencas + "presenças adicionadas com sucesso!");
                    }
                    else
                        MessageBox.Show("Insira um nº de presenças a adicionar válido!");
                }
            }
            else
                MessageBox.Show("Para adicionar dados referentes aos ultimos 30 dias é necessário que o membro esteja ATIVO!");
            
            cbAddPresencas.Text = "1";
            AlterarForm(); 
        }

        private void btnReativarMembro_Click(object sender, EventArgs e)
        {
            if (membroSelecionado().Ativo == false)
            {
                if (membroSelecionado().ReativarMembro())
                    MessageBox.Show("Membro Reativado com Sucesso!");
                else
                    MessageBox.Show("O membro ainda não cumpriu a sua punição por completo");
            }
            else
                MessageBox.Show("O membro já se encontra ativo!");

            AtualizarForm();
        }

        private void btnVerificarMensalidade_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A mensalidade deste membro é de " + Convert.ToString(membroSelecionado().MensalidadeEfetiva()) + "€");
            AtualizarForm();
        }

        private void btnAdicionarRemoverSPA_Click(object sender, EventArgs e)
        {
            membroSelecionado().AtivarDesativarSPA();

            if (membroSelecionado().SPA)
            {
                MessageBox.Show("SPA ativado com Sucesso!");
            }
            else
            {
                MessageBox.Show("SPA desativado com Sucesso!");
            } 

            AlterarForm();
        }

        private void btnAtribuirDesconto_Click(object sender, EventArgs e)
        {
            if (membroSelecionado().Ativo)
            {
                if (txtAddDesconto.Text != "")
                {
                    double desconto = Convert.ToDouble(txtAddDesconto.Text);
                    if (desconto > 0)
                    {
                        if (desconto <= membroSelecionado().MensalidadeEfetiva())
                        {
                            membroSelecionado().Desconto = desconto;
                            MessageBox.Show("Descontro atribuido! Para verificar o novo valor da mensalidade, utilize o botão [Calcular Mensalidade]");
                        }
                        else
                            MessageBox.Show("Insira um valor de desconto inferior à Mensalidade!");                      
                    }
                    else
                        MessageBox.Show("Insira um valor de desconto válido!");
                }
                else
                    MessageBox.Show("Para atribuir um desconto é necessário indicar o seu valor!");
            }            
            else
                MessageBox.Show("Para adicionar dados referentes aos ultimos 30 dias é necessário que o membro esteja ATIVO!");

            AlterarForm();
            txtAddDesconto.Text = "";
        }


        private void btnAddExercicios_Click(object sender, EventArgs e)
        {
            if (membroSelecionado().Ativo)
            {
                if (txtAddExercicios.Text != "")
                {
                    int nExercicos = Convert.ToInt32(txtAddExercicios.Text);
                    if (nExercicos > 0)
                    {
                        ((Grupo)membroSelecionado()).NumeroDeExercicios = nExercicos;
                        MessageBox.Show("Nº de exercícios adicionado!");
                    }
                    else
                        MessageBox.Show("Insira um valor para o nº de exercícios a adicionar válido!");

                }
                else
                    MessageBox.Show("Para adicionar um nº de exercícios é necessário indicar esse valor!");
            }
            else
                MessageBox.Show("Para adicionar dados referentes aos ultimos 30 dias é necessário que o membro esteja ATIVO!");

            AlterarForm();
            txtAddExercicios.Text = "";


        }

        private void btnAddCaloriasPorSessao_Click(object sender, EventArgs e)
        {
            if (membroSelecionado().Ativo)
            {
                if (txtAddCaloriasPorSessao.Text != "")
                {
                    int caloriasPorSessao = Convert.ToInt32(txtAddCaloriasPorSessao.Text);
                    if (caloriasPorSessao > 0)
                    {
                        ((Individual)membroSelecionado()).CaloriasPorSessao = caloriasPorSessao;
                        MessageBox.Show("Calorias por sessão adicionadas!");
                    }
                    else
                        MessageBox.Show("Insira um valor para o nº de calorias por sessão a adicionar válido!");

                }
                else
                    MessageBox.Show("Para adicionar um nº de calorias por sessão é necessário indicar esse valor!");
            }
            else
                MessageBox.Show("Para adicionar dados referentes aos ultimos 30 dias é necessário que o membro esteja ATIVO!");


            AlterarForm();
            txtAddCaloriasPorSessao.Text = "";
        }

        private void btnAddMinutosMeditacao_Click(object sender, EventArgs e)
        {
            if (membroSelecionado().Ativo)
            {
                if (txtAddMinutosMeditacao.Text != "")
                {
                    int minutosMeditacao = Convert.ToInt32(txtAddMinutosMeditacao.Text);

                    if (minutosMeditacao > 0)
                    {
                        ((Ned)membroSelecionado()).MinutosMeditacao = minutosMeditacao + Convert.ToInt32(txtPropriedadeExtra1.Text);
                        MessageBox.Show("Minutos de meditação adicionados!");
                    }
                    else
                        MessageBox.Show("Insira um valor para o nº de minutos de meditação a adicionar válido!");

                }
                else
                    MessageBox.Show("Para adicionar um nº de minutos de meditação é necessário indicar esse valor!");
            }
            else
                MessageBox.Show("Para adicionar dados referentes aos ultimos 30 dias é necessário que o membro esteja ATIVO!");


            AlterarForm();
            txtAddMinutosMeditacao.Text = "";
        }

        private void btnAddPesoMaximo_Click(object sender, EventArgs e)
        {
            if (membroSelecionado().Ativo)
            {
                if (txtAddPesoMaximo.Text != "")
                {
                    double pesoMaximo = Convert.ToDouble(txtAddPesoMaximo.Text);

                    if (pesoMaximo > 0)
                    {                        
                        ((Jaime)membroSelecionado()).PesoMaximo = pesoMaximo;
                        MessageBox.Show("Peso máximo adicionado!");   
                    }
                    else
                        MessageBox.Show("Insira um valor para o peso máximo a adicionar válido!");

                }
                else
                    MessageBox.Show("Para adicionar um peso máximo é necessário indicar esse valor!");
            }
            else
                MessageBox.Show("Para adicionar dados referentes aos ultimos 30 dias é necessário que o membro esteja ATIVO!");


            AlterarForm();
            txtAddPesoMaximo.Text = "";
        }

        private void AtualizarForm()
        {
            dgvMembro.Update();
            dgvMembro.Refresh();
            cbGuardiaoDaNoite.Update();
            cbGuardiaoDaNoite.Refresh();
            cbProblemasCardiacos.Update();
            cbProblemasCardiacos.Refresh();
            cbPT.Update();
            cbPT.Refresh();
            txtPropriedadeExtra1.Update();
            txtPropriedadeExtra1.Refresh();
            txtPropriedadeExtra2.Update();
            txtPropriedadeExtra2.Refresh();
            txtPropriedadeExtra3.Update();
            txtPropriedadeExtra3.Refresh();
            btnAtivarDesativarMembro.Update();
            btnAtivarDesativarMembro.Refresh();
            btnAtivarDesativarSPA.Update();
            btnAtivarDesativarSPA.Refresh();
            btnAtivarDesativarPersonalTrainer.Update();
            btnAtivarDesativarPersonalTrainer.Refresh();

        }

        private void AlterarForm() // consoante a classe do membro altera a interface do form
        {
            if (membroSelecionado() is Grupo)
            {
                lbPropriedadeExtra2.Visible = true;
                txtPropriedadeExtra2.Visible = true;
                lbPropriedadeExtra3.Visible = true;
                txtPropriedadeExtra3.Visible = true;
                cbProblemasCardiacos.Visible = false;
                txtAddExercicios.Visible = true;
                btnadAddExercicios.Visible = true;
                txtAddCaloriasPorSessao.Visible = false;
                btnAddCaloriasPorSessao.Visible = false;
                txtAddPesoMaximo.Visible = false;
                btnAddPesoMaximo.Visible = false;
                btnAtivarDesativarPersonalTrainer.Visible = false;
                cbPT.Visible = false;
                txtAddDuracaoDaAula.Visible = true;
                btnAddDuracaoDaAula.Visible = true;
                cbAddPresencas.Text = "1"; // para que apareça um por default na combobox das presenças
                cbDiasDesdeUltimaPresenca.Text = "1";
                lbPropriedadeExtra3.Text = "Duração da Aula:";
                txtPropriedadeExtra3.Text = ((Grupo)membroSelecionado()).DuracaoDaAula.ToString();
                lbPropriedadeExtra2.Text = "Número de Exercicios:";
                txtPropriedadeExtra2.Text = ((Grupo)membroSelecionado()).NumeroDeExercicios.ToString();

                if (membroSelecionado() is Ned)
                {
                    lblPropriedadeExtra1.Visible = true;
                    txtPropriedadeExtra1.Visible = true;
                    txtAddMinutosMeditacao.Visible = true;
                    btnAddMinutosMeditacao.Visible = true;
                    lblPropriedadeExtra1.Text = "Minutos de Meditação:";
                    txtPropriedadeExtra1.Text = ((Ned)membroSelecionado()).MinutosMeditacao.ToString();
                    cbGuardiaoDaNoite.Checked = ((Ned)membroSelecionado()).GuardioesDaNoite();
                }
                else if (membroSelecionado() is Brienne)
                {
                    lblPropriedadeExtra1.Visible = false;
                    txtPropriedadeExtra1.Visible = false;
                    txtAddMinutosMeditacao.Visible = false;
                    btnAddMinutosMeditacao.Visible = false;
                    cbGuardiaoDaNoite.Checked = ((Brienne)membroSelecionado()).GuardioesDaNoite();
                }
            }
            else if (membroSelecionado() is Individual)
            {
                lblPropriedadeExtra1.Visible = true;
                txtPropriedadeExtra1.Visible = true;
                lbPropriedadeExtra3.Visible = false;
                txtPropriedadeExtra3.Visible = false;
                cbProblemasCardiacos.Visible = true;
                txtAddExercicios.Visible = false;
                btnadAddExercicios.Visible = false;
                txtAddMinutosMeditacao.Visible = false;
                btnAddMinutosMeditacao.Visible = false;
                txtAddCaloriasPorSessao.Visible = true;
                btnAddCaloriasPorSessao.Visible = true;
                txtAddDuracaoDaAula.Visible = false;
                btnAddDuracaoDaAula.Visible = false;
                lblPropriedadeExtra1.Text = "Calorias Por Sessão:";
                txtPropriedadeExtra1.Text = ((Individual)membroSelecionado()).CaloriasPorSessao.ToString();
                cbProblemasCardiacos.Checked = ((Individual)membroSelecionado()).ProblemasCardiacos;

                if (membroSelecionado() is Bran)
                {
                    lbPropriedadeExtra2.Visible = false;
                    txtPropriedadeExtra2.Visible = false;
                    txtAddPesoMaximo.Visible = false;
                    btnAddPesoMaximo.Visible = false;
                    cbPT.Visible = false;
                    btnAtivarDesativarPersonalTrainer.Visible = false;
                    cbGuardiaoDaNoite.Checked = ((Bran)membroSelecionado()).GuardioesDaNoite();
                    
                }
                else if (membroSelecionado() is Jaime)
                {
                    txtAddPesoMaximo.Visible = true;
                    btnAddPesoMaximo.Visible = true;
                    btnAtivarDesativarPersonalTrainer.Visible = true;
                    cbPT.Visible = true;
                    lbPropriedadeExtra2.Visible = true;
                    txtPropriedadeExtra2.Visible = true;
                    lbPropriedadeExtra2.Text = "Peso Máximo:";
                    txtPropriedadeExtra2.Text = ((Jaime)membroSelecionado()).PesoMaximo.ToString();
                    cbGuardiaoDaNoite.Checked = ((Jaime)membroSelecionado()).GuardioesDaNoite();
                    cbPT.Checked = ((Jaime)membroSelecionado()).PersonalTrainer;
                }
            }

            if(membroSelecionado() is Jaime)
            {
                if (((Jaime)membroSelecionado()).PersonalTrainer)
                    btnAtivarDesativarPersonalTrainer.Text = "Desativar Personal Trainer";
                else
                    btnAtivarDesativarPersonalTrainer.Text = "Ativar Personal Trainer";
            }

            if (membroSelecionado().Ativo)
                btnAtivarDesativarMembro.Text = "Desativar Membro";
            else
                btnAtivarDesativarMembro.Text = "Ativar Membro";

            if (membroSelecionado().SPA)
                btnAtivarDesativarSPA.Text = "Desativar SPA";
            else
                btnAtivarDesativarSPA.Text = "Ativar SPA";

            AtualizarForm();
        }

        private void btnAtivarDesativarMembro_Click(object sender, EventArgs e)
        {
            membroSelecionado().AtivarDesativarMembro();
            
            if (membroSelecionado().Ativo)
            {
                MessageBox.Show("Membro ativado com sucesso!");
            }
            else
            {
                MessageBox.Show("Membro desativado com sucesso!");
            }

            AlterarForm();
        }

        private void dgvMembro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddDuracaoDaAula_Click(object sender, EventArgs e)
        {
            if (membroSelecionado().Ativo)
            {
                if (txtAddDuracaoDaAula.Text != "")
                {
                    int duracaoDaAula = Convert.ToInt32(txtAddDuracaoDaAula.Text);

                    if (duracaoDaAula > 0)
                    {
                        ((Grupo)membroSelecionado()).DuracaoDaAula = duracaoDaAula;
                        MessageBox.Show("Duração da Aula adicionada!");
                    }
                    else
                        MessageBox.Show("Insira um duração a adicionar válido!");
                }
                else
                    MessageBox.Show("Para adicionar a duração da aula é necessário indicar esse valor!");
            }
            else
                MessageBox.Show("Para adicionar dados referentes aos ultimos 30 dias é necessário que o membro esteja ATIVO!");

            AlterarForm();
            txtAddDuracaoDaAula.Text = "";
        }

        private void btnAtivarDesativarPersonalTrainer_Click(object sender, EventArgs e)
        {
            ((Jaime)membroSelecionado()).AtivarDesativarPersonalTrainer();

            if (((Jaime)membroSelecionado()).PersonalTrainer)
                MessageBox.Show("Personal Trainer ativado com sucesso!");
            else
                MessageBox.Show("Personal Trainer desativado com sucesso!");

            AlterarForm();
        }

        private void cbProblemasCardiacos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAddDiasDesdeDaUltimaPresenca_Click(object sender, EventArgs e)
        {
            int numeroDeDiasDesdeDaUltimaPresenca = Convert.ToInt32(cbDiasDesdeUltimaPresenca.Text);

            if (numeroDeDiasDesdeDaUltimaPresenca > 0)
            {
                  membroSelecionado().MarcarDiasQueNaoFoiAoGinasio(numeroDeDiasDesdeDaUltimaPresenca);
                  MessageBox.Show(numeroDeDiasDesdeDaUltimaPresenca + " Dias Desde Da Última Presença adicionadas com sucesso!");
            }
            else
                  MessageBox.Show("Insira um Numero de Dias a adicionar válido!");
            
            AlterarForm();
        }
    }
}
