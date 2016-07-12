using BLL;
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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            NameTextBox.Text = " ";
            IdTextBox.Text = " ";
            CargoTextBox.Text = "";
            CedulaTextBox.Text = "";
            CelTextBox.Text = "";
            DirecTextBox.Text = "";
            IncentivoTextBox.Text = "";
            SueldoTextBox.Text = "";
            TelTextBox.Text = "";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            RHHDb db = new RHHDb();

            EmpleadosBLL.Modificar(Convert.ToInt32(IdTextBox.Text)).Incentivo = Convert.ToDouble(IncentivoTextBox.Text);
            EmpleadosBLL.Modificar(Convert.ToInt32(IdTextBox.Text)).Nombre = NameTextBox.Text;
            EmpleadosBLL.Modificar(Convert.ToInt32(IdTextBox.Text)).Sueldo = Convert.ToDouble(SueldoTextBox.Text);
            EmpleadosBLL.Modificar(Convert.ToInt32(IdTextBox.Text)).Telefono = TelTextBox.Text;
            EmpleadosBLL.Modificar(Convert.ToInt32(IdTextBox.Text)).Cargo = CargoTextBox.Text;
            EmpleadosBLL.Modificar(Convert.ToInt32(IdTextBox.Text)).Cedula = CedulaTextBox.Text;
            EmpleadosBLL.Modificar(Convert.ToInt32(IdTextBox.Text)).Celular = CelTextBox.Text;
            EmpleadosBLL.Modificar(Convert.ToInt32(IdTextBox.Text)).Direccion = DirecTextBox.Text;

            db.SaveChanges();
            limpiar();


        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(IdTextBox.Text))
            {
                IdErrorProvider.SetError(IdTextBox,"Favor Digitar el ID");
            }
            else
            {
               

                /*EmpleadosBLL.Buscar(Convert.ToInt32(IdTextBox.Text)).Cargo=CargoTextBox.Text;
                CedulaTextBox.Text = EmpleadosBLL.Buscar(Convert.ToInt32(IdTextBox.Text)).Cedula;
                CelTextBox.Text = EmpleadosBLL.Buscar(Convert.ToInt32(IdTextBox.Text)).Celular;
                DirecTextBox.Text = EmpleadosBLL.Buscar(Convert.ToInt32(IdTextBox.Text)).Direccion;
                NameTextBox.Text = EmpleadosBLL.Buscar(Convert.ToInt32(IdTextBox.Text)).Nombre;
                TelTextBox.Text = EmpleadosBLL.Buscar(Convert.ToInt32(IdTextBox.Text)).Telefono;
                IdTextBox.Text = EmpleadosBLL.Buscar(Convert.ToInt32(IdTextBox.Text)).IdEmpleado.ToString();*/



                //limpiar();
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
                limpiar();
            }

            
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdTextBox.Text))
            {
                IdErrorProvider.SetError(IdTextBox, "Favor Digitar el ID");
            }
            else
            {
                


                CargoTextBox.Text = EmpleadosBLL.Modificar(Convert.ToInt32(IdTextBox.Text)).Cargo;
                CedulaTextBox.Text = EmpleadosBLL.Modificar(Convert.ToInt32(IdTextBox.Text)).Cedula;
                CelTextBox.Text = EmpleadosBLL.Modificar(Convert.ToInt32(IdTextBox.Text)).Celular;
                DirecTextBox.Text = EmpleadosBLL.Modificar(Convert.ToInt32(IdTextBox.Text)).Direccion;
                NameTextBox.Text = EmpleadosBLL.Modificar(Convert.ToInt32(IdTextBox.Text)).Nombre;
                TelTextBox.Text = EmpleadosBLL.Modificar(Convert.ToInt32(IdTextBox.Text)).Telefono;
                IdTextBox.Text = EmpleadosBLL.Modificar(Convert.ToInt32(IdTextBox.Text)).IdEmpleado.ToString();
                SueldoTextBox.Text = EmpleadosBLL.Modificar(Convert.ToInt32(IdTextBox.Text)).Sueldo.ToString();
                IncentivoTextBox.Text = EmpleadosBLL.Modificar(Convert.ToInt32(IdTextBox.Text)).Incentivo.ToString();

            }


            

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Empleados empleado = new Empleados();
            /*empleado.Activo = true;
            empleado.Cargo = CargoTextBox.Text;
            empleado.Cedula = CedulaTextBox.Text;
            empleado.Celular = CelTextBox.Text;
            empleado.Direccion = DirecTextBox.Text;
            empleado.Incentivo = float.Parse(IncentivoTextBox.Text);
            empleado.Nombre = NameTextBox.Text;
            empleado.Sueldo = float.Parse(SueldoTextBox.Text);
            empleado.Telefono = TelTextBox.Text;*/

            empleado.Activo = true;
            empleado.Cargo = "Jefe";
            empleado.Cedula = "402-2437519-2";
            empleado.Celular = "809-577-4546";
            empleado.Direccion = "Salcedo RD";
            empleado.Incentivo = 15.2f;
            empleado.Nombre = "Hugo Jimenez";
            empleado.Sueldo = 8500.2222f;
            empleado.Telefono = "809-577-6469";
            EmpleadosBLL.Insertar(empleado);
            limpiar();
        }
    }
}
