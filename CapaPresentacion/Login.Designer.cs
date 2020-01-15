namespace CapaPresentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.t_usuario = new System.Windows.Forms.TextBox();
            this.t_contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonAcceder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.botonCerrar = new System.Windows.Forms.PictureBox();
            this.botonMinimizar = new System.Windows.Forms.PictureBox();
            this.l_Usuario = new System.Windows.Forms.Label();
            this.l_Contraseña = new System.Windows.Forms.Label();
            this.l_Login = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 79);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(225, 176);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // t_usuario
            // 
            this.t_usuario.BackColor = System.Drawing.Color.Navy;
            this.t_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_usuario.ForeColor = System.Drawing.Color.LightGray;
            this.t_usuario.Location = new System.Drawing.Point(307, 89);
            this.t_usuario.Name = "t_usuario";
            this.t_usuario.Size = new System.Drawing.Size(369, 20);
            this.t_usuario.TabIndex = 1;
            this.t_usuario.Text = "USUARIO";
            this.t_usuario.Enter += new System.EventHandler(this.t_usuario_Enter);
            this.t_usuario.Leave += new System.EventHandler(this.t_usuario_Leave);
            // 
            // t_contraseña
            // 
            this.t_contraseña.BackColor = System.Drawing.Color.Navy;
            this.t_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t_contraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_contraseña.ForeColor = System.Drawing.Color.LightGray;
            this.t_contraseña.Location = new System.Drawing.Point(307, 170);
            this.t_contraseña.Name = "t_contraseña";
            this.t_contraseña.Size = new System.Drawing.Size(369, 20);
            this.t_contraseña.TabIndex = 2;
            this.t_contraseña.Text = "CONTRASEÑA";
            this.t_contraseña.TextChanged += new System.EventHandler(this.t_contraseña_TextChanged);
            this.t_contraseña.Enter += new System.EventHandler(this.t_contraseña_Enter);
            this.t_contraseña.Leave += new System.EventHandler(this.t_contraseña_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(301, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // botonAcceder
            // 
            this.botonAcceder.FlatAppearance.BorderSize = 0;
            this.botonAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.botonAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.botonAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAcceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAcceder.ForeColor = System.Drawing.Color.White;
            this.botonAcceder.Location = new System.Drawing.Point(307, 259);
            this.botonAcceder.Name = "botonAcceder";
            this.botonAcceder.Size = new System.Drawing.Size(369, 36);
            this.botonAcceder.TabIndex = 0;
            this.botonAcceder.Text = "ACCEDER";
            this.botonAcceder.UseVisualStyleBackColor = true;
            this.botonAcceder.Click += new System.EventHandler(this.botonAcceder_Click);
            this.botonAcceder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.botonAcceder_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(307, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 11);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(307, 196);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(369, 11);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // botonCerrar
            // 
            this.botonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("botonCerrar.Image")));
            this.botonCerrar.Location = new System.Drawing.Point(739, 8);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(25, 25);
            this.botonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonCerrar.TabIndex = 7;
            this.botonCerrar.TabStop = false;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // botonMinimizar
            // 
            this.botonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("botonMinimizar.Image")));
            this.botonMinimizar.Location = new System.Drawing.Point(708, 8);
            this.botonMinimizar.Name = "botonMinimizar";
            this.botonMinimizar.Size = new System.Drawing.Size(25, 25);
            this.botonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonMinimizar.TabIndex = 8;
            this.botonMinimizar.TabStop = false;
            this.botonMinimizar.Click += new System.EventHandler(this.botonMinimizar_Click);
            // 
            // l_Usuario
            // 
            this.l_Usuario.AutoSize = true;
            this.l_Usuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Usuario.ForeColor = System.Drawing.Color.DarkGray;
            this.l_Usuario.Location = new System.Drawing.Point(304, 129);
            this.l_Usuario.Name = "l_Usuario";
            this.l_Usuario.Size = new System.Drawing.Size(54, 17);
            this.l_Usuario.TabIndex = 9;
            this.l_Usuario.Text = "Usuario";
            this.l_Usuario.Visible = false;
            // 
            // l_Contraseña
            // 
            this.l_Contraseña.AutoSize = true;
            this.l_Contraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Contraseña.ForeColor = System.Drawing.Color.DarkGray;
            this.l_Contraseña.Location = new System.Drawing.Point(304, 210);
            this.l_Contraseña.Name = "l_Contraseña";
            this.l_Contraseña.Size = new System.Drawing.Size(84, 17);
            this.l_Contraseña.TabIndex = 10;
            this.l_Contraseña.Text = "Contraseña";
            this.l_Contraseña.Visible = false;
            // 
            // l_Login
            // 
            this.l_Login.AutoSize = true;
            this.l_Login.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Login.ForeColor = System.Drawing.Color.DarkGray;
            this.l_Login.Location = new System.Drawing.Point(304, 234);
            this.l_Login.Name = "l_Login";
            this.l_Login.Size = new System.Drawing.Size(0, 17);
            this.l_Login.TabIndex = 11;
            this.l_Login.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(772, 330);
            this.Controls.Add(this.l_Login);
            this.Controls.Add(this.l_Contraseña);
            this.Controls.Add(this.l_Usuario);
            this.Controls.Add(this.botonMinimizar);
            this.Controls.Add(this.botonCerrar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botonAcceder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_contraseña);
            this.Controls.Add(this.t_usuario);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox t_usuario;
        private System.Windows.Forms.TextBox t_contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonAcceder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox botonCerrar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox botonMinimizar;
        private System.Windows.Forms.Label l_Usuario;
        private System.Windows.Forms.Label l_Contraseña;
        private System.Windows.Forms.Label l_Login;
    }
}