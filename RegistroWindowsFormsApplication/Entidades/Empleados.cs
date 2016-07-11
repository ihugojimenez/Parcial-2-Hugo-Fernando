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
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Cedula { get; set; }
        public string Cargo { get; set; }
        public float Sueldo { get; set; }
        public float Incentivo { get; set; }
        public bool Activo { get; set; }

        public Empleados()
        {

        }

    }
}
