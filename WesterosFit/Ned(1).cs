using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesterosFit
{
    public sealed class Ned : Grupo2
    {
        int m_minutosMeditacao;
        

        public int MinutosMeditacao
        {
            get { return m_minutosMeditacao; }
            set
            {
                if (value > 0)
                    m_minutosMeditacao = value;
            }
        }

        public bool GuardioesDaNoite()
        {
            return false;
        }

        public override bool VerificarDedicacao()
        {
            if (m_minutosMeditacao < 200 || m_nExercicios < 5)
            {
                m_infracoes++; 
                return false;
            }                       

            return base.VerificarDedicacao();
        }


        public Ned(string nome, int idade) : base(nome, idade)
        {
            m_experiencia = 1;
            m_desconto = idade;
        }

        public Ned(string nome, int idade, int nExercicios) : base(nome, idade, nExercicios)
        {
            m_experiencia = 1;
            m_nExercicios = nExercicios;
            m_desconto = idade;
        }
    }
}
