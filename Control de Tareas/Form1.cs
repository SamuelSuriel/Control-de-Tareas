namespace Control_de_Tareas
{
    public partial class frmTareas : Form
    {
        CD_Conexion conexion = new CD_Conexion();
        ControldeTareas_Datos controlDeTareasDatos = new ControldeTareas_Datos();
        private string? idTarea = null;
        private bool EsEditar = false;

        public frmTareas()
        {
            InitializeComponent();
            CargarTareas(0);
            LimpiarCampos();
        }


        private void CargarTareas(int id)
        {
            dgvTareas.DataSource = controlDeTareasDatos.MostrarTareas(id);
            this.dgvTareas.Columns["IdTarea"].Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscarTarea.Text != "")
            {
                int TareaID = int.Parse(txtBuscarTarea.Text);

                if (TareaID > 0)
                    CargarTareas(TareaID);
                else
                    MessageBox.Show("Ingrese un código numérico valido!");
            }
            else
                CargarTareas(0);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombreTarea.Text == "" || txtDescripcion.Text == "" || cbEstado.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            else if (dtFechaVencimiento.Value < DateTime.Now)
            {
                MessageBox.Show("Por favor, ingrese una fecha mayor a la actual.");
                return;
            }
            else
            {
                string nombre = txtNombreTarea.Text;
                string descripcion = txtDescripcion.Text;
                DateTime vencimiento = Convert.ToDateTime(dtFechaVencimiento.Value);
                string estado = (string)cbEstado.SelectedItem;

                if (EsEditar == false)
                {
                    try
                    {
                        controlDeTareasDatos.InsertarTarea(nombre, descripcion, vencimiento, estado);
                        MessageBox.Show("SE INSERTÓ CORRECTAMENTE!");
                        LimpiarCampos();
                        CargarTareas(0);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("no se pudo realizar la operación: " + ex);
                    }
                }
                if (EsEditar == true)
                {
                    try
                    {
                        int id = Convert.ToInt32(idTarea);
                        controlDeTareasDatos.EditarTarea(Convert.ToInt32(id), nombre, descripcion, vencimiento, estado);
                        MessageBox.Show("Se editó correctamente!");
                        LimpiarCampos();
                        CargarTareas(0);
                        EsEditar = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("no se pudo realizar la operación: " + ex);
                    }
                }
            }

        }

        private void LimpiarCampos()
        {
            txtBuscarTarea.Clear();
            txtNombreTarea.Clear();
            txtDescripcion.Clear();
            cbEstado.Text = "";
            dtFechaVencimiento.Value = DateTime.Now;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedCells.Count > 0)
            {
                EsEditar = true;
                txtNombreTarea.Text = dgvTareas.CurrentRow.Cells["NombreTarea"].Value.ToString();
                txtDescripcion.Text = dgvTareas.CurrentRow.Cells["DescripcionTarea"].Value.ToString();
                cbEstado.Text = dgvTareas.CurrentRow.Cells["EstadoTarea"].Value.ToString();
                dtFechaVencimiento.Text = dgvTareas.CurrentRow.Cells["FechaVencimientoTarea"].Value.ToString();
                idTarea = dgvTareas.CurrentRow.Cells["IdTarea"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una celda para editar!");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedCells.Count > 0)
            {
                string message = "¿Estás seguro de que quieres eliminar a esta tarea?";
                string title = "Eliminar Tarea";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    idTarea = dgvTareas.CurrentRow.Cells["IdTarea"].Value.ToString();
                    controlDeTareasDatos.EliminarTarea(Convert.ToInt32(idTarea));
                    MessageBox.Show("Se eliminó correctamente!");
                    CargarTareas(0);
                }
            }
            else
                MessageBox.Show("Seleccione una celda para eliminar!");
        }

        private void btnMarcarCompletada_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedCells.Count > 0)
            {
                try
                {
                    string nombre = dgvTareas.CurrentRow.Cells["NombreTarea"].Value.ToString();
                    string descripcion = dgvTareas.CurrentRow.Cells["DescripcionTarea"].Value.ToString();
                    string vencimiento = dgvTareas.CurrentRow.Cells["FechaVencimientoTarea"].Value.ToString();
                    string estado = "Completada";
                    idTarea = dgvTareas.CurrentRow.Cells["IdTarea"].Value.ToString();

                    controlDeTareasDatos.EditarTarea(Convert.ToInt32(idTarea), nombre, descripcion, Convert.ToDateTime(vencimiento), estado);
                    MessageBox.Show("Se marcó como completada!");
                    CargarTareas(0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo realizar la operación: " + ex);
                }
            }
            else
                MessageBox.Show("Seleccione una celda para completar!");
        }

        private void txtBuscarTarea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
