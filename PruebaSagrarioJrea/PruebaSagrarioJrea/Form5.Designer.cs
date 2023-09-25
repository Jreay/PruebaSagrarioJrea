namespace PruebaSagrarioJrea
{
    partial class Form5
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
            txtIdentificacion = new TextBox();
            lblIdentificacion = new Label();
            btnFind = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtCelular = new TextBox();
            txtDireccion = new TextBox();
            txtApellido = new TextBox();
            txtEmail = new TextBox();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 26);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 0;
            label1.Text = "Consultar Cliente";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(321, 65);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(125, 27);
            txtIdentificacion.TabIndex = 1;
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Location = new Point(191, 68);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(99, 20);
            lblIdentificacion.TabIndex = 2;
            lblIdentificacion.Text = "Identificacion";
            // 
            // btnFind
            // 
            btnFind.Location = new Point(486, 65);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 3;
            btnFind.Text = "Buscar";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 146);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(436, 146);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 5;
            label3.Text = "Apellidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 209);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 6;
            label4.Text = "Celular";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(436, 209);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 7;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 278);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 8;
            label6.Text = "Direccion";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(177, 143);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(181, 27);
            txtNombre.TabIndex = 9;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(177, 209);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(181, 27);
            txtCelular.TabIndex = 10;
            txtCelular.TextChanged += txtCelular_TextChanged;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(177, 275);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(181, 27);
            txtDireccion.TabIndex = 11;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(530, 139);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(175, 27);
            txtApellido.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(530, 209);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(175, 27);
            txtEmail.TabIndex = 13;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(338, 372);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(txtEmail);
            Controls.Add(txtApellido);
            Controls.Add(txtDireccion);
            Controls.Add(txtCelular);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnFind);
            Controls.Add(lblIdentificacion);
            Controls.Add(txtIdentificacion);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdentificacion;
        private Label lblIdentificacion;
        private Button btnFind;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtCelular;
        private TextBox txtDireccion;
        private TextBox txtApellido;
        private TextBox txtEmail;
        private Button btnUpdate;
    }
}