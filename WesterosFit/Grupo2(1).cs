using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesterosFit
{
    public abstract class Grupo2 : Membro
    {
        public int m_duracaoAula;
        public int m_nExercicios;

       
        public int DuracaoAula
        {
            get { return m_duracaoAula; }
            set
            {
                if (value > 0)
                    m_duracaoAula = value;
            }
        }

        public int nExercicios
        {
            get { return m_nExercicios; }
            set
            {
                if (value > 0)
                    m_nExercicios = value;
            }
        }

        public Grupo2(string nome, int idade) : base(nome, idade)
        {
            m_duracaoAula = 0;
            m_nExercicios = 1;
        }

        public Grupo2(string nome, int idade, int nExercicios) : base(nome, idade)
        {
            m_duracaoAula = 0;
            m_nExercicios = nExercicios;
        }
    }
}
