using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class EmpleadosBLL
    {
        public static bool Insertar(Empleados empleado)
        {
            bool Hecho = false;
            try
            {
                using (var db = new RHHDb())
                {
                    db.Empleado.Add(empleado);
                    db.SaveChanges();
                    db.Dispose();
                    Hecho = true;
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
            return Hecho;

        }

        public static Empleados Buscar(int id)
        {
            var db = new RHHDb();

            return db.Empleado.Find(id);
        }

        public static void Eliminar(int id)
        {
            var db = new RHHDb();

            Empleados e = (from p in db.Empleado
                           where p.IdEmpleado == id
                           select p).FirstOrDefault();

            db.Empleado.Remove(e);
            db.SaveChanges();
        }
        
        public static void Modificar(int id)
        {
            var db = new RHHDb();

            Empleados e = (from p in db.Empleado
                           where p.IdEmpleado == id
                           select p).FirstOrDefault();


            

        }

        public static List<Empleados> getList()
        {
            List<Empleados> lista = new List<Empleados>();


            return lista.ToList();
        }
        

    }
}
