using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesterosFit
{
    public abstract class Grupo : Membro
    {
        #region Campos
        private int m_duracaoDaAula;
        private int m_numeroDeExercicios;
        #endregion

        #region Propriedades
        public int DuracaoDaAula
        {
            get { return m_duracaoDaAula; }
            set
            {
                if (value > 0)
                    m_duracaoDaAula = value;
            }
        }

        public int NumeroDeExercicios
        {
            get { return m_numeroDeExercicios; }
            set
            {
                if (value > 0)
                    m_numeroDeExercicios = value;
            }
        }
        #endregion

        public Grupo(string nome, int idade) : base(nome, idade)
        {
            m_duracaoDaAula = 0;
            m_numeroDeExercicios = 1;
        }

        public Grupo(string nome, int idade,int numeroDeExercicios) : base(nome, idade)
        {
            m_duracaoDaAula = 0;
            m_numeroDeExercicios = numeroDeExercicios;                             
        }
    }
}
