using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Log : MonoBehaviour
{
    public string user;
    string User_File;
    public void Count(string side) {
    string time= System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            File.AppendAllText(User_File, "Passerby detected at"+time + "on the"+ side + "\n");
    }
    public void begin()
    {  
        User_File = string.Concat("C:/Users/josev/Documents/GitHub/Chariots/Chariots/Assets/Logs/User", user, ".txt");
        string time = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        File.WriteAllText(User_File, "Video started at"+time);
    }

  
}


