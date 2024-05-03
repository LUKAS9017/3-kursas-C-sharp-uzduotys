using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // Nustatome norimą sekos ilgį
        long n = 100; //su tokiu skaiciu, kaip 1000000000000000 programa neveikia

        // Skaičiuojame seką iki n
        CalculateSequence(n);
    }

    static void CalculateSequence(long n)
    {
        long[] sequence = new long[n];

        // Pirmas narys yra 1
        sequence[0] = 1;

        // Skaičiuojame kitus narius
        for (int i = 1; i < n; i++)
        {
            // Narius lyginiais indeksais skaičiuojame kaip dvigubai didesnius už prieš tai esantį narį
            if (i % 2 == 0)
            {
                sequence[i] = sequence[i / 2] * 2;
            }
            // Narius nelyginiais indeksais skaičiuojame kaip prieš tai esantį narį
            else
            {
                sequence[i] = sequence[i - 1];
            }
        }

        // Spausdiname sekos narius
        Console.WriteLine("Seka iki " + n + ": ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(sequence[i] + " ");
        }


        // Programos veikimo laiko matavimas
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();
        stopwatch.Stop();

        Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
    }
}