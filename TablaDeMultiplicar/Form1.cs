using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TablaDeMultiplicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMos_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(label2Numero.Text, out int numero))
            {
                MessageBox.Show("Ingresar un numero valido");
                return;
            }
            label1Mul.Text = "";

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                label1Mul.Text += $"{numero} x {i} = {resultado}\n";
            }
        }
    }
}
