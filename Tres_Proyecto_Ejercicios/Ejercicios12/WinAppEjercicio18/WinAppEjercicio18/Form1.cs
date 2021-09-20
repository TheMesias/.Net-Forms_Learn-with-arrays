using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicio18
{
    public partial class FormDieciYOcho : Form
    {
        int filas, columnas;
        int f = 0;
        int c = 0;
        int i = 0;
        int ncolu = 0;
        int nfila = 0, inserf = 0;
        int[,] arreglo = new int[10, 10];
        int[,] matriNuev = new int[10, 10];
        int[] vec = new int[20];
        public FormDieciYOcho()
        {
            InitializeComponent();
        }

        private void txt_NumElementosColumnas_KeyPress(object sender, KeyPressEventArgs e)
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
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void txt_InsertarColumna_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar) == (char)Keys.Enter)
            {
                    inserf = int.Parse(txt_dato.Text);

                    if ((ncolu >= 0) && (inserf <= ncolu))
                    {
                        txt_dato.Enabled = false;
                        txt_elem2.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Ingrese un numero de columna válido!!!!");
                        txt_dato.Clear();
                    }
             }
                
        }


        
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                try
                {

                    vec[i] = int.Parse(txt_elem2.Text);
                    i++;
                    txt_elem2.Clear();

                    if (i == ncolu)
                    {
                        txt_elem2.Enabled = false;


                        ClDieciOcho objResul = new ClDieciOcho(arreglo, nfila, ncolu, inserf, vec, matriNuev);
                        objResul.ProcesoAumentarColumna(matriNuev); 
                        dataGridView2.ColumnCount = ncolu + 1;
                        dataGridView2.RowCount = nfila ;



                        for (int i = 0; i <nfila; i++)
                        {
                            for (int j = 0; j < (ncolu + 1); j++)
                            {
                                dataGridView2.Rows[i].Cells[j].Value = matriNuev[i, j];
                            }
                        }
                    }
                }





                catch
                {

                }
            }
        }

        private void txt_NumElementosFilas_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
