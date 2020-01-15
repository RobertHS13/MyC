namespace CapaPresentacion
{
    partial class Form_Mensaje_E
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Mensaje_E));
            this.b_aceptar = new System.Windows.Forms.Button();
            this.lb_mensajeE = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_aceptar
            // 
            this.b_aceptar.BackColor = System.Drawing.Color.Transparent;
            this.b_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.b_aceptar.FlatAppearance.BorderSize = 0;
            this.b_aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b_aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.b_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_aceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_aceptar.ForeColor = System.Drawing.Color.Black;
            this.b_aceptar.Location = new System.Drawing.Point(161, 54);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(101, 27);
            this.b_aceptar.TabIndex = 4;
            this.b_aceptar.Text = "Aceptar";
            this.b_aceptar.UseVisualStyleBackColor = false;
            this.b_aceptar.Click += new System.EventHandler(this.b_aceptar_Click);
            // 
            // lb_mensajeE
            // 
            this.lb_mensajeE.AutoSize = true;
            this.lb_mensajeE.BackColor = System.Drawing.Color.Transparent;
            this.lb_mensajeE.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mensajeE.ForeColor = System.Drawing.Color.Black;
            this.lb_mensajeE.Location = new System.Drawing.Point(87, 23);
            this.lb_mensajeE.Name = "lb_mensajeE";
            this.lb_mensajeE.Size = new System.Drawing.Size(47, 17);
            this.lb_mensajeE.TabIndex = 3;
            this.lb_mensajeE.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Form_Mensaje_E
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(373, 91);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.lb_mensajeE);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Mensaje_E";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Mensaje_E";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.Label lb_mensajeE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}