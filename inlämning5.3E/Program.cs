using System;
namespace inlämning5.__3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[3];
            int sum = 0;
            for (int i = 0;i<3;i++) 
            {
                Console.WriteLine("Skriv ett tal");
                tal[i]=int.Parse(Console.ReadLine());
                sum += tal[i];
            }
            Console.WriteLine("Summan av alla talen är " + sum);
        }
    }
}