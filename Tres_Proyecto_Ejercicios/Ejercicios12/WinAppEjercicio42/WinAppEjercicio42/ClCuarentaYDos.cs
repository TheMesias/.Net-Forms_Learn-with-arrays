using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppEjercicio42
{
    class ClCuarentaYDos
    {
        int[,] Matriz = new int[10, 10];

        public ClCuarentaYDos(int[,] matriz)
        {
            Matriz = matriz;
        }

        public string BuscarElemento(int num_busqueda,int filas)
        {
            string respuesta = "no";
            for (int f = 0; f < filas; f++)
                for (int j = 0; j < f; j++)
                    if (num_busqueda == Matriz[f, j])
                        respuesta = "si";
            return respuesta;
        }
    }
}
