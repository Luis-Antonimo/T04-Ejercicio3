using System;

namespace T04Ejercicio3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escriba su nombre:");
            String nombre = Console.ReadLine();
            Console.WriteLine("Escriba su edad:");
            //Se necesita convertir el string que retorna ReadLine
            //a una variable numérica
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hola " + nombre + " tienes " + edad + " años.");
        }
    }
}