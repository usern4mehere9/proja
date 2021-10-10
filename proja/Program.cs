using System;

namespace proja
{
    class Program
    {
        static void Main(string[] args)
        {
            double kb, pb, kbp, v, aux;

            kb = double.Parse(Console.ReadLine());
            pb = double.Parse(Console.ReadLine());

            kbp = kb / 2;

            if (kbp < pb)
            {
                v = (kbp + kb) / 2;
                Console.WriteLine(Math.Round(v, 2));
            }

            else
            {
                aux = 2 * pb;
                v = (aux + pb) / 2;
                Console.WriteLine(Math.Round(v, 2));
            }
        }
    }
}
