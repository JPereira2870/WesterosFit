using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesterosFit
{
    public abstract class Individual : Membro
    {
        #region Campos
        private int m_caloriasPorSessao;
        private bool m_problemasCardiacos;
        #endregion

        #region Propriedades
        public int CaloriasPorSessao
        {
            get { return m_caloriasPorSessao; }
            set
            {
                if (value > 0)
                    m_caloriasPorSessao = value;
            }

        }
        public bool ProblemasCardiacos
        {
            get { return m_problemasCardiacos; }
            set { m_problemasCardiacos = value; } // Para utilizar na classe Bran
        }
        #endregion

        public Individual(string nome, int idade, bool problemasCardiacos) : base (nome, idade)
        {
            m_caloriasPorSessao = 200;
            m_problemasCardiacos = problemasCardiacos;
        }
    }
}
