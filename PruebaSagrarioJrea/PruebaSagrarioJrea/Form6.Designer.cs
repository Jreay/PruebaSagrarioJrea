namespace PruebaSagrarioJrea
{
    partial class Form6
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
            txtEmail = new TextBox();
            txtApellido = new TextBox();
            txtDireccion = new TextBox();
            txtCelular = new TextBox();
            txtNombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnFind = new Button();
            lblIdentificacion = new Label();
            txtIdentificacion = new TextBox();
            label7 = new Label();
            txtProducto = new TextBox();
            label8 = new Label();
            txtCantidad = new TextBox();
            label9 = new Label();
            txtPrecio = new TextBox();
            btnAgg = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btnSave = new Button();
            txtTotalFinal = new TextBox();
            txtIVA = new TextBox();
            txtSubtotal = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 38);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Nueva Factura";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(527, 225);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(175, 27);
            txtEmail.TabIndex = 26;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(527, 155);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(175, 27);
            txtApellido.TabIndex = 25;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(174, 291);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(181, 27);
            txtDireccion.TabIndex = 24;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(174, 225);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(181, 27);
            txtCelular.TabIndex = 23;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(174, 159);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(181, 27);
            txtNombre.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(67, 294);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 21;
            label6.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(433, 225);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 20;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 225);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 19;
            label4.Text = "Celular";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(433, 162);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 18;
            label3.Text = "Apellidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 162);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 17;
            label2.Text = "Nombres";
            // 
            // btnFind
            // 
            btnFind.Location = new Point(483, 81);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 16;
            btnFind.Text = "Buscar";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Location = new Point(188, 84);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(99, 20);
            lblIdentificacion.TabIndex = 15;
            lblIdentificacion.Text = "Identificacion";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(318, 81);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(125, 27);
            txtIdentificacion.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 379);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 27;
            label7.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(160, 376);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(125, 27);
            txtProducto.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(312, 379);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 29;
            label8.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(387, 376);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(69, 27);
            txtCantidad.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(493, 379);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 31;
            label9.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(549, 376);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(64, 27);
            txtPrecio.TabIndex = 32;
            txtPrecio.TextChanged += textBox3_TextChanged;
            // 
            // btnAgg
            // 
            btnAgg.Location = new Point(652, 375);
            btnAgg.Name = "btnAgg";
            btnAgg.Size = new Size(94, 29);
            btnAgg.TabIndex = 33;
            btnAgg.Text = "Agregar";
            btnAgg.UseVisualStyleBackColor = true;
            btnAgg.Click += btnAgg_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Producto, Cantidad, Precio, Total });
            dataGridView1.Location = new Point(53, 439);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(691, 188);
            dataGridView1.TabIndex = 34;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(326, 810);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 29);
            btnSave.TabIndex = 35;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtTotalFinal
            // 
            txtTotalFinal.Location = new Point(348, 750);
            txtTotalFinal.Name = "txtTotalFinal";
            txtTotalFinal.Size = new Size(125, 27);
            txtTotalFinal.TabIndex = 70;
            // 
            // txtIVA
            // 
            txtIVA.Location = new Point(348, 703);
            txtIVA.Name = "txtIVA";
            txtIVA.Size = new Size(125, 27);
            txtIVA.TabIndex = 69;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(348, 655);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(125, 27);
            txtSubtotal.TabIndex = 68;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(277, 750);
            label12.Name = "label12";
            label12.Size = new Size(42, 20);
            label12.TabIndex = 67;
            label12.Text = "Total";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(277, 703);
            label11.Name = "label11";
            label11.Size = new Size(63, 20);
            label11.TabIndex = 66;
            label11.Text = "IVA 12%";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(277, 658);
            label10.Name = "label10";
            label10.Size = new Size(65, 20);
            label10.TabIndex = 65;
            label10.Text = "Subtotal";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 865);
            Controls.Add(txtTotalFinal);
            Controls.Add(txtIVA);
            Controls.Add(txtSubtotal);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(btnSave);
            Controls.Add(dataGridView1);
            Controls.Add(btnAgg);
            Controls.Add(txtPrecio);
            Controls.Add(label9);
            Controls.Add(txtCantidad);
            Controls.Add(label8);
            Controls.Add(txtProducto);
            Controls.Add(label7);
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
            Name = "Form6";
            Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private TextBox txtApellido;
        private TextBox txtDireccion;
        private TextBox txtCelular;
        private TextBox txtNombre;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnFind;
        private Label lblIdentificacion;
        private TextBox txtIdentificacion;
        private Label label7;
        private TextBox txtProducto;
        private Label label8;
        private TextBox txtCantidad;
        private Label label9;
        private TextBox txtPrecio;
        private Button btnAgg;
        private DataGridView dataGridView1;
        private Button btnSave;
        private TextBox txtTotalFinal;
        private TextBox txtIVA;
        private TextBox txtSubtotal;
        private Label label12;
        private Label label11;
        private Label label10;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Total;
    }
}