using Examen;


public class Program
{
    public static void Main()
    {
        Asignatura asignatura = new Asignatura();

        try
        {
            Console.Write("Ingrese el nombre del alumno: ");
            asignatura.NombreAlumno = Console.ReadLine();

            Console.Write("Ingrese el número de cuenta del alumno: ");
            asignatura.NumeroCuenta = Console.ReadLine();

            Console.Write("Ingrese el email del alumno: ");
            asignatura.Email = Console.ReadLine();

            Console.Write("Ingrese el nombre de la asignatura: ");
            asignatura.NombreAsignatura = Console.ReadLine();

            Console.Write("Ingrese el horario de la asignatura: ");
            asignatura.Horario = Console.ReadLine();

            Console.Write("Ingrese el nombre del docente: ");
            asignatura.NombreDocente = Console.ReadLine();

            Console.Write("Ingrese nota del primer parcial: ");
            asignatura.N1 = int.Parse(Console.ReadLine());
            if (asignatura.N1 > 30)
            {
                Console.WriteLine("La nota del primer parcial sobrepasa del 30%");
                return;
            }

            Console.Write("Ingrese nota del segundo parcial: ");
            asignatura.N2 = int.Parse(Console.ReadLine());
            if (asignatura.N2 > 30)
            {
                Console.WriteLine("La nota del segundo parcial sobrepasa del 30%");
                return;
            }

            Console.Write("Ingrese nota del tercer parcial: ");
            asignatura.N3 = int.Parse(Console.ReadLine());
            if (asignatura.N3 > 40)
            {
                Console.WriteLine("La nota del tercer parcial sobrepasa del 40%");
                return;
            }

            asignatura.Imprimir();
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese datos numéricos donde se requiera.");
        }
    }
}

