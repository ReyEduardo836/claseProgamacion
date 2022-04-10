using AppCore.IServices;
using Domain.Entities;
using Domain.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaDepreciacion.Forms
{
    public partial class AgregarEmpleado : Form
    {
        Panel mainPanel;
        Panel secPanel;
        IEmpleadoServices empleadoService;
        public AgregarEmpleado(Panel mainPanel, Panel secPanel, IEmpleadoServices empleadoService)
        {
            this.empleadoService = empleadoService;
            this.mainPanel = mainPanel;
            this.secPanel = secPanel;
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            previousScreen();
        }

        private void previousScreen()
        {
            this.mainPanel.Controls.RemoveAt(0);
            this.mainPanel.Controls.Add(secPanel);
        }

        private void cleanData()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtCedula.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            string[] campos = { txtNombre.Text, txtCedula.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text};
            if (!StringHelper.Wspaces(campos))
            {
                Empleado empleado = new Empleado()
                {
                    Cedula = txtCedula.Text,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text,
                    Email = txtEmail.Text
                };
                empleadoService.Add(empleado);
                cleanData();
                previousScreen();
                Form1.addEmpleado(empleado);
            }
            else
            {
                MessageBox.Show("Tienes que llenar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
