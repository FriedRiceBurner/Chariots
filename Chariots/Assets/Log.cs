using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Log : MonoBehaviour
{
    public string user;
    //public bool test = false;
    string User_File;
 


    public void Count() {
    string time= System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            File.AppendAllText(User_File, "Passerby detected at"+time + "\n");
    }
    // Start is called before the first frame update
    void Start()
    {User_File = string.Concat("User", user, ".txt");
        string time = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        File.WriteAllText(User_File, "Video started at"+time);
    }

  
}


