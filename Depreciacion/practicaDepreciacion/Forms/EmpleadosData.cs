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
        public EmpleadosData(Panel mainPanel, Panel secPanel)
        {
            this.mainPanel = mainPanel;
            this.secPanel = secPanel;
            InitializeComponent();
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
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
    }
}
