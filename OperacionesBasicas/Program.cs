using System;

namespace OperacionesBasicas
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1 = 50;
            double numero2 = 75;

            Console.WriteLine("Digite el primer numero");

            Console.WriteLine("Digite el segundo numero");


            Console.WriteLine("Su suma es: {0}", numero1 + numero2);
            Console.WriteLine("Su resta es: {0}",numero1 - numero2);
            Console.WriteLine("Su multiplicacion es: {0}", numero1 * numero2);
            Console.WriteLine("Su Division es: {0}", numero1 / numero2);
            Console.WriteLine("Su modulo es: {0}", numero1 % numero2);

        }
    }
}
