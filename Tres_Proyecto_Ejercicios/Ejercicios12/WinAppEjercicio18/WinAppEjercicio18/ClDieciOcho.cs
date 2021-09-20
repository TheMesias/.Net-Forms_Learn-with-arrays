using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppEjercicio18
{
    class ClDieciOcho
    {
        int[,] matriz = new int[10, 10];
        int fila, colu, pos;
        int[] vec = new int[20];
        int[,] matriNuev = new int[10, 10];

        public ClDieciOcho(int[,] matriz, int filas, int columnas, int posicion, int[] vector, int[,] NewMatriz)
        {
            this.matriz = matriz;
            this.fila = filas;
            this.colu = columnas;
            this.pos = posicion;
            this.vec = vector;
            this.matriNuev = NewMatriz;
        }

        public void ProcesoAumentarColumna(int[,] NewMatriz)
        {
            int aux = 0;

            int c = 0; //contador

            for (int i = 0; i < fila ; i++)
            {
                for (int j = 0; j < colu + 1; j++)
                {
                    if (j == pos)
                    {
                        matriNuev[i, j] = vec[c];
                        c++;
                        aux = j - 1;
                    }
                    else
                    {

                        NewMatriz[i, j] = matriz[aux, j];
                    }


                }

                aux++;
            }
        }
        
    }
}
