namespace PruebaSagrarioJrea
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnListFact = new Button();
            btnListClient = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(296, 33);
            label1.Name = "label1";
            label1.Size = new Size(168, 20);
            label1.TabIndex = 0;
            label1.Text = "Prueba Tecnica Sagrario";
            label1.Click += label1_Click;
            // 
            // btnListFact
            // 
            btnListFact.Location = new Point(305, 85);
            btnListFact.Name = "btnListFact";
            btnListFact.Size = new Size(149, 29);
            btnListFact.TabIndex = 2;
            btnListFact.Text = "Tabla Facturas";
            btnListFact.UseVisualStyleBackColor = true;
            btnListFact.Click += btnListFact_Click;
            // 
            // btnListClient
            // 
            btnListClient.Location = new Point(305, 159);
            btnListClient.Name = "btnListClient";
            btnListClient.Size = new Size(149, 29);
            btnListClient.TabIndex = 3;
            btnListClient.Text = "Tabla clientes";
            btnListClient.UseVisualStyleBackColor = true;
            btnListClient.Click += btnListClient_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListClient);
            Controls.Add(btnListFact);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnListFact;
        private Button btnListClient;
    }
}