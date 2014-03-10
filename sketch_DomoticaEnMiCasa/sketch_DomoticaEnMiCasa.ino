/*Proyecto Domótica en mi Casa

  Sseñales
  A -> Luces ON
  B -> Luces OFF
  C -> Clima ON; Calefacción OFF
  D -> Clima OFF; Calefacción ON

*/

/*Sensores*/ /*Inputs analogos*/
const int s_temperatura = 0;
const int s_iluminacion = 1;
const int s_movimiento = 2;

/*Actuadores*/
const int a_luces = 13;
const int a_clima = 12;
const int a_calefaccion = 11;

void setup(){
  pinMode(luces, OUTPUT); //declaramos el PIN 13 como salida
  Serial.begin(9600);  
}

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
