/*
 *    ARCHIVO:   SensorDeTemperatura_Prueba.ino
 *      AUTOR:   JUAN CORDOVA
 *      FECHA:   2013-04-16
 *
 *  PROPOSITO:   Probar individualmente Sensor de temperatura LM35
 *
 * Layout de conexión Pines del ARDUINO
 * ====================================
 *  A0 conectado al Sensor LM35
 *
 * Pines del Sensor
 * PIN 1 - VDD - 5V
 * PIN 2 - SIGNAL
 * PIN 3 - GND
 *
 */

/*************************************************************/ 
/*************** PINES DEL ARDUINO ***************************/
/*************************************************************/ 
const int SENSOR_TEMPERATURA = 0; // A0 entrada del sensor
const int LED_ROJO = 5; //D5 led del pin 5 como salida
const int LED_AZUL = 6; //D5 led del pin 6 como salida

/*************************************************************/ 
/***************** VARIABLES Y CONSTANTES ********************/
/*************************************************************/ 
float temperatura;
int milivolts;
int brillo;

/*************************************************************/ 
/*************************** SETUP ***************************/
/*************************************************************/ 
void setup(){
  Serial.begin(9600);//inicia la comunicacion serial
  pinMode(LED_ROJO, OUTPUT);
  pinMode(LED_AZUL, OUTPUT);
  //Para cmabiar aRef a 1.1V, se usa el éste comando:
  analogReference(INTERNAL);
}

/*************************************************************/ 
/************************  LOOP     **************************/ 
/*************************************************************/ 
void loop(){
  //El LM35 sólo produce tensiones de 0-1 V. 
  //El ADC utiliza 5V como el valor más alto posible. Esto es perder el 80% de la gama posible. 
  //Si cambia aRef a 1.1 V se obtiene casi la mayor resolución posible. 
  milivolts = analogRead(SENSOR_TEMPERATURA);
  temperatura = milivolts / 9.31;
  
  brillo = map(temperatura, 10, 40, 0, 255);//ajustamos map(variable a escalar, minimo, maximo, se traduce desde, hasta)
  brillo = constrain(brillo, 0, 255);//limitamos rango de brillo
  
  analogWrite(LED_ROJO, brillo);
  analogWrite(LED_AZUL, 255 - brillo);
  
  Serial.print("Temperatura: ");
  Serial.println(temperatura);delay(2000);
}
