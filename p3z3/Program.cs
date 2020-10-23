using System;

namespace p3z3
{
    class Program
    {
        static void SumaTablicyPoszarpanej(int[][] Tab)
        {
            int suma=0;
            for (int i = 0; i < Tab.Length; i++)
            {
                for (int j = 0; j < Tab[i].Length; j++)
                {
                    suma = Tab[i][j] + suma;
                }
            }
            Console.WriteLine("suma:" + suma);
        }
        static void FormatowanieZdania(string zdanie)
        {
            zdanie = zdanie[0].ToString().ToUpper() + zdanie.Substring(1);
            if (zdanie.EndsWith(".")) 
            {
                Console.WriteLine(zdanie);
            }
            else
            {
                Console.WriteLine(string.Concat(zdanie,"."));
            }
        }
        static void Main(string[] args)
        {
            

            int[][] TablicaPoszarpana = new int[3][];

            for (int i = 0; i < TablicaPoszarpana.Length; i++)
            {
                TablicaPoszarpana[i] = new int[i+5];
            }

            for (int i = 0; i < TablicaPoszarpana.Length; i++)
            {
                for (int j = 0; j < TablicaPoszarpana[i].Length; j++)
                {
                    TablicaPoszarpana[i][j] = i * 2;
                }
            }

            for (int i = 0; i < TablicaPoszarpana.Length; i++)
            {
                for (int j = 0; j < TablicaPoszarpana[i].Length; j++)
                {
                    Console.Write(TablicaPoszarpana[i][j] + " "); ;
                }
                Console.WriteLine();
            }

            SumaTablicyPoszarpanej(TablicaPoszarpana);
            string text = Console.ReadLine();
            FormatowanieZdania(text);
        }
    }
}
