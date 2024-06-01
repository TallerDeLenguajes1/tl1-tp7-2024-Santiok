namespace EspacioEmpresa;

public class Empleado
{
    private string Nombre;
    private string Apellido;
    private DateTime fecNac;
    private char estadoCivil;
    private DateTime ingresoEmpresa;
    private double sueldoBasico;
    private Cargo cargo; 
    public enum Cargo{
                                Auxiliar,
                                Administrativo,
                                Ingeniero,
                                Especialista,
                                Investigador
                                };

    //Metodo constructor.
    public Empleado(string nom, string ape, DateTime nacimiento, char estCivil, DateTime ingreso, double sueldo, Cargo cargo)
    {
        this.Nombre = nom;
        this.Apellido = ape;
        this.fecNac = nacimiento;
        this.estadoCivil = estCivil;
        this.ingresoEmpresa = ingreso;
        this.sueldoBasico = sueldo;
        this.cargo = cargo;
    }

    //Metodo para acceder a los campos de la clase.
    public string NombreEmpleado
    {
        get { return Nombre;}
    }
    public string ApellidoEmpleado
    {
        get { return Apellido;}
    }
    public DateTime FechaNacimientoEmpleado
    {
        get { return fecNac; }
    }
    public char EstadoCivilEmpleado
    {
        get { return estadoCivil; }
    }
    public DateTime IngresoEmpresaEmpleado
    {
        get { return ingresoEmpresa; }
    }
    public double SueldoBasicoEmpleado
    {
        get { return sueldoBasico; }
    }
    public Cargo CargoEmpleado
    {
        get { return cargo; }
    }

    //Metodo para obtener la antiguedad.
    public int Antiguedad(DateTime ingreso, DateTime actual)
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
    public double salarioTotal(double sueldo, int antiguedad, Cargo cargoE, char estadoC)
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

        if (cargoE == Cargo.Ingeniero || cargoE == Cargo.Especialista)
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

