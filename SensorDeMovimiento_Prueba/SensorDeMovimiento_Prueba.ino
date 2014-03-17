/*
 *    ARCHIVO:   SensorDeMovimiento_Prueba.ino
 *      AUTOR:   JUAN CORDOVA
 *      FECHA:   2013-03-17
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
const int pin_sensor = 3; //PIR
const int pin_led = 4;

int estado;

/*************************************************************/ 
/*************************** SETUP ***************************/
/*************************************************************/
void setup(){
  pinMode(pin_sensor, INPUT);
  pinMode(pin_led, OUTPUT);
  digitalWrite(pin_led, LOW);
}

/*************************************************************/ 
/************************  LOOP     **************************/ 
/*************************************************************/ 
void loop(){
  
  //LOW - el sensor SI detecta movimiento manda 0v como salida
  //HIGH - si NO detecta movimiento manda 3v como salida
  
  estado = digitalRead(pin_sensor); //leemos el estado del sensor PIR
  
  if(estado == HIGH)  //NO movimiento
  {
    digitalWrite(pin_led, LOW);//apagamos el led
  }
  else  //SI movimiento
  {
    digitalWrite(pin_led, HIGH);//encendemos el led
  }
}
