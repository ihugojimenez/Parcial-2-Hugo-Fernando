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
            empleado.Activo = true;
            empleado.Cargo = CargoTextBox.Text;
            empleado.Cedula = CedulaTextBox.Text;
            empleado.Celular = CelTextBox.Text;
            empleado.Direccion = DirecTextBox.Text;
            empleado.Incentivo = Convert.ToSingle(IncentivoTextBox.Text);
            empleado.Nombre = NameTextBox.Text;
            empleado.Sueldo = Convert.ToSingle(SueldoTextBox.Text);
            empleado.Telefono = TelTextBox.Text;
            EmpleadosBLL.Insertar(empleado)
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(IdTextBox.Text == " ")
            {
                IdErrorProvider.SetError(IdTextBox,"Favor Digitar el ID");
            }
            else
            {
                EmpleadosBLL.Buscar(Convert.ToInt32(IdTextBox.Text));
            }
            
        }
    }
}
