using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino;

#if UDUINO_READY
public class motors : MonoBehaviour
{
        private void Update()
    {
        UduinoDevice lefty = UduinoManager.Instance.GetBoard("Lefty");
        UduinoDevice righty = UduinoManager.Instance.GetBoard("Righty");

       
            UduinoManager.Instance.sendCommand(lefty,"hi",1);
            UduinoManager.Instance.sendCommand(righty, "hi", 2);
        
    }


    public void Received(string data, UduinoDevice u)
    {
        Debug.Log(u.name + " " + data);
    }
}

#else
public class UduinoWifi_ReadWrite : MonoBehaviour
{
    [Header("You need to download Uduino first")]
    public string downloadUduino = "https://www.assetstore.unity3d.com/#!/content/78402";
}
#endif