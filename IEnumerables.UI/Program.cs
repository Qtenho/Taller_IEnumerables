using IEnumerables.Logic;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {

            int option;
            do
            {
                
                Console.WriteLine("---------------------- IEnumerables Workshop --------------------");
                Console.WriteLine("                       By Edwin Qtenho\n");

                option = Menu();
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        int m, n, p;
                        Console.WriteLine("Multiplicación de Matrices");
                        Console.WriteLine("--------------------------");
                        Console.Write("Ingrese el valor de m: ");
                        m = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese el valor de n: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese el valor de p: ");
                        p = Convert.ToInt32(Console.ReadLine());

                        var myMatrix = new MatrixMultiplier(m, n, p);
                        myMatrix.FillMatrix();
                        myMatrix.MultiplierAB();
                        Console.WriteLine(myMatrix);
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        int x;
                        Console.WriteLine("Reloj de arena");
                        Console.WriteLine("--------------");
                        Console.Write("Ingrese orden de la matrix: ");
                        x = Convert.ToInt32(Console.ReadLine());

                        var mySandTimer = new SandTimer(x);
                        mySandTimer.FillCompleteMatrix();
                        mySandTimer.FillSandTimerMatrix();
                        Console.WriteLine(mySandTimer);
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        int y;
                        Console.WriteLine("Descomposición en Factores");
                        Console.WriteLine("--------------------------");
                        Console.Write("Ingrese el numero a descomponer: ");
                        y = Convert.ToInt32(Console.ReadLine());

                        var myFactorDecomposition = new FactorDecomposition(y);
                        myFactorDecomposition.GetFactors();
                        Console.WriteLine(myFactorDecomposition);
                        //Console.WriteLine("¡¡¡ Metodo en construcción !!!");
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Cosechando a Caballo");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("¡¡¡ Metodo en construcción !!!");
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Caballos en Conflicto");
                        Console.WriteLine("---------------------");
                        Console.WriteLine("¡¡¡ Metodo en construcción !!!");
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 0:
                        Console.Clear();
                        Console.WriteLine("¡¡¡ Exit !!!");
                        Console.WriteLine("************");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("¡¡¡ Opción no existe !!!");
                        Console.WriteLine("************************");
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (option != 0);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

    private static int Menu()
    {
        Console.WriteLine("1. Multiplicación de Matrices");
        Console.WriteLine("2. Reloj de arena");
        Console.WriteLine("3. Descomposición en Factores");
        Console.WriteLine("4. Cosechando a Caballo");
        Console.WriteLine("5. Caballos en Conflicto");
        Console.WriteLine("0. Salir");
        bool isValid = false;
        int option = 0;
        do
        {
            Console.Write("Digite su opción: ");
            var optionString = Console.ReadLine();
            if (!int.TryParse(optionString, out option))
            {
                Console.WriteLine("Opción inválida, solo use números.");
                isValid = false;
            }
            else
            {
                isValid = true;
            }
        } while (!isValid);
        return option;
    }
}

