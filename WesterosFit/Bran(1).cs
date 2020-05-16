using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesterosFit
{
    public sealed class Bran : Grupo1
    {
        public bool GuardioesDaNoite()
        {
            return true;
        }

        public override bool VerificarDedicacao()
        {
            if (m_caloriasPorSessao < 400)
            {
                m_infracoes++;
                return false;
            }
            return base.VerificarDedicacao();
        }

        public Bran(string nome, int idade) : base (nome, idade)
        {
            m_experiencia = 3;
        }
              
    }  
}
