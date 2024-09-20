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
        public static int[] list1 = new int[4] { 0, 1, 1, 2 };
        public static int[] list2 = new int[4] { 0, 5, 0, 0 };
        public static int[] list3 = new int[4] { 2, 0, 3, 3 };
        public int[][] lists2 = new int[][] { list1, list2, list3 };
        public Form1()
        {
            InitializeComponent();
        }

        int row = 0;
        int col = 0;

        int counter1=0;
        int counter2=0;


        double[,] matrix1 = new double[2,2];
        double[,] matrix2 = new double[2, 2];
        double[,] result_matrix = new double[2, 2];

        public void Populate_matrix() { 

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
                    result += matrix[i, j] + "\t";
                }
                result += Environment.NewLine;
            }

            return result;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                result_matrix = Helper.Sum_Matrix(matrix1,matrix2);
                lbl_result.Text = print_shit(result_matrix);
                
            }
            catch (Exception ex) { }
        }
    }
}
