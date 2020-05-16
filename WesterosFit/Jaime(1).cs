using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesterosFit
{
    public sealed class Jaime : Grupo1
    {
        
        double m_pesoMaximo;
        bool m_PT;
                       
        public double PesoMaximo
        {
            get { return m_pesoMaximo; }
            set
            {
                if (value > m_pesoMaximo && value > 0)
                    m_pesoMaximo = value;
            }
        }

        public bool PT
        {
            get { return m_PT; }
            set { m_PT = value; }
        }

        public bool GuardioesDaNoite()
        {
            return false;
        }

        public Jaime(string nome, int idade) : base(nome, idade)
        {
            m_PT = true;
            m_experiencia = 5;
            m_pesoMaximo = 0;
        }
           
    }
}
