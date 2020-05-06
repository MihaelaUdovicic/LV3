using System;
using System.Drawing;
using System.IO;

namespace LV3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ////1. zad
            //string filePath = @"C:\Users\User\source\repos\LV3\LV3\dat.txt";

            //Dataset ds = new Dataset(filePath);
            //ds.Clone();
            //ds.LoadDataFromCSV(filePath);
            //Console.WriteLine(ds.PrintList());

            ////2. zad
            //double[][] matrica = MatricaRandGen.GetInstance().Generator(6, 4);
            //for (int i = 0; i < 6; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(matrica[i][j].ToString() + "      ");
            //    }
            //    Console.WriteLine();
            //}

            ////3. zad
            //string fileName = "datoteka.txt";

            //Logger obj = new Logger();
            //obj.SetLogger(fileName);
            //Logger.GetInstance().Log("Recenica");



            ////4. zad
            ConsoleNotification cn = new ConsoleNotification("Mihaela", "DOOP", "LV3", DateTime.Now, Category.INFO, ConsoleColor.White);
            NotificationManager nm = new NotificationManager();
            nm.Display(cn);




        }
    }
}
