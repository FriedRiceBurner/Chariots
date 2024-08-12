// Uduino settings
#include <Uduino_Wifi.h>
#define LED 13
String unity_input;
Uduino_Wifi uduino("Lefty");  // Declare and name your object
#define left 13
#define middle 14
#define right 27
void setup() {

  Serial.begin(9600);

  // // Optional function,  to add BEFORE connectWifi(...)
  // uduino.setPort(4222);   // default 4222

  uduino.useSendBuffer(true);     // default true
  uduino.setConnectionTries(35);  // default 35
  uduino.useSerial(true);         // default is true

  // mendatory function
  ///uduino.connectWifi("TMobileWiFi-2.4GHz", "416356373337");
  uduino.connectWifi("NETGEAR75", "orangeballoon353");
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

digitalWrite(motor,HIGH);
delay(1000);
digitalWrite(motor,LOW);
}
  

