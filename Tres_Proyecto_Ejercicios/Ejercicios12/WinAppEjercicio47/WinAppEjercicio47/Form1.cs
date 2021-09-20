using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicio47
{
    public partial class FormCuarentaYSiete : Form
    {
        int filasYcolumnas, busqueda;
        int f = 0;
        int c = 0;
        int[,] arreglo = new int[10, 10];
        public FormCuarentaYSiete()
        {
            InitializeComponent();
        }

        private void txt_LlenadoMatriz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                if (Convert.ToInt32(txt_LlenadoMatriz.Text) == 1 || Convert.ToInt32(txt_LlenadoMatriz.Text) == 0) { 
                arreglo[f, c] = Convert.ToInt32(txt_LlenadoMatriz.Text);
                txt_LlenadoMatriz.Clear();
                c++;
                if (c == filasYcolumnas)
                {
                    f++;
                    c = 0;
                }
                if (f == filasYcolumnas)
                {
                    txt_LlenadoMatriz.Enabled = false;
                    dataGredMatriz.ColumnCount = filasYcolumnas;
                    dataGredMatriz.RowCount = filasYcolumnas;


                    for (int i = 0; i < filasYcolumnas; i++)
                    {
                        for (int j = 0; j < filasYcolumnas; j++)
                        {
                            dataGredMatriz.Rows[i].Cells[j].Value = arreglo[i, j];
                        }

                    }
                        Proceso(); 

                }
                }
                else
                {
                    MessageBox.Show("Solo puede ingresar numeros 1 o 0"); 
                }
            }
        }

        private void txt_NumFilasMatriz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                try
                {
                    if (Convert.ToInt32(txt_NumFilasMatriz.Text) > 0 && Convert.ToInt32(txt_NumFilasMatriz.Text) <= 10)
                    {
                        filasYcolumnas = Convert.ToInt32(txt_NumFilasMatriz.Text);
                        txt_NumFilasMatriz.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Los numeros no pueden ser menores o iguales a 0 ni mayores que 10!");
                    }

                }
                catch
                {
                    MessageBox.Show("Verifique si el caracter ingresado es un numero");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void Proceso()
        {
            ClCuarentaYSiete Obj47 = new ClCuarentaYSiete(arreglo);
            lbl_respuesta.Text = Obj47.ProcesoUnidad(filasYcolumnas); 
        }
    }
}
