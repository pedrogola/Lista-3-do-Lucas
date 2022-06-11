using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaDasMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {


            
            int calma;
            Console.WriteLine("Olá! digite numeros para ver a soma das matrizes");
            calma = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            int[,] A = new int[4, 4];
            int[,] B = new int[4, 4];
            



            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("insira numeros");
                    
                    
                    A[i, j] = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("insira numeros");
                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
            }

            int[,] C = soma(A, B);


            View(C);
            ;
            Console.ReadKey();
        }
        public static int[,] soma(int[,] A, int[,] B)
        {
            int[,] C = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }
           

            return C;
        }
        public static void View(int[,] a)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write("" + "\t" + a[i, j]);
                Console.WriteLine();
            }

        }
        

    }
}
