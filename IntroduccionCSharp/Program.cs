using IntroduccionCSharp;
using IntroduccionCSharp.Ejemplos;

Calculadora calculadora = new Calculadora();

Console.WriteLine("==== Calculadora ====: ");
Console.WriteLine("");

string operacion = "";
int n1 = 0;
int n2 = 0;

try
{
    Console.WriteLine("Que operacion quiere realizar se permite (+,-,*,/): ");
    operacion = Console.ReadLine();

    Console.WriteLine("Ingrese el primer numero");
    n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo numero");
    n2 = int.Parse(Console.ReadLine());
}
catch
{
    Console.WriteLine("Error en el formato de texto ingresado.");
}
int resultado = 0;
switch (operacion)
{
    case "+":
        resultado = calculadora.Sumar(n1, n2);
        break;
    case "-":
        resultado = calculadora.Restar(n1, n2);
        break;
    case "*":
        resultado = calculadora.Multiplicar(n1, n2);
        break;
    case "/":
        resultado = calculadora.Dividir(n1, n2);
        break;
    default:
        throw new InvalidOperationException("No ingreso una operacion valida");
        
}

Console.WriteLine("El resultado es; " + resultado);









/*
Persona persona1 = new Persona("Juan","Perez","M", 21);

Console.WriteLine("Hola " + persona1.Nombres + " " + persona1.Apellidos + " usted tiene " + persona1.Edad + " años");*/

/*class Program
{
    static void Main()
    {
        Console.WriteLine("Hola mundo");

        Console.WriteLine("¿Como te llamas?");
        string nombre = Console.ReadLine();

        Console.WriteLine("¿Que edad tienes?");
        string edad = Console.ReadLine();

        Console.WriteLine("\nHola " + nombre + " tienes " + edad + " años.");
    }
}*/