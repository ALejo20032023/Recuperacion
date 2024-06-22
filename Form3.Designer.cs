namespace examenreupe
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
            label2 = new Label();
            txtNewUsuario = new TextBox();
            label3 = new Label();
            txtNewContra = new TextBox();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 38);
            label1.Name = "label1";
            label1.Size = new Size(173, 20);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DE USUARIOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 91);
            label2.Name = "label2";
            label2.Size = new Size(243, 20);
            label2.TabIndex = 1;
            label2.Text = "INGRESE SU NOMBRE DE USUARIO";
            // 
            // txtNewUsuario
            // 
            txtNewUsuario.Location = new Point(154, 124);
            txtNewUsuario.Name = "txtNewUsuario";
            txtNewUsuario.Size = new Size(244, 27);
            txtNewUsuario.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 193);
            label3.Name = "label3";
            label3.Size = new Size(188, 20);
            label3.TabIndex = 3;
            label3.Text = "INGRESE SU CONTRASEÑA";
            // 
            // txtNewContra
            // 
            txtNewContra.Location = new Point(153, 226);
            txtNewContra.Name = "txtNewContra";
            txtNewContra.Size = new Size(244, 27);
            txtNewContra.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(172, 299);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(199, 60);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "REGISTRAR USUARIO";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 471);
            Controls.Add(btnRegistrar);
            Controls.Add(txtNewContra);
            Controls.Add(label3);
            Controls.Add(txtNewUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNewUsuario;
        private Label label3;
        private TextBox txtNewContra;
        private Button btnRegistrar;
    }
}