/*
 *    ARCHIVO:   Principal.ino
 *      AUTOR:   JUAN CORDOVA
 *      FECHA:   2014-05-15
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

//Otros actuadores
const int LED_VERDE = 12;
const int LED_AMARILLO = 9;
const int LED_CALEF = 10;

//Variables booleanas #Guardan el estado de los actuadores
int estado_led_verde = 0;
int modo_luces = 0;
int estado_auto_led_verde = 0;

int estado_led_amarillo = 0;
int modo_clima = 0;

int estado_led_calef = 0;
int modo_calefaccion = 0;

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
  Serial.begin(9600);
  //Serial.println("START");
  
  //LUMINOSIDAD  
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
  
  //OTROS ACTUADORES
  pinMode(LED_VERDE, OUTPUT);
  pinMode(LED_AMARILLO, OUTPUT);
  pinMode(LED_CALEF, OUTPUT);
}

/*************************************************************/ 
/************************  LOOP     **************************/ 
/*************************************************************/ 
void loop() 
{  
  if(Serial.available()){
        //Recibe señal del HMI
       int serial_input = Serial.read();
       
       //Codigos de LUCES
       if(serial_input=='A'){estado_led_verde = 1;}//ON
       if(serial_input=='B'){estado_led_verde = 0;}//OFF
       if(serial_input=='C'){modo_luces = 1;}//manual
       if(serial_input=='D'){modo_luces = 0;}//auto
       if(serial_input=='E'){estado_auto_led_verde = 1;}//ON manual
       if(serial_input=='F'){estado_auto_led_verde = 0;}//OFF auto}
       
       //Codigos de CLIMA
       if(serial_input=='G'){estado_led_amarillo = 1;}//ON
       if(serial_input=='H'){estado_led_amarillo = 0;}//OFF
       if(serial_input=='I'){modo_clima = 1;}//manual
       if(serial_input=='J'){modo_clima = 0;}//auto
       
       //Codigos de CALEFACCION      
       if(serial_input=='K'){estado_led_calef = 1;}//ON
       if(serial_input=='L'){estado_led_calef = 0;}//OFF
  }
  
  
  // -------------------- Luces -------------------- //
  
  if(modo_luces == 1) //Modo MANUAL Luces
  {
    // CHECK de los estados de las variables de los Actuadores
    if(estado_led_verde == 1){ digitalWrite(LED_VERDE, LOW); }//led verde TURN ON
    if(estado_led_verde == 0){ digitalWrite(LED_VERDE, HIGH); }//led verde TURN OFF
  }
  if(modo_luces == 0) //Modo AUTOMATICO Luces
  {
    // CHECK de los estados de las variables de los Actuadores
    if(estado_auto_led_verde == 1){ digitalWrite(LED_VERDE, LOW); }//led verde TURN ON
    if(estado_auto_led_verde == 0){ digitalWrite(LED_VERDE, HIGH); }//led verde TURN OFF
  }

  // -------------------- Clima -------------------- //  
  
    // CHECK de los estados de las variables de los Actuadores
    if(estado_led_amarillo == 1){ digitalWrite(LED_AMARILLO, LOW); }// TURN ON
    if(estado_led_amarillo == 0){ digitalWrite(LED_AMARILLO, HIGH); }// TURN OFF
    
   // -------------------- Calefaccion -------------------- //  
  
    // CHECK de los estados de las variables de los Actuadores
    if(estado_led_calef == 1){ digitalWrite(LED_CALEF, LOW); }// TURN ON
    if(estado_led_calef == 0){ digitalWrite(LED_CALEF, HIGH); }// TURN OFF
  
  
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
  
  Serial.flush();
  
  delay(500);
}
