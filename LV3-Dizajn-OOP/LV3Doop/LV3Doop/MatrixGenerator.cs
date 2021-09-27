using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace LV3Doop
{
    class MatrixGenerator
    {
        private static MatrixGenerator instance;
        private double[][] matrix;

        private MatrixGenerator()
        {
            RandomGenerator rand = RandomGenerator.GetInstance();
            double[][] matrixTemp = new double[5][];
            for (int i = 0; i < 5; i++)
            {
                matrixTemp[i] = new double[5];
                for (int j = 0; j < 5; j++)
                    matrixTemp[i][j] = rand.NextDouble();
            }
            this.matrix = matrixTemp;
        }

        public static MatrixGenerator GetInstance()
        {
            if (instance == null)
            {
                instance = new MatrixGenerator();
            }
            return instance;
        }

        public void MatrixOutput()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(this.matrix[i][j]);
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }
    }
}

