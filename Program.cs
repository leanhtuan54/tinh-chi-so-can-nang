using System;

namespace TinhChiSoCanNang
{
    class Program
    {
        static void Main(string[] args)
        {
            double height;
            double weight;
            double bmi;

            Console.WriteLine("Nhap chieu cao");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap can nang");
            weight = float.Parse(Console.ReadLine());

            bmi = weight / Math.Pow(height, 2);
            bmi = Math.Round(bmi, 1);

            if (bmi < 18)
                Console.WriteLine(" Thieu can");
            else if (bmi < 25.0)
                Console.WriteLine(" Binh thuong");
            else if (bmi < 30.0)
                Console.WriteLine(" Thua can");
            else
                Console.WriteLine(" Beo phi");

            Console.Write("BMI: " + bmi);
        }
    }
}