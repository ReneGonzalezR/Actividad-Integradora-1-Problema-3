using System;
using System.Windows.Forms;
/// <summary>
/// Lenguaje de programacion III
/// Autor: Rene Gonzalez Rodriguez
/// Maestro: Aarón I. Salazar
/// </summary>
namespace Actividad_Integradora_1_Problema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lbl1.Text = "Sí";
            lbl2.Text = "Sí";
            lbl3.Text = "Sí";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lbl1.Text = "No";
            lbl2.Text = "No";
            lbl3.Text = "No";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lbl1.Text = "A";
            lbl2.Text = "B";
            lbl3.Text = "C";
        }
    }
}
