/*
 *    ARCHIVO:   SensorDeLuz_Prueba.ino
 *      AUTOR:   JUAN CORDOVA
 *      FECHA:   2013-04-16
 *
 *  PROPOSITO:   Probar individualmente el Sensor Convertidor de 
 *               intensidad de luz a frecuencia - TSL235R   
 *
 * Layout de conexión Pines del ARDUINO
 * ====================================
 *  Digital 2 IRQ conectado al Sensor TSL235R
 *
 * Pines del Sensor
 * PIN 1 - GND
 * PIN 2 - VDD - 5V
 * PIN 3 - SIGNAL
 *
 */
 
/*************************************************************/ 
/***************   VARIABLES Y CONSTANTES ********************/
/*************************************************************/
const int SENSOR_LUZ = 2; //entrada del sensor

volatile unsigned long cont = 0;
unsigned long old_cont = 0;
unsigned long t = 0;
unsigned long ultimo_digito;

/*************************************************************/ 
/***************   METODOS Y FUNCIONES    ********************/
/*************************************************************/
void irq1()
{
  cont++;
}

/*************************************************************/ 
/*************************** SETUP ***************************/
/*************************************************************/ 
void setup() 
{
  Serial.begin(9600);//;(115200);
  Serial.println("START");
  pinMode(SENSOR_LUZ, INPUT);
  digitalWrite(2, HIGH);
  attachInterrupt(0, irq1, RISING);
}

/*************************************************************/ 
/************************  LOOP     **************************/ 
/*************************************************************/ 
void loop() 
{
  if (millis() - ultimo_digito >= 1000)
  {
    ultimo_digito = millis();
    t = cont;
    unsigned long hz = t - old_cont;
    //Serial.print("FREQ: ");
    Serial.print("Sensor_L: "); 
    Serial.print(hz);
    //Serial.print("\t = "); 
    Serial.println((hz + 50)/100);  // +50 == se redondea el ultimo digito
    //Serial.println(" mW/m2");
    old_cont = t;
  }
}

/*
En setup () la rutina de IRQ que cuenta los impulsos se inicializa, se utiliza un contador cnt largo sin signo que se incrementa en cada RIDING edge. Este contador no se restablece por lo que finalmente se desbordará. 
A medida que la energía de la luz es diferente durante el día, es difícil decir cuánto tiempo se tarda antes de que ocurra el desbordamiento. 

En loop () esperamos que 1000 millis antes de imprimir los impulsos del último segundo. La frecuencia se convierte en mW / m ^ 2. 
Agregamos 50 a la frecuencia antes de dividir por 100 para redondear el número. 
*/

