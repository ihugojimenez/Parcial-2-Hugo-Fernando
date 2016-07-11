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
        
        

    }
}
