
namespace Veterinario2021
{
    partial class FormJaime
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
            this.Usuario = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.CreaUsuario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IniciaSesion = new System.Windows.Forms.Button();
            this.texto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Usuario
            // 
            this.Usuario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Usuario.Location = new System.Drawing.Point(273, 225);
            this.Usuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Usuario.Multiline = true;
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(230, 39);
            this.Usuario.TabIndex = 2;
            this.Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Usuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(273, 289);
            this.password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(230, 39);
            this.password.TabIndex = 3;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // CreaUsuario
            // 
            this.CreaUsuario.BackColor = System.Drawing.Color.White;
            this.CreaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreaUsuario.Location = new System.Drawing.Point(338, 399);
            this.CreaUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CreaUsuario.Name = "CreaUsuario";
            this.CreaUsuario.Size = new System.Drawing.Size(104, 32);
            this.CreaUsuario.TabIndex = 4;
            this.CreaUsuario.Text = "Registrate";
            this.CreaUsuario.UseVisualStyleBackColor = false;
            this.CreaUsuario.Click += new System.EventHandler(this.CreaUsuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Veterinario2021.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(117, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // IniciaSesion
            // 
            this.IniciaSesion.BackColor = System.Drawing.Color.DodgerBlue;
            this.IniciaSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IniciaSesion.ForeColor = System.Drawing.Color.White;
            this.IniciaSesion.Location = new System.Drawing.Point(144, 349);
            this.IniciaSesion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IniciaSesion.Name = "IniciaSesion";
            this.IniciaSesion.Size = new System.Drawing.Size(340, 44);
            this.IniciaSesion.TabIndex = 6;
            this.IniciaSesion.Text = "Inicia Sesión";
            this.IniciaSesion.UseVisualStyleBackColor = false;
            this.IniciaSesion.Click += new System.EventHandler(this.IniciaSesion_Click);
            // 
            // texto
            // 
            this.texto.BackColor = System.Drawing.Color.White;
            this.texto.ForeColor = System.Drawing.Color.Blue;
            this.texto.Location = new System.Drawing.Point(173, 396);
            this.texto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(139, 32);
            this.texto.TabIndex = 7;
            this.texto.Text = "¿No tiene una cuenta?";
            this.texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.texto.Click += new System.EventHandler(this.texto_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(128, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "DNI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(128, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contraseña";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormJaime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Veterinario2021.Properties.Resources.patas;
            this.ClientSize = new System.Drawing.Size(677, 487);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.IniciaSesion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CreaUsuario);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Usuario);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormJaime";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button CreaUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button IniciaSesion;
        private System.Windows.Forms.Label texto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

