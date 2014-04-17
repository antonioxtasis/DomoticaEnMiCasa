/*
 *    ARCHIVO:   Principal.ino
 *      AUTOR:   JUAN CORDOVA
 *      FECHA:   2013-04-16
 *
 *  PROPOSITO:   Programa del microcontrolador.
 *               Convivencia de los 3 sensores: luminosidad, temperatura y movimiento.   
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
 *  Digital 3 conectado al Sensor de Movimiento
 *
 * Pines del Sensor
 * PIN 1 - VDD - 5V
 * PIN 2 - SIGNAL
 * PIN 3 - GND
 *
 *  A0 conectado al Sensor de Temperatura LM35
 *
 * Pines del Sensor
 * PIN 1 - VDD - 5V
 * PIN 2 - SIGNAL
 * PIN 3 - GND
 *
 */
 
/*************************************************************/ 
/***************   VARIABLES Y CONSTANTES ********************/
/*************************************************************/

//LUMINOSIDAD
const int SENSOR_LUZ = 2; //D2 entrada sensor luminosidad
volatile unsigned long cont = 0;
unsigned long old_cont = 0;
unsigned long t = 0;
unsigned long ultimo_digito;

//MOVIMIENTO
const int SENSOR_MOVIMENTO = 3; //D3 entrada sensor movimiento PIR
const int LED_ROJO = 4;
int estado;

//TEMPERATURA
const int SENSOR_TEMPERATURA = 0; // A0 entrada del sensor
const int LED_ROJO_RGB = 5; //D5 led del pin 5 como salida
const int LED_AZUL_RGB = 6; //D5 led del pin 6 como salida
float temperatura;
int milivolts;
int brillo;

/*************************************************************/ 
/***************   METODOS Y FUNCIONES    ********************/
/*************************************************************/

//LUMINOSIDAD
void irq1()
{
  cont++;
}

/*************************************************************/ 
/*************************** SETUP ***************************/
/*************************************************************/ 
void setup() 
{
  //LUMINOSIDAD
  Serial.begin(9600);
  Serial.println("START");
  pinMode(SENSOR_LUZ, INPUT);
  digitalWrite(2, HIGH);
  attachInterrupt(0, irq1, RISING);
  
  //MOVIMIENTO
  pinMode(SENSOR_MOVIMENTO, INPUT);
  pinMode(LED_ROJO, OUTPUT);
  digitalWrite(LED_ROJO, LOW);
  
  //TEMPERATURA
  pinMode(LED_ROJO_RGB, OUTPUT);
  pinMode(LED_AZUL_RGB, OUTPUT);
  analogReference(INTERNAL); //Para cmabiar aRef a 1.1V, se usa el éste comando
}

/*************************************************************/ 
/************************  LOOP     **************************/ 
/*************************************************************/ 
void loop() 
{
  
  //LUMINOSIDAD
  
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
  
  
  
  //MOVIMIENTO
  
  //LOW - el sensor SI detecta movimiento manda 0v como salida
  //HIGH - si NO detecta movimiento manda 3v como salida
  
  estado = digitalRead(SENSOR_MOVIMENTO); //leemos el estado del sensor PIR
  
  if(estado == HIGH)  //NO movimiento
  {
    digitalWrite(LED_ROJO, LOW);//apagamos el led
  }
  else  //SI movimiento
  {
    digitalWrite(LED_ROJO, HIGH);//encendemos el led
  }
  Serial.print("Sensor_M: ");
  Serial.println(estado);
  


  //TEMPERATURA
  
  //El LM35 sólo produce tensiones de 0-1 V. 
  //El ADC utiliza 5V como el valor más alto posible. Esto es perder el 80% de la gama posible. 
  //Si cambia aRef a 1.1 V se obtiene casi la mayor resolución posible. 
  milivolts = analogRead(SENSOR_TEMPERATURA);
  temperatura = milivolts / 9.31;
  
  brillo = map(temperatura, 10, 40, 0, 255);//ajustamos map(variable a escalar, minimo, maximo, se traduce desde, hasta)
  brillo = constrain(brillo, 0, 255);//limitamos rango de brillo
  
  analogWrite(LED_ROJO_RGB, brillo);
  analogWrite(LED_AZUL_RGB, 255 - brillo);
  
  Serial.print("Sensor_T: ");
  Serial.println(temperatura);
  delay(500);
}
