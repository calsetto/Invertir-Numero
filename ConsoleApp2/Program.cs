using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int residuo;
            int numerof = 0;
            int contador = 0;

       
            Console.WriteLine("Ingrese un numero de dos cifras");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                while (numero > 0)
                {

                    residuo = numero % 10;
                    numero = numero / 10;
                    contador = contador + 1;
                    numerof = numerof * 10 + residuo;

                }

                if(contador == 2)
                {
                    Console.WriteLine(numerof);
                    Console.WriteLine("Ingrese un numero de dos cifras");
                    contador = 0;
                    numero = 0;
                    numerof = 0;
                    numero = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Debe ingresar un numero de dos cifras");
                    contador = 0;
                    numero = 0;
                    numerof = 0;
                    numero = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}