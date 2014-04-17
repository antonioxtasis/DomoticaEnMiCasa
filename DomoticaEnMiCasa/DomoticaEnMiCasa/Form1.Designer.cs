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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_clima = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_calefaccion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_luces = new System.Windows.Forms.Label();
            this.Luces = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_siri = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_encender_calefaccion = new System.Windows.Forms.Button();
            this.btn_encender_clima = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_off = new System.Windows.Forms.Button();
            this.btn_on = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_grados = new System.Windows.Forms.TextBox();
            this.txt_movimiento = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(14, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(706, 348);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_movimiento);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txt_clima);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txt_calefaccion);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_luces);
            this.tabPage1.Controls.Add(this.Luces);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.btn_siri);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_encender_calefaccion);
            this.tabPage1.Controls.Add(this.btn_encender_clima);
            this.tabPage1.Controls.Add(this.btn_off);
            this.tabPage1.Controls.Add(this.btn_on);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(698, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monitor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(698, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuración";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_clima
            // 
            this.txt_clima.AutoSize = true;
            this.txt_clima.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_clima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clima.Location = new System.Drawing.Point(358, 180);
            this.txt_clima.Name = "txt_clima";
            this.txt_clima.Size = new System.Drawing.Size(2, 22);
            this.txt_clima.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(294, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Clima:";
            // 
            // txt_calefaccion
            // 
            this.txt_calefaccion.AutoSize = true;
            this.txt_calefaccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_calefaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_calefaccion.Location = new System.Drawing.Point(237, 180);
            this.txt_calefaccion.Name = "txt_calefaccion";
            this.txt_calefaccion.Size = new System.Drawing.Size(2, 22);
            this.txt_calefaccion.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Calefacción:";
            // 
            // txt_luces
            // 
            this.txt_luces.AutoSize = true;
            this.txt_luces.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_luces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_luces.Location = new System.Drawing.Point(78, 180);
            this.txt_luces.Name = "txt_luces";
            this.txt_luces.Size = new System.Drawing.Size(2, 22);
            this.txt_luces.TabIndex = 37;
            // 
            // Luces
            // 
            this.Luces.AutoSize = true;
            this.Luces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luces.Location = new System.Drawing.Point(14, 180);
            this.Luces.Name = "Luces";
            this.Luces.Size = new System.Drawing.Size(56, 20);
            this.Luces.TabIndex = 36;
            this.Luces.Text = "Luces:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.OldLace;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(434, 232);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(244, 74);
            this.textBox3.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(430, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Serial Port Data Received";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(434, 98);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(244, 128);
            this.textBox2.TabIndex = 33;
            // 
            // btn_siri
            // 
            this.btn_siri.BackColor = System.Drawing.Color.LightBlue;
            this.btn_siri.Location = new System.Drawing.Point(313, 36);
            this.btn_siri.Name = "btn_siri";
            this.btn_siri.Size = new System.Drawing.Size(98, 71);
            this.btn_siri.TabIndex = 32;
            this.btn_siri.Text = "Siri...";
            this.btn_siri.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Acciones:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Monitor:";
            // 
            // btn_encender_calefaccion
            // 
            this.btn_encender_calefaccion.Location = new System.Drawing.Point(23, 11);
            this.btn_encender_calefaccion.Name = "btn_encender_calefaccion";
            this.btn_encender_calefaccion.Size = new System.Drawing.Size(98, 35);
            this.btn_encender_calefaccion.TabIndex = 29;
            this.btn_encender_calefaccion.Text = "Encender Calefacción";
            this.btn_encender_calefaccion.UseVisualStyleBackColor = true;
            // 
            // btn_encender_clima
            // 
            this.btn_encender_clima.Location = new System.Drawing.Point(127, 11);
            this.btn_encender_clima.Name = "btn_encender_clima";
            this.btn_encender_clima.Size = new System.Drawing.Size(98, 35);
            this.btn_encender_clima.TabIndex = 28;
            this.btn_encender_clima.Text = "Encender Clima";
            this.btn_encender_clima.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(402, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(93, 29);
            this.textBox1.TabIndex = 27;
            // 
            // btn_off
            // 
            this.btn_off.Location = new System.Drawing.Point(122, 52);
            this.btn_off.Name = "btn_off";
            this.btn_off.Size = new System.Drawing.Size(98, 35);
            this.btn_off.TabIndex = 26;
            this.btn_off.Text = "Apagar Luces";
            this.btn_off.UseVisualStyleBackColor = true;
            // 
            // btn_on
            // 
            this.btn_on.Location = new System.Drawing.Point(18, 54);
            this.btn_on.Name = "btn_on";
            this.btn_on.Size = new System.Drawing.Size(98, 35);
            this.btn_on.TabIndex = 25;
            this.btn_on.Text = "Encender Luces";
            this.btn_on.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Oscuridad Total",
            "Oscuridad Media"});
            this.comboBox1.Location = new System.Drawing.Point(21, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "¿Cuándo prender las luces?";
            // 
            // txt_grados
            // 
            this.txt_grados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grados.Location = new System.Drawing.Point(501, 7);
            this.txt_grados.Name = "txt_grados";
            this.txt_grados.ReadOnly = true;
            this.txt_grados.Size = new System.Drawing.Size(93, 29);
            this.txt_grados.TabIndex = 28;
            // 
            // txt_movimiento
            // 
            this.txt_movimiento.AutoSize = true;
            this.txt_movimiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_movimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_movimiento.Location = new System.Drawing.Point(119, 232);
            this.txt_movimiento.Name = "txt_movimiento";
            this.txt_movimiento.Size = new System.Drawing.Size(2, 22);
            this.txt_movimiento.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Movimiento:";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Red;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cerrar.Location = new System.Drawing.Point(690, 7);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(26, 24);
            this.btn_cerrar.TabIndex = 30;
            this.btn_cerrar.Text = "X";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(732, 388);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.txt_grados);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Domótica en mi Casa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label txt_clima;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txt_calefaccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txt_luces;
        private System.Windows.Forms.Label Luces;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_siri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_encender_calefaccion;
        private System.Windows.Forms.Button btn_encender_clima;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_off;
        private System.Windows.Forms.Button btn_on;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_grados;
        private System.Windows.Forms.Label txt_movimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_cerrar;
    }
}

