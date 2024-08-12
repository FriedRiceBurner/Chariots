using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino;

#if UDUINO_READY
public class motors : MonoBehaviour
{

    public bool left = false;
    public bool right = false;
    private void Update()
    {

        if (left)
        {
            UduinoManager.Instance.sendCommand("hi",1);
        }
        if (right)
        {
            UduinoManager.Instance.sendCommand("hi", 2);
        }
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