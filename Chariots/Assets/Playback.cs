using System.Collections;
using System.IO;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class Playback : MonoBehaviour
{
    public GameObject Haptics;
    public GameObject Visuals;
    public VideoPlayer Videoscreen;
    public bool Play_Video;
    public bool Play_Haptics;
    public bool Play_Visuals;
    public string user;
    string User_File;

    // Start is called before the first frame update
    void Start()
    {
        Haptics.SetActive(false);
        Visuals.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Play_Video){
            Videoscreen.Play();
            Debug.Log("begin called now");
            begin();
            Play_Video = false;
        }
        if (Play_Visuals && Play_Video)
        {
            Visuals.SetActive(true);
        }
        if (Play_Haptics && Play_Video) {
            Haptics.SetActive(true);
        }
    
    }

    public void Count()
    {
        string time = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        File.AppendAllText(User_File, "Passerby detected at" + time + "\n");
    }
    public void begin()
    {
        User_File = string.Concat("User", user, ".txt");
        string time = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        File.WriteAllText(User_File, "Video started at" + time);
    }


}
