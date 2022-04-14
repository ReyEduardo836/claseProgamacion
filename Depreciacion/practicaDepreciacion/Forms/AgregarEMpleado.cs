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
        Empleado empleadoEdit;
        public AgregarEmpleado(Panel mainPanel, Panel secPanel, IEmpleadoServices empleadoService)
        {
            this.empleadoService = empleadoService;
            this.mainPanel = mainPanel;
            this.secPanel = secPanel;
            InitializeComponent();
            this.btnAgregarEmpleado.Text = "Agregar Empleado";
            this.label7.Text = "Agregar Empleado";
        }
        public AgregarEmpleado(Panel mainPanel, Panel secPanel, Empleado empleado, IEmpleadoServices empleadoService)
        {
            this.empleadoService = empleadoService;
            this.mainPanel = mainPanel;
            this.secPanel = secPanel;
            this.empleadoEdit = empleado;
            InitializeComponent();
            llenarCampos();
            this.btnAgregarEmpleado.Text = "Editar Empleado";
            this.label7.Text = "Editar Empleado";
        }

        private void llenarCampos()
        {
            this.txtNombre.Text = empleadoEdit.Nombre;
            this.txtApellido.Text = empleadoEdit.Apellido;
            this.txtCedula.Text = empleadoEdit.Cedula;
            this.txtDireccion.Text = empleadoEdit.Direccion;
            this.txtTelefono.Text = empleadoEdit.Telefono;
            this.txtEmail.Text = empleadoEdit.Email;
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
                if (empleadoEdit == null)
                {
                    int id = empleadoService.Add(empleado);
                    empleado.Id = id;
                    Form1.addEmpleado(empleado);
                }
                else
                {
                    empleado.Id = empleadoEdit.Id;
                    empleadoService.Update(empleado);
                    string nombreAnterior = $"{empleadoEdit.Nombre} {empleadoEdit.Apellido}";
                    Form1.updateEmpleado(empleado, nombreAnterior);
                }
                cleanData();
                previousScreen();
            }
            else
            {
                MessageBox.Show("Tienes que llenar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEmpleadosDg_Click(object sender, EventArgs e)
        {
            if(mainPanel.Controls.Count > 0)
            {
                mainPanel.Controls.RemoveAt(0);
            }
            EmpleadosData empleadosData = new EmpleadosData(mainPanel, this.PnlAgregarEmpleado, empleadoService);
            empleadosData.TopLevel = false;
            mainPanel.Controls.Add(empleadosData);
            empleadosData.Show();
        }
    }
}
