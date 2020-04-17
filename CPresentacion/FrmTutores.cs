using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNegocio;

namespace CPresentacion
{
    public partial class FrmTutores : Form
    {
        public CNTutores _CNTutores = new CNTutores();
        private int idTutor = 0;
        private bool Crear = true;
        public FrmTutores()
        {
            InitializeComponent();
        }

        private void FrmTutores_Load(object sender, EventArgs e)
        {
            CargarGrid();   
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Length > 7)
                {
                    int result;
                    if (Crear)
                    {
                        result = _CNTutores.InsertTutor(txtNombre.Text, txtCedula.Text, txtDireccion.Text, txtTelefono.Text, txtCentroTrabajo.Text);
                        if (result == 1)
                        {
                            CargarGrid();
                            MessageBox.Show("Datos guardados");
                            this.panelRight.Visible = false;
                        }
                    }
                    else if (idTutor > 0)
                    {
                        result = _CNTutores.ActualizarTutor(idTutor, txtNombre.Text, txtCedula.Text, txtDireccion.Text, txtTelefono.Text, txtCentroTrabajo.Text);
                        if (result == 1)
                        {
                            CargarGrid();
                            MessageBox.Show("Datos actualizados");
                            this.panelRight.Visible = false;
                        }
                    }
                    else
                    {
                        this.panelRight.Visible = false;
                        MessageBox.Show("IdTutor no fue seleccioado, pruebe a seleccionar un regitro de nuevo");
                    }
                }
                else
                {
                    MessageBox.Show("El nombre y apellido es requerido");
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("" + ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void CargarGrid()
        {
            try
            {
                this.dataGridView1.DataSource = _CNTutores.GetAllTutores();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("" + ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    idTutor = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            //    txtNombre.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            //    txtCedula.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            //    txtDireccion.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            //    txtTelefono.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
            //    txtCentroTrabajo.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if ( dataGridView1.CurrentRow.Index != null || dataGridView1.CurrentRow.Index >= 0)
            {
                idTutor = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                txtNombre.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txtCedula.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                txtDireccion.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                txtTelefono.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                txtCentroTrabajo.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
                this.panelRight.Visible = true;
                this.Crear = false;
                this.lblAccion.Text = "Actualizar";
            }
            else
            {
                MessageBox.Show("Seleccione un registro");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.panelRight.Visible = false;
            this.idTutor = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Crear = true;
            this.idTutor = 0;
            this.panelRight.Visible = true;
            this.lblAccion.Text = "Crear";
            this.limpiarFormulario();
        }

        private void limpiarFormulario ()
        {
            this.txtNombre.Text = "";
            this.txtTelefono.Text = "";
            this.txtCedula.Text = "";
            this.txtDireccion.Text = "";
            this.txtCentroTrabajo.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro de eliminar este registro", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if ( dialogResult == DialogResult.Yes )
                {
                    this.panelRight.Visible = false;
                    if (dataGridView1.CurrentRow.Index != null || dataGridView1.CurrentRow.Index >= 0)
                    {
                        idTutor = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);

                        int result = _CNTutores.EliminarTutor(idTutor);
                        if (result == 1)
                        {
                            CargarGrid();
                            MessageBox.Show("Registro eliminado");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un registro");
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("" + ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}
