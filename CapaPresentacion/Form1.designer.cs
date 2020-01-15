namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panelSubmenu = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.botonReporteVentas = new System.Windows.Forms.Button();
            this.botonProveedores = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.botonCortes = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.botonReportes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.botonProductos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botonClientes = new System.Windows.Forms.Button();
            this.panelBotonVentas = new System.Windows.Forms.Panel();
            this.botonVentas = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.tabla_movimientos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ganancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonCerrar = new System.Windows.Forms.PictureBox();
            this.botonAmpliar = new System.Windows.Forms.PictureBox();
            this.botonMinimizar = new System.Windows.Forms.PictureBox();
            this.botonRestaurar = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelMenu.SuspendLayout();
            this.panelSubmenu.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_movimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonAmpliar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonRestaurar)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.panelMenu.Controls.Add(this.panel9);
            this.panelMenu.Controls.Add(this.panelSubmenu);
            this.panelMenu.Controls.Add(this.botonProveedores);
            this.panelMenu.Controls.Add(this.panel5);
            this.panelMenu.Controls.Add(this.botonCortes);
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Controls.Add(this.botonReportes);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.botonProductos);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.botonClientes);
            this.panelMenu.Controls.Add(this.panelBotonVentas);
            this.panelMenu.Controls.Add(this.botonVentas);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 35);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 615);
            this.panelMenu.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Navy;
            this.panel9.Location = new System.Drawing.Point(0, 162);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 32);
            this.panel9.TabIndex = 12;
            // 
            // panelSubmenu
            // 
            this.panelSubmenu.Controls.Add(this.panel6);
            this.panelSubmenu.Controls.Add(this.botonReporteVentas);
            this.panelSubmenu.Location = new System.Drawing.Point(10, 247);
            this.panelSubmenu.Name = "panelSubmenu";
            this.panelSubmenu.Size = new System.Drawing.Size(170, 42);
            this.panelSubmenu.TabIndex = 12;
            this.panelSubmenu.Visible = false;
            this.panelSubmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSubmenu_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Navy;
            this.panel6.Location = new System.Drawing.Point(1, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 28);
            this.panel6.TabIndex = 16;
            // 
            // botonReporteVentas
            // 
            this.botonReporteVentas.FlatAppearance.BorderSize = 0;
            this.botonReporteVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.botonReporteVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonReporteVentas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonReporteVentas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.botonReporteVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonReporteVentas.Location = new System.Drawing.Point(8, 0);
            this.botonReporteVentas.Name = "botonReporteVentas";
            this.botonReporteVentas.Size = new System.Drawing.Size(159, 28);
            this.botonReporteVentas.TabIndex = 13;
            this.botonReporteVentas.Text = "Movimientos";
            this.botonReporteVentas.UseVisualStyleBackColor = true;
            this.botonReporteVentas.Click += new System.EventHandler(this.botonReporteVentas_Click);
            // 
            // botonProveedores
            // 
            this.botonProveedores.FlatAppearance.BorderSize = 0;
            this.botonProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.botonProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonProveedores.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonProveedores.ForeColor = System.Drawing.Color.AliceBlue;
            this.botonProveedores.Image = ((System.Drawing.Image)(resources.GetObject("botonProveedores.Image")));
            this.botonProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonProveedores.Location = new System.Drawing.Point(3, 162);
            this.botonProveedores.Name = "botonProveedores";
            this.botonProveedores.Size = new System.Drawing.Size(177, 32);
            this.botonProveedores.TabIndex = 13;
            this.botonProveedores.Text = "Proveedores";
            this.botonProveedores.UseVisualStyleBackColor = true;
            this.botonProveedores.Click += new System.EventHandler(this.botonProveedores_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Navy;
            this.panel5.Location = new System.Drawing.Point(0, 410);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 32);
            this.panel5.TabIndex = 10;
            this.panel5.Visible = false;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // botonCortes
            // 
            this.botonCortes.FlatAppearance.BorderSize = 0;
            this.botonCortes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.botonCortes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCortes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCortes.ForeColor = System.Drawing.Color.AliceBlue;
            this.botonCortes.Image = ((System.Drawing.Image)(resources.GetObject("botonCortes.Image")));
            this.botonCortes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCortes.Location = new System.Drawing.Point(3, 409);
            this.botonCortes.Name = "botonCortes";
            this.botonCortes.Size = new System.Drawing.Size(177, 32);
            this.botonCortes.TabIndex = 11;
            this.botonCortes.Text = "Cortes";
            this.botonCortes.UseVisualStyleBackColor = true;
            this.botonCortes.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.Location = new System.Drawing.Point(0, 209);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 32);
            this.panel4.TabIndex = 8;
            // 
            // botonReportes
            // 
            this.botonReportes.FlatAppearance.BorderSize = 0;
            this.botonReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.botonReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonReportes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonReportes.ForeColor = System.Drawing.Color.AliceBlue;
            this.botonReportes.Image = ((System.Drawing.Image)(resources.GetObject("botonReportes.Image")));
            this.botonReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonReportes.Location = new System.Drawing.Point(3, 209);
            this.botonReportes.Name = "botonReportes";
            this.botonReportes.Size = new System.Drawing.Size(177, 32);
            this.botonReportes.TabIndex = 9;
            this.botonReportes.Text = "Reportes";
            this.botonReportes.UseVisualStyleBackColor = true;
            this.botonReportes.Click += new System.EventHandler(this.botonReportes_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Location = new System.Drawing.Point(0, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 32);
            this.panel2.TabIndex = 4;
            // 
            // botonProductos
            // 
            this.botonProductos.FlatAppearance.BorderSize = 0;
            this.botonProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.botonProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonProductos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonProductos.ForeColor = System.Drawing.Color.AliceBlue;
            this.botonProductos.Image = ((System.Drawing.Image)(resources.GetObject("botonProductos.Image")));
            this.botonProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonProductos.Location = new System.Drawing.Point(3, 112);
            this.botonProductos.Name = "botonProductos";
            this.botonProductos.Size = new System.Drawing.Size(177, 32);
            this.botonProductos.TabIndex = 5;
            this.botonProductos.Text = "Productos";
            this.botonProductos.UseVisualStyleBackColor = true;
            this.botonProductos.Click += new System.EventHandler(this.botonProductos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 32);
            this.panel1.TabIndex = 2;
            // 
            // botonClientes
            // 
            this.botonClientes.FlatAppearance.BorderSize = 0;
            this.botonClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.botonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonClientes.ForeColor = System.Drawing.Color.AliceBlue;
            this.botonClientes.Image = ((System.Drawing.Image)(resources.GetObject("botonClientes.Image")));
            this.botonClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonClientes.Location = new System.Drawing.Point(3, 64);
            this.botonClientes.Name = "botonClientes";
            this.botonClientes.Size = new System.Drawing.Size(177, 32);
            this.botonClientes.TabIndex = 3;
            this.botonClientes.Text = "Clientes";
            this.botonClientes.UseVisualStyleBackColor = true;
            this.botonClientes.Click += new System.EventHandler(this.botonClientes_Click);
            // 
            // panelBotonVentas
            // 
            this.panelBotonVentas.BackColor = System.Drawing.Color.Navy;
            this.panelBotonVentas.Location = new System.Drawing.Point(0, 18);
            this.panelBotonVentas.Name = "panelBotonVentas";
            this.panelBotonVentas.Size = new System.Drawing.Size(5, 32);
            this.panelBotonVentas.TabIndex = 0;
            // 
            // botonVentas
            // 
            this.botonVentas.FlatAppearance.BorderSize = 0;
            this.botonVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.botonVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVentas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVentas.ForeColor = System.Drawing.Color.AliceBlue;
            this.botonVentas.Image = ((System.Drawing.Image)(resources.GetObject("botonVentas.Image")));
            this.botonVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonVentas.Location = new System.Drawing.Point(3, 18);
            this.botonVentas.Name = "botonVentas";
            this.botonVentas.Size = new System.Drawing.Size(177, 32);
            this.botonVentas.TabIndex = 1;
            this.botonVentas.Text = "Ventas";
            this.botonVentas.UseVisualStyleBackColor = true;
            this.botonVentas.Click += new System.EventHandler(this.botonVentas_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Transparent;
            this.panelContenedor.Controls.Add(this.tabla_movimientos);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(180, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1120, 615);
            this.panelContenedor.TabIndex = 2;
            // 
            // tabla_movimientos
            // 
            this.tabla_movimientos.AllowUserToAddRows = false;
            this.tabla_movimientos.AllowUserToDeleteRows = false;
            this.tabla_movimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla_movimientos.BackgroundColor = System.Drawing.Color.White;
            this.tabla_movimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_movimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descripcion,
            this.fecha,
            this.ganancia,
            this.cantidad});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_movimientos.DefaultCellStyle = dataGridViewCellStyle1;
            this.tabla_movimientos.Location = new System.Drawing.Point(47, 64);
            this.tabla_movimientos.Name = "tabla_movimientos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_movimientos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabla_movimientos.Size = new System.Drawing.Size(599, 150);
            this.tabla_movimientos.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id_movimiento ";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion_movimiento";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha_movimiento";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            // 
            // ganancia
            // 
            this.ganancia.DataPropertyName = "ganancia_movimiento";
            this.ganancia.HeaderText = "Ganancia";
            this.ganancia.Name = "ganancia";
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad_movimiento";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // botonCerrar
            // 
            this.botonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("botonCerrar.Image")));
            this.botonCerrar.Location = new System.Drawing.Point(1263, 4);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(25, 25);
            this.botonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonCerrar.TabIndex = 0;
            this.botonCerrar.TabStop = false;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // botonAmpliar
            // 
            this.botonAmpliar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonAmpliar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAmpliar.Image = ((System.Drawing.Image)(resources.GetObject("botonAmpliar.Image")));
            this.botonAmpliar.Location = new System.Drawing.Point(1232, 4);
            this.botonAmpliar.Name = "botonAmpliar";
            this.botonAmpliar.Size = new System.Drawing.Size(25, 25);
            this.botonAmpliar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonAmpliar.TabIndex = 1;
            this.botonAmpliar.TabStop = false;
            this.botonAmpliar.Click += new System.EventHandler(this.botonAmpliar_Click);
            // 
            // botonMinimizar
            // 
            this.botonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("botonMinimizar.Image")));
            this.botonMinimizar.Location = new System.Drawing.Point(1201, 4);
            this.botonMinimizar.Name = "botonMinimizar";
            this.botonMinimizar.Size = new System.Drawing.Size(25, 25);
            this.botonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonMinimizar.TabIndex = 1;
            this.botonMinimizar.TabStop = false;
            this.botonMinimizar.Click += new System.EventHandler(this.botonMinimizar_Click);
            // 
            // botonRestaurar
            // 
            this.botonRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("botonRestaurar.Image")));
            this.botonRestaurar.Location = new System.Drawing.Point(1232, 4);
            this.botonRestaurar.Name = "botonRestaurar";
            this.botonRestaurar.Size = new System.Drawing.Size(25, 25);
            this.botonRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonRestaurar.TabIndex = 1;
            this.botonRestaurar.TabStop = false;
            this.botonRestaurar.Visible = false;
            this.botonRestaurar.Click += new System.EventHandler(this.botonRestaurar_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Navy;
            this.panelTitulo.Controls.Add(this.botonRestaurar);
            this.panelTitulo.Controls.Add(this.botonMinimizar);
            this.panelTitulo.Controls.Add(this.botonAmpliar);
            this.panelTitulo.Controls.Add(this.botonCerrar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1300, 35);
            this.panelTitulo.TabIndex = 0;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTitulo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelSubmenu.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_movimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonAmpliar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonRestaurar)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelBotonVentas;
        private System.Windows.Forms.Button botonVentas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonClientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button botonProductos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button botonCortes;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button botonProveedores;
        private System.Windows.Forms.PictureBox botonRestaurar;
        private System.Windows.Forms.PictureBox botonAmpliar;
        private System.Windows.Forms.PictureBox botonMinimizar;
        private System.Windows.Forms.PictureBox botonCerrar;
        private System.Windows.Forms.Panel panelTitulo;
        //private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button botonReportes;
        private System.Windows.Forms.Panel panelSubmenu;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button botonReporteVentas;
        private System.Windows.Forms.DataGridView tabla_movimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ganancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
    }
}

