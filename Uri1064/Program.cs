using System;
using System.Globalization;
namespace Uri1064
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, f, cont, cont1,m;

            cont1 = 0;
            cont = 0;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (a >= 0)
            {
                cont1 += a;
                cont += +1;
            }

            if (b >= 0)
            {
                cont1 += b;
                cont += +1;
            }

            if (c >= 0)
            {
                cont1 += c;
                cont += +1;
            }

            if (d >= 0)
            {
                cont1 += d;
                cont += +1;
            }

            if (e >= 0)
            {
                cont1 += e;
                cont += +1;
            }

            if (f >= 0)
            {
                cont1 += f;
                cont += +1;
            }

            m = cont1 / cont;

            Console.WriteLine();
            Console.WriteLine(cont + " Valores positivos");
            Console.WriteLine();
            Console.WriteLine(m.ToString(CultureInfo.InvariantCulture));
        }
    }
}
