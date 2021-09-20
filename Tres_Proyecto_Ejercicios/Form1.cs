using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tres_Proyecto_Ejercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void tresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinAppEjercicio3.FormTres Obj3 = new WinAppEjercicio3.FormTres();
            Obj3.Show(); 
        }

        private void cuarentaYSieteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinAppEjercicio47.FormCuarentaYSiete Obj47 = new WinAppEjercicio47.FormCuarentaYSiete();
            Obj47.Show(); 
        }

        private void ochoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinAppEjercicio8.FormOcho Obj8 = new WinAppEjercicio8.FormOcho();
            Obj8.Show(); 
        }

        private void treceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            WinAppEjercicio13.FormTrece Obj13 = new WinAppEjercicio13.FormTrece();
            Obj13.Show(); 
        }

        private void diesiochoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinAppEjercicio18.FormDieciYOcho Obj18 = new WinAppEjercicio18.FormDieciYOcho();
            Obj18.Show(); 
        }

        private void veintiTresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinAppEjercicio23.FormVeinteYtres Obj23 = new WinAppEjercicio23.FormVeinteYtres();
            Obj23.Show(); 
        }

        private void veinteYOchoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinAppEjercicio28.Form1 Obj28 = new WinAppEjercicio28.Form1();
            Obj28.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void treintaYTresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinAppEjercicio33.FormTreintaYTres Obj33 = new WinAppEjercicio33.FormTreintaYTres();
            Obj33.Show(); 
        }

        private void treintaYOchoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinAppEjercicio38.FormTrenintaYTres Obj38 = new WinAppEjercicio38.FormTrenintaYTres();
            Obj38.Show(); 
        }

        private void cuarentaYDosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinAppEjercicio42.FormCuarentaYDos Obj42 = new WinAppEjercicio42.FormCuarentaYDos();
            Obj42.Show(); 
        }

        private void cincuentaYDosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinAppEjercicio52.FormCincuentaYDos Obj52 = new WinAppEjercicio52.FormCincuentaYDos();
            Obj52.Show();
        }

        private void ciencuentaYSieteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinAppEjercicio57.FormCincuentaYSiete Obj57 = new WinAppEjercicio57.FormCincuentaYSiete();
            Obj57.Show(); 
        }
    }
}
