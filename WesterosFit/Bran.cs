using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesterosFit
{
    public sealed class Bran : Individual
    {
        #region Metodos
        public override bool GuardioesDaNoite()
        {
            return true;
        }

        public override bool VerificarDedicacao()
        {
            if (CaloriasPorSessao < 400)
            {                
                Infracoes++;
                AtualizarEstado();
                return false;
            }
            else
                return base.VerificarDedicacao();
        }
        #endregion

        public Bran(string nome, int idade, bool problemasCardiacos) : base (nome, idade, problemasCardiacos)
        {
            PontosPorPresenca = 3;
            Classe = "Bran";
            ProblemasCardiacos = problemasCardiacos;            
        }
              
    }  
}
