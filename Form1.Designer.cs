﻿namespace Inicio_Sesion
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
            this.usuario = new System.Windows.Forms.TextBox();
            this.contra = new System.Windows.Forms.TextBox();
            this.txtusua = new System.Windows.Forms.Label();
            this.txtcontra = new System.Windows.Forms.Label();
            this.btningre = new System.Windows.Forms.Button();
            this.bntsalir = new System.Windows.Forms.Button();
            this.Hola = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(212, 180);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(144, 20);
            this.usuario.TabIndex = 0;
            this.usuario.TextChanged += new System.EventHandler(this.usuario_TextChanged);
            // 
            // contra
            // 
            this.contra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contra.Location = new System.Drawing.Point(212, 208);
            this.contra.Name = "contra";
            this.contra.PasswordChar = '*';
            this.contra.Size = new System.Drawing.Size(144, 20);
            this.contra.TabIndex = 1;
            // 
            // txtusua
            // 
            this.txtusua.AutoSize = true;
            this.txtusua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusua.Location = new System.Drawing.Point(51, 180);
            this.txtusua.Name = "txtusua";
            this.txtusua.Size = new System.Drawing.Size(96, 13);
            this.txtusua.TabIndex = 2;
            this.txtusua.Text = "Ingrese su usuario:";
            this.txtusua.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtcontra
            // 
            this.txtcontra.AutoSize = true;
            this.txtcontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontra.Location = new System.Drawing.Point(51, 211);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(115, 13);
            this.txtcontra.TabIndex = 3;
            this.txtcontra.Text = "Ingrese su contraseña:";
            // 
            // btningre
            // 
            this.btningre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btningre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btningre.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btningre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningre.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btningre.Location = new System.Drawing.Point(54, 240);
            this.btningre.Name = "btningre";
            this.btningre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btningre.Size = new System.Drawing.Size(127, 23);
            this.btningre.TabIndex = 4;
            this.btningre.Text = "Iniciar sesión";
            this.btningre.UseVisualStyleBackColor = false;
            this.btningre.Click += new System.EventHandler(this.btningre_Click);
            // 
            // bntsalir
            // 
            this.bntsalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bntsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntsalir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bntsalir.Location = new System.Drawing.Point(229, 240);
            this.bntsalir.Name = "bntsalir";
            this.bntsalir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bntsalir.Size = new System.Drawing.Size(127, 23);
            this.bntsalir.TabIndex = 5;
            this.bntsalir.Text = "Salir";
            this.bntsalir.UseVisualStyleBackColor = false;
            this.bntsalir.Click += new System.EventHandler(this.bntsalir_Click);
            // 
            // Hola
            // 
            this.Hola.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Hola.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.Hola.Location = new System.Drawing.Point(12, 65);
            this.Hola.Name = "Hola";
            this.Hola.Size = new System.Drawing.Size(392, 63);
            this.Hola.TabIndex = 0;
            this.Hola.Text = "¡BIENVENIDO!";
            this.Hola.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(117, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese sus datos para continuar";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // regis
            // 
            this.regis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.regis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regis.ForeColor = System.Drawing.SystemColors.Desktop;
            this.regis.Location = new System.Drawing.Point(143, 269);
            this.regis.Name = "regis";
            this.regis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.regis.Size = new System.Drawing.Size(127, 23);
            this.regis.TabIndex = 7;
            this.regis.Text = "Registrarse";
            this.regis.UseVisualStyleBackColor = false;
            this.regis.Click += new System.EventHandler(this.regis_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(399, 321);
            this.Controls.Add(this.regis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hola);
            this.Controls.Add(this.txtusua);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.bntsalir);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.btningre);
            this.Controls.Add(this.contra);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox contra;
        private System.Windows.Forms.Label txtusua;
        private System.Windows.Forms.Label txtcontra;
        private System.Windows.Forms.Button btningre;
        private System.Windows.Forms.Button bntsalir;
        private System.Windows.Forms.Label Hola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button regis;
    }
}

