using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppEjercicio52
{
    class ClCincuentaYDoscs
    {
        int[,] matri = new int[10, 10];
        int detm=0;

        public ClCincuentaYDoscs(int[,] Matriz)
        {
            this.matri = Matriz; 
        }

        public int CalcularDeterminante()
        {
            detm = (matri[0,0] * matri[1,1] * matri[2,2] + matri[1,0] * matri[2,1] * matri[0,2] +
            matri[2,0] * matri[0,1] * matri[1,2] - (matri[0,2] * matri[1,1] * matri[2,0]) -
           (matri[1,2] * matri[2,1] * matri[0,0]) - (matri[2,2] * matri[1,0] * matri[0,1]));
          
            return detm; 
        }

        public void MatrizAdjunta(int[,] matre)
        {
            matre[0,0] = matri[1,1] * matri[2,2] - matri[2,1] * matri[1,2];
            matre[0,1] = -(matri[1,0] * matri[2,2] - matri[2,0] * matri[1,2]);
            matre[0,2] = matri[1,0] * matri[2,1] - matri[2,0] * matri[1,1];
            matre[1,0] = -(matri[0,1] * matri[2,2] - matri[2,1] * matri[0,2]);
            matre[1,1] = matri[0,0] * matri[2,2] - matri[2,0] * matri[0,2];
            matre[1,2] = -(matri[0,0] * matri[2,1] - matri[2,0] * matri[0,1]);
            matre[2,0] = matri[0,1] * matri[1,2] - matri[1,1] * matri[0,2];
            matre[2,1] = -(matri[0,0] * matri[1,2] - matri[1,0] * matri[0,2]);
            matre[2,2] = matri[0,0] * matri[1,1] - matri[1,0] * matri[0,1];
        }

        public void MatrizInversa(int[,] matre)
        {
            for (int a = 0; a < 3; a++)
            {
                for (int s = 0; s < 3; s++)
                {

                    matre[a,s] = (matre[a,s] / detm);

                }
            }

        }
    }
}
