using System;

namespace lab_21_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //1d
            int[] array01 = new int[10];    //size 10
            int[] arrayLiteral = new int[] { 1, 2, 3, 4, 5 };
            string[] stringLiteral = new string[] { "one", "two", "three" };

            //2d
            int[,] Array2D = new int[10, 10];
            //put data in
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Array2D[i, j] = i * i * j * j;
                }
            }
            //get data out
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    sum += Array2D[i, j];
                }
            }
            Console.WriteLine(sum);
            //=================================================================
            //3d
            int[,,] Cube3D = new int[10, 10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        Cube3D[i, j, k] = i * i * j * j  * k * k;
                    }
                    
                }
            }
            //get data out
            int sum2 = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        sum2 += Cube3D[i, j, k];
                    }

                }
            }
            Console.WriteLine(sum2);

            ////=================================================================
            /////jagged is an array of arrays which have indistinct lengths

            int[][] myJaggedArray = new int[10][];
            myJaggedArray[0] = new int[5];
            myJaggedArray[1] = new int[] { 1, 2, 3 };


        }
    }
}
