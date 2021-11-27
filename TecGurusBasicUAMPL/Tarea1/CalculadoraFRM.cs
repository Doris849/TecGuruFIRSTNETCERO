using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecGurusBasicUAMPL.Tarea1
{
    public partial class CalculadoraFRM : Form
    {
        public CalculadoraFRM()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {

            int suma = Convert.ToInt32(TboxNumero1.Text) + Convert.ToInt32(TboxNumero2.Text);
            //lblResultado.Text = "El resultado de la suma es ";
            //lblResultado.Visible = true;
            btnSuma.Text = suma.ToString();
            MessageBox.Show("El resultado de la suma es " + suma);
        }
    }
}
