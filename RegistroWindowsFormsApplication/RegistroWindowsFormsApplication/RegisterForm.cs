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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Empleados empleado = new Empleados();
            /*empleado.Activo = true;
            empleado.Cargo = CargoTextBox.Text;
            empleado.Cedula = CedulaTextBox.Text;
            empleado.Celular = CelTextBox.Text;
            empleado.Direccion = DirecTextBox.Text;
            empleado.Incentivo = Convert.ToSingle(IncentivoTextBox.Text);
            empleado.Nombre = NameTextBox.Text;
            empleado.Sueldo = Convert.ToSingle(SueldoTextBox.Text);
            empleado.Telefono = TelTextBox.Text;*/

            empleado.Activo = true;
            empleado.Cargo = "Jefe";
            empleado.Cedula = "402-2437519-2";
            empleado.Celular = "809-577-4546";
            empleado.Direccion = "Salcedo RD";
            //empleado.Incentivo = 15.23f;
            empleado.Nombre = "Hugo Jimenez";
            //empleado.Sueldo = 8500.2f;
            empleado.Telefono = "809-577-6469";
            EmpleadosBLL.Insertar(empleado);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(IdTextBox.Text))
            {
                IdErrorProvider.SetError(IdTextBox,"Favor Digitar el ID");
            }
            else
            {
                int aux = Convert.ToInt32(IdTextBox.Text);
                EmpleadosBLL.Buscar(aux);
            }
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdTextBox.Text))
            {
                IdErrorProvider.SetError(IdTextBox, "Favor Digitar el ID");
            }
            else
            {
                EmpleadosBLL.Eliminar(Convert.ToInt32(IdTextBox.Text));
            }

            
        }
    }
}
