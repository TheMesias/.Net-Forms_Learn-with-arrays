using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppEjercicio38
{
    class ClTreintaYtres
    {
        int[,] Matriz = new int[11, 11];

        public ClTreintaYtres(int[,] mz)
        {
            Matriz = mz;
        }


        public int MayorDiagSuperior(int fcs)
        {
            int mayor = Matriz[0,0];
            for (int f = 0; f < fcs - 1; f++)
                for (int j = f + 1; j < fcs; j++)
                    if (Matriz[f, j] > mayor)
                        mayor = Matriz[f, j];
            return mayor; 

        }
    }
}
