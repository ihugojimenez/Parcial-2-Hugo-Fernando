using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RHHDb : DbContext
    {
        public RHHDb() : base("name = RHH")
        {

        }

        public virtual DbSet<Empleados> Empleado { get; set; }
    }
}
