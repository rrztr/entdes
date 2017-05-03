namespace Práctica2_2EV
{
    partial class form_add_barco
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
            this.Nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_prioridad = new System.Windows.Forms.ComboBox();
            this.Prioridad = new System.Windows.Forms.Label();
            this.tipobarco = new System.Windows.Forms.Label();
            this.img_barco_elegido = new System.Windows.Forms.PictureBox();
            this.label_barco_elegido = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label_metros = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.radio_pasajeros = new System.Windows.Forms.RadioButton();
            this.radio_comerciante = new System.Windows.Forms.RadioButton();
            this.boton_mas1 = new System.Windows.Forms.Button();
            this.boton_mas25 = new System.Windows.Forms.Button();
            this.boton_menos1 = new System.Windows.Forms.Button();
            this.boton_menos25 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_tipo = new System.Windows.Forms.GroupBox();
            this.boton_ordenarA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_barco_elegido)).BeginInit();
            this.gb_tipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(12, 113);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre";
            this.Nombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(58, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "INSERTAR BARCO";
            // 
            // combo_prioridad
            // 
            this.combo_prioridad.DisplayMember = "1";
            this.combo_prioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_prioridad.FormattingEnabled = true;
            this.combo_prioridad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.combo_prioridad.Location = new System.Drawing.Point(92, 156);
            this.combo_prioridad.Name = "combo_prioridad";
            this.combo_prioridad.Size = new System.Drawing.Size(117, 21);
            this.combo_prioridad.TabIndex = 3;
            this.combo_prioridad.Tag = "";
            this.combo_prioridad.SelectedIndexChanged += new System.EventHandler(this.combo_prioridad_SelectedIndexChanged);
            // 
            // Prioridad
            // 
            this.Prioridad.AutoSize = true;
            this.Prioridad.Location = new System.Drawing.Point(12, 159);
            this.Prioridad.Name = "Prioridad";
            this.Prioridad.Size = new System.Drawing.Size(48, 13);
            this.Prioridad.TabIndex = 4;
            this.Prioridad.Text = "Prioridad";
            // 
            // tipobarco
            // 
            this.tipobarco.AutoSize = true;
            this.tipobarco.Location = new System.Drawing.Point(24, 31);
            this.tipobarco.Name = "tipobarco";
            this.tipobarco.Size = new System.Drawing.Size(28, 13);
            this.tipobarco.TabIndex = 5;
            this.tipobarco.Text = "Tipo";
            // 
            // img_barco_elegido
            // 
            this.img_barco_elegido.Location = new System.Drawing.Point(356, 198);
            this.img_barco_elegido.Name = "img_barco_elegido";
            this.img_barco_elegido.Size = new System.Drawing.Size(50, 50);
            this.img_barco_elegido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_barco_elegido.TabIndex = 9;
            this.img_barco_elegido.TabStop = false;
            this.img_barco_elegido.Click += new System.EventHandler(this.img_barco_elegido_Click);
            // 
            // label_barco_elegido
            // 
            this.label_barco_elegido.AutoSize = true;
            this.label_barco_elegido.Location = new System.Drawing.Point(353, 308);
            this.label_barco_elegido.Name = "label_barco_elegido";
            this.label_barco_elegido.Size = new System.Drawing.Size(72, 13);
            this.label_barco_elegido.TabIndex = 10;
            this.label_barco_elegido.Text = "Barco elegido";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "AÑADIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Mostrar barcos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_metros
            // 
            this.label_metros.AutoSize = true;
            this.label_metros.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_metros.Location = new System.Drawing.Point(86, 343);
            this.label_metros.Name = "label_metros";
            this.label_metros.Size = new System.Drawing.Size(29, 31);
            this.label_metros.TabIndex = 17;
            this.label_metros.Text = "0";
            this.label_metros.Click += new System.EventHandler(this.label_metros_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(166, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 34);
            this.button3.TabIndex = 18;
            this.button3.Text = "+10";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 347);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 34);
            this.button4.TabIndex = 19;
            this.button4.Text = "-10";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // radio_pasajeros
            // 
            this.radio_pasajeros.AutoSize = true;
            this.radio_pasajeros.Location = new System.Drawing.Point(88, 19);
            this.radio_pasajeros.Name = "radio_pasajeros";
            this.radio_pasajeros.Size = new System.Drawing.Size(71, 17);
            this.radio_pasajeros.TabIndex = 20;
            this.radio_pasajeros.TabStop = true;
            this.radio_pasajeros.Text = "Pasajeros";
            this.radio_pasajeros.UseVisualStyleBackColor = true;
            this.radio_pasajeros.CheckedChanged += new System.EventHandler(this.radio_pasajeros_CheckedChanged);
            // 
            // radio_comerciante
            // 
            this.radio_comerciante.AutoSize = true;
            this.radio_comerciante.Location = new System.Drawing.Point(88, 40);
            this.radio_comerciante.Name = "radio_comerciante";
            this.radio_comerciante.Size = new System.Drawing.Size(84, 17);
            this.radio_comerciante.TabIndex = 21;
            this.radio_comerciante.TabStop = true;
            this.radio_comerciante.Text = "Comerciante";
            this.radio_comerciante.UseVisualStyleBackColor = true;
            this.radio_comerciante.CheckedChanged += new System.EventHandler(this.radio_comerciante_CheckedChanged);
            // 
            // boton_mas1
            // 
            this.boton_mas1.Location = new System.Drawing.Point(166, 308);
            this.boton_mas1.Name = "boton_mas1";
            this.boton_mas1.Size = new System.Drawing.Size(43, 35);
            this.boton_mas1.TabIndex = 22;
            this.boton_mas1.Text = "+1";
            this.boton_mas1.UseVisualStyleBackColor = true;
            this.boton_mas1.Click += new System.EventHandler(this.boton_mas1_Click);
            // 
            // boton_mas25
            // 
            this.boton_mas25.Location = new System.Drawing.Point(166, 387);
            this.boton_mas25.Name = "boton_mas25";
            this.boton_mas25.Size = new System.Drawing.Size(43, 33);
            this.boton_mas25.TabIndex = 23;
            this.boton_mas25.Text = "+25";
            this.boton_mas25.UseVisualStyleBackColor = true;
            this.boton_mas25.Click += new System.EventHandler(this.boton_mas25_Click);
            // 
            // boton_menos1
            // 
            this.boton_menos1.Location = new System.Drawing.Point(15, 308);
            this.boton_menos1.Name = "boton_menos1";
            this.boton_menos1.Size = new System.Drawing.Size(41, 35);
            this.boton_menos1.TabIndex = 24;
            this.boton_menos1.Text = "-1";
            this.boton_menos1.UseVisualStyleBackColor = true;
            this.boton_menos1.Click += new System.EventHandler(this.boton_menos1_Click);
            // 
            // boton_menos25
            // 
            this.boton_menos25.Location = new System.Drawing.Point(15, 387);
            this.boton_menos25.Name = "boton_menos25";
            this.boton_menos25.Size = new System.Drawing.Size(41, 33);
            this.boton_menos25.TabIndex = 25;
            this.boton_menos25.Text = "-25";
            this.boton_menos25.UseVisualStyleBackColor = true;
            this.boton_menos25.Click += new System.EventHandler(this.boton_menos25_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Longitud";
            // 
            // gb_tipo
            // 
            this.gb_tipo.Controls.Add(this.radio_comerciante);
            this.gb_tipo.Controls.Add(this.radio_pasajeros);
            this.gb_tipo.Controls.Add(this.tipobarco);
            this.gb_tipo.Location = new System.Drawing.Point(4, 191);
            this.gb_tipo.Name = "gb_tipo";
            this.gb_tipo.Size = new System.Drawing.Size(208, 79);
            this.gb_tipo.TabIndex = 27;
            this.gb_tipo.TabStop = false;
            // 
            // boton_ordenarA
            // 
            this.boton_ordenarA.Location = new System.Drawing.Point(238, 61);
            this.boton_ordenarA.Name = "boton_ordenarA";
            this.boton_ordenarA.Size = new System.Drawing.Size(144, 28);
            this.boton_ordenarA.TabIndex = 28;
            this.boton_ordenarA.Text = "Ordenar A";
            this.boton_ordenarA.UseVisualStyleBackColor = true;
            this.boton_ordenarA.Click += new System.EventHandler(this.boton_ordenarA_Click);
            // 
            // form_add_barco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 442);
            this.Controls.Add(this.boton_ordenarA);
            this.Controls.Add(this.gb_tipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton_menos25);
            this.Controls.Add(this.boton_menos1);
            this.Controls.Add(this.boton_mas25);
            this.Controls.Add(this.boton_mas1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label_metros);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_barco_elegido);
            this.Controls.Add(this.img_barco_elegido);
            this.Controls.Add(this.Prioridad);
            this.Controls.Add(this.combo_prioridad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Name = "form_add_barco";
            this.Text = "Añadir barco";
            this.Load += new System.EventHandler(this.form_add_barco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_barco_elegido)).EndInit();
            this.gb_tipo.ResumeLayout(false);
            this.gb_tipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_prioridad;
        private System.Windows.Forms.Label Prioridad;
        private System.Windows.Forms.Label tipobarco;
        private System.Windows.Forms.PictureBox img_barco_elegido;
        private System.Windows.Forms.Label label_barco_elegido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_metros;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton radio_pasajeros;
        private System.Windows.Forms.RadioButton radio_comerciante;
        private System.Windows.Forms.Button boton_mas1;
        private System.Windows.Forms.Button boton_mas25;
        private System.Windows.Forms.Button boton_menos1;
        private System.Windows.Forms.Button boton_menos25;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_tipo;
        private System.Windows.Forms.Button boton_ordenarA;
    }
}

