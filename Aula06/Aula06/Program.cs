using System;

namespace Aula06
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*
            Entrada de dados em C# Parte 01
            Console.ReadLine() // Sempre retorna como String
            */

            string frase = Console.ReadLine();
            
            string x = Console.ReadLine();
            
            string y = Console.ReadLine();
            
            string z = Console.ReadLine();

            string s = Console.ReadLine();

            // Função Split
            /*
            string[] <variavel> = <variavel>.Split(' ');
            string <variavel> = vet[0]; indice 0
            string <variavel> = vet[1]; indice 1
            string <variavel> = vet[2]; indice 2
            */

            string[] v = s.Split(' ');
            //string[] v = Console.Readline().Split(' '); Outra alternativa
            string p1 = v[0];
            string p2 = v[1];
            string p3 = v[2];

            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);







        }
    }
}