using System;

namespace VectorInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Citeste marimea vectorului
            Console.Write("Introdu marimea vectorului: ");
            int n = int.Parse(Console.ReadLine());

            //Creare de vector + adaugare de valori rand
            int[] vector = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti valorea pentru elementul {i}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            //Apelare functie
            InversareVector(vector);

            //Afisare vector inversat
            Console.WriteLine("Vector inversat:");
            foreach(int value in vector)
            {
                Console.WriteLine(value);
            }

        }

        static void InversareVector(int[] vector)
        {
            //Inverseaza elementele
            int stanga = 0;
            int dreapta = vector.Length - 1;
            while (stanga < dreapta)
            {
                //Schimba valorile din stanga si dreapta
                int temp = vector[stanga];
                vector[stanga] = vector[dreapta];
                vector[dreapta] = temp;

                stanga++;
                dreapta--;
            }
        }
    }
}

 