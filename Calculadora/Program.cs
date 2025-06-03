using EspacioCalculadora;

class Program
{
    static void Main() {
        
        Calculadora calc = new Calculadora();
        void linea()
        {
            Console.WriteLine("\n--------------------------\n");
        }
        int pedirNumero()
        {
            int num1;
            Console.WriteLine("Ingrese el numero: ");
            bool control1 = int.TryParse(Console.ReadLine(), out num1);
            while (!control1)
            {
                Console.WriteLine("No se ingresó un numero. Ingrese de vuelta");
                control1 = int.TryParse(Console.ReadLine(), out num1);
            }
            return num1;
        }

        void calculadora(int eleccion)
        {
            int num1;
            switch (eleccion)
            {
                case 1:
                    Console.WriteLine("\nCuanto desea sumar?:");
                    num1 = pedirNumero();
                    linea();
                    calc.Sumar(num1);
                    break;

                case 2:
                    Console.WriteLine("\nCuanto desea restar?:");
                    num1 = pedirNumero();
                    linea();
                    calc.Restar(num1);
                    break;


                case 3:
                    Console.WriteLine("\nPor cuanto desea multiplicar?:");
                    num1 = pedirNumero();
                    linea();
                    calc.Multiplicar(num1);
                    break;


                case 4:
                    Console.WriteLine("\nPor cuanto desea dividir?:");
                    num1 = pedirNumero();
                    linea();
                    calc.Dividir(num1);
                    break;

                case 5:
                    calc.Limpiar();
                    linea();
                    break;

                case 6:
                    Console.WriteLine("Resultado: " + calc.Resultado);
                    linea();
                    break;



                default:
                    break;
            }
        }

        void Menu()
        {
            Console.WriteLine("-------------Menu-------------\n1) Sumar\n2) Restar\n3) Multiplicar\n4) Dividir\n5) Limpiar\n6) Resultado\n7) Salir\n------------------------------\nQue operacion desea realizar?");
        }


        Menu();
        int eleccion = pedirNumero();
        linea();
        while (eleccion >= 1 && eleccion <= 6)
        {
            calculadora(eleccion);
            Menu();
            eleccion = pedirNumero();
            linea();

        }
    }
}