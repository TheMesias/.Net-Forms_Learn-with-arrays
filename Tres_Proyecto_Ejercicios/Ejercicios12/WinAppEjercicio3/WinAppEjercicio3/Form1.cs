using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicio3
{
    public partial class FormTres : Form
    {
        int n;
        int i = 0;
        int l = 1;
        int eliminar;
        int[] arreglo = new int[50];
        public FormTres()
        {
            InitializeComponent();
        }

        private void txt_NumElementosVector_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                try
                {
                    if (Convert.ToInt32(txt_NumElementosVector.Text) > 0)
                    {
                        n = Convert.ToInt32(txt_NumElementosVector.Text);
                        txt_NumElementosVector.Enabled = false;
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

        private void txt_LlenarVector_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                arreglo[i] = Convert.ToInt32(txt_LlenarVector.Text);
                txt_LlenarVector.Clear();
                l++;
                lbl_NumElemento.Text = Convert.ToString(l);

                if (i == (n - 1))
                {
                    txt_LlenarVector.Enabled = false;
                    for (int j = 0; j < n; j++)
                    {
                        listBox1.Items.Add(arreglo[j]);
                    }
                    ProcesoMenor(); 
                }
                else
                {
                    i++;
                }
            }
        }

        private void ProcesoMenor()
        {
            ClTres Obj3 = new ClTres(arreglo);
            lbl_RespuestaVector.Text = Obj3.MenorVector(n).ToString(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
