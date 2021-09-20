using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppEjercicio33
{
    class ClTreintaYTres
    {
        int[,] Matriz = new int[10, 10];

        public ClTreintaYTres(int[,] matriz)
        {
            Matriz = matriz;
        }

        public int numDiagSuperior(int filas)
        {
            int mayor = Matriz[0,0];
            for (int i = 0; i < filas; i++)
            {
                if (Matriz[i, i] > mayor)
                    mayor = Matriz[i, i]; 
            }
            return mayor;
        }
    }
}
