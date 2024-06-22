namespace examenreupe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtagregarc = new TextBox();
            btnAgregarCan = new Button();
            btnAgregarPlay = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            btnEliminarPlay = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 177);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE DE LA CANCION";
            label1.Click += label1_Click;
            // 
            // txtagregarc
            // 
            txtagregarc.Location = new Point(32, 202);
            txtagregarc.Name = "txtagregarc";
            txtagregarc.Size = new Size(148, 23);
            txtagregarc.TabIndex = 1;
            // 
            // btnAgregarCan
            // 
            btnAgregarCan.Location = new Point(32, 231);
            btnAgregarCan.Name = "btnAgregarCan";
            btnAgregarCan.Size = new Size(148, 31);
            btnAgregarCan.TabIndex = 2;
            btnAgregarCan.Text = "AGREGAR CANCION";
            btnAgregarCan.UseVisualStyleBackColor = true;
            btnAgregarCan.Click += btnAgregarCan_Click;
            // 
            // btnAgregarPlay
            // 
            btnAgregarPlay.Location = new Point(459, 177);
            btnAgregarPlay.Name = "btnAgregarPlay";
            btnAgregarPlay.Size = new Size(156, 40);
            btnAgregarPlay.TabIndex = 3;
            btnAgregarPlay.Text = "AGREGAR PLAYLIST";
            btnAgregarPlay.UseVisualStyleBackColor = true;
            btnAgregarPlay.Click += btnAgregarPlay_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 278);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(281, 365);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(371, 278);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(347, 365);
            dataGridView2.TabIndex = 5;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // btnEliminarPlay
            // 
            btnEliminarPlay.Location = new Point(371, 231);
            btnEliminarPlay.Name = "btnEliminarPlay";
            btnEliminarPlay.Size = new Size(91, 37);
            btnEliminarPlay.TabIndex = 6;
            btnEliminarPlay.Text = "ELIMINAR";
            btnEliminarPlay.UseVisualStyleBackColor = true;
            btnEliminarPlay.Click += btnEliminarPlay_Click;
            // 
            // button1
            // 
            button1.Location = new Point(613, 231);
            button1.Name = "button1";
            button1.Size = new Size(91, 41);
            button1.TabIndex = 7;
            button1.Text = "MOSTRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(767, 142);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 655);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(btnEliminarPlay);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(btnAgregarPlay);
            Controls.Add(btnAgregarCan);
            Controls.Add(txtagregarc);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtagregarc;
        private Button btnAgregarCan;
        private Button btnAgregarPlay;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button btnEliminarPlay;
        private Button button1;
        private PictureBox pictureBox1;
    }
}