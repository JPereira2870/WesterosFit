using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesterosFit
{
    static class BDMembros
    {
        public static List<Membro> listaDeMembros = new List<Membro>();

        public static Membro obterMembroPorID(int id)
        {
            List<Membro>.Enumerator enumerator = listaDeMembros.GetEnumerator(); //como se fosse um for nos array para percorrer e encontrar o indice selecionado

            while (enumerator.MoveNext())
            {
                if (enumerator.Current.ID == id)   
                {
                    return enumerator.Current;
                }
            }

            return null;
        }
    }
}
