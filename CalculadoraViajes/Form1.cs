using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraViajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double distancia, velocidad;
            if (!double.TryParse(txtdistancia.Text, out distancia) || !double.TryParse(txtvelo.Text, out velocidad))
            {
                return;
            }

            double tiempoEstimado = distancia / velocidad;
            MessageBox.Show("Tiempo estimado de viaje: " + tiempoEstimado.ToString("0.00") + " horas", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
    
        }
    }
}
