/*
 *    ARCHIVO:   sketch_DomoticaEnMiCasa.ino
 *      AUTOR:   JUAN CORDOVA
 *      FECHA:   2013-03-09
 *
 *  PROPOSITO:   Proyecto Domotica en mi casa
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
 * Digital 2 IRQ conectado al Sensor TSL235R
 *
 * Pines del Sensor
 * PIN 1 - GND
 * PIN 2 - VDD - 5V
 * PIN 3 - SIGNAL
 *
 */
 
/*************************************************************/ 
/*************** PINES DEL ARDUINO ***************************/
/*************************************************************/
/*Sensores*/
const int s_temperatura = 0;
const int s_iluminacion = 1;
const int s_movimiento = 2;

/*Actuadores*/
const int a_luces = 13;
const int a_clima = 12;
const int a_calefaccion = 11;

/*************************************************************/ 
/***************** VARIABLES Y CONSTANTES ********************/
/*************************************************************/ 
// --


/*************************************************************/ 
/*************************** SETUP ***************************/
/*************************************************************/
void setup(){
  pinMode(a_luces, OUTPUT); //declaramos el PIN 13 como salida
  Serial.begin(9600);  
}

/*************************************************************/ 
/************************  LOOP     **************************/ 
/*************************************************************/ 
void loop(){
  if(Serial.available()){
    
    //Recibe signal de la App
    int request = Serial.read();
    
    if(request=='A'){
      digitalWrite(a_luces, HIGH);//Luces ON
    }
    if(request=='B'){
      digitalWrite(a_luces, LOW);//Luces OFF
    }
    if(request=='C'){
      digitalWrite(a_calefaccion, LOW);//Clima ON; Calefacción OFF
      digitalWrite(a_clima, HIGH);
    }
    if(request=='D'){
      digitalWrite(a_clima, LOW);//Clima OFF; Calefacción ON
      digitalWrite(a_calefaccion, HIGH);
    }
  }//end serial available
}
