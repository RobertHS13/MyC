namespace CapaPresentacion
{
    partial class FormProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_foliofactura = new System.Windows.Forms.ComboBox();
            this.b_eliminar = new System.Windows.Forms.Button();
            this.b_modificar = new System.Windows.Forms.Button();
            this.t_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.t_descripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.b_guardar = new System.Windows.Forms.Button();
            this.t_existencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.t_cantidadminima = new System.Windows.Forms.TextBox();
            this.t_preciocosto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.t_precioventa = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.t_buscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_minima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folio_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.cb_foliofactura);
            this.panel1.Controls.Add(this.b_eliminar);
            this.panel1.Controls.Add(this.b_modificar);
            this.panel1.Controls.Add(this.t_id);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.t_descripcion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.b_guardar);
            this.panel1.Controls.Add(this.t_existencia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.t_cantidadminima);
            this.panel1.Controls.Add(this.t_preciocosto);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.t_precioventa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(753, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 615);
            this.panel1.TabIndex = 0;
            // 
            // cb_foliofactura
            // 
            this.cb_foliofactura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_foliofactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.cb_foliofactura.FormattingEnabled = true;
            this.cb_foliofactura.Location = new System.Drawing.Point(153, 438);
            this.cb_foliofactura.Name = "cb_foliofactura";
            this.cb_foliofactura.Size = new System.Drawing.Size(183, 25);
            this.cb_foliofactura.TabIndex = 20;
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
            this.b_eliminar.Location = new System.Drawing.Point(24, 500);
            this.b_eliminar.Name = "b_eliminar";
            this.b_eliminar.Size = new System.Drawing.Size(111, 40);
            this.b_eliminar.TabIndex = 18;
            this.b_eliminar.Text = "Eliminar";
            this.b_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_eliminar.UseVisualStyleBackColor = false;
            this.b_eliminar.Click += new System.EventHandler(this.b_eliminar_Click);
            // 
            // b_modificar
            // 
            this.b_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.b_modificar.FlatAppearance.BorderSize = 0;
            this.b_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.b_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_modificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_modificar.ForeColor = System.Drawing.Color.White;
            this.b_modificar.Image = ((System.Drawing.Image)(resources.GetObject("b_modificar.Image")));
            this.b_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_modificar.Location = new System.Drawing.Point(24, 152);
            this.b_modificar.Name = "b_modificar";
            this.b_modificar.Size = new System.Drawing.Size(111, 40);
            this.b_modificar.TabIndex = 17;
            this.b_modificar.Text = "Modificar";
            this.b_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_modificar.UseVisualStyleBackColor = false;
            this.b_modificar.Click += new System.EventHandler(this.b_modificar_Click);
            // 
            // t_id
            // 
            this.t_id.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.t_id.Location = new System.Drawing.Point(153, 222);
            this.t_id.Name = "t_id";
            this.t_id.Size = new System.Drawing.Size(183, 23);
            this.t_id.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cantidad Minima:";
            // 
            // t_descripcion
            // 
            this.t_descripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.t_descripcion.Location = new System.Drawing.Point(153, 258);
            this.t_descripcion.Name = "t_descripcion";
            this.t_descripcion.Size = new System.Drawing.Size(183, 23);
            this.t_descripcion.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Folio Factura:";
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
            this.b_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_guardar.Location = new System.Drawing.Point(229, 152);
            this.b_guardar.Name = "b_guardar";
            this.b_guardar.Size = new System.Drawing.Size(107, 40);
            this.b_guardar.TabIndex = 16;
            this.b_guardar.Text = "Guardar";
            this.b_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_guardar.UseVisualStyleBackColor = false;
            this.b_guardar.Click += new System.EventHandler(this.b_guardar_Click);
            // 
            // t_existencia
            // 
            this.t_existencia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_existencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.t_existencia.Location = new System.Drawing.Point(153, 295);
            this.t_existencia.Name = "t_existencia";
            this.t_existencia.Size = new System.Drawing.Size(183, 23);
            this.t_existencia.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Precio Venta:";
            // 
            // t_cantidadminima
            // 
            this.t_cantidadminima.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_cantidadminima.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.t_cantidadminima.Location = new System.Drawing.Point(153, 402);
            this.t_cantidadminima.Name = "t_cantidadminima";
            this.t_cantidadminima.Size = new System.Drawing.Size(183, 23);
            this.t_cantidadminima.TabIndex = 14;
            // 
            // t_preciocosto
            // 
            this.t_preciocosto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_preciocosto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.t_preciocosto.Location = new System.Drawing.Point(153, 329);
            this.t_preciocosto.Name = "t_preciocosto";
            this.t_preciocosto.Size = new System.Drawing.Size(183, 23);
            this.t_preciocosto.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Existencia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Precio Costo:";
            // 
            // t_precioventa
            // 
            this.t_precioventa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_precioventa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.t_precioventa.Location = new System.Drawing.Point(153, 365);
            this.t_precioventa.Name = "t_precioventa";
            this.t_precioventa.Size = new System.Drawing.Size(183, 23);
            this.t_precioventa.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.t_buscar);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 615);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // t_buscar
            // 
            this.t_buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.t_buscar.Location = new System.Drawing.Point(34, 57);
            this.t_buscar.Name = "t_buscar";
            this.t_buscar.Size = new System.Drawing.Size(212, 23);
            this.t_buscar.TabIndex = 1;
            this.t_buscar.TextChanged += new System.EventHandler(this.t_buscar_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.descripcion_producto,
            this.existencia,
            this.precio_costo,
            this.precio_venta,
            this.cantidad_minima,
            this.folio_factura});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(9, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 457);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_producto
            // 
            this.id_producto.DataPropertyName = "id_producto";
            this.id_producto.HeaderText = "ID";
            this.id_producto.Name = "id_producto";
            // 
            // descripcion_producto
            // 
            this.descripcion_producto.DataPropertyName = "descripcion_producto";
            this.descripcion_producto.HeaderText = "Descripción";
            this.descripcion_producto.Name = "descripcion_producto";
            // 
            // existencia
            // 
            this.existencia.DataPropertyName = "existencia";
            this.existencia.HeaderText = "Existencia";
            this.existencia.Name = "existencia";
            // 
            // precio_costo
            // 
            this.precio_costo.DataPropertyName = "precio_costo";
            this.precio_costo.HeaderText = "Precio Costo";
            this.precio_costo.Name = "precio_costo";
            // 
            // precio_venta
            // 
            this.precio_venta.DataPropertyName = "precio_venta";
            this.precio_venta.HeaderText = "Precio Venta";
            this.precio_venta.Name = "precio_venta";
            // 
            // cantidad_minima
            // 
            this.cantidad_minima.DataPropertyName = "cantidad_minima";
            this.cantidad_minima.HeaderText = "Cantidad Mínima";
            this.cantidad_minima.Name = "cantidad_minima";
            // 
            // folio_factura
            // 
            this.folio_factura.DataPropertyName = "folio_factura";
            this.folio_factura.HeaderText = "Folio Factura";
            this.folio_factura.Name = "folio_factura";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1120, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_existencia;
        private System.Windows.Forms.TextBox t_descripcion;
        private System.Windows.Forms.TextBox t_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_guardar;
        private System.Windows.Forms.TextBox t_cantidadminima;
        private System.Windows.Forms.TextBox t_precioventa;
        private System.Windows.Forms.TextBox t_preciocosto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_eliminar;
        private System.Windows.Forms.Button b_modificar;
        private System.Windows.Forms.ComboBox cb_foliofactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_minima;
        private System.Windows.Forms.DataGridViewTextBoxColumn folio_factura;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox t_buscar;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}