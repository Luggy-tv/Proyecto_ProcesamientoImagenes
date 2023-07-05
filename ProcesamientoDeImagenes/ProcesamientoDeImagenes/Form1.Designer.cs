namespace ProcesamientoDeImagenes
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
            panelMenu = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            button4 = new Button();
            label1 = new Label();
            button5 = new Button();
            button6 = new Button();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(17, 0, 158);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(190, 591);
            panelMenu.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(73, 66, 228);
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Gainsboro;
            button3.Image = Properties.Resources.Camera_100x100;
            button3.Location = new Point(5, 400);
            button3.Name = "button3";
            button3.Size = new Size(180, 190);
            button3.TabIndex = 2;
            button3.Text = "Abrir Camara";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(73, 66, 228);
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Gainsboro;
            button2.Image = Properties.Resources.Video_100x100;
            button2.Location = new Point(5, 200);
            button2.Name = "button2";
            button2.Size = new Size(180, 190);
            button2.TabIndex = 1;
            button2.Text = "Seleccionar   Video";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(73, 66, 228);
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Gainsboro;
            button1.Image = Properties.Resources.Image_100x100;
            button1.Location = new Point(5, 0);
            button1.Name = "button1";
            button1.Size = new Size(180, 190);
            button1.TabIndex = 0;
            button1.Text = "Seleccionar Imagen";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(214, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(475, 294);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(714, 53);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(258, 23);
            comboBox1.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(73, 66, 228);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Gainsboro;
            button4.Location = new Point(714, 124);
            button4.Name = "button4";
            button4.Size = new Size(258, 66);
            button4.TabIndex = 3;
            button4.Text = "Aplicar Filtro";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(714, 20);
            label1.Name = "label1";
            label1.Size = new Size(233, 30);
            label1.TabIndex = 4;
            label1.Text = "Selecciona una opcion:";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(17, 0, 158);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Gainsboro;
            button5.Location = new Point(714, 255);
            button5.Name = "button5";
            button5.Size = new Size(258, 66);
            button5.TabIndex = 5;
            button5.Text = "Guardar Imagen";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(196, 186, 255);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(714, 200);
            button6.Name = "button6";
            button6.Size = new Size(258, 40);
            button6.TabIndex = 6;
            button6.Text = "Quitar Filtro";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(134, 150, 254);
            ClientSize = new Size(984, 591);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Procesamiento de Imagenes";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Button button1;
        private Button button3;
        private Button button2;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Button button4;
        private Label label1;
        private Button button5;
        private Button button6;
    }
}