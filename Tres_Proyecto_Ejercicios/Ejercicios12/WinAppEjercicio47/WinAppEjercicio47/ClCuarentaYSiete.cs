using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppEjercicio47
{
    class ClCuarentaYSiete
    {
        int[,] Matriz = new int[10, 10]; 

        public ClCuarentaYSiete(int[,] Mat)
        {
            Matriz = Mat; 
        }

        public string ProcesoUnidad(int filas)
        {
            int numero = 0;
            for (int i = 0; i < filas; i++)
                numero += Matriz[i, i];

            if (numero == filas)
                return "SI";
            else
                return "NO";          
        }
    }
}
