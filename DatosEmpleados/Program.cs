using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosEmpleados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a Sistema de Empleado.");
            Console.WriteLine("________________________________");

            Console.Clear();

            Empleado empleadouno = new Empleado();

            Console.WriteLine("Sistema de Empleado: Ingreso de datos.");
            Console.WriteLine("______________________________________");

            empleadouno.Inicializar();

            Console.Clear();

            Console.WriteLine("Sistema de Empleado.");
            Console.WriteLine("____________________");

            Console.WriteLine(empleadouno.obtenerFicha());

            Console.Clear();

            Console.WriteLine("Sistema de Empleado: Aumento 20% del sueldo.");
            Console.WriteLine("____________________________________________");

            empleadouno.SubirSueldo(20);

            Console.WriteLine(empleadouno.obtenerFicha());

            Console.ReadKey();
        }
    }
}
