
//0 declarar variables -- tipo de dato  (int - numero entero / float - numeros con , temp promedios / char - letras / bool - v o f / 0 y 1)
//1 pedir valores
//2 realizar calculo -asignacion
//3 dar resultado


using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, suma, resta, multi, division; // declaramos todas las var


            Console.WriteLine("ingrese un numero: "); // input usuario
            n1 = int.Parse(Console.ReadLine()); // lee lo que pide en consola
            Console.WriteLine("ingrese numero2: ");
            n2 = int.Parse(Console.ReadLine());

            suma = n1 + n2; // asignamos a una nueva variable
            resta = n1 - n2;
            multi = n1 * n2;
            division = n1 / n2;

            Console.WriteLine("El resultado es: " + suma);
            Console.WriteLine("El resultado es: " + resta);
            Console.WriteLine("El resultado es: " + multi);
            Console.WriteLine("El resultado es: " + division);
        }
    }
}


// instrucciones de terminal

//clear -- borra todo en terminal

//dotnet new console -o primer-programa --crear un proyecto

//dotnet run -- ejecuta el proyecto

//ls -- lista de proyecto -