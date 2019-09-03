using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosEmpleados
{
    public class Empleado
    {
        //Properties
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Departamento { get; set; }
        public bool Sexo { get; set; } //false for male, true for female 
        public string SexoLegible
        {
            get
            {
                if (this.Sexo == true) return "Mujer";
                else return "Hombre";

            }
            set
            {
                if (value.ToLower() == "mujer") this.Sexo = true;
                else if (value.ToLower() == "hombre") this.Sexo = false;
                else throw new ArgumentOutOfRangeException();
            }
        }
        public double Sueldo { get; set; }

        //Methods

        public void Inicializar()
        {
            Console.Write("Ingrese nombre: ");
            Nombre = Console.ReadLine();


            Console.Write("Ingrese apellido: ");
            Apellido = Console.ReadLine();


            Console.Write("Ingrese departamento: ");
            Departamento = Console.ReadLine();

            string linea;

            Console.Write("Ingrese sexo: ");
            linea = Console.ReadLine();
            Sexo = bool.Parse(linea);

            Console.Write("Ingrese sueldo: ");
            linea = Console.ReadLine();
            Sueldo = int.Parse(linea);
        }

        public string obtenerFicha()
        {
            string ficha =
            "Nombre completo:" + this.Nombre + " " + this.Apellido + Environment.NewLine +
            "Departamento: " + this.Departamento + Environment.NewLine +
            "Sexo:" + this.SexoLegible + Environment.NewLine +
            "Sueldo:" + this.Sueldo + " Pesos" + Environment.NewLine;

            return ficha;

        }

        public void SubirSueldo(double porcentaje)
        {
            this.Sueldo = this.Sueldo + porcentaje * this.Sueldo / 100;
        }
    }
}
