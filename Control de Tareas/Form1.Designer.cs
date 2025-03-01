namespace Control_de_Tareas
{
    partial class frmTareas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnMarcarCompletada = new Button();
            btnBuscar = new Button();
            label2 = new Label();
            txtNombreTarea = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtFechaVencimiento = new DateTimePicker();
            dgvTareas = new DataGridView();
            cbEstado = new ComboBox();
            txtBuscarTarea = new TextBox();
            label6 = new Label();
            txtDescripcion = new RichTextBox();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTareas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 9);
            label1.Name = "label1";
            label1.Size = new Size(581, 42);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Control de Tareas";
            // 
            // btnAgregar
            // 
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderColor = Color.Navy;
            btnAgregar.Font = new Font("Lucida Sans", 12F);
            btnAgregar.ForeColor = Color.Green;
            btnAgregar.Location = new Point(388, 396);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(113, 42);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.Control;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderColor = Color.Navy;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Lucida Sans", 12F);
            btnEliminar.ForeColor = Color.Red;
            btnEliminar.Location = new Point(670, 396);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(113, 42);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnMarcarCompletada
            // 
            btnMarcarCompletada.Cursor = Cursors.Hand;
            btnMarcarCompletada.FlatAppearance.BorderColor = Color.Navy;
            btnMarcarCompletada.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMarcarCompletada.ForeColor = Color.Orange;
            btnMarcarCompletada.Location = new Point(567, 348);
            btnMarcarCompletada.Name = "btnMarcarCompletada";
            btnMarcarCompletada.Size = new Size(216, 42);
            btnMarcarCompletada.TabIndex = 3;
            btnMarcarCompletada.Text = "Marcar como Completada";
            btnMarcarCompletada.UseVisualStyleBackColor = true;
            btnMarcarCompletada.Click += btnMarcarCompletada_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderColor = Color.Navy;
            btnBuscar.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.Blue;
            btnBuscar.Location = new Point(673, 94);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 30);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 12F);
            label2.Location = new Point(28, 82);
            label2.Name = "label2";
            label2.Size = new Size(202, 23);
            label2.TabIndex = 5;
            label2.Text = "Nombre de la Tarea";
            // 
            // txtNombreTarea
            // 
            txtNombreTarea.Font = new Font("Lucida Sans", 12F);
            txtNombreTarea.Location = new Point(31, 108);
            txtNombreTarea.Name = "txtNombreTarea";
            txtNombreTarea.Size = new Size(247, 31);
            txtNombreTarea.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 12F);
            label3.Location = new Point(28, 376);
            label3.Name = "label3";
            label3.Size = new Size(227, 23);
            label3.TabIndex = 7;
            label3.Text = "Fecha de Vencimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans", 12F);
            label4.Location = new Point(28, 142);
            label4.Name = "label4";
            label4.Size = new Size(125, 23);
            label4.TabIndex = 9;
            label4.Text = "Descripción";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans", 12F);
            label5.Location = new Point(28, 300);
            label5.Name = "label5";
            label5.Size = new Size(82, 23);
            label5.TabIndex = 11;
            label5.Text = "Estado ";
            // 
            // dtFechaVencimiento
            // 
            dtFechaVencimiento.Font = new Font("Lucida Sans", 12F);
            dtFechaVencimiento.Location = new Point(28, 402);
            dtFechaVencimiento.Name = "dtFechaVencimiento";
            dtFechaVencimiento.Size = new Size(250, 31);
            dtFechaVencimiento.TabIndex = 12;
            // 
            // dgvTareas
            // 
            dgvTareas.BackgroundColor = SystemColors.Control;
            dgvTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTareas.Location = new Point(318, 131);
            dgvTareas.Name = "dgvTareas";
            dgvTareas.RowHeadersWidth = 51;
            dgvTareas.Size = new Size(465, 211);
            dgvTareas.TabIndex = 15;
            // 
            // cbEstado
            // 
            cbEstado.Font = new Font("Lucida Sans", 12F);
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "Pendiente", "En Progreso", "Completada" });
            cbEstado.Location = new Point(28, 326);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(245, 31);
            cbEstado.TabIndex = 16;
            // 
            // txtBuscarTarea
            // 
            txtBuscarTarea.Font = new Font("Lucida Sans", 12F);
            txtBuscarTarea.Location = new Point(318, 94);
            txtBuscarTarea.Name = "txtBuscarTarea";
            txtBuscarTarea.PlaceholderText = "Ingrese el código de la tarea.";
            txtBuscarTarea.Size = new Size(349, 31);
            txtBuscarTarea.TabIndex = 17;
            txtBuscarTarea.KeyPress += txtBuscarTarea_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(754, 9);
            label6.Name = "label6";
            label6.Size = new Size(30, 17);
            label6.TabIndex = 18;
            label6.Text = "SRS";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(28, 168);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(250, 129);
            txtDescripcion.TabIndex = 19;
            txtDescripcion.Text = "";
            // 
            // btnActualizar
            // 
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.BorderColor = Color.Navy;
            btnActualizar.Font = new Font("Lucida Sans", 12F);
            btnActualizar.ForeColor = Color.Yellow;
            btnActualizar.Location = new Point(527, 396);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(122, 42);
            btnActualizar.TabIndex = 20;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // frmTareas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnActualizar);
            Controls.Add(txtDescripcion);
            Controls.Add(label6);
            Controls.Add(txtBuscarTarea);
            Controls.Add(cbEstado);
            Controls.Add(dgvTareas);
            Controls.Add(dtFechaVencimiento);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNombreTarea);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(btnMarcarCompletada);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "frmTareas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TAREAS";
            ((System.ComponentModel.ISupportInitialize)dgvTareas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnMarcarCompletada;
        private Button btnBuscar;
        private Label label2;
        private TextBox txtNombreTarea;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtFechaVencimiento;
        private DataGridView dgvTareas;
        private ComboBox cbEstado;
        private TextBox txtBuscarTarea;
        private Label label6;
        private RichTextBox txtDescripcion;
        private Button btnActualizar;
    }
}
