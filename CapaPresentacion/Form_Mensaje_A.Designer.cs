namespace CapaPresentacion
{
    partial class Form_Mensaje_A
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Mensaje_A));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_mensajeA = new System.Windows.Forms.Label();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(24, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_mensajeA
            // 
            this.lb_mensajeA.AutoSize = true;
            this.lb_mensajeA.BackColor = System.Drawing.Color.Transparent;
            this.lb_mensajeA.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mensajeA.ForeColor = System.Drawing.Color.White;
            this.lb_mensajeA.Location = new System.Drawing.Point(98, 20);
            this.lb_mensajeA.Name = "lb_mensajeA";
            this.lb_mensajeA.Size = new System.Drawing.Size(47, 17);
            this.lb_mensajeA.TabIndex = 1;
            this.lb_mensajeA.Text = "label1";
            this.lb_mensajeA.Click += new System.EventHandler(this.lb_mensajeA_Click);
            // 
            // b_aceptar
            // 
            this.b_aceptar.BackColor = System.Drawing.Color.Transparent;
            this.b_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.b_aceptar.FlatAppearance.BorderSize = 0;
            this.b_aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b_aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.b_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_aceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_aceptar.ForeColor = System.Drawing.Color.White;
            this.b_aceptar.Location = new System.Drawing.Point(156, 52);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(101, 27);
            this.b_aceptar.TabIndex = 2;
            this.b_aceptar.Text = "Aceptar";
            this.b_aceptar.UseVisualStyleBackColor = false;
            this.b_aceptar.Click += new System.EventHandler(this.b_aceptar_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Form_Mensaje_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(373, 91);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.lb_mensajeA);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Mensaje_A";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Mensaje_A";
            this.Load += new System.EventHandler(this.Form_Mensaje_A_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_mensajeA;
        private System.Windows.Forms.Button b_aceptar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}