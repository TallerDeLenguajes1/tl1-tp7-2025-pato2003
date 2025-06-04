Empleado[] arregloEmpleados = new Empleado[3];
arregloEmpleados[0] = new Empleado("nombre1", "apellido1", new DateTime(2003, 3, 20), 'c', new DateTime(2024, 3, 17), 400000, Cargo.Auxiliar);
arregloEmpleados[1] = new Empleado("nombre2", "apellido2", new DateTime(1994, 8, 2), 's', new DateTime(2020, 3, 17), 2700000, Cargo.Ingeniero);
arregloEmpleados[2] = new Empleado("nombre3", "apellido3", new DateTime(1987, 1, 16), 'c', new DateTime(2000, 3, 17), 3400000, Cargo.Especialista);

void mostrarEmpleado(Empleado empleado)
{
    Console.WriteLine("Nombre: " + empleado.Nombre);
    Console.WriteLine("Apellido: " + empleado.Apellido);
    Console.WriteLine("Fecha de Nacimiento: " + empleado.FechaNac.ToShortDateString());
    Console.WriteLine("Fecha de Ingreso: " + empleado.FechaIngreso.ToShortDateString());
    Console.WriteLine("Salario: $" + empleado.Salario);
    Console.WriteLine("Cargo: " + empleado.CargoEmpleado);
    Console.WriteLine("Edad: " + empleado.Edad);
    Console.WriteLine("Años para Jubilación: " + empleado.AniosJubilacion);
    if (empleado.EstadoCivil == 'c')
    {
        Console.WriteLine("Estado Civil: Casado");
    }else
    {
        Console.WriteLine("Estado Civil: Soltero");
    }
    Console.WriteLine();
}

double montoTotal = 0;
foreach (var empleado in arregloEmpleados)
{
    montoTotal += empleado.Salario;
}

Console.WriteLine("\nEl monto total a pagar por los 3 empleados es: $" + montoTotal + "\n");

int maximo = 0;
for (int i = 1; i < 3; i++)
{
    if (arregloEmpleados[i].AniosJubilacion < arregloEmpleados[maximo].AniosJubilacion)
    {
        maximo = i;
    }
}

mostrarEmpleado(arregloEmpleados[maximo]);

