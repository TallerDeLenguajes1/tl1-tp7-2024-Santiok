// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Globalization;
using EspacioCalculadora;

/*

Calculadora num = new Calculadora();
int opcion = 999;
double operando;

do
{
    Console.WriteLine("\n----------Elija la operacion que desea realizar----------\n 1)Sumar \n 2)Restar \n3)Multiplicar \n4)Dividir \n 5)Limpiar \n 6)Salir");
    Console.WriteLine("\nIngrese una opcion:");
    int.TryParse(Console.ReadLine(), out opcion);

    switch (opcion)
    {
        case 1:

            Console.WriteLine("\nIngrese un numero:");
            double.TryParse(Console.ReadLine(), out operando);

            if (num.Resultado == 0)
            {
                num.Sumar(operando);
                Console.WriteLine("\nEl valor es: 0 + " + operando + " = " + num.Resultado);
            } else
            {
                double aux = num.Resultado;
                num.Sumar(operando);
                Console.WriteLine("\nEl valor es: " + aux + "+" + operando + " = " + num.Resultado);
            }

        break;

        case 2:

            Console.WriteLine("\nIngrese un numero:");
            double.TryParse(Console.ReadLine(), out operando);

            if (num.Resultado == 0)
            {
                num.Restar(operando);
                Console.WriteLine("\nEl valor es: 0 - " + operando + " = " + num.Resultado);
            } else
            {
                double aux = num.Resultado;
                num.Restar(operando);
                Console.WriteLine("\nEl valor es: " + aux + "-" + operando + " = " + num.Resultado);
            }

        break;

        case 3:

            Console.WriteLine("\nIngrese un numero:");
            double.TryParse(Console.ReadLine(), out operando);

            if (num.Resultado == 0)
            {
                num.Multiplicar(operando);
                Console.WriteLine("\nEl valor es: 0 * " + operando + " = " + num.Resultado);
            } else
            {
                double aux = num.Resultado;
                num.Multiplicar(operando);
                Console.WriteLine("\nEl valor es: " + aux + "*" + operando + " = " + num.Resultado);
            }

        break;

        case 4:

            Console.WriteLine("\nIngrese un numero:");
            double.TryParse(Console.ReadLine(), out operando);

            if (num.Resultado == 0)
            {
                num.Dividir(operando);
                Console.WriteLine("\nEl valor es: 0 / " + operando + " = " + num.Resultado);
            } else
            {
                double aux = num.Resultado;
                num.Dividir(operando);
                Console.WriteLine("\nEl valor es: " + aux + "/" + operando + " = " + num.Resultado);
            }

        break;

        case 5:

            if (num.Resultado == 0)
            {
                num.Limpiar();
                Console.WriteLine("\nEl valor es: " + num.Resultado);
            } else
            {
                num.Limpiar();
                Console.WriteLine("\nEl valor es: " + num.Resultado);
            }

        break;

        case 6:
            Console.WriteLine("\nEl programa finalizo.");
        break;
        
        default:
        Console.WriteLine("\nLa opcion ingresada no es valida.");
        break;
    }

} while (opcion != 6);

*/

using EspacioEmpresa;

Empleado []empleados = new Empleado[3];

empleados[0] = new Empleado();
empleados[1] = new Empleado();
empleados[2] = new Empleado();