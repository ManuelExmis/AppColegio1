namespace CPresentacion
{
    partial class FrmAlumnos
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idAlumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codEstudianteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPeticionesAlumnosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cNPeticionesAlumnosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cNPeticionesAlumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtParentesco3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTutor3 = new System.Windows.Forms.ComboBox();
            this.cNPeticionesTutoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.txtParentesco2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTutor2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtParentesco1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTutor1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoEstudiante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblTitutlo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPeticionesAlumnosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPeticionesAlumnosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPeticionesAlumnosBindingSource)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cNPeticionesTutoresBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(9, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(598, 20);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlumnoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.codEstudianteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cNPeticionesAlumnosBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(9, 35);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(598, 526);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idAlumnoDataGridViewTextBoxColumn
            // 
            this.idAlumnoDataGridViewTextBoxColumn.DataPropertyName = "IdAlumno";
            this.idAlumnoDataGridViewTextBoxColumn.HeaderText = "IdAlumno";
            this.idAlumnoDataGridViewTextBoxColumn.Name = "idAlumnoDataGridViewTextBoxColumn";
            this.idAlumnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            this.fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codEstudianteDataGridViewTextBoxColumn
            // 
            this.codEstudianteDataGridViewTextBoxColumn.DataPropertyName = "CodEstudiante";
            this.codEstudianteDataGridViewTextBoxColumn.HeaderText = "CodEstudiante";
            this.codEstudianteDataGridViewTextBoxColumn.Name = "codEstudianteDataGridViewTextBoxColumn";
            this.codEstudianteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cNPeticionesAlumnosBindingSource2
            // 
            this.cNPeticionesAlumnosBindingSource2.DataSource = typeof(CNegocio.Peticiones.CNPeticionesAlumnos);
            // 
            // cNPeticionesAlumnosBindingSource1
            // 
            this.cNPeticionesAlumnosBindingSource1.DataSource = typeof(CNegocio.Peticiones.CNPeticionesAlumnos);
            // 
            // cNPeticionesAlumnosBindingSource
            // 
            this.cNPeticionesAlumnosBindingSource.DataSource = typeof(CNegocio.Peticiones.CNPeticionesAlumnos);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregar.Location = new System.Drawing.Point(449, 587);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditar.Location = new System.Drawing.Point(257, 587);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminar.Location = new System.Drawing.Point(69, 587);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelRight.Controls.Add(this.lblTitutlo);
            this.panelRight.Controls.Add(this.btnCancelar);
            this.panelRight.Controls.Add(this.txtParentesco3);
            this.panelRight.Controls.Add(this.label10);
            this.panelRight.Controls.Add(this.cmbTutor3);
            this.panelRight.Controls.Add(this.label11);
            this.panelRight.Controls.Add(this.txtParentesco2);
            this.panelRight.Controls.Add(this.label8);
            this.panelRight.Controls.Add(this.cmbTutor2);
            this.panelRight.Controls.Add(this.label9);
            this.panelRight.Controls.Add(this.txtParentesco1);
            this.panelRight.Controls.Add(this.label7);
            this.panelRight.Controls.Add(this.cmbTutor1);
            this.panelRight.Controls.Add(this.label6);
            this.panelRight.Controls.Add(this.btnGuardar);
            this.panelRight.Controls.Add(this.txtDireccion);
            this.panelRight.Controls.Add(this.label5);
            this.panelRight.Controls.Add(this.txtCodigoEstudiante);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.dtpFechaNacimiento);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.txtApellido);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Controls.Add(this.txtNombre);
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Enabled = false;
            this.panelRight.Location = new System.Drawing.Point(627, 3);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(283, 619);
            this.panelRight.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(199, 587);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtParentesco3
            // 
            this.txtParentesco3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParentesco3.Location = new System.Drawing.Point(96, 541);
            this.txtParentesco3.Name = "txtParentesco3";
            this.txtParentesco3.Size = new System.Drawing.Size(180, 20);
            this.txtParentesco3.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 548);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Parentesco:";
            // 
            // cmbTutor3
            // 
            this.cmbTutor3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTutor3.DataSource = this.cNPeticionesTutoresBindingSource;
            this.cmbTutor3.DisplayMember = "Nombre";
            this.cmbTutor3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTutor3.FormattingEnabled = true;
            this.cmbTutor3.Location = new System.Drawing.Point(28, 514);
            this.cmbTutor3.Name = "cmbTutor3";
            this.cmbTutor3.Size = new System.Drawing.Size(248, 21);
            this.cmbTutor3.TabIndex = 20;
            this.cmbTutor3.ValueMember = "IdTutor";
            // 
            // cNPeticionesTutoresBindingSource
            // 
            this.cNPeticionesTutoresBindingSource.DataSource = typeof(CNegocio.Peticiones.CNPeticionesTutores);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 489);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Tutor  #3:";
            // 
            // txtParentesco2
            // 
            this.txtParentesco2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParentesco2.Location = new System.Drawing.Point(95, 451);
            this.txtParentesco2.Name = "txtParentesco2";
            this.txtParentesco2.Size = new System.Drawing.Size(180, 20);
            this.txtParentesco2.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Parentesco:";
            // 
            // cmbTutor2
            // 
            this.cmbTutor2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTutor2.DataSource = this.cNPeticionesTutoresBindingSource;
            this.cmbTutor2.DisplayMember = "Nombre";
            this.cmbTutor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTutor2.FormattingEnabled = true;
            this.cmbTutor2.Location = new System.Drawing.Point(27, 424);
            this.cmbTutor2.Name = "cmbTutor2";
            this.cmbTutor2.Size = new System.Drawing.Size(248, 21);
            this.cmbTutor2.TabIndex = 16;
            this.cmbTutor2.ValueMember = "IdTutor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tutor  #2:";
            // 
            // txtParentesco1
            // 
            this.txtParentesco1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParentesco1.Location = new System.Drawing.Point(94, 367);
            this.txtParentesco1.Name = "txtParentesco1";
            this.txtParentesco1.Size = new System.Drawing.Size(180, 20);
            this.txtParentesco1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Parentesco:";
            // 
            // cmbTutor1
            // 
            this.cmbTutor1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTutor1.DataSource = this.cNPeticionesTutoresBindingSource;
            this.cmbTutor1.DisplayMember = "Nombre";
            this.cmbTutor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTutor1.FormattingEnabled = true;
            this.cmbTutor1.Location = new System.Drawing.Point(26, 340);
            this.cmbTutor1.Name = "cmbTutor1";
            this.cmbTutor1.Size = new System.Drawing.Size(248, 21);
            this.cmbTutor1.TabIndex = 12;
            this.cmbTutor1.ValueMember = "IdTutor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tutor  #1:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(118, 587);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.Location = new System.Drawing.Point(26, 256);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(248, 56);
            this.txtDireccion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dirección:";
            // 
            // txtCodigoEstudiante
            // 
            this.txtCodigoEstudiante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoEstudiante.Location = new System.Drawing.Point(26, 205);
            this.txtCodigoEstudiante.Name = "txtCodigoEstudiante";
            this.txtCodigoEstudiante.Size = new System.Drawing.Size(248, 20);
            this.txtCodigoEstudiante.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Codigo de estudiante:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(26, 155);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(248, 20);
            this.dtpFechaNacimiento.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellido.Location = new System.Drawing.Point(26, 104);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(248, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(26, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(248, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.42105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.57895F));
            this.tableLayoutPanel1.Controls.Add(this.panelRight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelLeft, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(913, 625);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.btnAgregar);
            this.panelLeft.Controls.Add(this.btnEditar);
            this.panelLeft.Controls.Add(this.btnEliminar);
            this.panelLeft.Controls.Add(this.textBox1);
            this.panelLeft.Controls.Add(this.dataGridView1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(3, 3);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(618, 619);
            this.panelLeft.TabIndex = 6;
            // 
            // lblTitutlo
            // 
            this.lblTitutlo.AutoSize = true;
            this.lblTitutlo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitutlo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitutlo.Location = new System.Drawing.Point(230, 6);
            this.lblTitutlo.Name = "lblTitutlo";
            this.lblTitutlo.Size = new System.Drawing.Size(44, 19);
            this.lblTitutlo.TabIndex = 24;
            this.lblTitutlo.Text = "Crear";
            // 
            // FrmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(913, 625);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmAlumnos";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.FrmAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPeticionesAlumnosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPeticionesAlumnosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPeticionesAlumnosBindingSource)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cNPeticionesTutoresBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigoEstudiante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource cNPeticionesAlumnosBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.TextBox txtParentesco3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbTutor3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtParentesco2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTutor2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtParentesco1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTutor1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource cNPeticionesTutoresBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEstudianteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutor1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTutor1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutor2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTutor2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutor3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTutor3DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cNPeticionesAlumnosBindingSource1;
        private System.Windows.Forms.BindingSource cNPeticionesAlumnosBindingSource2;
        private System.Windows.Forms.Label lblTitutlo;
    }
}