using System;

namespace csharp_bmi_app
{
    class Program
    {
        static void Main(string[] args)
        {
            float Weight, Height;
            double Bmi;
            Console.WriteLine("*********BMI Calculator**********");
            Console.WriteLine("Enter your weight(in Kg):");
            Weight = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height (in m):");
            Height = float.Parse(Console.ReadLine());
            Bmi = (Weight / (Height * Height));

            Console.WriteLine($"Your BMI is : {Bmi}");


            if (Bmi < 18.5)
            {
                Console.WriteLine("You are Underweight");
            }
            else if (Bmi >= 18.5 && Bmi <= 24.9)
            {
                Console.WriteLine("Your BMI is Normal");
            }
            else if (Bmi > 24.9 && Bmi <= 29.9)
            {
                Console.WriteLine("You are Overweight");
            }
            else
            {
                Console.WriteLine("You are Obese");
            }

            Console.ReadKey();

        }
    }
}
