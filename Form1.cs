using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
