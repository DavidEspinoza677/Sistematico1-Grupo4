using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                
        private bool ValidarEntrada(out double numero1, out double numero2)
        {
            bool esValido = double.TryParse(textBoxNumero1.Text, out numero1) && double.TryParse(textBoxNumero2.Text, out numero2);
            if (!esValido)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
            }
            return esValido;
        }

        //sumar
        private void buttonSuma_Click(object sender, EventArgs e)
        {
            if (ValidarEntrada(out double numero1, out double numero2))
            {
                double resultado = numero1 + numero2;
                listBoxResultados.Items.Add($"{numero1} + {numero2} = {resultado}");
            }
        }

        //restar
        private void buttonResta_Click(object sender, EventArgs e)
        {
            if (ValidarEntrada(out double numero1, out double numero2))
            {
                double resultado = numero1 - numero2;
                listBoxResultados.Items.Add($"{numero1} - {numero2} = {resultado}");
            }
        }

        //multiplicar
        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            if (ValidarEntrada(out double numero1, out double numero2))
            {
                double resultado = numero1 * numero2;
                listBoxResultados.Items.Add($"{numero1} * {numero2} = {resultado}");
            }
        }

        //dividir
        private void buttonDividir_Click(object sender, EventArgs e)
        {
            if (ValidarEntrada(out double numero1, out double numero2))
            {
                if (numero2 != 0)
                {
                    double resultado = numero1 / numero2;
                    listBoxResultados.Items.Add($"{numero1} / {numero2} = {resultado}");
                }
                else
                {
                    MessageBox.Show("No se puede dividir entre cero.");
                }
            }
        }
    }
}