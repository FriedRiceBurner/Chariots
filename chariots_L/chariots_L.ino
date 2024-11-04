// Uduino settings
#include <Uduino_Wifi.h>
#define LED 13
String unity_input;
Uduino_Wifi uduino("Lefty");  // Declare and name your object
#define behind 13
#define middle 14
#define front 27
void setup() {

  Serial.begin(9600);

  // // Optional function,  to add BEFORE connectWifi(...)
  uduino.setPort(4222);   // default 4222

  uduino.useSendBuffer(true);     // default true
  uduino.setConnectionTries(35);  // default 35
  uduino.useSerial(true);         // default is true

  // mendatory function
 // uduino.connectWifi("TMobileWiFi-2.4GHz", "416356373337");
uduino.connectWifi("Hidden Network (2)", "proprioception");
  pinMode(13,OUTPUT);
  pinMode(14,OUTPUT);
  pinMode(27,OUTPUT);
  uduino.addCommand("hi",hi);
}

void loop() {
  uduino.update();
  }


void hi(){
  int side= uduino.charToInt(uduino.getParameter(0));
  switch(side){
    case 1:
    delay(147759);
    digitalWrite(behind,HIGH); //stimuli 1
    delay(750);
    digitalWrite(behind,LOW);
    delay(22438);
    digitalWrite(side,HIGH); //stimuli 2
    delay(750);
    digitalWrite(side,LOW);
    
  
    break;

    case 2:
    delay(118015);
    digitalWrite(behind,HIGH); //stimuli 3
    delay(750);
    digitalWrite(behind,LOW);
    delay(115793);
    digitalWrite(behind,HIGH);//stimuli 4
    delay(750);
    digitalWrite(behind,LOW);
    delay(175486);
    digitalWrite(behind,HIGH);//stimuli 5
    delay(750);
    digitalWrite(behind,LOW);
    break;

    case 3:
    delay(109250);
    digitalWrite(behind,HIGH); //stimuli 1
    delay(750);
    digitalWrite(behind,LOW);
    delay(114250);
    digitalWrite(behind,HIGH);//stimuli 5
    delay(750);
    digitalWrite(behind,LOW);
    break;
   
    case 4:

    delay(12250);
    digitalWrite(side,HIGH); //stimuli 2
    delay(750);
    digitalWrite(side,LOW);
    delay(299250);
    digitalWrite(front,HIGH); //stimuli 3
    delay(750);
    digitalWrite(front,LOW);
    delay(59250);
    digitalWrite(behind,HIGH);//stimuli 4
    delay(750);
    digitalWrite(behind,LOW);
    break;


    default:
    return;
  }

}
  


