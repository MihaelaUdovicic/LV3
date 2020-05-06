using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    class MatricaRandGen
    {
        public static MatricaRandGen instance;
        
        
        public static MatricaRandGen GetInstance()
        {
            if (instance == null)
            {
                instance = new MatricaRandGen();
            }
            return instance;
        }

        public double[][] Generator(int n,int m)
        {
            double[][] matrica = new double [n][];
            for (int i= 0; i<n ;i++)
            {
                matrica[i] = new double[m];
                for(int j=0; j< m;j++)
                {
                    matrica[i][j] = RandomGenerator.GetInstance().NextDouble();
                }
            }
            return matrica;

        }

    }
}
