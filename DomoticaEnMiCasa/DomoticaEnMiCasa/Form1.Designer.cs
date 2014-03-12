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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_off = new System.Windows.Forms.Button();
            this.btn_on = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_encender_clima = new System.Windows.Forms.Button();
            this.btn_encender_calefaccion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_siri = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(410, 29);
            this.textBox1.TabIndex = 6;
            // 
            // btn_off
            // 
            this.btn_off.Location = new System.Drawing.Point(12, 82);
            this.btn_off.Name = "btn_off";
            this.btn_off.Size = new System.Drawing.Size(98, 45);
            this.btn_off.TabIndex = 5;
            this.btn_off.Text = "Apagar Luces";
            this.btn_off.UseVisualStyleBackColor = true;
            this.btn_off.Click += new System.EventHandler(this.btn_off_Click);
            // 
            // btn_on
            // 
            this.btn_on.Location = new System.Drawing.Point(12, 31);
            this.btn_on.Name = "btn_on";
            this.btn_on.Size = new System.Drawing.Size(98, 45);
            this.btn_on.TabIndex = 4;
            this.btn_on.Text = "Encender Luces";
            this.btn_on.UseVisualStyleBackColor = true;
            this.btn_on.Click += new System.EventHandler(this.btn_on_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived_1);
            // 
            // btn_encender_clima
            // 
            this.btn_encender_clima.Location = new System.Drawing.Point(220, 31);
            this.btn_encender_clima.Name = "btn_encender_clima";
            this.btn_encender_clima.Size = new System.Drawing.Size(98, 45);
            this.btn_encender_clima.TabIndex = 7;
            this.btn_encender_clima.Text = "Encender Clima";
            this.btn_encender_clima.UseVisualStyleBackColor = true;
            this.btn_encender_clima.Click += new System.EventHandler(this.btn_encender_clima_Click);
            // 
            // btn_encender_calefaccion
            // 
            this.btn_encender_calefaccion.Location = new System.Drawing.Point(324, 31);
            this.btn_encender_calefaccion.Name = "btn_encender_calefaccion";
            this.btn_encender_calefaccion.Size = new System.Drawing.Size(98, 45);
            this.btn_encender_calefaccion.TabIndex = 10;
            this.btn_encender_calefaccion.Text = "Encender Calefacción";
            this.btn_encender_calefaccion.UseVisualStyleBackColor = true;
            this.btn_encender_calefaccion.Click += new System.EventHandler(this.btn_encender_calefaccion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Monitor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Acciones:";
            // 
            // btn_siri
            // 
            this.btn_siri.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_siri.Location = new System.Drawing.Point(220, 108);
            this.btn_siri.Name = "btn_siri";
            this.btn_siri.Size = new System.Drawing.Size(202, 67);
            this.btn_siri.TabIndex = 13;
            this.btn_siri.Text = "Siri...";
            this.btn_siri.UseVisualStyleBackColor = false;
            this.btn_siri.Click += new System.EventHandler(this.btn_siri_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(473, 65);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(292, 184);
            this.textBox2.TabIndex = 16;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(469, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Serial Port1 Data Received";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_siri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_encender_calefaccion);
            this.Controls.Add(this.btn_encender_clima);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_off);
            this.Controls.Add(this.btn_on);
            this.Name = "Form1";
            this.Text = "Domótica en mi Casa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_off;
        private System.Windows.Forms.Button btn_on;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_encender_clima;
        private System.Windows.Forms.Button btn_encender_calefaccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_siri;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}

