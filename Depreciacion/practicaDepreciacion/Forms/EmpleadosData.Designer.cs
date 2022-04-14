
namespace practicaDepreciacion.Forms
{
    partial class EmpleadosData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlEmpleadosData = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmpleadosData = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlEmpleadosData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosData)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEmpleadosData
            // 
            this.pnlEmpleadosData.Controls.Add(this.btnRegresar);
            this.pnlEmpleadosData.Controls.Add(this.label1);
            this.pnlEmpleadosData.Controls.Add(this.dgvEmpleadosData);
            this.pnlEmpleadosData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmpleadosData.Location = new System.Drawing.Point(0, 0);
            this.pnlEmpleadosData.Name = "pnlEmpleadosData";
            this.pnlEmpleadosData.Size = new System.Drawing.Size(800, 450);
            this.pnlEmpleadosData.TabIndex = 0;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(39, 39);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empleados";
            // 
            // dgvEmpleadosData
            // 
            this.dgvEmpleadosData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleadosData.Location = new System.Drawing.Point(12, 92);
            this.dgvEmpleadosData.Name = "dgvEmpleadosData";
            this.dgvEmpleadosData.ReadOnly = true;
            this.dgvEmpleadosData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleadosData.Size = new System.Drawing.Size(776, 346);
            this.dgvEmpleadosData.TabIndex = 0;
            this.dgvEmpleadosData.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmpleadosData_CellMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // EmpleadosData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlEmpleadosData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpleadosData";
            this.Text = "EmpleadosData";
            this.pnlEmpleadosData.ResumeLayout(false);
            this.pnlEmpleadosData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosData)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmpleadosData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmpleadosData;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
    }
}