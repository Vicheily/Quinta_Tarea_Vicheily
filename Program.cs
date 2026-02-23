using System;

class Program
{
    static void Main()
    {

        //EJERCICIO 1
        //Calculadora Modular:
        Console.WriteLine("----------Calculadora Modular-------------");

        //En el Main, pide los números y llama a las funciones.
        Console.Write("Ingresa el primer número: ");
        double numero1 = double.Parse(Console.ReadLine()!);

        Console.Write("Ingresa el segundo número: ");
        double numero2 = double.Parse(Console.ReadLine()!);

        //Crea 4 funciones: Sumar, Restar, Multiplicar, Dividir. Todas deben recibir 2 números y retornar (return) el resultado.
        Console.WriteLine($"Suma:           {Sumar(numero1, numero2)}");
        Console.WriteLine($"Resta:          {Restar(numero1, numero2)}");
        Console.WriteLine($"Multiplicación: {Multiplicar(numero1, numero2)}");


        if (numero2 == 0)
            Console.WriteLine(" No se puede dividir entre cero.");
        else
            Console.WriteLine($"División:       {Dividir(numero1, numero2)}");



        //EJERCICIO 2
        //El Validador de Acceso (Void):
        Console.WriteLine("\n---------- Validador de Acceso ----------");

        Console.Write("Ingresa tu edad: ");
        int edad = int.Parse(Console.ReadLine()!);

        //Crea una función ValidarEdad (int edad)
        ValidarEdad(edad);






        //EJERCICIO 3
        //El Formulario Flexible:
        Console.WriteLine("\n---------- Formulario Flexible ----------");

        // Primera llamada (con hobby)
        Console.Write("Ingresa tu nombre: ");
        string nombre1 = Console.ReadLine()!;

        Console.Write("Ingresa tu hobby: ");
        string hobby1 = Console.ReadLine()!;

        CrearPerfil(nombre1, hobby1);

        // Segunda llamada (sin hobby - valor por defecto)
        Console.Write("\nIngresa tu nombre: ");
        string nombre2 = Console.ReadLine()!;

        CrearPerfil(nombre2); // Sin hobby


    }


    //Funciones ejercicio 1
    static double Sumar(double a, double b) => a + b;
    static double Restar(double a, double b) => a - b;
    static double Multiplicar(double a, double b) => a * b;
    static double Dividir(double a, double b) => a / b;




    //Funciones ejercicio 2
    static void ValidarEdad(int edad)
    {
        //Si es < 18, imprime "Acceso Denegado"
        if (edad < 18)
        {
            Console.WriteLine("Acceso Denegado");
        }
        //Si es >= 18, imprime "Bienvenido"
        else if (edad >= 18)
        {
            Console.WriteLine("Bienvenido");
        }
    }



    //Funciones ejercicio 3
    static void CrearPerfil(string nombre, string hobby = "Dormir")
    {
        Console.WriteLine($"\nNombre: {nombre}");
        Console.WriteLine($"Hobby:  {hobby}\n");
    }   
}