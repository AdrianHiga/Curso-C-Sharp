using System;
using System.Globalization;

namespace Aula04 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Saída de dados em C#

               Sem quebra de linha no final:
               Console.Write("Olá, Mundo!");

               Com quebra de linha no final;
               Console.WriteLine("Olá, Mundo!");
             */

            // Sem quebra de linha no final:
            Console.Write("Olá, Mundo!");
            Console.Write("Bom dia!");

            //Com quebra de linha no final;
            Console.WriteLine("Olá, Mundo!");
            Console.WriteLine("Bom dia!");

            // Variável com ponto flutuante
            double x = 10.123;
            Console.WriteLine(x);

            // Limitar a quantidade de casa decimais
            Console.WriteLine(x.ToString("F2")); // F (Quantidade de casa decimais)
            Console.WriteLine(x.ToString("F4")); // F (Quantidade de casa decimais)

            // Como configurar a localidade do sistema, como padrão é configurado no padrão USA...(Para utilizar a virgula ao invés do ponto, basta importar a boblioteca Globalization)
            Console.WriteLine(x.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine();

            // Concatenação
            //Regra geral
            // elemento1 + elemento2 + elemento3 ....
            // Console.WriteLine(Texto + <variavel>);
            // Console.WriteLine(Texto + <variavel>.ToString("F2") + "texto");
        }
    }
}