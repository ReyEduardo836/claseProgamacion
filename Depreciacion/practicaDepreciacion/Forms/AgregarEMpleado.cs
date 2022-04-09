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
        public AgregarEmpleado(Panel mainPanel, Panel secPanel, IEmpleado )
        {
            this.mainPanel = mainPanel;
            this.secPanel = secPanel;
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.RemoveAt(0);
            this.mainPanel.Controls.Add(secPanel);
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            string[] campos = { txtNombre.Text, txtApellido.Text, txtCedula.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text};
            if (StringHelper.Wspaces(campos))
            {
                //Activo activo = new Activo()
                //{
                //    Nombre = txtNombre.Text,
                //    Valor = double.Parse(txtValor.Text),
                //    ValorResidual = double.Parse(txtValorR.Text),
                //    VidaUtil = int.Parse(txtVidaU.Text)
                //};
                //activoServices.Add(activo);
                ////        dataGridView1.DataSource = null;
                //limpiar();
                //dataGridView1.DataSource = activoServices.Read();
            }
            else
            {
                MessageBox.Show("Tienes que llenar todos los formularios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
