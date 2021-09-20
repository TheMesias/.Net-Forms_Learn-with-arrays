using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicio28
{
    public partial class Form1 : Form
    {
        int filasYcolumnas;
        int f = 0, i = 0;
        int c = 0;
        int[,] arreglo = new int[10, 10];
        int[,] nuevoarreglo = new int[10, 10]; 
        int[] vec = new int[20];
        public Form1()
        {
            InitializeComponent();
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

        private void txt_LlenadoMatriz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
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

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void text_NewRow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                vec[i] = Convert.ToInt32(txt_NewRow.Text);
                i++;
                txt_NewRow.Clear(); 
                
                if(i == filasYcolumnas)
                {
                    txt_NewRow.Enabled = false;
                    ClVeinteYOcho Obj28 = new ClVeinteYOcho(arreglo, filasYcolumnas, vec, nuevoarreglo);
                    Obj28.InsertarFila(nuevoarreglo);
                    dataGridView1.ColumnCount = filasYcolumnas;
                    dataGridView1.RowCount = filasYcolumnas + 1;
                    for (int i = 0; i < (filasYcolumnas + 1); i++)
                    {
                        for (int j = 0; j < filasYcolumnas; j++)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = nuevoarreglo[i, j];
                        }
                    }
                }
            
            
            
            
            
            
            }
        }
    }
}
