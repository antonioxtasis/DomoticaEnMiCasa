namespace DomoticaEnMiCasa
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_grados = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Luces = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_encender_calefaccion = new System.Windows.Forms.Button();
            this.btn_encender_clima = new System.Windows.Forms.Button();
            this.btn_off = new System.Windows.Forms.Button();
            this.btn_on = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_prender_luces = new System.Windows.Forms.TextBox();
            this.txt_prender_calefaccion = new System.Windows.Forms.TextBox();
            this.txt_prender_clima = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboCalefaccion = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboClima = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboLuces = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_siri = new System.Windows.Forms.PictureBox();
            this.picture_calefaccion = new System.Windows.Forms.PictureBox();
            this.picture_clima = new System.Windows.Forms.PictureBox();
            this.picture_movimiento = new System.Windows.Forms.PictureBox();
            this.picture_luces = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_siri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_calefaccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_clima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_movimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_luces)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(631, 348);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_siri);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.picture_calefaccion);
            this.tabPage1.Controls.Add(this.picture_clima);
            this.tabPage1.Controls.Add(this.picture_movimiento);
            this.tabPage1.Controls.Add(this.picture_luces);
            this.tabPage1.Controls.Add(this.txt_grados);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.Luces);
            this.tabPage1.Controls.Add(this.btn_encender_calefaccion);
            this.tabPage1.Controls.Add(this.btn_encender_clima);
            this.tabPage1.Controls.Add(this.btn_off);
            this.tabPage1.Controls.Add(this.btn_on);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(623, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monitor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_grados
            // 
            this.txt_grados.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_grados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_grados.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grados.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_grados.Location = new System.Drawing.Point(438, 8);
            this.txt_grados.Name = "txt_grados";
            this.txt_grados.ReadOnly = true;
            this.txt_grados.Size = new System.Drawing.Size(174, 40);
            this.txt_grados.TabIndex = 28;
            this.txt_grados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Movimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Clima:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Calefacción:";
            // 
            // Luces
            // 
            this.Luces.AutoSize = true;
            this.Luces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luces.Location = new System.Drawing.Point(20, 40);
            this.Luces.Name = "Luces";
            this.Luces.Size = new System.Drawing.Size(62, 20);
            this.Luces.TabIndex = 36;
            this.Luces.Text = "Luces:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.OldLace;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(272, 4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(221, 25);
            this.textBox3.TabIndex = 35;
            // 
            // btn_encender_calefaccion
            // 
            this.btn_encender_calefaccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_encender_calefaccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_encender_calefaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_encender_calefaccion.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_encender_calefaccion.Location = new System.Drawing.Point(234, 242);
            this.btn_encender_calefaccion.Name = "btn_encender_calefaccion";
            this.btn_encender_calefaccion.Size = new System.Drawing.Size(129, 47);
            this.btn_encender_calefaccion.TabIndex = 29;
            this.btn_encender_calefaccion.Text = "Encender Calefacción";
            this.btn_encender_calefaccion.UseVisualStyleBackColor = true;
            // 
            // btn_encender_clima
            // 
            this.btn_encender_clima.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_encender_clima.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_encender_clima.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_encender_clima.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_encender_clima.Location = new System.Drawing.Point(234, 174);
            this.btn_encender_clima.Name = "btn_encender_clima";
            this.btn_encender_clima.Size = new System.Drawing.Size(129, 47);
            this.btn_encender_clima.TabIndex = 28;
            this.btn_encender_clima.Text = "Encender Clima";
            this.btn_encender_clima.UseVisualStyleBackColor = true;
            // 
            // btn_off
            // 
            this.btn_off.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_off.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_off.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_off.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_off.Location = new System.Drawing.Point(234, 34);
            this.btn_off.Name = "btn_off";
            this.btn_off.Size = new System.Drawing.Size(129, 47);
            this.btn_off.TabIndex = 26;
            this.btn_off.Text = "Apagar Luces";
            this.btn_off.UseVisualStyleBackColor = true;
            // 
            // btn_on
            // 
            this.btn_on.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_on.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_on.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_on.Location = new System.Drawing.Point(234, 103);
            this.btn_on.Name = "btn_on";
            this.btn_on.Size = new System.Drawing.Size(129, 47);
            this.btn_on.TabIndex = 25;
            this.btn_on.Text = "Encender Luces";
            this.btn_on.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_prender_luces);
            this.tabPage2.Controls.Add(this.txt_prender_calefaccion);
            this.tabPage2.Controls.Add(this.txt_prender_clima);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.comboCalefaccion);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.comboClima);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.comboLuces);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(623, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuración";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_prender_luces
            // 
            this.txt_prender_luces.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prender_luces.Location = new System.Drawing.Point(483, 43);
            this.txt_prender_luces.Name = "txt_prender_luces";
            this.txt_prender_luces.ReadOnly = true;
            this.txt_prender_luces.Size = new System.Drawing.Size(93, 29);
            this.txt_prender_luces.TabIndex = 36;
            // 
            // txt_prender_calefaccion
            // 
            this.txt_prender_calefaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prender_calefaccion.Location = new System.Drawing.Point(483, 126);
            this.txt_prender_calefaccion.Name = "txt_prender_calefaccion";
            this.txt_prender_calefaccion.ReadOnly = true;
            this.txt_prender_calefaccion.Size = new System.Drawing.Size(93, 29);
            this.txt_prender_calefaccion.TabIndex = 35;
            // 
            // txt_prender_clima
            // 
            this.txt_prender_clima.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prender_clima.Location = new System.Drawing.Point(483, 83);
            this.txt_prender_clima.Name = "txt_prender_clima";
            this.txt_prender_clima.ReadOnly = true;
            this.txt_prender_clima.Size = new System.Drawing.Size(93, 29);
            this.txt_prender_clima.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(479, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Config. Actual:";
            // 
            // comboCalefaccion
            // 
            this.comboCalefaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCalefaccion.FormattingEnabled = true;
            this.comboCalefaccion.Items.AddRange(new object[] {
            "0°C",
            "1°C",
            "2°C",
            "3°C",
            "4°C",
            "5°C",
            "6°C",
            "7°C",
            "8°C",
            "9°C",
            "10°C",
            "11°C",
            "12°C",
            "13°C",
            "14°C",
            "15°C",
            "16°C",
            "17°C",
            "18°C",
            "19°C",
            "20°C",
            "21°C",
            "22°C",
            "23°C",
            "24°C",
            "25°C",
            "26°C",
            "27°C",
            "28°C",
            "29°C",
            "30°C"});
            this.comboCalefaccion.Location = new System.Drawing.Point(279, 125);
            this.comboCalefaccion.Name = "comboCalefaccion";
            this.comboCalefaccion.Size = new System.Drawing.Size(147, 24);
            this.comboCalefaccion.TabIndex = 33;
            this.comboCalefaccion.SelectedIndexChanged += new System.EventHandler(this.comboCalefaccion_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "¿Cuándo prender la Calefacción?";
            // 
            // comboClima
            // 
            this.comboClima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboClima.FormattingEnabled = true;
            this.comboClima.Items.AddRange(new object[] {
            "10°C",
            "11°C",
            "12°C",
            "13°C",
            "14°C",
            "15°C",
            "16°C",
            "17°C",
            "18°C",
            "19°C",
            "20°C",
            "21°C",
            "22°C",
            "23°C",
            "24°C",
            "25°C",
            "26°C",
            "27°C",
            "28°C",
            "29°C",
            "30°C",
            "31°C",
            "32°C",
            "33°C",
            "34°C",
            "35°C",
            "36°C",
            "37°C",
            "38°C",
            "39°C",
            "39°C",
            "40°C",
            "41°C",
            "42°C",
            "43°C",
            "44°C",
            "45°C"});
            this.comboClima.Location = new System.Drawing.Point(279, 83);
            this.comboClima.Name = "comboClima";
            this.comboClima.Size = new System.Drawing.Size(147, 24);
            this.comboClima.TabIndex = 31;
            this.comboClima.SelectedIndexChanged += new System.EventHandler(this.comboClima_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "¿Cuándo prender el Clima?";
            // 
            // comboLuces
            // 
            this.comboLuces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLuces.FormattingEnabled = true;
            this.comboLuces.Items.AddRange(new object[] {
            "Oscuridad Total",
            "Oscuridad Media"});
            this.comboLuces.Location = new System.Drawing.Point(279, 42);
            this.comboLuces.Name = "comboLuces";
            this.comboLuces.Size = new System.Drawing.Size(147, 24);
            this.comboLuces.TabIndex = 29;
            this.comboLuces.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "¿Cuándo prender las luces?";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(499, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(93, 29);
            this.textBox1.TabIndex = 27;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Red;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cerrar.Location = new System.Drawing.Point(598, 5);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(26, 24);
            this.btn_cerrar.TabIndex = 30;
            this.btn_cerrar.Text = "X";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(623, 322);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "RT Log";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Datos recibidos del Puerto Serial:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Chartreuse;
            this.textBox2.Location = new System.Drawing.Point(274, 23);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(331, 275);
            this.textBox2.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(205, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 306);
            this.panel1.TabIndex = 48;
            // 
            // btn_siri
            // 
            this.btn_siri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_siri.Image = global::DomoticaEnMiCasa.Properties.Resources.speak;
            this.btn_siri.Location = new System.Drawing.Point(423, 103);
            this.btn_siri.Name = "btn_siri";
            this.btn_siri.Size = new System.Drawing.Size(144, 133);
            this.btn_siri.TabIndex = 49;
            this.btn_siri.TabStop = false;
            // 
            // picture_calefaccion
            // 
            this.picture_calefaccion.Image = global::DomoticaEnMiCasa.Properties.Resources.mov_no;
            this.picture_calefaccion.Location = new System.Drawing.Point(136, 244);
            this.picture_calefaccion.Name = "picture_calefaccion";
            this.picture_calefaccion.Size = new System.Drawing.Size(40, 45);
            this.picture_calefaccion.TabIndex = 47;
            this.picture_calefaccion.TabStop = false;
            // 
            // picture_clima
            // 
            this.picture_clima.Image = global::DomoticaEnMiCasa.Properties.Resources.mov_no;
            this.picture_clima.Location = new System.Drawing.Point(136, 174);
            this.picture_clima.Name = "picture_clima";
            this.picture_clima.Size = new System.Drawing.Size(40, 45);
            this.picture_clima.TabIndex = 46;
            this.picture_clima.TabStop = false;
            // 
            // picture_movimiento
            // 
            this.picture_movimiento.Image = global::DomoticaEnMiCasa.Properties.Resources.mov_no;
            this.picture_movimiento.Location = new System.Drawing.Point(136, 106);
            this.picture_movimiento.Name = "picture_movimiento";
            this.picture_movimiento.Size = new System.Drawing.Size(40, 45);
            this.picture_movimiento.TabIndex = 45;
            this.picture_movimiento.TabStop = false;
            // 
            // picture_luces
            // 
            this.picture_luces.Image = global::DomoticaEnMiCasa.Properties.Resources.off;
            this.picture_luces.Location = new System.Drawing.Point(136, 36);
            this.picture_luces.Name = "picture_luces";
            this.picture_luces.Size = new System.Drawing.Size(40, 45);
            this.picture_luces.TabIndex = 44;
            this.picture_luces.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(631, 381);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Domótica en mi Casa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_siri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_calefaccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_clima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_movimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_luces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Luces;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_encender_calefaccion;
        private System.Windows.Forms.Button btn_encender_clima;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_off;
        private System.Windows.Forms.Button btn_on;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboLuces;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_grados;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.ComboBox comboClima;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_prender_clima;
        private System.Windows.Forms.ComboBox comboCalefaccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_prender_calefaccion;
        private System.Windows.Forms.TextBox txt_prender_luces;
        private System.Windows.Forms.PictureBox picture_luces;
        private System.Windows.Forms.PictureBox picture_movimiento;
        private System.Windows.Forms.PictureBox picture_clima;
        private System.Windows.Forms.PictureBox picture_calefaccion;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_siri;
    }
}

