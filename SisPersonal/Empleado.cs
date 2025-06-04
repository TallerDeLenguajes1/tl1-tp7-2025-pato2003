partial class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime fechaNac;
    private char estadoCivil;
    private DateTime fechaIngreso;
    private double sueldoBasico;
    private int edad;
    private int aniosJubilacion;
    private int antiguedad;
    private Cargo cargoEmpleado;
    private double salario;
    private double adicional;


    public Empleado(string nombre, string apellido, DateTime fechaNac, char estadoCivil, DateTime fechaIngreso, double sueldoBasico, Cargo cargoEmpleado)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaNac = fechaNac;
        this.estadoCivil = estadoCivil;
        this.fechaIngreso = fechaIngreso;
        this.sueldoBasico = sueldoBasico;
        this.cargoEmpleado = cargoEmpleado;
        this.antiguedad = (DateTime.Now - fechaIngreso).Days / 365;
        this.edad = (DateTime.Now - fechaNac).Days / 365;
        this.aniosJubilacion = (fechaNac.AddYears(65) - DateTime.Now).Days / 365;

        if (antiguedad <= 20)
        {
            this.adicional = sueldoBasico * antiguedad / 100.0;
        }
        else
        {
            this.adicional = sueldoBasico * 0.25;
        }

        if (cargoEmpleado == Cargo.Ingeniero || cargoEmpleado == Cargo.Especialista)
        {
            this.adicional *= 1.5;
        }
        
        if (estadoCivil=='c')
        {
            this.adicional += 150000;
        }

        this.salario = sueldoBasico + adicional;
    }

    public double Salario { get => salario;}
    public int AniosJubilacion { get => aniosJubilacion;}
    public int Antiguedad { get => antiguedad;}
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public int Edad { get => edad; set => edad = value; }
    public Cargo CargoEmpleado { get => cargoEmpleado; set => cargoEmpleado = value; }
}
