/*
 *    ARCHIVO:   SensorDeMovimiento_Prueba.ino
 *      AUTOR:   JUAN CORDOVA
 *      FECHA:   2013-04-16
 *
 *  PROPOSITO:   Probar individualmente el Sensor Pirólico GH-718
 *
 * Layout de conexión Pines del ARDUINO
 * ====================================
 *  Digital 3 conectado al Sensor
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
const int SENSOR_MOVIMENTO = 3; //PIR
const int LED_ROJO = 4;

int estado;

/*************************************************************/ 
/*************************** SETUP ***************************/
/*************************************************************/
void setup(){
  pinMode(SENSOR_MOVIMENTO, INPUT);
  pinMode(LED_ROJO, OUTPUT);
  digitalWrite(LED_ROJO, LOW);
}

/*************************************************************/ 
/************************  LOOP     **************************/ 
/*************************************************************/ 
void loop(){
  
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
}
