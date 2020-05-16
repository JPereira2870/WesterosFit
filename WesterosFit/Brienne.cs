using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesterosFit
{
    public sealed class Brienne : Grupo
    {
        #region Metodos
        public override bool GuardioesDaNoite()
        {
            if (Nivel >= 3) 
                return true;
            else
                return false;
        }
        #endregion

        public Brienne(string nome, int idade) : base(nome, idade)
        {
            Classe = "Brienne";
            PontosPorPresenca = 2;
        }

        public Brienne(string nome, int idade,int numeroDeExercicios) : base(nome, idade, numeroDeExercicios)
        {
            PontosPorPresenca = 2;
            NumeroDeExercicios = numeroDeExercicios;
            Classe = "Brienne";
        }

    }
}
