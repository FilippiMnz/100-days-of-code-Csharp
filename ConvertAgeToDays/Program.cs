using System;
 
namespace Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira sua idade");
            int AgeUser = int.Parse(Console.ReadLine());
            int LeapYear = AgeUser / 4;
            int FinalMath = (AgeUser * 365) + LeapYear;
            Console.WriteLine("Vossa senhoria já vivificaste um total de: " + FinalMath + " dias");
            Console.WriteLine("O total de ano bissextos vivenciados por vossa excelencia totaliza: " + LeapYear);
        }
    }
}