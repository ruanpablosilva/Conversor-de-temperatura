using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graus_ou_Fahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                MessageBox.Show("Por favor, digite a temperatura.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtNumero.Text, out decimal temperatura))
            {
                MessageBox.Show("Por favor, digite uma temperatura válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rbGraus.Checked)
            {

                decimal temperaturaCelsius = (temperatura - 32) * 5 / 9;
                MessageBox.Show($"A temperatura em Celsius é: {temperaturaCelsius:F2} °C", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rbFahrenheit.Checked)
            {

                decimal temperaturaFahrenheit = (temperatura * 9 / 5) + 32;
                MessageBox.Show($"A temperatura em Fahrenheit é: {temperaturaFahrenheit:F2} °F", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma unidade de temperatura.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
} //2 radioButton, 1 button, 2 Label com instruções e 1 textbox clicavel para botar a temperatura para conversão
