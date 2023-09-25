namespace PruebaSagrarioJrea
{
    partial class Form3
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
            btnViewFact = new Button();
            btnSaveFact = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 65);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 0;
            label1.Text = "Listado de Facturas";
            // 
            // btnViewFact
            // 
            btnViewFact.Location = new Point(312, 115);
            btnViewFact.Name = "btnViewFact";
            btnViewFact.Size = new Size(94, 29);
            btnViewFact.TabIndex = 2;
            btnViewFact.Text = "Consultar";
            btnViewFact.UseVisualStyleBackColor = true;
            btnViewFact.Click += button1_Click;
            // 
            // btnSaveFact
            // 
            btnSaveFact.Location = new Point(292, 206);
            btnSaveFact.Name = "btnSaveFact";
            btnSaveFact.Size = new Size(135, 29);
            btnSaveFact.TabIndex = 3;
            btnSaveFact.Text = "Nueva Factura";
            btnSaveFact.UseVisualStyleBackColor = true;
            btnSaveFact.Click += btnSaveFact_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 413);
            Controls.Add(btnSaveFact);
            Controls.Add(btnViewFact);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnViewFact;
        private Button btnSaveFact;
    }
}