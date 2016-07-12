using BLL;
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
            Empleados empleado = new Empleados();
            empleado.Activo = true;
            empleado.Cargo = "El Jefe";
            empleado.Cedula = "452-1235478-1";
            empleado.Celular = "809-577-4648";
            empleado.Direccion = "Salcedo RD";
            empleado.Incentivo = 15.6f;
            empleado.Nombre = "Andres FErnando";
            empleado.Sueldo = 58000.23f;
            empleado.Telefono = "809-577-4646";

            EmpleadosBLL.Eliminar(1);
            
            
        }

        private void registrarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaForm cf = new ConsultaForm();
            cf.Show();
        }
    }
}
