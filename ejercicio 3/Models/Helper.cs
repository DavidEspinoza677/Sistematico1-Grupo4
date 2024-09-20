using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3.Models
{
    internal class Helper
    {

        public static double[,] Sum_Matrix(double[,] A, double[,] B)
        {
            int rA = A.GetLength(0);
            int cA = A.GetLength(1);
            int rB = B.GetLength(0);
            int cB = B.GetLength(1);



            if (cA != rB)
            {

            }
            else
            {
                double temp = 0;
                double[,] kHasil = new double[rA, cB];

                for (int i = 0; i < rA; i++)
                {
                    for (int j = 0; j < cB; j++)
                    {
                        temp = 0;
                        for (int k = 0; k < cA; k++)
                        {
                            temp += A[i, k] * B[k, j];
                        }
                        kHasil[i, j] = temp;
                    }
                }

                return kHasil;
            }

            return new double[0, 0];

        }
    }
}
