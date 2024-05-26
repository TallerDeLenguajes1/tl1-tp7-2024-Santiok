namespace EspacioEmpresa;

public class Empleado
{
    private string Nombre;
    private string Apellido;
    private DateTime fecNac;
    private char estadoCivil;
    private DateTime ingresoEmpresa;
    private double sueldoBasico;
    private enum cargo{
                                Auxiliar,
                                Administrativo,
                                Ingeniero,
                                Especialista,
                                Investigador
                                };

    
}