// Uduino settings
#include <Uduino_Wifi.h>
#define LED 13
String unity_input;
Uduino_Wifi uduino("Righty");  // Declare and name your object
#define behind 13
#define middle 14
#define front 27
void setup() {

  Serial.begin(9600);

  // // Optional function,  to add BEFORE connectWifi(...)
  uduino.setPort(4233);   // default 4222

  uduino.useSendBuffer(true);     // default true
  uduino.setConnectionTries(35);  // default 35
  uduino.useSerial(true);         // default is true

  // mendatory function
  uduino.connectWifi("TMobileWiFi-2.4GHz", "416356373337");
  //uduino.connectWifi("NETGEAR75", "orangeballoon353");
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
    delay(9000);
    digitalWrite(behind,HIGH); //stimuli 1
    delay(750);
    digitalWrite(behind,LOW);
    delay(45000);
    digitalWrite(side,HIGH); //stimuli 2
    delay(750);
    digitalWrite(side,LOW);
    delay(278000);
    digitalWrite(front,HIGH); //stimuli 3
    delay(750);
    digitalWrite(front,LOW);
    delay(59000);
    digitalWrite(behind,HIGH);//stimuli 4
    delay(750);
    digitalWrite(behind,LOW);
    delay(60000);
    digitalWrite(side,HIGH);//stimuli 5
    delay(750);
    digitalWrite(side,LOW);
    break;

    case 2:
    delay(85000);
    digitalWrite(behind,HIGH); //stimuli 1
    delay(750);
    digitalWrite(behind,LOW);
    delay(50000);
    digitalWrite(behind,HIGH); //stimuli 2
    delay(750);
    digitalWrite(behind,LOW);
    delay(283000);
    digitalWrite(behind,HIGH); //stimuli 3
    delay(750);
    digitalWrite(behind,LOW);
    delay(69000);
    digitalWrite(behind,HIGH);//stimuli 4
    delay(750);
    digitalWrite(behind,LOW);
    delay(75000);
    digitalWrite(behind,HIGH);//stimuli 5
    delay(750);
    digitalWrite(behind,LOW);
    break;

    default:
    return;
  }

}
  

