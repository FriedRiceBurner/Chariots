using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino;

#if UDUINO_READY
public class motors : MonoBehaviour
{

    public bool left = false;
    public bool right = false;
    public bool middle = false;
    private void Update()
    {

        if (left)
        {
            UduinoManager.Instance.sendCommand("hi",13);
            left = false;
        }
        if (middle)
        {
            UduinoManager.Instance.sendCommand("hi", 14);
            middle = false;
        }
        if (right)
        {
            UduinoManager.Instance.sendCommand("hi", 27);
            right = false;
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