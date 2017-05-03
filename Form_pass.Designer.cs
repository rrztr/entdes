namespace Práctica2_2EV
{
    partial class Form_pass
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
            this.titulo_contra = new System.Windows.Forms.Label();
            this.caja_pass = new System.Windows.Forms.TextBox();
            this.entrar_pass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo_contra
            // 
            this.titulo_contra.AutoSize = true;
            this.titulo_contra.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_contra.Location = new System.Drawing.Point(12, 73);
            this.titulo_contra.Name = "titulo_contra";
            this.titulo_contra.Size = new System.Drawing.Size(251, 28);
            this.titulo_contra.TabIndex = 0;
            this.titulo_contra.Text = "INTRODUZCA CONTRASEÑA";
            // 
            // caja_pass
            // 
            this.caja_pass.Location = new System.Drawing.Point(40, 122);
            this.caja_pass.Name = "caja_pass";
            this.caja_pass.Size = new System.Drawing.Size(206, 20);
            this.caja_pass.TabIndex = 1;
            this.caja_pass.UseSystemPasswordChar = true;
            this.caja_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.caja_pass_KeyDown);
            // 
            // entrar_pass
            // 
            this.entrar_pass.Location = new System.Drawing.Point(77, 164);
            this.entrar_pass.Name = "entrar_pass";
            this.entrar_pass.Size = new System.Drawing.Size(112, 23);
            this.entrar_pass.TabIndex = 2;
            this.entrar_pass.Text = "ENTRAR";
            this.entrar_pass.UseVisualStyleBackColor = true;
            this.entrar_pass.Click += new System.EventHandler(this.entrar_pass_Click);
            // 
            // Form_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.entrar_pass);
            this.Controls.Add(this.caja_pass);
            this.Controls.Add(this.titulo_contra);
            this.Name = "Form_pass";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo_contra;
        private System.Windows.Forms.TextBox caja_pass;
        private System.Windows.Forms.Button entrar_pass;
    }
}