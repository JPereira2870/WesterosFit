using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesterosFit
{
    public abstract class Grupo1 : Membro
    {
        public int m_caloriasPorSessao;
        public bool m_problemasCardiacos;

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
            set { m_problemasCardiacos = value; }
        }

        public Grupo1(string nome, int idade) : base (nome, idade)
        {
            m_caloriasPorSessao = 200;
            m_problemasCardiacos = false;
        }
    }
}
