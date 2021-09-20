using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppEjercicio3
{
    class ClTres
    {
        int[] Vector = new int[50]; 

        public ClTres(int[] Vect)
        {
            Vector = Vect; 
        }

        public int MenorVector(int tam)
        {
            int menor = Vector[0];
            for (int i = 0; i < tam; i++)
                if (Vector[i] < menor)
                    menor = Vector[i];
            return menor;
        }
    }
}
