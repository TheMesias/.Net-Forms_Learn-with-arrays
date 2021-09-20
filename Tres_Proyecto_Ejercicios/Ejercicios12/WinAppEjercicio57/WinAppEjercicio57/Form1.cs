using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicio57
{
    public partial class FormCincuentaYSiete : Form
    {
        int filasYcolumnas;
        int f = 0;
        int c = 0;
        int[,] arreglo = new int[10, 10];
        int[,] arreglodos = new int[10, 10];
        int[,] arregloidentidad = new int[10, 10]; 
        public FormCincuentaYSiete()
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
                    Proceso();
                    ProcesoIdentidad();

                }
            }
        }

        private void Proceso()
        {
            ClCincuentaySiete Obj57 = new ClCincuentaySiete(arreglo);
            Obj57.llenadoMatriz(arreglodos,filasYcolumnas);
            DGV2.ColumnCount = filasYcolumnas;
            DGV2.RowCount = filasYcolumnas;


            for (int i = 0; i < filasYcolumnas; i++)
            {
                for (int j = 0; j < filasYcolumnas; j++)
                {
                    DGV2.Rows[i].Cells[j].Value = arreglodos[i, j];
                }

            }
        }

        private void ProcesoIdentidad()
        {
            ClCincuentaySiete Obj57 = new ClCincuentaySiete(arreglo);
            Obj57.ProcesoIdentidad(filasYcolumnas,arreglo);
            dataGridView1.ColumnCount = filasYcolumnas;
            dataGridView1.RowCount = filasYcolumnas;


            for (int i = 0; i < filasYcolumnas; i++)
            {
                for (int j = 0; j < filasYcolumnas; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = arreglodos[i, j];
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
