using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_de_un_triangulo__C_sharp__Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Triangulo x = new Triangulo();
            double lado1 = double.Parse(textBox1.Text);
            double lado2 = double.Parse(textBox2.Text);
            //            double lado3 = double.Parse(textBox3.Text);
            double respuesta = x.triangulo(lado1, lado2);
            MessageBox.Show("area del triangulo es:" + respuesta, "area triangulo", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
