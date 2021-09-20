using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppEjercicio23
{
    class ClVeinteYTres
    {
        int[,] Matriz = new int[11, 11];

        public ClVeinteYTres(int[,] mz)
        {
            Matriz = mz;
        }

        public int menorMatriz(int fc)
        {
            int menor = Matriz[0, 0];

            for (int f = 0; f < fc; f++)
                for (int c = 0; c < fc; c++)
                    if (menor > Matriz[f, c])
                        menor = Matriz[f, c];
            return menor;
        }
    }
}
