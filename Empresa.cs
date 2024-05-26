namespace EspacioEmpresa;

public class Empleado
{
    private string Nombre;
    private string Apellido;
    private DateTime fecNac;
    private char estadoCivil;
    private DateTime ingresoEmpresa;
    private double sueldoBasico;
    public enum cargo{
                                Auxiliar,
                                Administrativo,
                                Ingeniero,
                                Especialista,
                                Investigador
                                };

    //Metodo para obtener la antiguedad.
    public int antiguedad(DateTime ingreso, DateTime actual)
    {
        int anioIngreso = ingreso.Year;
        int anioActual = actual.Year;
        int aniosTotal = anioActual - anioIngreso;

        if (actual.Month < ingreso.Month || (actual.Month == ingreso.Month && actual.Day < ingreso.Day))
        {
            aniosTotal--;
        }

        return aniosTotal;
    }

    //Metodo para obtener la edad del empleado.
    public int edadEmpleado(DateTime nacimiento, DateTime actual)
        {
            int anioNac = nacimiento.Year;
            int anioActual = actual.Year;
            int edadActual = anioActual - anioNac;

            if (actual.Month < nacimiento.Month || (actual.Month == nacimiento.Month && actual.Day < nacimiento.Day))
            {
                edadActual--;
            }

            return edadActual;    
        }

    //Metodo para calcular cuanto falta para la jubilacion.
    public int jubilacion(DateTime nacimiento, DateTime actual)
        {
            int anioNac = nacimiento.Year;
            int anioActual = actual.Year;
            int edadActual = anioActual - anioNac;

            if (actual.Month < nacimiento.Month || (actual.Month == nacimiento.Month && actual.Day < nacimiento.Day))
            {
                edadActual--;
            }

            int jubilacion = 65 - edadActual;

            return jubilacion;    
        }

    //Metodo para calcular el salario.
    public double salarioTotal(double sueldo, int antiguedad, cargo cargoE, char estadoC)
    {
        double total = sueldo;

        //Calculo de antiguedad.

        if (antiguedad < 20)
        {
            total = total + total * (antiguedad/100);
        } else
        {
            total = total + total * 0.25;
        }

        //Calculo del tipo de cargo.

        if (cargoE == cargo.Ingeniero || cargoE == cargo.Especialista)
        {
            total = total + total * 0.5;
        }

        //Calculo del estado civil.

        if (estadoC == 'c')
        {
            total = total + 150000;
        }

        return total;
    }

}

