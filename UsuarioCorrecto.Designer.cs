namespace Inicio_Sesion
{
    partial class UsuarioCorrecto
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
            this.Hola = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            this.NombrUsu = new System.Windows.Forms.Label();
            this.NombContra = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Hola
            // 
            this.Hola.AutoSize = true;
            this.Hola.Location = new System.Drawing.Point(259, 27);
            this.Hola.Name = "Hola";
            this.Hola.Size = new System.Drawing.Size(0, 13);
            this.Hola.TabIndex = 0;
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(219, 17);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 3;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // NombrUsu
            // 
            this.NombrUsu.AutoSize = true;
            this.NombrUsu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NombrUsu.Location = new System.Drawing.Point(15, 64);
            this.NombrUsu.Name = "NombrUsu";
            this.NombrUsu.Size = new System.Drawing.Size(10, 13);
            this.NombrUsu.TabIndex = 1;
            this.NombrUsu.Text = ".";
            this.NombrUsu.Click += new System.EventHandler(this.NombrUsu_Click);
            // 
            // NombContra
            // 
            this.NombContra.AutoSize = true;
            this.NombContra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NombContra.Location = new System.Drawing.Point(15, 90);
            this.NombContra.Name = "NombContra";
            this.NombContra.Size = new System.Drawing.Size(10, 13);
            this.NombContra.TabIndex = 4;
            this.NombContra.Text = ".";
            this.NombContra.Click += new System.EventHandler(this.contra_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cerrar sesión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UsuarioCorrecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(306, 193);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NombContra);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.NombrUsu);
            this.Controls.Add(this.Hola);
            this.Name = "UsuarioCorrecto";
            this.Text = "Página de inicio";
            this.Load += new System.EventHandler(this.UsuarioCorrecto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hola;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Label NombrUsu;
        private System.Windows.Forms.Label NombContra;
        private System.Windows.Forms.Button button1;
    }
}