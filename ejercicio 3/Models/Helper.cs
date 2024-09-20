using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3.Models
{
    internal class Helper
    {
        
        public static float TestMethod(int[][] matrix)
        {
            float sum = 0;
            for (int column = 0; column < 4; column++)
                for (int row = 0; row < 3; row++)
                {
                    if (matrix[row][column] != 0)
                        sum += matrix[row][column];
                    else
                        break;
                }
            return sum;
        }

        public static float TestMethod(int[,] matrix)
        {
            float sum = 0;
            for (int column = 0; column < 4; column++)
                for (int row = 0; row < 3; row++)
                {
                    if (matrix[row,column] != 0)
                        sum += matrix[row,column];
                    else
                        break;
                }
            return sum;
        }
    }
}
