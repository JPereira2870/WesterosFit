using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesterosFit
{
    public sealed class Jaime : Individual
    {
        #region Campos
        private double m_pesoMaximo;
        private bool m_personalTrainer;
        #endregion

        #region Propriedades
        public double PesoMaximo
        {
            get { return m_pesoMaximo; }
            set
            {
                if (value > 0)
                    m_pesoMaximo = value;
            }
        }

        public bool PersonalTrainer
        {
            get { return m_personalTrainer; }
        }
        #endregion

        #region Metodos
        public override bool GuardioesDaNoite()
        {
            if (Nivel >= 5 && m_pesoMaximo > 100)
                return true;
            else
                return false;
        }

        public void AtivarDesativarPersonalTrainer()
        {
            if (PersonalTrainer)
                m_personalTrainer = false;
            else
                m_personalTrainer = true;
        }
        #endregion

        public Jaime(string nome, int idade,bool problemasCardiacos) : base(nome, idade, problemasCardiacos)
        {
            PontosPorPresenca = 5;
            m_personalTrainer = true;
            m_pesoMaximo = 0;
            Classe = "Jaime";
        }
           
    }
}
