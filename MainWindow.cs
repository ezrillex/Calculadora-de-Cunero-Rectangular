using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatora
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bAnalizar_Click(object sender, EventArgs e)
        {
            Recomendar("0", 0m, 0m, 0m);
            tbResultadoAplastamiento.Text = "";
            tbResultadoCortante.Text = "";
            tbAncho.Text = "";
            tbAlto.Text = "";

            if(numericUltimoTension.Value == 0 | numericFluencia.Value == 0)
            {
                MessageBox.Show("Error: Los valores de Esfuerzo no pueden ser 0");
                return;
            } 
            if(numericFactorSeguridad.Value == 0)
            {
                MessageBox.Show("Error: El factor de seguridad no puede ser 0");
                return;
            }
            if(numericTorqueMaximoTransimitr.Value == 0)
            {
                MessageBox.Show("Error: El Torque Maximo a Transimitr no puede ser 0");
                return;
            }

            decimal d = numericDiametro.Value; // diametro

            decimal ancho = 0;
            decimal alto = 0;

            if (d >= 8 & d <= 10) { ancho = 3; alto = 3; Recomendar("6-36", 0.2m, 2.2m, 2.6m); }
            else if (d > 10 & d <= 12) { ancho = 4; alto = 4; Recomendar("8-45", 0.2m, 2.4m, 2.8m); }
            else if (d > 12 & d <= 17) { ancho = 5; alto = 5; Recomendar("10-56", 0.3m, 2.4m, 2.8m); }
            else if (d > 17 & d <= 22) { ancho = 6; alto = 6; Recomendar("14-70", 0.3m, 2.6m, 3m); }
            else if (d > 22 & d <= 30) { ancho = 8; alto = 7; Recomendar("18-90", 0.3m, 2.9m, 3.2m); }
            else if (d > 30 & d <= 38) { ancho = 10; alto = 8; Recomendar("22-110", 0.5m, 2.4m, 2.8m); }
            else if (d > 38 & d <= 44) { ancho = 12; alto = 8; Recomendar("28-140", 0.5m, 2.8m, 3.1m); }
            else if (d > 44 & d <= 50) { ancho = 14; alto = 9; Recomendar("36-160", 0.5m, 2.9m, 3.2m); }
            else if (d > 50 & d <= 58) { ancho = 16; alto = 10; Recomendar("45-180", 0.5m, 3.2m, 3.5m); }
            else if (d > 58 & d <= 65) { ancho = 18; alto = 11; Recomendar("50-200", 0.5m, 3.5m, 3.8m); }
            else if (d > 65 & d <= 75) { ancho = 20; alto = 12; }
            else if (d > 75 & d <= 85) { ancho = 22; alto = 14; }
            else if (d > 85 & d <= 95) { ancho = 25; alto = 14; }
            else
            {
                MessageBox.Show("Error: el valor decimal es invalido");
            }

            // Formulas

            decimal EsfuerzoCortanteMaximoPermisible = numericFluencia.Value / (2 * numericFactorSeguridad.Value);

            decimal EsfuerzoAplastamientoMaximoPermisible = numericFluencia.Value /  numericFactorSeguridad.Value;

            // Formula 1 (Cortante)

            decimal ResultadoCortante = (2 * numericTorqueMaximoTransimitr.Value) / (d * ancho * EsfuerzoCortanteMaximoPermisible);
            tbResultadoCortante.Text = Math.Round( ResultadoCortante, 10) + " milimetros";

            // Formula 2 (Aplastamiento)

            decimal ResultadoAplastamiento = (4 * numericTorqueMaximoTransimitr.Value) / (d * alto * EsfuerzoAplastamientoMaximoPermisible);
            tbResultadoAplastamiento.Text =Math.Round( ResultadoAplastamiento, 10) + " milimetros";

            tbAncho.Text = ancho + " milimetros";
            tbAlto.Text = alto + " milimetros";
        }

        private void Recomendar(string L, decimal r, decimal Kt, decimal Kts)
        {
            tbL.Text = L;
            tbr.Text = r.ToString();
            tbKt.Text = Kt.ToString();
            tbKts.Text = Kts.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label10.Visible = false;
            label10.Enabled = false;
            numericUltimoTension.Enabled = false;
            numericUltimoTension.Visible = false;

            numericUltimoTension.Maximum = Decimal.MaxValue;
            numericFluencia.Maximum = Decimal.MaxValue;
            numericFactorSeguridad.Maximum = Decimal.MaxValue;
            numericTorqueMaximoTransimitr.Maximum = Decimal.MaxValue;
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright © 2021\nVersion 1.1\nProgramación: Ezra Abarca\nValidación: Jorge Linares", "Acerca De", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
