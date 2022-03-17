namespace Ejercicio1_STRUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.richText_recetas = new System.Windows.Forms.RichTextBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.text_tiempo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_preparacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_numingredientes = new System.Windows.Forms.TextBox();
            this.text_ingredientes = new System.Windows.Forms.TextBox();
            this.text_nombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "RECETAS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.AutoSize = true;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(80, 32);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(126, 18);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.Text = "Nombre Receta";
            this.txt_nombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingedientes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "N de ingrdientes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btn_limpiar);
            this.panel1.Controls.Add(this.richText_recetas);
            this.panel1.Controls.Add(this.btn_consultar);
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.btn_modificar);
            this.panel1.Controls.Add(this.btn_registrar);
            this.panel1.Controls.Add(this.text_tiempo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.text_preparacion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.text_numingredientes);
            this.panel1.Controls.Add(this.text_ingredientes);
            this.panel1.Controls.Add(this.text_nombre);
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(294, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 428);
            this.panel1.TabIndex = 4;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(463, 201);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(62, 24);
            this.btn_limpiar.TabIndex = 16;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // richText_recetas
            // 
            this.richText_recetas.Location = new System.Drawing.Point(71, 293);
            this.richText_recetas.Name = "richText_recetas";
            this.richText_recetas.Size = new System.Drawing.Size(444, 118);
            this.richText_recetas.TabIndex = 15;
            this.richText_recetas.Text = "";
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_consultar.Font = new System.Drawing.Font("Segoe Print", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.Location = new System.Drawing.Point(244, 245);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(92, 32);
            this.btn_consultar.TabIndex = 14;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_eliminar.Font = new System.Drawing.Font("Segoe Print", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(440, 139);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(85, 34);
            this.btn_eliminar.TabIndex = 13;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_modificar.Font = new System.Drawing.Font("Segoe Print", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(440, 82);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(85, 39);
            this.btn_modificar.TabIndex = 12;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_registrar.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.Location = new System.Drawing.Point(440, 31);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(85, 33);
            this.btn_registrar.TabIndex = 11;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // text_tiempo
            // 
            this.text_tiempo.Location = new System.Drawing.Point(232, 156);
            this.text_tiempo.Name = "text_tiempo";
            this.text_tiempo.Size = new System.Drawing.Size(128, 20);
            this.text_tiempo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tiempo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // text_preparacion
            // 
            this.text_preparacion.Location = new System.Drawing.Point(232, 204);
            this.text_preparacion.Name = "text_preparacion";
            this.text_preparacion.Size = new System.Drawing.Size(222, 20);
            this.text_preparacion.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Preparación";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // text_numingredientes
            // 
            this.text_numingredientes.Location = new System.Drawing.Point(232, 68);
            this.text_numingredientes.Name = "text_numingredientes";
            this.text_numingredientes.Size = new System.Drawing.Size(128, 20);
            this.text_numingredientes.TabIndex = 6;
            // 
            // text_ingredientes
            // 
            this.text_ingredientes.Location = new System.Drawing.Point(232, 111);
            this.text_ingredientes.Name = "text_ingredientes";
            this.text_ingredientes.Size = new System.Drawing.Size(128, 20);
            this.text_ingredientes.TabIndex = 5;
            // 
            // text_nombre
            // 
            this.text_nombre.Location = new System.Drawing.Point(232, 31);
            this.text_nombre.Name = "text_nombre";
            this.text_nombre.Size = new System.Drawing.Size(128, 20);
            this.text_nombre.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(624, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 555);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox text_numingredientes;
        private System.Windows.Forms.TextBox text_ingredientes;
        private System.Windows.Forms.TextBox text_nombre;
        private System.Windows.Forms.TextBox text_preparacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richText_recetas;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.TextBox text_tiempo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_limpiar;
    }
}

