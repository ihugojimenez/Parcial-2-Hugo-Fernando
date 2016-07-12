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
    public partial class ConsultaForm : Form
    {
        public ConsultaForm()
        {
            InitializeComponent();
        }

        private void ConsultButton_Click(object sender, EventArgs e)
        {
            ConsultDataGridView.DataSource = EmpleadosBLL.getList();
        }
    }
}
