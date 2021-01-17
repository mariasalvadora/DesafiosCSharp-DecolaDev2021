using System;

namespace HoraDaCorrida 
{
    class Program 
    {
        static void Main(string[] args) 
        {    
            string[] vet = Console.ReadLine().Split(" ");
            
            int A = int.Parse(vet[0]);
            int N = int.Parse(vet[1]);
            
            int NumeroPlacas = A * N;

            for (int i = 10; i <= 90; i += 10) 
            {
                double total = (double)NumeroPlacas / 100 * i;
                Console.Write(Math.Ceiling(total) + " ");
            }
        }
    }
}