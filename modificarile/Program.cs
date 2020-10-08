using System;
namespace Adelina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buna ziua");
            Console.WriteLine("Introduceti nr de pagini a cartii: ");
            int numarPagini;
            try
            {
                numarPagini = int.Parse(Console.ReadLine());
                Console.WriteLine($"Cartea are {numarPagini} pagini");
            }
            catch (Exception)
            {
                Console.WriteLine("Va rugam sa folositi doar numere intregi!");
                return;
            }



        }
    }
}