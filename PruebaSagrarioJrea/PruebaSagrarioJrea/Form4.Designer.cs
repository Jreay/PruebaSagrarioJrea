namespace PruebaSagrarioJrea
{
    partial class Form4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtIdentificacion = new TextBox();
            txtApellido = new TextBox();
            txtEmail = new TextBox();
            txtNombre = new TextBox();
            txtCelular = new TextBox();
            txtDireccion = new TextBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 36);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(413, 138);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 204);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Apellidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(413, 204);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 3;
            label4.Text = "Celular";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 274);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 138);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 5;
            label6.Text = "Identificacion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(413, 274);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 6;
            label7.Text = "Direccion";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(181, 131);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(125, 27);
            txtIdentificacion.TabIndex = 7;
            txtIdentificacion.TextChanged += textBox1_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(181, 197);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(181, 271);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(528, 131);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 10;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(528, 201);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(125, 27);
            txtCelular.TabIndex = 11;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(528, 274);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(125, 27);
            txtDireccion.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(335, 360);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(txtDireccion);
            Controls.Add(txtCelular);
            Controls.Add(txtNombre);
            Controls.Add(txtEmail);
            Controls.Add(txtApellido);
            Controls.Add(txtIdentificacion);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtIdentificacion;
        private TextBox txtApellido;
        private TextBox txtEmail;
        private TextBox txtNombre;
        private TextBox txtCelular;
        private TextBox txtDireccion;
        private Button btnGuardar;
    }
}