using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        int[,] matrix1 = new int[2,2];



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float return_value = Helper.TestMethod(matrix1);
                label1.Text = return_value.ToString();
            }
            catch (Exception ex) { }
        }
    }
}
