using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesterosFit
{
    public sealed class Ned : Grupo
    {
        #region Campos
        private int m_minutosMeditacao;
        #endregion

        #region Propriedades
        public int MinutosMeditacao
        {
            get { return m_minutosMeditacao; }
            set
            {
                if (value > 0)
                    m_minutosMeditacao = value;
            }
        }
        #endregion

        #region Metodos
        public override bool GuardioesDaNoite()
        {
            return false;
        }

        public override double MensalidadeEfetiva()
        {
            double mensalidadeNed, percentagemDesconto;

            percentagemDesconto = 1 - Convert.ToDouble(Idade) / 100;

            mensalidadeNed = base.MensalidadeEfetiva() * percentagemDesconto;

            return mensalidadeNed;
        }       

        public override bool VerificarDedicacao()
        {
            if (m_minutosMeditacao < 200 || NumeroDeExercicios < 5)
            {
                Infracoes++;
                AtualizarEstado();
                return false;
            }
            else 
                return base.VerificarDedicacao();
        }
        #endregion


        public Ned(string nome, int idade) : base(nome, idade)
        {
            PontosPorPresenca = 1;
            Classe = "Ned";
        }

        public Ned(string nome, int idade,int numeroExercicios) : base(nome, idade,numeroExercicios)
        {
            PontosPorPresenca = 1;
            Classe = "Ned";
            NumeroDeExercicios = numeroExercicios;
        }
    }
}
