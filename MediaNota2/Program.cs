using System;
using System.Globalization;

namespace ProjetoBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, media;


            nota1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota3 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (((nota1 * 2) + (nota2 * 3) + (nota3 * 5))) / 10;

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}