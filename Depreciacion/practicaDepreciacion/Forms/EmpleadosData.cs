using AppCore.IServices;
using Domain.Entities;
using Domain.Interfaces;
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
    public partial class EmpleadosData : Form
    {
        Panel mainPanel;
        Panel secPanel;
        IEmpleadoServices empleadoService;
        public EmpleadosData(Panel mainPanel, Panel secPanel, IEmpleadoServices empleadoService)
        {
            this.empleadoService = empleadoService;
            this.mainPanel = mainPanel;
            this.secPanel = secPanel;
            InitializeComponent();
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            dgvEmpleadosData.DataSource = null;
            dgvEmpleadosData.DataSource = Form1.getEmpleados();
        }

        private void dgvEmpleadosData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!e.Button.Equals(MouseButtons.Right)) return;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            dgvEmpleadosData.CurrentCell = dgvEmpleadosData.Rows[e.RowIndex].Cells[e.ColumnIndex];
            this.contextMenuStrip1.Show(Cursor.Position);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if(mainPanel.Controls.Count > 0)
            {
                mainPanel.Controls.RemoveAt(0);
            }
            mainPanel.Controls.Add(secPanel);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dgvEmpleadosData.CurrentRow.Cells[0].Value;
            string nombre = $"{dgvEmpleadosData.CurrentRow.Cells[2].Value} {dgvEmpleadosData.CurrentRow.Cells[3].Value}";
            if (empleadoService.Delete(id))
            {
                //dgvEmpleadosData.Rows.Remove(dgvEmpleadosData.CurrentRow);
                Form1.removeEmpleado(id, nombre);
                LoadDataGrid();
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado()
            {
                Id = (int)dgvEmpleadosData.CurrentRow.Cells[0].Value,
                Cedula = (string)dgvEmpleadosData.CurrentRow.Cells[1].Value,
                Nombre = (string)dgvEmpleadosData.CurrentRow.Cells[2].Value,
                Apellido = (string)dgvEmpleadosData.CurrentRow.Cells[3].Value,
                Direccion = (string)dgvEmpleadosData.CurrentRow.Cells[4].Value,
                Telefono = (string)dgvEmpleadosData.CurrentRow.Cells[5].Value,
                Email = (string)dgvEmpleadosData.CurrentRow.Cells[6].Value
            };
            AgregarEmpleado editarEmpleado = new AgregarEmpleado(mainPanel, this.pnlEmpleadosData, empleado, empleadoService);
            if(mainPanel.Controls.Count > 0)
            {
                mainPanel.Controls.RemoveAt(0);
            }
            editarEmpleado.TopLevel = false;
            mainPanel.Controls.Add(editarEmpleado);
            editarEmpleado.Show();
        }
    }
}
