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
  switch(side){
    case 1:
    delay(108509);
    digitalWrite(behind,HIGH); //stimuli 1
    delay(750);
    digitalWrite(behind,LOW);
    delay(13188);
    digitalWrite(side,HIGH); //stimuli 2
    delay(750);
    digitalWrite(side,LOW);
    delay(349229);
    digitalWrite(front,HIGH); //stimuli 3
    delay(750);
    digitalWrite(front,LOW);
    delay(47738);
    digitalWrite(behind,HIGH);//stimuli 4
    delay(750);
    digitalWrite(behind,LOW);
    delay(71336);
    digitalWrite(side,HIGH);//stimuli 5
    delay(750);
    digitalWrite(side,LOW);
    break;

    case 2:
    delay(145000);
    digitalWrite(behind,HIGH); //stimuli 1
    delay(750);
    digitalWrite(behind,LOW);
    delay(123456);
    digitalWrite(behind,HIGH); //stimuli 2
    delay(750);
    digitalWrite(behind,LOW);
    delay(98765);
    digitalWrite(behind,HIGH); //stimuli 3
    delay(750);
    digitalWrite(behind,LOW);
    delay(76543);
    digitalWrite(behind,HIGH);//stimuli 4
    delay(750);
    digitalWrite(behind,LOW);
    delay(146236);
    digitalWrite(behind,HIGH);//stimuli 5
    delay(750);
    digitalWrite(behind,LOW);
    break;

    case 3:
    delay(145000);
    digitalWrite(behind,HIGH); //stimuli 1
    delay(750);
    digitalWrite(behind,LOW);
    delay(123456);
    digitalWrite(behind,HIGH); //stimuli 2
    delay(750);
    digitalWrite(behind,LOW);
    delay(98765);
    digitalWrite(behind,HIGH); //stimuli 3
    delay(750);
    digitalWrite(behind,LOW);
    delay(76543);
    digitalWrite(behind,HIGH);//stimuli 4
    delay(750);
    digitalWrite(behind,LOW);
    delay(146236);
    digitalWrite(behind,HIGH);//stimuli 5
    delay(750);
    digitalWrite(behind,LOW);
    break;
   
    case 4:
     delay(108509);
    digitalWrite(behind,HIGH); //stimuli 1
    delay(750);
    digitalWrite(behind,LOW);
    delay(13188);
    digitalWrite(side,HIGH); //stimuli 2
    delay(750);
    digitalWrite(side,LOW);
    delay(349229);
    digitalWrite(front,HIGH); //stimuli 3
    delay(750);
    digitalWrite(front,LOW);
    delay(47738);
    digitalWrite(behind,HIGH);//stimuli 4
    delay(750);
    digitalWrite(behind,LOW);
    delay(71336);
    digitalWrite(side,HIGH);//stimuli 5
    delay(750);
    digitalWrite(side,LOW);
    break;


    default:
    return;
  }
}
  

