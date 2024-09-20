using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistematico1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim();
            Console.WriteLine("Añadir los valores de x: ");
            int x = 0;
         
            Console.WriteLine("Añadir los valores de y: ");
            int y = 0;
          
        }

        private void ltbinverso_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar el ListBox antes de agregar elementos nuevos
            listBoxNumeros.Items.Clear();

            // Obtener los valores de x e y
            int x = int.Parse(textBoxX.Text);
            int y = int.Parse(textBoxY.Text);

            // Verificar si x es mayor que y
            if (x > y)
            {
                // Mostrar los números en orden inverso en el ListBox
                for (int i = x; i >= y; i--)
                {
                    listBoxNumeros.Items.Add(i);
                }
            }
            else
            {
                // Mostrar los números en orden normal en el ListBox
                for (int i = x; i <= y; i++)
                {
                    listBoxNumeros.Items.Add(i);
                }
            }
        }
    }
    }

