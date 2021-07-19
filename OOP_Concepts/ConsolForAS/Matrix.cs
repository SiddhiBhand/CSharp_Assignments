using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolForAS
{
    class Matrix
    {
        static int n = 2;
        static void Add(int[,] A,int[,] B,int[,] C)
        {
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    C[i,j] = A[i,j] + B[i,j];
                }
            }
        }
        static void Multi(int[,] mat1,int[,] mat2,int[,] res)
        {
            int i, j, k;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    res[i, j] = 0;
                    for (k = 0; k < n; k++)
                        res[i, j] += mat1[i, k]
                                     * mat2[k, j];
                }
            }
        }
     /*   public static void Main()
        {
            int[,] A = { { 10, 5 }, { 20, 5 } };
            int[,] B = { { 5, 5 }, { 10, 4 } };
            int[,] C = new int[n, n];
            Add(A, B, C);
            Console.WriteLine("Matrix Addition");
            int i, j;
            for(i = 0; i < n; i++)
            {
                for(j = 0; j < n; j++)
                {
                    Console.Write(C[i, j] + " ");
                   
                }
                Console.WriteLine();
            }

            int[,] mat1 = { { 2, 4 }, { 1, 1 } };
            int[,] mat2 = { { 1, 4 }, { 1, 2 } };
            int[,] res = new int[n, n];
            Multi(mat1,mat2,res);
            Console.WriteLine("Matrix Multiplication");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(res[i, j] + " ");

                }
                Console.WriteLine();
            }
        }*/
    }
}
