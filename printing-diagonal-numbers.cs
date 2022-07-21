using System;

namespace Nested_For_Loops_And_2D_Arrays
{
    internal class Program
    {
        static int[,] matrix =
        {
            {1,2,3 },
            {4,5,6 },
            {7,8,9 }
        };

        static void Main(string[] args)
        {
            /* NESTED LOOP VARIATION
            
            Console.WriteLine("This is our 2D array printed using a Nested For Loop ");
            // outer for loop inside a Nested For Loop
            for (int i = 0; i < matrix.GetLength(0); i++) // (0) = the number of ROWS
            {
                // inner loop
               for (int j = 0; j < matrix.GetLength(1); j++) // (1) - the number of COLUMNS
                {
                    if (i == j)
                        //Console.Write(matrix[i, j] + " ");
                        matrix[i, j] = 0;
                    else
                        Console.Write(" ");
                }
               
            }

            foreach (int item in matrix)
            {
                Console.Write(item + " ");
            }

            */

            /* 
            // FOR LOOP VARIATION that goes through diagonal elements

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(matrix[i,i]);
            }
            */


            // FOR that goes through diagonal elements 3 5 7
            // only works for arrays with same amounts of rows as columns 
            for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--)
            {
                Console.WriteLine(matrix[i,j] + "");
                
            }
        }
    }
}
