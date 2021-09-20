using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppEjercicio28
{
    class ClVeinteYOcho
    {
        int[,] matriz;
        int[,] newMatriz; 
        int[] vector; 
        int filasYcolumnas; 

        public ClVeinteYOcho(int[,] matriz, int filasYcolumnas, int[] vec, int[,] newMatriz)
        {
            this.matriz = matriz;
            this.filasYcolumnas = filasYcolumnas;
            vector = vec;
            this.newMatriz = newMatriz; 
        }

        public void InsertarFila(int[,] newM)
        {
           
            int c = 0;
            for (int i = 0; i < filasYcolumnas + 1; i++)
            {
                for (int j = 0; j < filasYcolumnas; j++)
                {
                    if (i == (filasYcolumnas)) {
                        newM[i, j] = vector[c];
                    }
                    else
                    {
                        newM[i, j] = matriz[i, j]; 
                    }
                    
                }
                
            }
        }
    }
}
