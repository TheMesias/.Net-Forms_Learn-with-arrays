using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WinAppEjercicio57
{
    class ClCincuentaySiete
    {
        int[,] matriz; 

        public ClCincuentaySiete(int[,] matriz)
        {
            this.matriz = matriz; 
        }

        public void llenadoMatriz(int[,] m2, int filas)
        {
            for(int i=0; i < filas; i++)
            {
                m2[i, i] = 1; 
            } 
        }

        public void ProcesoIdentidad(int filas,int[,] mat)
        {
            for(int i=0; i < filas; i++)
            {
                for(int j = 0; j < filas; j++)
                {
                    if(i == j)
                    {
                        mat[i, j] = mat[i, j] / mat[i, j];
                    }
                    else
                    {
                        mat[i, j] *= 0; 
                    }
                } 
            }
        }
    }
}
