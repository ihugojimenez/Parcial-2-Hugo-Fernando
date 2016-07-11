using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroWindowsFormsApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleados empleado = new Empleados("Andres Fernando", "Salcedo RD", "809-577-4546", "809-564-4241", "405-1547893-2", "El Jefe", 85000.25f, 15.2f, true);
            using (var db = new RHHDb())
            {
                db.Empleado.Add(empleado);
                db.SaveChanges();
                db.Dispose();
            }
        }
    }
}
