namespace Inicio_Sesion
{
    partial class Director
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
            this.NombrUsu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.rango = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Hola
            // 
            this.Hola.AutoSize = true;
            this.Hola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hola.Location = new System.Drawing.Point(115, 24);
            this.Hola.Name = "Hola";
            this.Hola.Size = new System.Drawing.Size(0, 25);
            this.Hola.TabIndex = 0;
            // 
            // NombrUsu
            // 
            this.NombrUsu.AutoSize = true;
            this.NombrUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombrUsu.Location = new System.Drawing.Point(93, 49);
            this.NombrUsu.Name = "NombrUsu";
            this.NombrUsu.Size = new System.Drawing.Size(236, 25);
            this.NombrUsu.TabIndex = 1;
            this.NombrUsu.Text = "Bienvenido a la institución";
            this.NombrUsu.Click += new System.EventHandler(this.NombrUsu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "¿Qué le gustaría hacer?";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Visualizar alumnos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(199, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Visualizar maestros";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(19, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 51);
            this.button3.TabIndex = 5;
            this.button3.Text = "Modificar lista de alumnos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(199, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 51);
            this.button4.TabIndex = 6;
            this.button4.Text = "Modificar lista de maestros";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(19, 255);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 45);
            this.button5.TabIndex = 7;
            this.button5.Text = "Modificar rango";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(199, 255);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(160, 45);
            this.button6.TabIndex = 8;
            this.button6.Text = "Cerrar sesión";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(387, 50);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(56, 16);
            this.nombre.TabIndex = 9;
            this.nombre.Text = "Nombre";
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido.Location = new System.Drawing.Point(387, 75);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(57, 16);
            this.apellido.TabIndex = 10;
            this.apellido.Text = "Apellido";
            // 
            // rango
            // 
            this.rango.AutoSize = true;
            this.rango.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rango.Location = new System.Drawing.Point(387, 25);
            this.rango.Name = "rango";
            this.rango.Size = new System.Drawing.Size(101, 16);
            this.rango.TabIndex = 11;
            this.rango.Text = "Rango: Director";
            this.rango.Click += new System.EventHandler(this.rango_Click);
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(387, 100);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(54, 16);
            this.usuario.TabIndex = 12;
            this.usuario.Text = "Usuario";
            // 
            // Director
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 309);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.rango);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombrUsu);
            this.Controls.Add(this.Hola);
            this.Name = "Director";
            this.Text = "UsuarioCorrecto";
            this.Load += new System.EventHandler(this.UsuarioCorrecto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hola;
        private System.Windows.Forms.Label NombrUsu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.Label rango;
        private System.Windows.Forms.Label usuario;
    }
}