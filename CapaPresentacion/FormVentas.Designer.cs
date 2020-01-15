namespace CapaPresentacion
{
    partial class FormVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_agregarServicio = new System.Windows.Forms.Button();
            this.t_costoServicio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.t_descripcionServicio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t_cantidad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.b_agregar = new System.Windows.Forms.Button();
            this.t_descuento = new System.Windows.Forms.TextBox();
            this.t_buscar = new System.Windows.Forms.TextBox();
            this.tabla_productos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.b_eliminar = new System.Windows.Forms.Button();
            this.b_guardar = new System.Windows.Forms.Button();
            this.t_pago = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.b_cobrar = new System.Windows.Forms.Button();
            this.tabla_venta = new System.Windows.Forms.DataGridView();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_neto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_productos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_venta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.b_agregarServicio);
            this.panel1.Controls.Add(this.t_costoServicio);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.t_descripcionServicio);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.t_cantidad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.b_agregar);
            this.panel1.Controls.Add(this.t_descuento);
            this.panel1.Controls.Add(this.t_buscar);
            this.panel1.Controls.Add(this.tabla_productos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 615);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // b_agregarServicio
            // 
            this.b_agregarServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.b_agregarServicio.FlatAppearance.BorderSize = 0;
            this.b_agregarServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.b_agregarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_agregarServicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_agregarServicio.ForeColor = System.Drawing.Color.White;
            this.b_agregarServicio.Image = ((System.Drawing.Image)(resources.GetObject("b_agregarServicio.Image")));
            this.b_agregarServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_agregarServicio.Location = new System.Drawing.Point(496, 513);
            this.b_agregarServicio.Name = "b_agregarServicio";
            this.b_agregarServicio.Size = new System.Drawing.Size(111, 40);
            this.b_agregarServicio.TabIndex = 28;
            this.b_agregarServicio.Text = "Agregar";
            this.b_agregarServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_agregarServicio.UseVisualStyleBackColor = false;
            this.b_agregarServicio.Click += new System.EventHandler(this.b_agregarServicio_Click);
            // 
            // t_costoServicio
            // 
            this.t_costoServicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_costoServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.t_costoServicio.Location = new System.Drawing.Point(213, 542);
            this.t_costoServicio.Name = "t_costoServicio";
            this.t_costoServicio.Size = new System.Drawing.Size(189, 23);
            this.t_costoServicio.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.label6.Location = new System.Drawing.Point(61, 549);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Costo:";
            // 
            // t_descripcionServicio
            // 
            this.t_descripcionServicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_descripcionServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.t_descripcionServicio.Location = new System.Drawing.Point(213, 513);
            this.t_descripcionServicio.Name = "t_descripcionServicio";
            this.t_descripcionServicio.Size = new System.Drawing.Size(189, 23);
            this.t_descripcionServicio.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.label5.Location = new System.Drawing.Point(61, 516);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.label4.Location = new System.Drawing.Point(23, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ingresa un servicio:";
            // 
            // t_cantidad
            // 
            this.t_cantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.t_cantidad.Location = new System.Drawing.Point(276, 52);
            this.t_cantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.t_cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.t_cantidad.Name = "t_cantidad";
            this.t_cantidad.Size = new System.Drawing.Size(71, 23);
            this.t_cantidad.TabIndex = 22;
            this.t_cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.label2.Location = new System.Drawing.Point(385, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Descuento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.label1.Location = new System.Drawing.Point(273, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cantidad:";
            // 
            // b_agregar
            // 
            this.b_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.b_agregar.FlatAppearance.BorderSize = 0;
            this.b_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.b_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_agregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_agregar.ForeColor = System.Drawing.Color.White;
            this.b_agregar.Image = ((System.Drawing.Image)(resources.GetObject("b_agregar.Image")));
            this.b_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_agregar.Location = new System.Drawing.Point(496, 42);
            this.b_agregar.Name = "b_agregar";
            this.b_agregar.Size = new System.Drawing.Size(111, 40);
            this.b_agregar.TabIndex = 18;
            this.b_agregar.Text = "Agregar";
            this.b_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_agregar.UseVisualStyleBackColor = false;
            this.b_agregar.Click += new System.EventHandler(this.b_agregar_Click_1);
            // 
            // t_descuento
            // 
            this.t_descuento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_descuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.t_descuento.Location = new System.Drawing.Point(388, 51);
            this.t_descuento.Name = "t_descuento";
            this.t_descuento.Size = new System.Drawing.Size(76, 23);
            this.t_descuento.TabIndex = 6;
            this.t_descuento.Text = "0";
            // 
            // t_buscar
            // 
            this.t_buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.t_buscar.Location = new System.Drawing.Point(52, 52);
            this.t_buscar.Name = "t_buscar";
            this.t_buscar.Size = new System.Drawing.Size(186, 23);
            this.t_buscar.TabIndex = 3;
            this.t_buscar.TextChanged += new System.EventHandler(this.t_buscar_TextChanged);
            // 
            // tabla_productos
            // 
            this.tabla_productos.AllowUserToAddRows = false;
            this.tabla_productos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            this.tabla_productos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla_productos.BackgroundColor = System.Drawing.Color.White;
            this.tabla_productos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabla_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.descripcion_producto,
            this.Existencia,
            this.Precio_Venta});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_productos.DefaultCellStyle = dataGridViewCellStyle3;
            this.tabla_productos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.tabla_productos.Location = new System.Drawing.Point(26, 108);
            this.tabla_productos.Name = "tabla_productos";
            this.tabla_productos.Size = new System.Drawing.Size(581, 320);
            this.tabla_productos.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_producto";
            this.ID.FillWeight = 81.20678F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // descripcion_producto
            // 
            this.descripcion_producto.DataPropertyName = "descripcion_producto";
            this.descripcion_producto.FillWeight = 165.1094F;
            this.descripcion_producto.HeaderText = "Descripción";
            this.descripcion_producto.Name = "descripcion_producto";
            // 
            // Existencia
            // 
            this.Existencia.DataPropertyName = "existencia";
            this.Existencia.FillWeight = 62.31342F;
            this.Existencia.HeaderText = "Existencia";
            this.Existencia.Name = "Existencia";
            // 
            // Precio_Venta
            // 
            this.Precio_Venta.DataPropertyName = "precio_venta";
            this.Precio_Venta.FillWeight = 91.37062F;
            this.Precio_Venta.HeaderText = "Precio Venta";
            this.Precio_Venta.Name = "Precio_Venta";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.b_eliminar);
            this.panel2.Controls.Add(this.b_guardar);
            this.panel2.Controls.Add(this.t_pago);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lb_total);
            this.panel2.Controls.Add(this.b_cobrar);
            this.panel2.Controls.Add(this.tabla_venta);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(633, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 615);
            this.panel2.TabIndex = 1;
            // 
            // b_eliminar
            // 
            this.b_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.b_eliminar.FlatAppearance.BorderSize = 0;
            this.b_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.b_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_eliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_eliminar.ForeColor = System.Drawing.Color.White;
            this.b_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("b_eliminar.Image")));
            this.b_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_eliminar.Location = new System.Drawing.Point(325, 319);
            this.b_eliminar.Name = "b_eliminar";
            this.b_eliminar.Size = new System.Drawing.Size(111, 40);
            this.b_eliminar.TabIndex = 23;
            this.b_eliminar.Text = "Eliminar";
            this.b_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_eliminar.UseVisualStyleBackColor = false;
            this.b_eliminar.Click += new System.EventHandler(this.b_eliminar_Click);
            // 
            // b_guardar
            // 
            this.b_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.b_guardar.FlatAppearance.BorderSize = 0;
            this.b_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.b_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_guardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_guardar.ForeColor = System.Drawing.Color.White;
            this.b_guardar.Image = ((System.Drawing.Image)(resources.GetObject("b_guardar.Image")));
            this.b_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.b_guardar.Location = new System.Drawing.Point(347, 388);
            this.b_guardar.Name = "b_guardar";
            this.b_guardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.b_guardar.Size = new System.Drawing.Size(107, 100);
            this.b_guardar.TabIndex = 22;
            this.b_guardar.Text = "PAGAR";
            this.b_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b_guardar.UseVisualStyleBackColor = false;
            this.b_guardar.Click += new System.EventHandler(this.b_guardar_Click);
            // 
            // t_pago
            // 
            this.t_pago.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_pago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.t_pago.Location = new System.Drawing.Point(190, 463);
            this.t_pago.Name = "t_pago";
            this.t_pago.Size = new System.Drawing.Size(126, 31);
            this.t_pago.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(56, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Pagó con:";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.ForeColor = System.Drawing.Color.White;
            this.lb_total.Location = new System.Drawing.Point(50, 396);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(106, 32);
            this.lb_total.TabIndex = 19;
            this.lb_total.Text = "Total: $";
            this.lb_total.Visible = false;
            // 
            // b_cobrar
            // 
            this.b_cobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.b_cobrar.FlatAppearance.BorderSize = 0;
            this.b_cobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.b_cobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_cobrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_cobrar.ForeColor = System.Drawing.Color.White;
            this.b_cobrar.Image = ((System.Drawing.Image)(resources.GetObject("b_cobrar.Image")));
            this.b_cobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_cobrar.Location = new System.Drawing.Point(56, 319);
            this.b_cobrar.Name = "b_cobrar";
            this.b_cobrar.Size = new System.Drawing.Size(111, 40);
            this.b_cobrar.TabIndex = 18;
            this.b_cobrar.Text = "Cobrar";
            this.b_cobrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_cobrar.UseVisualStyleBackColor = false;
            this.b_cobrar.Click += new System.EventHandler(this.b_cobrar_Click);
            // 
            // tabla_venta
            // 
            this.tabla_venta.AllowUserToAddRows = false;
            this.tabla_venta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabla_venta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tabla_venta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.tabla_venta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_venta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tabla_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_venta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcion,
            this.Cantidad,
            this.precio_neto});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_venta.DefaultCellStyle = dataGridViewCellStyle6;
            this.tabla_venta.Location = new System.Drawing.Point(31, 42);
            this.tabla_venta.Name = "tabla_venta";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_venta.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tabla_venta.Size = new System.Drawing.Size(423, 254);
            this.tabla_venta.TabIndex = 0;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 230;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 70;
            // 
            // precio_neto
            // 
            this.precio_neto.HeaderText = "Precio Neto";
            this.precio_neto.Name = "precio_neto";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1120, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_productos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_venta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tabla_productos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox t_buscar;
        private System.Windows.Forms.DataGridView tabla_venta;
        private System.Windows.Forms.TextBox t_descuento;
        private System.Windows.Forms.Button b_agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown t_cantidad;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Button b_cobrar;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_pago;
        private System.Windows.Forms.Button b_guardar;
        private System.Windows.Forms.Button b_eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_neto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Venta;
        private System.Windows.Forms.Button b_agregarServicio;
        private System.Windows.Forms.TextBox t_costoServicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox t_descripcionServicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}