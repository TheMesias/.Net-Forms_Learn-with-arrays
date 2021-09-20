using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicio13
{
    public partial class FormTrece : Form
    {
        int filas, columnas, may;
        int f = 0;
        int c = 0;
        int[,] arreglo = new int[10, 10];

        private void txt_NumColumnasMatriz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                try
                {
                    if (Convert.ToInt32(txt_NumColumnasMatriz.Text) > 0)
                    {
                        if (Convert.ToInt32(txt_NumColumnasMatriz.Text) != Convert.ToInt32(txt_NumFilasMatriz.Text))
                        {
                            columnas = Convert.ToInt32(txt_NumColumnasMatriz.Text);
                            txt_NumColumnasMatriz.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Las columnas no tienen que ser igual a las filas");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Los numeros no pueden ser menores o iguales a 0");
                    }

                }
                catch
                {
                    MessageBox.Show("Verifique si el caracter ingresado es un numero");
                }
            }
        }

        private void txt_LlenadoMatriz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                arreglo[f, c] = Convert.ToInt32(txt_LlenadoMatriz.Text);
                txt_LlenadoMatriz.Clear();
                c++;
                if (c == columnas)
                {
                    f++;
                    c = 0;
                }
                if (f == filas)
                {
                    txt_LlenadoMatriz.Enabled = false;
                    dataGredMatriz.ColumnCount = columnas;
                    dataGredMatriz.RowCount = filas;


                    for (int i = 0; i < filas; i++)
                    {
                        for (int j = 0; j < columnas; j++)
                        {
                            dataGredMatriz.Rows[i].Cells[j].Value = arreglo[i, j];
                        }
                    }
                    MayorFilas();
                }
            }
        }

        public FormTrece()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void txt_NumFilasMatriz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                try
                {
                    if ((Convert.ToInt32(txt_NumFilasMatriz.Text) > 0 && Convert.ToInt32(txt_NumFilasMatriz.Text) <= 10))
                    {
                        filas = Convert.ToInt32(txt_NumFilasMatriz.Text);
                        txt_NumFilasMatriz.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Los numeros no pueden ser menores o iguales a 0 ni mayores a 10!");
                    }

                }
                catch
                {
                    MessageBox.Show("Verifique si el caracter ingresado es un numero");
                }
            }
        }

        public void MayorFilas()
        {
            for (int i = 0; i < filas; i++)
            {
                may = 0;
                for (int j = 0; j <= columnas; j++)
                {
                    if (arreglo[i, j] > may)
                    {
                        may = arreglo[i, j];

                    }

                }
                listBox1.Items.Add(may);
            }

        }
    }
}
