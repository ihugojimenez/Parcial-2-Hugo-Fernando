using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleados
    {
        [Key]
        public int IdEmpleado { get; set; }
       // public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Cedula { get; set; }
        public string Cargo { get; set; }
        public double Sueldo { get; set; }
        public double Incentivo { get; set; }
        public bool Activo { get; set; }

        

        public Empleados()
        {

        }

        /*public Empleados(/*DateTime Fechastring Nombre, string Direccion, string Telefono, string Celular, string Cedula, string Cargo, float Sueldo, float Incentivo, bool Activo)
        {
            this.Activo = Activo;
            this.Cargo = Cargo;
            this.Cedula = Cedula;
            this.Celular = Celular;
            this.Direccion = Direccion;
            //this.Fecha = Fecha;
            this.Incentivo = Incentivo;
            this.Sueldo = Sueldo;
            this.Nombre = Nombre;
            this.Telefono = Telefono;
            


        }*/

    }
}
