using System;

namespace Calculadorgit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            string operacao = "";

            Console.WriteLine("Por favor digite o primeiro número!");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor digite o segundo número!");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEscolha o uma operação! \n\n" +
             "a ou + : adiçao \r\n" +
            "b ou - : subtracao\r\n" +
            "c ou * : multiplicação\r\n" +
            "d ou / : divisão\n");

            if (operacao == "a" || operacao == "+")
            {
                Console.WriteLine(num1 + num2);
            }


            Console.WriteLine(num1 + num2);

        }
    }
}
