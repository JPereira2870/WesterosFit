using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesterosFit
{
    public sealed class Brienne : Grupo2
    {                
        public bool GuardioesDaNoite()
        {
            return false;
        }

        public Brienne(string nome, int idade) : base(nome, idade)
        {
            m_experiencia = 2;            
        }

        public Brienne(string nome, int idade, int nExercicios) : base(nome, idade,nExercicios)
        {
            m_experiencia = 2;
            m_nExercicios = nExercicios;
        }

    }
}
