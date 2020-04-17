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
using CNegocio.Peticiones;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CPresentacion
{
    public partial class FrmAlumnos : Form
    {
        CNAlumnos _CNAlumnos = new CNAlumnos();
        CNTutores _CNTutores = new CNTutores();
        List<CNPeticionesTutores> listaTutores = new List<CNPeticionesTutores>();
        List<CNPeticionesTutoresAlumnos> listaTutoresAlumnos = new List<CNPeticionesTutoresAlumnos>();
        DateTime fechaMinima;
        DateTime fechaMaxima;
        bool crear = true;
        int idEstudiante = 0;
        List<CNPeticionesTutoresAlumnos> listaTutoresDelAlumno = new List<CNPeticionesTutoresAlumnos>();
        public FrmAlumnos()
        {
            InitializeComponent();
            fechaMinima = DateTime.Now.AddYears(-60);
            fechaMaxima = DateTime.Now.AddYears(-3);
        }

        private void CargarGrid()
        {
            this.dataGridView1.DataSource = _CNAlumnos.GetAllAlumnos();
            this.cargarListaTutores();
            this.cargarListaTutoresAlumnos();
            llenarPanelRight();
        }

        public void cargarListaTutores ()
        {
            DataTable tabla = _CNTutores.GetAllTutores();
            foreach (DataRow row in tabla.Rows)
            {
                CNPeticionesTutores tutor = new CNPeticionesTutores()
                {
                    IdTutor = int.Parse(row[0].ToString()),
                    Nombre = row[1].ToString(),
                    Cedula = row[2].ToString(),
                    Direccion = row[3].ToString(),
                    Telefono = row[4].ToString(),
                    CentroTrabajo = row[5].ToString()
                };
                listaTutores.Add(tutor);
            }
        }

        public void cargarListaTutoresAlumnos()
        {
            DataTable tabla = _CNAlumnos.GetAllTutoresAlumnos();
            foreach (DataRow row in tabla.Rows)
            {
                CNPeticionesTutoresAlumnos tutorAlumno = new CNPeticionesTutoresAlumnos()
                {
                    IdTutAlumnos = int.Parse(row[0].ToString()),
                    IdTutor = int.Parse(row[1].ToString()),
                    IdAlumno = int.Parse(row[2].ToString()),
                    Parentesco = row[3].ToString()
                };
                listaTutoresAlumnos.Add(tutorAlumno);
            }
        }

        private void CargarComboBoxs()
        {
            this.cmbTutor1.DataSource = listaTutores.ToList();
            this.cmbTutor1.SelectedItem = null;
            this.cmbTutor2.DataSource = listaTutores.ToList();
            this.cmbTutor2.SelectedItem = null;
            this.cmbTutor3.DataSource = listaTutores.ToList();
            this.cmbTutor3.SelectedItem = null;
            this.txtParentesco1.Clear();
            this.txtParentesco2.Clear();
            this.txtParentesco3.Clear();
        }

        private void FrmAlumnos_Load(object sender, EventArgs e)
        {
            CargarGrid();
            CargarComboBoxs();
            this.dtpFechaNacimiento.MinDate = fechaMinima;
            this.dtpFechaNacimiento.MaxDate = fechaMaxima;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.panelRight.Enabled = false;
            this.vaciarPanelRight();
            this.lblTitutlo.Text = "Crear";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.lblTitutlo.Text = "Crear";
            this.panelRight.Enabled = true;
            this.crear = true;
            this.vaciarPanelRight();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.panelRight.Enabled)
            {
                this.vaciarPanelRight();
                this.llenarPanelRight();
            }
            this.panelRight.Enabled = true;
            this.crear = false;
            this.lblTitutlo.Text = "Editar";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!this.panelRight.Enabled)
                llenarPanelRight();
        }

        private void vaciarPanelRight()
        {
            this.txtNombre.Clear();
            this.txtApellido.Clear();
            this.dtpFechaNacimiento.Value = fechaMinima;
            this.txtDireccion.Clear();
            this.txtCodigoEstudiante.Clear();
            this.txtParentesco1.Clear();
            this.txtParentesco2.Clear();
            this.txtParentesco3.Clear();
            this.cmbTutor1.SelectedItem = null;
            this.cmbTutor2.SelectedItem = null;
            this.cmbTutor3.SelectedItem = null;
            this.listaTutoresDelAlumno.Clear();
        }

        private void llenarPanelRight()
        {
            try
            {
                if (dataGridView1.CurrentRow.Index != null && dataGridView1.CurrentRow.Index >= 0)
                {
                    //obtengo todos los datos del alumno desde el datagridview
                    this.idEstudiante = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                    string nombre = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                    string apellido = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                    DateTime fecha = DateTime.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString());
                    string direccion = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                    string codigoInss = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
                    //recorrer las tablas tutores y tutoresalumnos para obtener los tutores del alumno con su parentesco
                    var listaTutoresDelAlumnoTemp = listaTutores.Join(listaTutoresAlumnos,
                            tutor => tutor.IdTutor,
                            tutorAlumno => tutorAlumno.IdTutor,
                            (tutor, tutorAlumno) => new { CNPeticionesTutores = tutor, CNPeticionesTutoresAlumnos = tutorAlumno })
                        .Where(tutorA => tutorA.CNPeticionesTutoresAlumnos.IdAlumno == idEstudiante).ToList();
                    //asigno a un array los 3 combobox del formulario
                    List<ComboBox> comboBoxs = new List<ComboBox>();
                    comboBoxs.Add(cmbTutor1);
                    comboBoxs.Add(cmbTutor2);
                    comboBoxs.Add(cmbTutor3);
                    List<TextBox> listaParentescos = new List<TextBox>();
                    listaParentescos.Add(txtParentesco1);
                    listaParentescos.Add(txtParentesco2);
                    listaParentescos.Add(txtParentesco3);
                    this.listaTutoresDelAlumno.Clear();
                    //insertar los tutores en un bucle de 3 ciclos, cuando no tenga un tutor entonces se pone en vacio en combobox
                    for (int i = 0; i < 3; i++)
                    {
                        if (listaTutoresDelAlumnoTemp.Count - 1 < i)
                        {
                            comboBoxs[i].SelectedItem = null;
                            listaParentescos[i].Text = "";
                        }
                        else
                        {
                            comboBoxs[i].SelectedValue = listaTutoresDelAlumnoTemp[i].CNPeticionesTutores.IdTutor;
                            this.listaTutoresDelAlumno.Add(listaTutoresDelAlumnoTemp[i].CNPeticionesTutoresAlumnos);
                            listaParentescos[i].Text = listaTutoresDelAlumnoTemp[i].CNPeticionesTutoresAlumnos.Parentesco;
                        }
                    }
                    txtNombre.Text = nombre;
                    txtApellido.Text = apellido;
                    dtpFechaNacimiento.Value = fecha;
                    txtCodigoEstudiante.Text = codigoInss;
                    txtDireccion.Text = direccion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.crear)
                {
                    if (txtNombre.Text.Length > 2 && txtApellido.Text.Length > 2 && txtCodigoEstudiante.Text.Length>5 && txtDireccion.Text.Length > 5)
                    {
                        if ((cmbTutor1.SelectedItem != null && cmbTutor2.SelectedItem != null) || (cmbTutor1.SelectedItem != null && cmbTutor3.SelectedItem != null) || (cmbTutor3.SelectedItem != null && cmbTutor2.SelectedItem != null))
                        {
                            CNPeticionesAlumnos alumo = new CNPeticionesAlumnos()
                            {
                                Nombre = txtNombre.Text.Trim(),
                                Apellidos = txtApellido.Text.Trim(),
                                FechaNacimiento = dtpFechaNacimiento.Value,
                                Direccion = txtDireccion.Text.Trim(),
                                CodEstudiante = txtCodigoEstudiante.Text.Trim()
                            };
                            List<CNPeticionesTutoresAlumnos> listaTutoresAlumnos = new List<CNPeticionesTutoresAlumnos>();
                            List<ComboBox> listaComboBox = new List<ComboBox>();
                            List<TextBox> listaTextBoxs = new List<TextBox>();
                            listaComboBox.Add(cmbTutor1);
                            listaComboBox.Add(cmbTutor2);
                            listaComboBox.Add(cmbTutor3);
                            listaTextBoxs.Add(txtParentesco1);
                            listaTextBoxs.Add(txtParentesco2);
                            listaTextBoxs.Add(txtParentesco3);

                            for ( int i = 0; i < 3; i++)
                            {
                                if (listaComboBox[i].SelectedItem == null)
                                    continue;
                                else
                                {
                                    CNPeticionesTutoresAlumnos tutorAlumno = new CNPeticionesTutoresAlumnos()
                                    {
                                        IdTutor = int.Parse(listaComboBox[i].SelectedValue.ToString()),
                                        Parentesco = listaTextBoxs[i].Text.Trim()
                                    };
                                    listaTutoresAlumnos.Add(tutorAlumno);
                                }
                            }

                            int result = _CNAlumnos.insertarAlumno(alumo, listaTutoresAlumnos);
                            if (result >= 3)
                            {
                                MessageBox.Show("Datos guardados");
                            }
                            this.CargarGrid();
                            this.vaciarPanelRight();
                            this.CargarComboBoxs();
                            this.cargarListaTutoresAlumnos();
                        } else
                        {
                            MessageBox.Show("Debe ingresar al menos 2 tutores");
                        }
                    } else
                    {
                        MessageBox.Show("llene los cambos del alumno");
                    }
                } else
                {
                    if (txtNombre.Text.Length > 2 && txtApellido.Text.Length > 2 && txtCodigoEstudiante.Text.Length > 5 && txtDireccion.Text.Length > 5)
                    {
                        if ((cmbTutor1.SelectedItem != null && cmbTutor2.SelectedItem != null) || (cmbTutor1.SelectedItem != null && cmbTutor3.SelectedItem != null) || (cmbTutor3.SelectedItem != null && cmbTutor2.SelectedItem != null))
                        {
                            CNPeticionesAlumnos alumo = new CNPeticionesAlumnos()
                            {
                                IdAlumno = this.idEstudiante,
                                Nombre = txtNombre.Text.Trim(),
                                Apellidos = txtApellido.Text.Trim(),
                                FechaNacimiento = dtpFechaNacimiento.Value,
                                Direccion = txtDireccion.Text.Trim(),
                                CodEstudiante = txtCodigoEstudiante.Text.Trim()
                            };
                            List<CNPeticionesTutoresAlumnos> listaTutoresAlumnos = new List<CNPeticionesTutoresAlumnos>();
                            List<ComboBox> listaComboBox = new List<ComboBox>();
                            List<TextBox> listaTextBoxs = new List<TextBox>();
                            listaComboBox.Add(cmbTutor1);
                            listaComboBox.Add(cmbTutor2);
                            listaComboBox.Add(cmbTutor3);
                            listaTextBoxs.Add(txtParentesco1);
                            listaTextBoxs.Add(txtParentesco2);
                            listaTextBoxs.Add(txtParentesco3);

                            for (int i = 0; i < 3; i++)
                            {
                                CNPeticionesTutoresAlumnos tutorAlumno;
                                if (listaComboBox[i].SelectedItem == null)
                                {
                                    continue;
                                }
                                else if (this.listaTutoresDelAlumno.Count > i)
                                {
                                    tutorAlumno = new CNPeticionesTutoresAlumnos()
                                    {
                                        IdTutAlumnos = this.listaTutoresDelAlumno[i].IdTutAlumnos,
                                        IdAlumno = alumo.IdAlumno,
                                        IdTutor = int.Parse(listaComboBox[i].SelectedValue.ToString()),
                                        Parentesco = listaTextBoxs[i].Text.Trim()
                                    };
                                } else
                                {
                                    tutorAlumno = new CNPeticionesTutoresAlumnos()
                                    {
                                        IdAlumno = alumo.IdAlumno,
                                        IdTutor = int.Parse(listaComboBox[i].SelectedValue.ToString()),
                                        Parentesco = listaTextBoxs[i].Text.Trim()
                                    };
                                }
                                listaTutoresAlumnos.Add(tutorAlumno);
                            }

                            int result = _CNAlumnos.actualizarAlumno(alumo, listaTutoresAlumnos);
                            if (result >= 3)
                            {
                                MessageBox.Show("Datos guardados");
                            }
                            this.CargarGrid();
                            this.vaciarPanelRight();
                            this.cargarListaTutoresAlumnos();
                            this.CargarComboBoxs();
                            this.panelRight.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar al menos 2 tutores");
                        }
                    }
                    else
                    {
                        MessageBox.Show("llene los cambos del alumno");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
