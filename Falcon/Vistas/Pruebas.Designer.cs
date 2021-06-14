namespace Falcon
{
    partial class Pruebas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pruebas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pruebaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.falconDataSet8 = new Falcon.FalconDataSet8();
            this.pruebaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.falconDataSet3 = new Falcon.FalconDataSet3();
            this.pruebaTableAdapter = new Falcon.FalconDataSet3TableAdapters.PruebaTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pruebaTableAdapter1 = new Falcon.FalconDataSet8TableAdapters.PruebaTableAdapter();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_tipoprueba = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_fecha = new System.Windows.Forms.DateTimePicker();
            this.tb_cantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.bnt_agregar = new System.Windows.Forms.Button();
            this.dgv_pruebas = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPruebaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Cerrar_sesion = new System.Windows.Forms.Button();
            this.MinimizarBtn = new System.Windows.Forms.Panel();
            this.BarraTituloPnl = new System.Windows.Forms.Panel();
            this.BotonMinimizarBtn = new System.Windows.Forms.PictureBox();
            this.CerrarBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falconDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falconDataSet3)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pruebas)).BeginInit();
            this.MinimizarBtn.SuspendLayout();
            this.BarraTituloPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMinimizarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(701, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pruebaBindingSource1
            // 
            this.pruebaBindingSource1.DataMember = "Prueba";
            this.pruebaBindingSource1.DataSource = this.falconDataSet8;
            // 
            // falconDataSet8
            // 
            this.falconDataSet8.DataSetName = "FalconDataSet8";
            this.falconDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pruebaBindingSource
            // 
            this.pruebaBindingSource.DataMember = "Prueba";
            this.pruebaBindingSource.DataSource = this.falconDataSet3;
            // 
            // falconDataSet3
            // 
            this.falconDataSet3.DataSetName = "FalconDataSet3";
            this.falconDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pruebaTableAdapter
            // 
            this.pruebaTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pruebaTableAdapter1
            // 
            this.pruebaTableAdapter1.ClearBeforeFill = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbl);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.tb_id);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(78, 290);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(956, 279);
            this.panel5.TabIndex = 3;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.GhostWhite;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Crimson;
            this.lbl.Location = new System.Drawing.Point(687, 45);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(13, 16);
            this.lbl.TabIndex = 23;
            this.lbl.Text = "*";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel3);
            this.panel8.Controls.Add(this.tb_cantidad);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(2, 76);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(951, 197);
            this.panel8.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cb_tipoprueba);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dt_fecha);
            this.panel3.Location = new System.Drawing.Point(2, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(946, 130);
            this.panel3.TabIndex = 11;
            // 
            // cb_tipoprueba
            // 
            this.cb_tipoprueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tipoprueba.FormattingEnabled = true;
            this.cb_tipoprueba.Items.AddRange(new object[] {
            "VIH",
            "Leucocitos"});
            this.cb_tipoprueba.Location = new System.Drawing.Point(254, 74);
            this.cb_tipoprueba.Name = "cb_tipoprueba";
            this.cb_tipoprueba.Size = new System.Drawing.Size(257, 37);
            this.cb_tipoprueba.TabIndex = 8;
            this.cb_tipoprueba.SelectedIndexChanged += new System.EventHandler(this.cb_tipoprueba_SelectedIndexChanged);
            this.cb_tipoprueba.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_tipoprueba_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "TIPO DE PRUEBA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(127, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "FECHA:";
            // 
            // dt_fecha
            // 
            this.dt_fecha.CustomFormat = "yyyy-MM-dd";
            this.dt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_fecha.Location = new System.Drawing.Point(254, 10);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(257, 35);
            this.dt_fecha.TabIndex = 6;
            this.dt_fecha.Value = new System.DateTime(2021, 1, 18, 19, 14, 26, 0);
            this.dt_fecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tb_cantidad
            // 
            this.tb_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cantidad.Location = new System.Drawing.Point(256, 139);
            this.tb_cantidad.Name = "tb_cantidad";
            this.tb_cantidad.Size = new System.Drawing.Size(162, 35);
            this.tb_cantidad.TabIndex = 10;
            this.tb_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cantidad_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(73, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "CANTIDAD:";
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(258, 16);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(162, 35);
            this.tb_id.TabIndex = 4;
            this.tb_id.TextChanged += new System.EventHandler(this.tb_id_TextChanged);
            this.tb_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_id_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(186, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_Limpiar);
            this.panel6.Controls.Add(this.btn_modificar);
            this.panel6.Controls.Add(this.btn_eliminar);
            this.panel6.Controls.Add(this.bnt_agregar);
            this.panel6.Location = new System.Drawing.Point(1040, 290);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(190, 279);
            this.panel6.TabIndex = 4;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.Black;
            this.btn_Limpiar.FlatAppearance.BorderSize = 0;
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpiar.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpiar.Location = new System.Drawing.Point(5, 65);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(184, 44);
            this.btn_Limpiar.TabIndex = 6;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click_1);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.Black;
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.Color.White;
            this.btn_modificar.Location = new System.Drawing.Point(3, 124);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(184, 45);
            this.btn_modificar.TabIndex = 5;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Black;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Location = new System.Drawing.Point(5, 187);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(184, 46);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // bnt_agregar
            // 
            this.bnt_agregar.BackColor = System.Drawing.Color.Black;
            this.bnt_agregar.FlatAppearance.BorderSize = 0;
            this.bnt_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_agregar.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_agregar.ForeColor = System.Drawing.Color.White;
            this.bnt_agregar.Location = new System.Drawing.Point(3, 3);
            this.bnt_agregar.Name = "bnt_agregar";
            this.bnt_agregar.Size = new System.Drawing.Size(184, 45);
            this.bnt_agregar.TabIndex = 1;
            this.bnt_agregar.Text = "Agregar";
            this.bnt_agregar.UseVisualStyleBackColor = false;
            this.bnt_agregar.Click += new System.EventHandler(this.bnt_agregar_Click);
            // 
            // dgv_pruebas
            // 
            this.dgv_pruebas.AllowUserToAddRows = false;
            this.dgv_pruebas.AllowUserToDeleteRows = false;
            this.dgv_pruebas.AutoGenerateColumns = false;
            this.dgv_pruebas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pruebas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_pruebas.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_pruebas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_pruebas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pruebas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_pruebas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pruebas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.tipoPruebaDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn});
            this.dgv_pruebas.DataSource = this.pruebaBindingSource1;
            this.dgv_pruebas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_pruebas.EnableHeadersVisualStyles = false;
            this.dgv_pruebas.GridColor = System.Drawing.Color.DimGray;
            this.dgv_pruebas.Location = new System.Drawing.Point(78, 575);
            this.dgv_pruebas.Name = "dgv_pruebas";
            this.dgv_pruebas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pruebas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_pruebas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_pruebas.Size = new System.Drawing.Size(1152, 301);
            this.dgv_pruebas.TabIndex = 5;
            this.dgv_pruebas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pruebas_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // tipoPruebaDataGridViewTextBoxColumn
            // 
            this.tipoPruebaDataGridViewTextBoxColumn.DataPropertyName = "TipoPrueba";
            this.tipoPruebaDataGridViewTextBoxColumn.HeaderText = "TipoPrueba";
            this.tipoPruebaDataGridViewTextBoxColumn.Name = "tipoPruebaDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Courier New", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.Location = new System.Drawing.Point(58, 92);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(26, 28);
            this.labelB.TabIndex = 6;
            this.labelB.Text = "_";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(78, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Consultas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Cerrar_sesion
            // 
            this.Cerrar_sesion.BackColor = System.Drawing.Color.Black;
            this.Cerrar_sesion.FlatAppearance.BorderSize = 0;
            this.Cerrar_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cerrar_sesion.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrar_sesion.ForeColor = System.Drawing.Color.White;
            this.Cerrar_sesion.Location = new System.Drawing.Point(1250, 821);
            this.Cerrar_sesion.Name = "Cerrar_sesion";
            this.Cerrar_sesion.Size = new System.Drawing.Size(286, 46);
            this.Cerrar_sesion.TabIndex = 3;
            this.Cerrar_sesion.Text = "Cerrar ";
            this.Cerrar_sesion.UseVisualStyleBackColor = false;
            this.Cerrar_sesion.Click += new System.EventHandler(this.Cerrar_sesion_Click);
            // 
            // MinimizarBtn
            // 
            this.MinimizarBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.MinimizarBtn.Controls.Add(this.BarraTituloPnl);
            this.MinimizarBtn.Controls.Add(this.pictureBox3);
            this.MinimizarBtn.Controls.Add(this.Cerrar_sesion);
            this.MinimizarBtn.Controls.Add(this.button1);
            this.MinimizarBtn.Controls.Add(this.labelB);
            this.MinimizarBtn.Controls.Add(this.dgv_pruebas);
            this.MinimizarBtn.Controls.Add(this.panel6);
            this.MinimizarBtn.Controls.Add(this.panel5);
            this.MinimizarBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinimizarBtn.Location = new System.Drawing.Point(0, 0);
            this.MinimizarBtn.Name = "MinimizarBtn";
            this.MinimizarBtn.Size = new System.Drawing.Size(1569, 888);
            this.MinimizarBtn.TabIndex = 22;
            this.MinimizarBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // BarraTituloPnl
            // 
            this.BarraTituloPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.BarraTituloPnl.Controls.Add(this.BotonMinimizarBtn);
            this.BarraTituloPnl.Controls.Add(this.CerrarBtn);
            this.BarraTituloPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTituloPnl.Location = new System.Drawing.Point(0, 0);
            this.BarraTituloPnl.Name = "BarraTituloPnl";
            this.BarraTituloPnl.Size = new System.Drawing.Size(1569, 30);
            this.BarraTituloPnl.TabIndex = 28;
            this.BarraTituloPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTituloPnl_MouseDown);
            // 
            // BotonMinimizarBtn
            // 
            this.BotonMinimizarBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.BotonMinimizarBtn.Image = ((System.Drawing.Image)(resources.GetObject("BotonMinimizarBtn.Image")));
            this.BotonMinimizarBtn.Location = new System.Drawing.Point(1509, 0);
            this.BotonMinimizarBtn.Name = "BotonMinimizarBtn";
            this.BotonMinimizarBtn.Size = new System.Drawing.Size(30, 30);
            this.BotonMinimizarBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BotonMinimizarBtn.TabIndex = 30;
            this.BotonMinimizarBtn.TabStop = false;
            this.BotonMinimizarBtn.Click += new System.EventHandler(this.BotonMinimizarBtn_Click);
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CerrarBtn.Image = ((System.Drawing.Image)(resources.GetObject("CerrarBtn.Image")));
            this.CerrarBtn.Location = new System.Drawing.Point(1539, 0);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(30, 30);
            this.CerrarBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CerrarBtn.TabIndex = 0;
            this.CerrarBtn.TabStop = false;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(500, 92);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(389, 180);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // Pruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1569, 888);
            this.Controls.Add(this.MinimizarBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pruebas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pruebas";
            this.Load += new System.EventHandler(this.Pruebas_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falconDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falconDataSet3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pruebas)).EndInit();
            this.MinimizarBtn.ResumeLayout(false);
            this.MinimizarBtn.PerformLayout();
            this.BarraTituloPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BotonMinimizarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private FalconDataSet3 falconDataSet3;
        private System.Windows.Forms.BindingSource pruebaBindingSource;
        private FalconDataSet3TableAdapters.PruebaTableAdapter pruebaTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private FalconDataSet8 falconDataSet8;
        private System.Windows.Forms.BindingSource pruebaBindingSource1;
        private FalconDataSet8TableAdapters.PruebaTableAdapter pruebaTableAdapter1;
        public System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cb_tipoprueba;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_fecha;
        private System.Windows.Forms.TextBox tb_cantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button bnt_agregar;
        public System.Windows.Forms.DataGridView dgv_pruebas;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPruebaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Cerrar_sesion;
        public System.Windows.Forms.Panel MinimizarBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel BarraTituloPnl;
        private System.Windows.Forms.PictureBox CerrarBtn;
        private System.Windows.Forms.PictureBox BotonMinimizarBtn;
    }
}