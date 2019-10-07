// obliczanie sredniej ocen, jeden przedmiot, nie wiadomo ile ocen

using System;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
            string text = "@";
            float suma = 0;
            float result;

            Funkcje obiekt = new Funkcje();

            while (text != string.Empty)
            {
                text = Console.ReadLine();
                    builder.Append(text + ";");
            }

            string gradesString = builder.ToString();
            string[] grades = gradesString.Split(";", StringSplitOptions.RemoveEmptyEntries);

            float[] gradesInt = new float[grades.Length];

            for(int i = 0; i < grades.Length; i++)
            {
                gradesInt[i] = Convert.ToSingle(grades[i]);
            }

            foreach (float grade in gradesInt)
            {
                suma += grade;
            }

            Console.WriteLine(obiekt.ObliczSrednia(suma, gradesInt.Length));
        }
    }
}