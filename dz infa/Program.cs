using System;

namespace EuropeCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n =
             { "Италия", "Франция", "Нидерланды", "Германия",
             "Испания", "Бельгия", "Австрия", "Россия", "Швеция", "Польша" };

            int[] k =
            { 61000000, 66086208, 17734600, 84270625, 47344649, 11521238, 8933300, 146424729, 10420000, 37890216 };

            int[] s =
             { 302073, 551695, 41526, 357021,
            498508, 32528, 83858, 17125191, 449964, 312685 };

            double[] p = new double[10];
            for (int i = 0; i < 10; i++)
            {
                p[i] = k[i] / (double)s[i];
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (p[i] > p[j])
                    {
                        double temp = p[i];
                        p[i] = p[j];
                        p[j] = temp;

                        int tempK = k[i];
                        k[i] = k[j];
                        k[j] = tempK;

                        int tempS = s[i];
                        s[i] = s[j];
                        s[j] = tempS;

                        string tempN = n[i];
                        n[i] = n[j];
                        n[j] = tempN;
                    }
                }
            }

            Console.WriteLine("Названия стран в порядке возрастания плотности населения:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(n[i]);
            }
            Console.ReadKey();
        }
    }
}
