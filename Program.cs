using System;

namespace Calculadorgit
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            string operacao = "";

            Console.WriteLine("Por favor digite o primeiro número!");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor digite o segundo número!");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEscolha o uma operação! \n\n" +
             "a ou + : adiçao \r\n" +
            "b ou - : subtracao\r\n" +
            "c ou * : multiplicação\r\n" +
            "d ou / : divisão\n");

            operacao = Console.ReadLine();

            if (operacao == "a" || operacao == "+")
            {
                Console.WriteLine(numero1 + numero2);
            }

            if (operacao == "b" || operacao == "-")
            {
                Console.WriteLine(numero1 - numero2);
            }

            Console.WriteLine("\nDigite qualquer tecla para sair!");
            Console.ReadKey();

        }
    }
}
