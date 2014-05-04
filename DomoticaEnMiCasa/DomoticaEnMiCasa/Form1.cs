using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Serial
using System.IO.Ports;
//Siri
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Media;
//Assert
using System.Diagnostics;

namespace DomoticaEnMiCasa
{
    public partial class Form1 : Form
    {
        //Global Variables
        public static int val_max_luz = 990000;
        public static int val_prender_clima = 20;
        public static int val_prender_calefaccion = 15;

        public static int luces_modo_auto= 1; //Modo Automatico LUCES
        public static int clima_modo_auto = 1; //Modo Automatico CLIMA
        public static int calefaccion_modo_auto = 1; //Modo Automatico CALEFACCIÓN

        // Add this variable 
        string RxString;

        private static SpeechRecognitionEngine recognizer;

        public Form1()
        {
            InitializeComponent();
            serialPort1.PortName = "COM3";
            serialPort1.BaudRate = 9600;
            //serialPort1.Open();
        }

        private void btn_siri_Click(object sender, EventArgs e)
        {
            //**SONIDO DEL SISTEMA**//
            System.Media.SystemSounds.Exclamation.Play();

            btn_siri.BackColor = Color.Gray;

            // Initialize a SpeechRecognitionEngine object and set its input.
            recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-Us"));
            recognizer.SetInputToDefaultAudioDevice();

            // Add a handler for the LoadGrammarCompleted event.
            recognizer.LoadGrammarCompleted += new EventHandler<LoadGrammarCompletedEventArgs>(recognizer_LoadGrammarCompleted);

            // Add a handler for the SpeechRecognized event.
            recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);

            Grammar page = new Grammar(new GrammarBuilder(new Choices(new string[] { "Start", "Off", "Turn on", "Shut down"})));

            page.Name = "Paginas";

            // Create the "done" grammar within the constructor of a Grammar object.
            Grammar doneGrammar = new Grammar(new GrammarBuilder(new Choices(new string[] { "salir" })));
            doneGrammar.Name = "Done";

            // Load the Grammar objects to the recognizer.
            //recognizer.LoadGrammarAsync(yesnoGrammar);
            recognizer.LoadGrammarAsync(doneGrammar);
            recognizer.LoadGrammarAsync(page);

            // Start asynchronous, continuous recognition.
            recognizer.RecognizeAsync(RecognizeMode.Multiple);

            // Keep the console window open.
            Console.ReadLine();
        }

        static void recognizer_LoadGrammarCompleted(object sender, LoadGrammarCompletedEventArgs e)
        {
            string grammarName = e.Grammar.Name;
            bool grammarLoaded = e.Grammar.Loaded;
            bool grammarEnabled = e.Grammar.Enabled;

            if (e.Error != null)
            {
                Console.WriteLine("LoadGrammar for {0} failed with a {1}.",
                grammarName, e.Error.GetType().Name);

                // Add exception handling code here.
            }

            Console.WriteLine("Grammar {0} {1} loaded and {2} enabled.", grammarName, (grammarLoaded) ? "is" : "is not", (grammarEnabled) ? "is" : "is not");
        }

        // Handle the SpeechRecognized event
        void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            btn_siri.BackColor = Color.Gray;

            recognizer.RecognizeAsyncStop();
            SpeechSynthesizer _Synthesizer = new SpeechSynthesizer();

            if (e.Result.Text.Equals("Turn on"))
            {
                _Synthesizer.Speak("Turn on Lights ");
                btn_siri.BackColor = Color.WhiteSmoke;
                //btn_on_Click(sender, e);
                
            }

            if (e.Result.Text.Equals("Shut Down"))
            {
                _Synthesizer.Speak("Shut down Lights ");
                btn_siri.BackColor = Color.WhiteSmoke;
                //btn_off_Click(sender, e);

            }

        }

