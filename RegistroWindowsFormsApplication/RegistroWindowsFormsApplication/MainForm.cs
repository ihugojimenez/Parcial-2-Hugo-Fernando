﻿using BLL;
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
            

            
            
            
        }

        private void registrarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.Show();
           
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaForm cf = new ConsultaForm();
            cf.Show();
        }
    }
}
