using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicio52
{
    public partial class FormCincuentaYDos : Form
    {
        int f = 0;
        int c = 0;
        int determinante = 0; 
        int[,] arreglo = new int[10, 10];
        int[,] matrizAdjunta = new int[10, 10];
        int[,] matrizInversa = new int[10, 10]; 
        public FormCincuentaYDos()
        {
            InitializeComponent();
        }

        private void txt_LlenadoMatriz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                arreglo[f, c] = Convert.ToInt32(txt_LlenadoMatriz.Text);
                txt_LlenadoMatriz.Clear();
                c++;
                if (c == 3)
                {
                    f++;
                    c = 0;
                }
                if (f == 3)
                {
                    txt_LlenadoMatriz.Enabled = false;
                    dataGredMatriz.ColumnCount = 3;
                    dataGredMatriz.RowCount = 3;


                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            dataGredMatriz.Rows[i].Cells[j].Value = arreglo[i, j];
                        }
                        
                    }
                    ProcesoDeterminante();
                    ProcesoAdjunta();
                    

                }
            }
        }

        private void ProcesoDeterminante()
        { 
            ClCincuentaYDoscs Obj52 = new ClCincuentaYDoscs(arreglo);
            determinante = Obj52.CalcularDeterminante();
            if (determinante != 0)
                lbl_determinante.Text = determinante.ToString();
             
        }

        private void ProcesoAdjunta()
        {
            ClCincuentaYDoscs Obj52 = new ClCincuentaYDoscs(arreglo);
            Obj52.MatrizAdjunta(matrizAdjunta);
            
            dataGridView1.ColumnCount = 3;
            dataGridView1.RowCount = 3;
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = matrizAdjunta[i, j];
                }
            }

            
        }
         
        private void ProcesoInversa()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.RowCount = 3;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = matrizInversa[i, j];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
