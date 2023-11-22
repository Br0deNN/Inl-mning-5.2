using System;
namespace inlämming_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal");
            int input = int.Parse(Console.ReadLine());
            int[] x = {1, 2, input};

            Console.WriteLine(x[0] + " " + x[1] + " " + x[2]);
            
            

            
        }
    }
}
