namespace practicaDepreciacion
{
    partial class Form1
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtValorR = new System.Windows.Forms.TextBox();
            this.txtVidaU = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.flpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cmbDepreciacion = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Descripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.Empleado = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.flpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(3, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.txtEnviar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(106, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(189, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyUp);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(106, 162);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(189, 20);
            this.txtValor.TabIndex = 2;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress_1);
            // 
            // txtValorR
            // 
            this.txtValorR.Location = new System.Drawing.Point(106, 188);
            this.txtValorR.Name = "txtValorR";
            this.txtValorR.Size = new System.Drawing.Size(189, 20);
            this.txtValorR.TabIndex = 3;
            this.txtValorR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorR_KeyPress);
            // 
            // txtVidaU
            // 
            this.txtVidaU.Location = new System.Drawing.Point(106, 214);
            this.txtVidaU.Name = "txtVidaU";
            this.txtVidaU.Size = new System.Drawing.Size(189, 20);
            this.txtVidaU.TabIndex = 4;
            this.txtVidaU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVidaU_KeyPress);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(56, 38);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 5;
            this.Nombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor residual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vida util";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(382, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(526, 235);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(84, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.comboBox1);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.Add(this.Empleado);
            this.gbInfo.Controls.Add(this.txtEmpleado);
            this.gbInfo.Controls.Add(this.txtDescripcion);
            this.gbInfo.Controls.Add(this.Descripcion);
            this.gbInfo.Controls.Add(this.Nombre);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.txtNombre);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.txtValor);
            this.gbInfo.Controls.Add(this.txtVidaU);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.txtValorR);
            this.gbInfo.Location = new System.Drawing.Point(12, 15);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(345, 310);
            this.gbInfo.TabIndex = 11;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Información";
            // 
            // flpBotones
            // 
            this.flpBotones.Controls.Add(this.btnAceptar);
            this.flpBotones.Controls.Add(this.btnEliminar);
            this.flpBotones.Controls.Add(this.btnActualizar);
            this.flpBotones.Controls.Add(this.btnNuevo);
            this.flpBotones.Location = new System.Drawing.Point(21, 331);
            this.flpBotones.Name = "flpBotones";
            this.flpBotones.Size = new System.Drawing.Size(244, 72);
            this.flpBotones.TabIndex = 12;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(165, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(3, 32);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // cmbDepreciacion
            // 
            this.cmbDepreciacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepreciacion.FormattingEnabled = true;
            this.cmbDepreciacion.Location = new System.Drawing.Point(410, 271);
            this.cmbDepreciacion.Name = "cmbDepreciacion";
            this.cmbDepreciacion.Size = new System.Drawing.Size(121, 21);
            this.cmbDepreciacion.TabIndex = 13;
            this.cmbDepreciacion.SelectedIndexChanged += new System.EventHandler(this.cmbDepreciacion_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(550, 271);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(358, 156);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(37, 58);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(63, 13);
            this.Descripcion.TabIndex = 10;
            this.Descripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(106, 58);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(189, 98);
            this.txtDescripcion.TabIndex = 11;
            this.txtDescripcion.Text = "";
            // 
            // Empleado
            // 
            this.Empleado.AutoSize = true;
            this.Empleado.Location = new System.Drawing.Point(6, 243);
            this.Empleado.Name = "Empleado";
            this.Empleado.Size = new System.Drawing.Size(94, 13);
            this.Empleado.TabIndex = 13;
            this.Empleado.Text = "Nombre Empleado";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(106, 240);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(189, 20);
            this.txtEmpleado.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Estado";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 264);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 449);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cmbDepreciacion);
            this.Controls.Add(this.flpBotones);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.flpBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtValorR;
        private System.Windows.Forms.TextBox txtVidaU;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.FlowLayoutPanel flpBotones;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cmbDepreciacion;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Label Empleado;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

