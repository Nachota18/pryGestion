namespace pryGestion
{
    partial class frmMostrar
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
            this.btnIngresarActividad = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresarActividad
            // 
            this.btnIngresarActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarActividad.Location = new System.Drawing.Point(43, 163);
            this.btnIngresarActividad.Name = "btnIngresarActividad";
            this.btnIngresarActividad.Size = new System.Drawing.Size(221, 49);
            this.btnIngresarActividad.TabIndex = 3;
            this.btnIngresarActividad.Text = "Ingresar Actividad";
            this.btnIngresarActividad.UseVisualStyleBackColor = true;
            this.btnIngresarActividad.Click += new System.EventHandler(this.btnIngresarActividad_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(43, 283);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(221, 45);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 370);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnIngresarActividad);
            this.Name = "frmMostrar";
            this.Text = "Actividad";
            this.Load += new System.EventHandler(this.frmMostrar_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnIngresarActividad;
        private System.Windows.Forms.Button btnVolver;
    }
}