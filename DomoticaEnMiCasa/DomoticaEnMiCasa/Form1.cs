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
        // Add this variable 
        string RxString;

        private static SpeechRecognitionEngine recognizer;

        public Form1()
        {
            InitializeComponent();
            serialPort1.PortName = "COM3";
            serialPort1.BaudRate = 9600;
            serialPort1.Open();
        }

        private void btn_on_Click(object sender, EventArgs e)
        {
            serialPort1.Write("A");
            textBox1.Text = "Luces ON";
            btn_on.Enabled = false;
            btn_off.Enabled = true;
            btn_siri.BackColor = Color.WhiteSmoke;
        }

        private void btn_off_Click(object sender, EventArgs e)
        {
            serialPort1.Write("B");
            textBox1.Text = "Luces OFF";
            btn_on.Enabled = true;
            btn_off.Enabled = false;
            btn_siri.BackColor = Color.WhiteSmoke;
        }

        private void btn_encender_clima_Click(object sender, EventArgs e)
        {
            serialPort1.Write("C");
            textBox1.Text = "Clima ON; Calefacción OFF";
            btn_encender_clima.Enabled = false;
            btn_encender_calefaccion.Enabled = true;
            btn_siri.BackColor = Color.WhiteSmoke;
        }

        private void btn_encender_calefaccion_Click(object sender, EventArgs e)
        {
            serialPort1.Write("D");
            textBox1.Text = "Clima OFF; Calefacción ON";
            btn_encender_clima.Enabled = true;
            btn_encender_calefaccion.Enabled = false;
            btn_siri.BackColor = Color.WhiteSmoke;
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
                btn_on_Click(sender, e);
                
            }

            if (e.Result.Text.Equals("Shut Down"))
            {
                _Synthesizer.Speak("Shut down Lights ");
                btn_siri.BackColor = Color.WhiteSmoke;
                btn_off_Click(sender, e);

            }

        }

////////comunicacion serial desde Arduino a HMI


        private void DisplayText(object sender, EventArgs e)
        {
            textBox2.AppendText(RxString);
        }
        
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
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
        }

        private void serialPort1_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(DisplayText));
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                Debug.Assert(false);
                serialPort1.Close();
            }
        }
    }
}
