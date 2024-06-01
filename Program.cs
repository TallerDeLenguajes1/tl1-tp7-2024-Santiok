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

//EJERCICIO NUMERO 2.

using EspacioEmpresa;

double montoTotalEmpleados = 0;

//Creo el arreglo de empleados.
Empleado []empleados = new Empleado[3];

Empleado.Cargo cargoEmpleado1 = (Empleado.Cargo)Enum.Parse(typeof(Empleado.Cargo), "Ingeniero", true);
empleados[0] = new Empleado("Santiago", "Medina", DateTime.Parse("2002-05-13"), 's', DateTime.Parse("2020-10-20"), 600000, cargoEmpleado1);

Empleado.Cargo cargoEmpleado2 = (Empleado.Cargo)Enum.Parse(typeof(Empleado.Cargo), "Especialista", true);
empleados[1] = new Empleado("Daniel", "Juarez", DateTime.Parse("1980-08-06"), 'c', DateTime.Parse("2006-04-16"), 500000, cargoEmpleado2);

Empleado.Cargo cargoEmpleado3 = (Empleado.Cargo)Enum.Parse(typeof(Empleado.Cargo), "Auxiliar", true);
empleados[2] = new Empleado("Maria", "Gomez", DateTime.Parse("1992-06-28"), 's', DateTime.Parse("2010-10-10"), 200000, cargoEmpleado3);


//Obtengo el monto total.
for (int i = 0; i < 3; i++)
{
    int antiguedadAux;
    double salarioAux, sueldoAux;
    char estadoAux;
    Empleado.Cargo cargoAux;
    DateTime ingresoAux = empleados[i].IngresoEmpresaEmpleado;
    DateTime actualAux = DateTime.Now;

    antiguedadAux = empleados[i].Antiguedad(ingresoAux, actualAux);
    sueldoAux = empleados[i].SueldoBasicoEmpleado;
    estadoAux = empleados[i].EstadoCivilEmpleado;
    cargoAux = empleados[i].CargoEmpleado;


    salarioAux = empleados[i].salarioTotal(sueldoAux, antiguedadAux, cargoAux, estadoAux);

    montoTotalEmpleados = montoTotalEmpleados + salarioAux;
}
Console.WriteLine("\n----------El monto total es: " + montoTotalEmpleados + " $ ----------\n");