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
            button4_Inicio = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox_Camara = new GroupBox();
            label2_Camara = new Label();
            button7_Camara_Change = new Button();
            pictureBox_Camara = new PictureBox();
            comboBox_Camara = new ComboBox();
            button4_Imagen_Apply = new Button();
            label_Imagen = new Label();
            button5_Imagen_Save = new Button();
            button6_Imagen_Remove = new Button();
            groupBox_Imagen = new GroupBox();
            trackBar1_imagen = new TrackBar();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            pictureBox_Imagen_Azul = new PictureBox();
            pictureBox_Imagen_Verde = new PictureBox();
            pictureBox_Imagen_Rojo = new PictureBox();
            pictureBox_Imagen = new PictureBox();
            comboBox_imagen = new ComboBox();
            groupBox_Video = new GroupBox();
            trackBar2 = new TrackBar();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            pictureBox_Videos_Azul = new PictureBox();
            pictureBox_Videos_Verde = new PictureBox();
            pictureBox_Videos_Rojo = new PictureBox();
            pictureBox3_Video = new PictureBox();
            comboBox3_Video = new ComboBox();
            button8_Video_Apply = new Button();
            button9_Video_Remove = new Button();
            label3 = new Label();
            groupBox1_Inicio = new GroupBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelMenu.SuspendLayout();
            groupBox_Camara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Camara).BeginInit();
            groupBox_Imagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1_imagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Imagen_Azul).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Imagen_Verde).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Imagen_Rojo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Imagen).BeginInit();
            groupBox_Video.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Videos_Azul).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Videos_Verde).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Videos_Rojo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3_Video).BeginInit();
            groupBox1_Inicio.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(17, 0, 158);
            panelMenu.Controls.Add(button4_Inicio);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(190, 832);
            panelMenu.TabIndex = 0;
            // 
            // button4_Inicio
            // 
            button4_Inicio.BackColor = Color.FromArgb(73, 66, 228);
            button4_Inicio.BackgroundImageLayout = ImageLayout.Center;
            button4_Inicio.FlatAppearance.BorderSize = 0;
            button4_Inicio.FlatStyle = FlatStyle.Flat;
            button4_Inicio.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button4_Inicio.ForeColor = Color.Gainsboro;
            button4_Inicio.Image = (Image)resources.GetObject("button4_Inicio.Image");
            button4_Inicio.Location = new Point(0, 0);
            button4_Inicio.Name = "button4_Inicio";
            button4_Inicio.Size = new Size(190, 153);
            button4_Inicio.TabIndex = 3;
            button4_Inicio.Text = "Inicio";
            button4_Inicio.UseVisualStyleBackColor = false;
            button4_Inicio.Click += button4_Inicio_Click;
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
            button3.Location = new Point(0, 642);
            button3.Name = "button3";
            button3.Size = new Size(190, 190);
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
            button2.Location = new Point(0, 413);
            button2.Name = "button2";
            button2.Size = new Size(190, 190);
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
            button1.Location = new Point(-3, 190);
            button1.Name = "button1";
            button1.Size = new Size(193, 190);
            button1.TabIndex = 0;
            button1.Text = "Seleccionar Imagen";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox_Camara
            // 
            groupBox_Camara.Controls.Add(label2_Camara);
            groupBox_Camara.Controls.Add(button7_Camara_Change);
            groupBox_Camara.Controls.Add(pictureBox_Camara);
            groupBox_Camara.Controls.Add(comboBox_Camara);
            groupBox_Camara.Location = new Point(196, 12);
            groupBox_Camara.Name = "groupBox_Camara";
            groupBox_Camara.Size = new Size(980, 812);
            groupBox_Camara.TabIndex = 8;
            groupBox_Camara.TabStop = false;
            groupBox_Camara.Text = "Controles de Camara";
            groupBox_Camara.Visible = false;
            // 
            // label2_Camara
            // 
            label2_Camara.AutoSize = true;
            label2_Camara.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2_Camara.Location = new Point(6, 19);
            label2_Camara.Name = "label2_Camara";
            label2_Camara.Size = new Size(254, 30);
            label2_Camara.TabIndex = 4;
            label2_Camara.Text = "Selecciona un dispositivo";
            // 
            // button7_Camara_Change
            // 
            button7_Camara_Change.BackColor = Color.FromArgb(73, 66, 228);
            button7_Camara_Change.FlatAppearance.BorderSize = 0;
            button7_Camara_Change.FlatStyle = FlatStyle.Flat;
            button7_Camara_Change.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button7_Camara_Change.ForeColor = Color.Gainsboro;
            button7_Camara_Change.Location = new Point(289, 25);
            button7_Camara_Change.Name = "button7_Camara_Change";
            button7_Camara_Change.Size = new Size(252, 50);
            button7_Camara_Change.TabIndex = 3;
            button7_Camara_Change.Text = "Cambiar ";
            button7_Camara_Change.UseVisualStyleBackColor = false;
            // 
            // pictureBox_Camara
            // 
            pictureBox_Camara.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_Camara.Location = new Point(8, 88);
            pictureBox_Camara.Name = "pictureBox_Camara";
            pictureBox_Camara.Size = new Size(960, 600);
            pictureBox_Camara.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Camara.TabIndex = 1;
            pictureBox_Camara.TabStop = false;
            // 
            // comboBox_Camara
            // 
            comboBox_Camara.FormattingEnabled = true;
            comboBox_Camara.Location = new Point(8, 52);
            comboBox_Camara.Name = "comboBox_Camara";
            comboBox_Camara.Size = new Size(252, 23);
            comboBox_Camara.TabIndex = 2;
            comboBox_Camara.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button4_Imagen_Apply
            // 
            button4_Imagen_Apply.BackColor = Color.FromArgb(73, 66, 228);
            button4_Imagen_Apply.FlatAppearance.BorderSize = 0;
            button4_Imagen_Apply.FlatStyle = FlatStyle.Flat;
            button4_Imagen_Apply.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button4_Imagen_Apply.ForeColor = Color.Gainsboro;
            button4_Imagen_Apply.Location = new Point(707, 124);
            button4_Imagen_Apply.Name = "button4_Imagen_Apply";
            button4_Imagen_Apply.Size = new Size(252, 66);
            button4_Imagen_Apply.TabIndex = 3;
            button4_Imagen_Apply.Text = "Aplicar Filtro";
            button4_Imagen_Apply.UseVisualStyleBackColor = false;
            button4_Imagen_Apply.Click += button4_Click;
            // 
            // label_Imagen
            // 
            label_Imagen.AutoSize = true;
            label_Imagen.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label_Imagen.Location = new Point(707, 37);
            label_Imagen.Name = "label_Imagen";
            label_Imagen.Size = new Size(233, 30);
            label_Imagen.TabIndex = 4;
            label_Imagen.Text = "Selecciona una opcion:";
            // 
            // button5_Imagen_Save
            // 
            button5_Imagen_Save.BackColor = Color.FromArgb(17, 0, 158);
            button5_Imagen_Save.FlatAppearance.BorderSize = 0;
            button5_Imagen_Save.FlatStyle = FlatStyle.Flat;
            button5_Imagen_Save.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button5_Imagen_Save.ForeColor = Color.Gainsboro;
            button5_Imagen_Save.Location = new Point(707, 249);
            button5_Imagen_Save.Name = "button5_Imagen_Save";
            button5_Imagen_Save.Size = new Size(252, 66);
            button5_Imagen_Save.TabIndex = 5;
            button5_Imagen_Save.Text = "Guardar Imagen";
            button5_Imagen_Save.UseVisualStyleBackColor = false;
            button5_Imagen_Save.Click += button5_Click;
            // 
            // button6_Imagen_Remove
            // 
            button6_Imagen_Remove.BackColor = Color.FromArgb(196, 186, 255);
            button6_Imagen_Remove.FlatAppearance.BorderSize = 0;
            button6_Imagen_Remove.FlatStyle = FlatStyle.Flat;
            button6_Imagen_Remove.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button6_Imagen_Remove.Location = new Point(707, 196);
            button6_Imagen_Remove.Name = "button6_Imagen_Remove";
            button6_Imagen_Remove.Size = new Size(252, 47);
            button6_Imagen_Remove.TabIndex = 6;
            button6_Imagen_Remove.Text = "Quitar Filtro";
            button6_Imagen_Remove.UseVisualStyleBackColor = false;
            button6_Imagen_Remove.Click += button6_Click;
            // 
            // groupBox_Imagen
            // 
            groupBox_Imagen.BackgroundImageLayout = ImageLayout.None;
            groupBox_Imagen.Controls.Add(trackBar1_imagen);
            groupBox_Imagen.Controls.Add(label8);
            groupBox_Imagen.Controls.Add(label9);
            groupBox_Imagen.Controls.Add(label10);
            groupBox_Imagen.Controls.Add(pictureBox_Imagen_Azul);
            groupBox_Imagen.Controls.Add(pictureBox_Imagen_Verde);
            groupBox_Imagen.Controls.Add(pictureBox_Imagen_Rojo);
            groupBox_Imagen.Controls.Add(pictureBox_Imagen);
            groupBox_Imagen.Controls.Add(comboBox_imagen);
            groupBox_Imagen.Controls.Add(button4_Imagen_Apply);
            groupBox_Imagen.Controls.Add(button6_Imagen_Remove);
            groupBox_Imagen.Controls.Add(button5_Imagen_Save);
            groupBox_Imagen.Controls.Add(label_Imagen);
            groupBox_Imagen.FlatStyle = FlatStyle.Flat;
            groupBox_Imagen.Location = new Point(196, 12);
            groupBox_Imagen.Name = "groupBox_Imagen";
            groupBox_Imagen.Size = new Size(980, 812);
            groupBox_Imagen.TabIndex = 7;
            groupBox_Imagen.TabStop = false;
            groupBox_Imagen.Text = "Controles de Imagen";
            groupBox_Imagen.Visible = false;
            // 
            // trackBar1_imagen
            // 
            trackBar1_imagen.Location = new Point(707, 332);
            trackBar1_imagen.Name = "trackBar1_imagen";
            trackBar1_imagen.Size = new Size(252, 45);
            trackBar1_imagen.TabIndex = 20;
            trackBar1_imagen.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(22, 666);
            label8.Name = "label8";
            label8.Size = new Size(38, 19);
            label8.TabIndex = 19;
            label8.Text = "Azul:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(22, 530);
            label9.Name = "label9";
            label9.Size = new Size(47, 19);
            label9.TabIndex = 18;
            label9.Text = "Verde:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(22, 401);
            label10.Name = "label10";
            label10.Size = new Size(39, 19);
            label10.TabIndex = 17;
            label10.Text = "Rojo:";
            // 
            // pictureBox_Imagen_Azul
            // 
            pictureBox_Imagen_Azul.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_Imagen_Azul.Location = new Point(22, 688);
            pictureBox_Imagen_Azul.Name = "pictureBox_Imagen_Azul";
            pictureBox_Imagen_Azul.Size = new Size(937, 101);
            pictureBox_Imagen_Azul.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Imagen_Azul.TabIndex = 16;
            pictureBox_Imagen_Azul.TabStop = false;
            // 
            // pictureBox_Imagen_Verde
            // 
            pictureBox_Imagen_Verde.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_Imagen_Verde.Location = new Point(22, 552);
            pictureBox_Imagen_Verde.Name = "pictureBox_Imagen_Verde";
            pictureBox_Imagen_Verde.Size = new Size(937, 101);
            pictureBox_Imagen_Verde.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Imagen_Verde.TabIndex = 15;
            pictureBox_Imagen_Verde.TabStop = false;
            // 
            // pictureBox_Imagen_Rojo
            // 
            pictureBox_Imagen_Rojo.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_Imagen_Rojo.Location = new Point(22, 423);
            pictureBox_Imagen_Rojo.Name = "pictureBox_Imagen_Rojo";
            pictureBox_Imagen_Rojo.Size = new Size(937, 101);
            pictureBox_Imagen_Rojo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Imagen_Rojo.TabIndex = 14;
            pictureBox_Imagen_Rojo.TabStop = false;
            // 
            // pictureBox_Imagen
            // 
            pictureBox_Imagen.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_Imagen.Location = new Point(22, 19);
            pictureBox_Imagen.Name = "pictureBox_Imagen";
            pictureBox_Imagen.Size = new Size(650, 365);
            pictureBox_Imagen.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Imagen.TabIndex = 7;
            pictureBox_Imagen.TabStop = false;
            // 
            // comboBox_imagen
            // 
            comboBox_imagen.FormattingEnabled = true;
            comboBox_imagen.Location = new Point(707, 89);
            comboBox_imagen.Name = "comboBox_imagen";
            comboBox_imagen.Size = new Size(252, 23);
            comboBox_imagen.TabIndex = 4;
            comboBox_imagen.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox_Video
            // 
            groupBox_Video.Controls.Add(trackBar2);
            groupBox_Video.Controls.Add(label7);
            groupBox_Video.Controls.Add(label6);
            groupBox_Video.Controls.Add(label5);
            groupBox_Video.Controls.Add(pictureBox_Videos_Azul);
            groupBox_Video.Controls.Add(pictureBox_Videos_Verde);
            groupBox_Video.Controls.Add(pictureBox_Videos_Rojo);
            groupBox_Video.Controls.Add(pictureBox3_Video);
            groupBox_Video.Controls.Add(comboBox3_Video);
            groupBox_Video.Controls.Add(button8_Video_Apply);
            groupBox_Video.Controls.Add(button9_Video_Remove);
            groupBox_Video.Controls.Add(label3);
            groupBox_Video.Location = new Point(196, 12);
            groupBox_Video.Name = "groupBox_Video";
            groupBox_Video.Size = new Size(980, 812);
            groupBox_Video.TabIndex = 8;
            groupBox_Video.TabStop = false;
            groupBox_Video.Text = "Controles de Video";
            groupBox_Video.Visible = false;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(707, 249);
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(252, 45);
            trackBar2.TabIndex = 21;
            trackBar2.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(22, 662);
            label7.Name = "label7";
            label7.Size = new Size(38, 19);
            label7.TabIndex = 13;
            label7.Text = "Azul:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(22, 526);
            label6.Name = "label6";
            label6.Size = new Size(47, 19);
            label6.TabIndex = 12;
            label6.Text = "Verde:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 397);
            label5.Name = "label5";
            label5.Size = new Size(39, 19);
            label5.TabIndex = 11;
            label5.Text = "Rojo:";
            // 
            // pictureBox_Videos_Azul
            // 
            pictureBox_Videos_Azul.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_Videos_Azul.Location = new Point(22, 684);
            pictureBox_Videos_Azul.Name = "pictureBox_Videos_Azul";
            pictureBox_Videos_Azul.Size = new Size(937, 101);
            pictureBox_Videos_Azul.TabIndex = 10;
            pictureBox_Videos_Azul.TabStop = false;
            // 
            // pictureBox_Videos_Verde
            // 
            pictureBox_Videos_Verde.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_Videos_Verde.Location = new Point(22, 548);
            pictureBox_Videos_Verde.Name = "pictureBox_Videos_Verde";
            pictureBox_Videos_Verde.Size = new Size(937, 101);
            pictureBox_Videos_Verde.TabIndex = 9;
            pictureBox_Videos_Verde.TabStop = false;
            // 
            // pictureBox_Videos_Rojo
            // 
            pictureBox_Videos_Rojo.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_Videos_Rojo.Location = new Point(22, 419);
            pictureBox_Videos_Rojo.Name = "pictureBox_Videos_Rojo";
            pictureBox_Videos_Rojo.Size = new Size(937, 101);
            pictureBox_Videos_Rojo.TabIndex = 8;
            pictureBox_Videos_Rojo.TabStop = false;
            // 
            // pictureBox3_Video
            // 
            pictureBox3_Video.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3_Video.Location = new Point(22, 19);
            pictureBox3_Video.Name = "pictureBox3_Video";
            pictureBox3_Video.Size = new Size(650, 365);
            pictureBox3_Video.TabIndex = 7;
            pictureBox3_Video.TabStop = false;
            // 
            // comboBox3_Video
            // 
            comboBox3_Video.FormattingEnabled = true;
            comboBox3_Video.Location = new Point(707, 89);
            comboBox3_Video.Name = "comboBox3_Video";
            comboBox3_Video.Size = new Size(252, 23);
            comboBox3_Video.TabIndex = 4;
            // 
            // button8_Video_Apply
            // 
            button8_Video_Apply.BackColor = Color.FromArgb(73, 66, 228);
            button8_Video_Apply.FlatAppearance.BorderSize = 0;
            button8_Video_Apply.FlatStyle = FlatStyle.Flat;
            button8_Video_Apply.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button8_Video_Apply.ForeColor = Color.Gainsboro;
            button8_Video_Apply.Location = new Point(707, 124);
            button8_Video_Apply.Name = "button8_Video_Apply";
            button8_Video_Apply.Size = new Size(252, 66);
            button8_Video_Apply.TabIndex = 3;
            button8_Video_Apply.Text = "Aplicar Filtro";
            button8_Video_Apply.UseVisualStyleBackColor = false;
            // 
            // button9_Video_Remove
            // 
            button9_Video_Remove.BackColor = Color.FromArgb(196, 186, 255);
            button9_Video_Remove.FlatAppearance.BorderSize = 0;
            button9_Video_Remove.FlatStyle = FlatStyle.Flat;
            button9_Video_Remove.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button9_Video_Remove.Location = new Point(707, 196);
            button9_Video_Remove.Name = "button9_Video_Remove";
            button9_Video_Remove.Size = new Size(252, 47);
            button9_Video_Remove.TabIndex = 6;
            button9_Video_Remove.Text = "Quitar Filtro";
            button9_Video_Remove.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(707, 37);
            label3.Name = "label3";
            label3.Size = new Size(233, 30);
            label3.TabIndex = 4;
            label3.Text = "Selecciona una opcion:";
            // 
            // groupBox1_Inicio
            // 
            groupBox1_Inicio.Controls.Add(label4);
            groupBox1_Inicio.Controls.Add(label2);
            groupBox1_Inicio.Controls.Add(label1);
            groupBox1_Inicio.Enabled = false;
            groupBox1_Inicio.Location = new Point(196, 12);
            groupBox1_Inicio.Name = "groupBox1_Inicio";
            groupBox1_Inicio.Size = new Size(980, 812);
            groupBox1_Inicio.TabIndex = 9;
            groupBox1_Inicio.TabStop = false;
            groupBox1_Inicio.Text = "Inicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(8, 104);
            label4.Name = "label4";
            label4.Size = new Size(960, 703);
            label4.TabIndex = 12;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(6, 65);
            label2.Name = "label2";
            label2.Size = new Size(192, 37);
            label2.TabIndex = 11;
            label2.Text = "¿Como se usa?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(164, 19);
            label1.Name = "label1";
            label1.Size = new Size(670, 46);
            label1.TabIndex = 10;
            label1.Text = "¡Bienvenido al procesamiento de imagenes!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(134, 150, 254);
            ClientSize = new Size(1197, 832);
            Controls.Add(groupBox1_Inicio);
            Controls.Add(groupBox_Video);
            Controls.Add(groupBox_Camara);
            Controls.Add(groupBox_Imagen);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Procesamiento de Imagenes";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            groupBox_Camara.ResumeLayout(false);
            groupBox_Camara.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Camara).EndInit();
            groupBox_Imagen.ResumeLayout(false);
            groupBox_Imagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1_imagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Imagen_Azul).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Imagen_Verde).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Imagen_Rojo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Imagen).EndInit();
            groupBox_Video.ResumeLayout(false);
            groupBox_Video.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Videos_Azul).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Videos_Verde).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Videos_Rojo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3_Video).EndInit();
            groupBox1_Inicio.ResumeLayout(false);
            groupBox1_Inicio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;

        private Button button1;
        private Button button2;
        private Button button3;

        private Button button4_Imagen_Apply;
        private Button button5_Imagen_Save;
        private Button button6_Imagen_Remove;

        private Button button7_Camara_Change;

        private Button button8_Video_Apply;
        private Button button9_Video_Remove;

        private PictureBox pictureBox_Camara;
        private PictureBox pictureBox_Imagen;
        private PictureBox pictureBox3_Video;

        private ComboBox comboBox_Camara;
        private ComboBox comboBox_imagen;
        private ComboBox comboBox3_Video;

        private Label label_Imagen;
        private Label label2_Camara;
        private Label label3;

        private GroupBox groupBox_Imagen;
        private GroupBox groupBox_Camara;
        private GroupBox groupBox_Video;
        private Button button4_Inicio;

        private GroupBox groupBox1_Inicio;

        private Label label4;
        private Label label2;
        private Label label1;

        private PictureBox pictureBox_Videos_Azul;
        private PictureBox pictureBox_Videos_Verde;
        private PictureBox pictureBox_Videos_Rojo;

        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label label10;

        private PictureBox pictureBox_Imagen_Azul;
        private PictureBox pictureBox_Imagen_Verde;
        private PictureBox pictureBox_Imagen_Rojo;

        private TrackBar trackBar1_imagen;
        private TrackBar trackBar2;
    }
}