////////comunicacion serial desde Arduino a HMI
        private void controlador()
        {
            int valor_luminosidad_actual = 0;
            int valor_movimiento_actual = 0;
            double valor_temperatura_actual = 0.00;

            string tipo_sensor = RxString.Substring(0, 8);

            //Sensor Luminosidad
            if (tipo_sensor == "Sensor_L")
            {
                valor_luminosidad_actual = int.Parse(RxString.Substring(10));
                textBox3.Text = valor_luminosidad_actual.ToString();

                if (luces_modo_auto == 1) //Modo Automatico?
                {
                    if (valor_luminosidad_actual <= val_max_luz)
                    {
                        encenderLuces_Auto();
                    }
                    else
                    {
                        apagarLuces_Auto();
                    }
                }                
            }

            //Sensor Movimiento
            if (tipo_sensor == "Sensor_M")
            {
                valor_movimiento_actual = int.Parse(RxString.Substring(10));
                if (valor_movimiento_actual == 1)
                {
                    this.picture_movimiento.Image = global::DomoticaEnMiCasa.Properties.Resources.mov_yes;
                }
                else if (valor_movimiento_actual == 0)
                {
                    this.picture_movimiento.Image = global::DomoticaEnMiCasa.Properties.Resources.mov_no;
                }
            }

            //Sensor Temperatura
            if (tipo_sensor == "Sensor_T")
            {
                valor_temperatura_actual = double.Parse(RxString.Substring(10));
                txt_grados.Text = valor_temperatura_actual.ToString() + " °C";

                if (clima_modo_auto == 1) //Modo Automatico?
                {
                    if (valor_temperatura_actual >= val_prender_clima)
                    {
                        this.picture_clima.Image = global::DomoticaEnMiCasa.Properties.Resources.snow;
                        serialPort1.Write("G");//encender clima
                        this.picture_calefaccion.Image = global::DomoticaEnMiCasa.Properties.Resources.mov_no;
                        serialPort1.Write("L");//apagar calefacción
                    }
                    else if (valor_temperatura_actual < val_prender_clima && valor_temperatura_actual > val_prender_calefaccion)
                    {
                        this.picture_clima.Image = global::DomoticaEnMiCasa.Properties.Resources.mov_no;
                        serialPort1.Write("H");//apagar clima
                        this.picture_calefaccion.Image = global::DomoticaEnMiCasa.Properties.Resources.mov_no;
                        serialPort1.Write("L");//apagar calefacción
                    }
                    else if (valor_temperatura_actual <= val_prender_calefaccion)
                    {
                        this.picture_clima.Image = global::DomoticaEnMiCasa.Properties.Resources.mov_no;
                        serialPort1.Write("H");//apagar clima
                        this.picture_calefaccion.Image = global::DomoticaEnMiCasa.Properties.Resources.sun;
                        serialPort1.Write("K");//encender calefacción
                    }
                }                
            }
        }

/// funciones LUCES
        private void encenderLuces_Auto()
        {
            this.picture_luces.Image = global::DomoticaEnMiCasa.Properties.Resources.on;
            serialPort1.Write("E");
        }
        private void apagarLuces_Auto()
        {
            this.picture_luces.Image = global::DomoticaEnMiCasa.Properties.Resources.off;
            serialPort1.Write("F");
        }
        private void encenderLuces_Manual()
        {
            this.picture_luces.Image = global::DomoticaEnMiCasa.Properties.Resources.on;
            serialPort1.Write("A");
        }
        private void apagarLuces_Manual()
        {
            this.picture_luces.Image = global::DomoticaEnMiCasa.Properties.Resources.off;
            serialPort1.Write("B");
        }
/// funciones CLIMA        
        private void encenderClima_Manual()
        {
            this.picture_clima.Image = global::DomoticaEnMiCasa.Properties.Resources.snow;
            serialPort1.Write("G");
        }
        private void apagarClima_Manual()
        {
            this.picture_clima.Image = global::DomoticaEnMiCasa.Properties.Resources.mov_no;
            serialPort1.Write("H");
        }
