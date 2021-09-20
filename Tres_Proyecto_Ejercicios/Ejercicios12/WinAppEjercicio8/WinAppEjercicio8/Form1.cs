using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicio8
{
    public partial class FormOcho : Form
    {
        int n;
        int i = 0;
        int l = 1;
        int eliminar;
        int[] arreglo = new int[50];
        public FormOcho()
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
                }
                else
                {
                    i++;
                }
            }
        }

        private void txt_ElementoEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                try
                {
                    listBox2.Items.Clear();
                    eliminar = Convert.ToInt32(txt_ElementoEliminar.Text);
                    arreglo = arreglo.Except(new int[] { eliminar }).ToArray();
                    for (int j = 0; j < n - 1; j++)
                    {
                        listBox2.Items.Add(arreglo[j]);
                    }
                }
                catch
                {
                    MessageBox.Show("Ingrese un numero!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
