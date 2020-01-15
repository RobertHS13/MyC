namespace CapaPresentacion
{
    partial class FormClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.t_buscar = new System.Windows.Forms.TextBox();
            this.tabla_clientes = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.b_eliminar = new System.Windows.Forms.Button();
            this.b_modificar = new System.Windows.Forms.Button();
            this.t_nombre = new System.Windows.Forms.TextBox();
            this.b_guardar = new System.Windows.Forms.Button();
            this.t_direccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.t_telefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.t_correo = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_clientes)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.t_buscar);
            this.panel1.Controls.Add(this.tabla_clientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 576);
            this.panel1.TabIndex = 0;
            // 
            // t_buscar
            // 
            this.t_buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.t_buscar.Location = new System.Drawing.Point(48, 46);
            this.t_buscar.Name = "t_buscar";
            this.t_buscar.Size = new System.Drawing.Size(212, 23);
            this.t_buscar.TabIndex = 3;
            this.t_buscar.TextChanged += new System.EventHandler(this.t_buscar_TextChanged);
            // 
            // tabla_clientes
            // 
            this.tabla_clientes.AllowUserToAddRows = false;
            this.tabla_clientes.AllowUserToDeleteRows = false;
            this.tabla_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla_clientes.BackgroundColor = System.Drawing.Color.White;
            this.tabla_clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_clientes.DefaultCellStyle = dataGridViewCellStyle1;
            this.tabla_clientes.Location = new System.Drawing.Point(23, 93);
            this.tabla_clientes.Name = "tabla_clientes";
            this.tabla_clientes.Size = new System.Drawing.Size(693, 431);
            this.tabla_clientes.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.b_eliminar);
            this.panel2.Controls.Add(this.b_modificar);
            this.panel2.Controls.Add(this.t_nombre);
            this.panel2.Controls.Add(this.b_guardar);
            this.panel2.Controls.Add(this.t_direccion);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.t_telefono);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.t_correo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(740, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 576);
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
            this.b_eliminar.Location = new System.Drawing.Point(24, 250);
            this.b_eliminar.Name = "b_eliminar";
            this.b_eliminar.Size = new System.Drawing.Size(111, 40);
            this.b_eliminar.TabIndex = 36;
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
            this.b_modificar.Location = new System.Drawing.Point(24, 29);
            this.b_modificar.Name = "b_modificar";
            this.b_modificar.Size = new System.Drawing.Size(111, 40);
            this.b_modificar.TabIndex = 35;
            this.b_modificar.Text = "Modificar";
            this.b_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_modificar.UseVisualStyleBackColor = false;
            this.b_modificar.Click += new System.EventHandler(this.b_modificar_Click);
            // 
            // t_nombre
            // 
            this.t_nombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.t_nombre.Location = new System.Drawing.Point(153, 93);
            this.t_nombre.Name = "t_nombre";
            this.t_nombre.Size = new System.Drawing.Size(183, 23);
            this.t_nombre.TabIndex = 29;
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
            this.b_guardar.Location = new System.Drawing.Point(229, 29);
            this.b_guardar.Name = "b_guardar";
            this.b_guardar.Size = new System.Drawing.Size(107, 40);
            this.b_guardar.TabIndex = 34;
            this.b_guardar.Text = "Guardar";
            this.b_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_guardar.UseVisualStyleBackColor = false;
            this.b_guardar.Click += new System.EventHandler(this.b_guardar_Click);
            // 
            // t_direccion
            // 
            this.t_direccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.t_direccion.Location = new System.Drawing.Point(153, 130);
            this.t_direccion.Name = "t_direccion";
            this.t_direccion.Size = new System.Drawing.Size(183, 23);
            this.t_direccion.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Correo:";
            // 
            // t_telefono
            // 
            this.t_telefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.t_telefono.Location = new System.Drawing.Point(153, 164);
            this.t_telefono.Name = "t_telefono";
            this.t_telefono.Size = new System.Drawing.Size(183, 23);
            this.t_telefono.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Dirección:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Teléfono:";
            // 
            // t_correo
            // 
            this.t_correo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.t_correo.Location = new System.Drawing.Point(153, 200);
            this.t_correo.Name = "t_correo";
            this.t_correo.Size = new System.Drawing.Size(183, 23);
            this.t_correo.TabIndex = 32;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_clientes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button b_eliminar;
        private System.Windows.Forms.Button b_modificar;
        private System.Windows.Forms.TextBox t_nombre;
        private System.Windows.Forms.Button b_guardar;
        private System.Windows.Forms.TextBox t_direccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox t_telefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox t_correo;
        private System.Windows.Forms.DataGridView tabla_clientes;
        private System.Windows.Forms.TextBox t_buscar;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}