/// funciones CALEFACCION        
        private void encenderCalefaccion_Manual()
        {
            this.picture_calefaccion.Image = global::DomoticaEnMiCasa.Properties.Resources.sun;
            serialPort1.Write("K");
        }
        private void apagarCalefaccion_Manual()
        {
            this.picture_calefaccion.Image = global::DomoticaEnMiCasa.Properties.Resources.mov_no;
            serialPort1.Write("L");
        }

        private void serialPort1_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            //RxString = serialPort1.ReadExisting();
            RxString = serialPort1.ReadLine();
            this.Invoke(new EventHandler(DisplayText));
        }

        private void DisplayText(object sender, EventArgs e)
        {
            textBox2.AppendText(RxString + "\r\n");
            //textBox3.Text = RxString.Substring(10);

            //Llamada al controlador, el cual es el encargado de tomar las decisiones
            controlador();
        }
        
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {/*
            // If the port is closed, don't try to send a character.
            if (!serialPort1.IsOpen) return;

            // If the port is Open, declare a char[] array with one element.
            char[] buff = new char[1];

            // Load element 0 with the key character.
            buff[0] = e.KeyChar;

            // Send the one character buffer.
            serialPort1.Write(buff, 0, 1);

            // Set the KeyPress event as handled so the character won't
            // display locally. If you want it to display, omit the next line.
            e.Handled = true;
        */}
        
        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                //Debug.Assert(true);
                serialPort1.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open();

            txt_prender_luces.Text = val_max_luz.ToString();
            txt_prender_clima.Text = val_prender_clima.ToString();
            txt_prender_calefaccion.Text = val_prender_calefaccion.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboLuces.SelectedIndex == 0)// "Oscuridad Total")
            {
                val_max_luz = 500000;
                txt_prender_luces.Text = val_max_luz.ToString();
            }
            else if (comboLuces.SelectedIndex == 1)//"Oscuridad Media")
            {
                val_max_luz = 990000;
                txt_prender_luces.Text = val_max_luz.ToString();
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboClima_SelectedIndexChanged(object sender, EventArgs e)
        {
            val_prender_clima = int.Parse(comboClima.SelectedItem.ToString().Substring(0,2));
            txt_prender_clima.Text = val_prender_clima.ToString();
        }

        private void comboCalefaccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            val_prender_calefaccion = int.Parse(comboCalefaccion.SelectedItem.ToString().Substring(0, 2));
            txt_prender_calefaccion.Text = val_prender_calefaccion.ToString();
        }

        private void btn_on_Click_1(object sender, EventArgs e)
        {
            encenderLuces_Manual();
        }

        private void btn_off_Click_1(object sender, EventArgs e)
        {
            apagarLuces_Manual();
        }

        private void chk_luces_manual_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_luces_manual.CheckState.ToString() == "Checked")
            {
                encenderLuces_Manual();
                luces_modo_auto = 0; //modo automatico desactivado
                serialPort1.Write("C"); //manual - luces
                btn_on.Enabled = true;
                btn_off.Enabled = true;
            }
            else if (chk_luces_manual.CheckState.ToString() == "Unchecked")
            {
                encenderLuces_Auto();
                luces_modo_auto = 1; //modo automatico activado
                serialPort1.Write("D"); //auto - luces
                btn_on.Enabled = false;
                btn_off.Enabled = false;
            }
        }

        private void chk_clima_manual_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_clima_manual.CheckState.ToString() == "Checked")
            {
                encenderClima_Manual();
                clima_modo_auto = 0; //modo automatico desactivado
                serialPort1.Write("I"); //manual - luces
                btn_encender_clima.Enabled = true;
                btn_apagar_clima.Enabled = true;
                btn_encender_calefaccion.Enabled = true;
                btn_apagar_calefaccion.Enabled = true;
            }
            else if (chk_clima_manual.CheckState.ToString() == "Unchecked")
            {
                clima_modo_auto = 1; //modo automatico activado
                serialPort1.Write("J"); //auto - luces
                btn_encender_clima.Enabled = false;
                btn_apagar_clima.Enabled = false;
                btn_encender_calefaccion.Enabled = false;
                btn_apagar_calefaccion.Enabled = false;
            }
        }

        private void btn_encender_clima_Click_1(object sender, EventArgs e)
        {
            encenderClima_Manual();
            btn_apagar_calefaccion_Click(sender, e);
        }

        private void btn_apagar_clima_Click(object sender, EventArgs e)
        {
            apagarClima_Manual();
        }        

        private void btn_encender_calefaccion_Click_1(object sender, EventArgs e)
        {
            encenderCalefaccion_Manual();
            btn_apagar_clima_Click(sender, e);
        }

        private void btn_apagar_calefaccion_Click(object sender, EventArgs e)
        {
            apagarCalefaccion_Manual();
        }        
    }
}
