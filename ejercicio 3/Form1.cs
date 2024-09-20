using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ejercicio_3.Models;

namespace ejercicio_3
{
    public partial class Form1 : Form
    {
        Random Random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        int row = 0;
        int col = 0;

        int counter1 = 0;
        int counter2 = 0;


        double[,] matrix1 = new double[2, 2];
        double[,] matrix2 = new double[2, 2];
        double[,] result_matrix = new double[2, 2];

        public double[,] Populate_matrix(double[,] matrix) {
            double[,] temp = matrix;
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
           
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                   temp[i, j]= Random.NextDouble();
                }
                
            }

            return temp;
        }

        public string print_shit(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            string result = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result += matrix[i, j] +"  " +"\t";
                }
                result += Environment.NewLine;
            }

            return result;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                matrix1 = Populate_matrix((double[,])matrix1);
                matrix2 = Populate_matrix((double[,])matrix2);

                lbl_matrix1.Text = print_shit(matrix1);
                lbl_matrix2.Text = print_shit(matrix2);

                result_matrix = Helper.Sum_Matrix(matrix1,matrix2);
                lbl_result.Text = print_shit(result_matrix);
                
            }
            catch (Exception ex) { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
