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
    public GameObject Game;
    public VideoPlayer Videoscreen;
    public GameObject[] spawners;
    public bool Play_Video;
    public bool Play_Haptics;
    public bool Play_Visuals;
    public bool Play_Game;
    public string user;
    string User_File;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Play_Video){
            Videoscreen.Play();
            Debug.Log("begin called now");
            begin();
         
        }
        if (Play_Game){
            Game.SetActive(true);
            spawners[0].SetActive(true);
            spawners[1].SetActive(true);
            spawners[2].SetActive(true);
            spawners[3].SetActive(true);
        }
            
        
        if (Play_Visuals && Play_Video || Play_Game && Play_Visuals)
        {
            Visuals.SetActive(true);
            Play_Video = false;
        }
        if (Play_Haptics && Play_Video || Play_Game && Play_Haptics) {
            Haptics.SetActive(true);
            Play_Video = false;
        }
    
    }

    public void Count(string side)
    {
        string time = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        File.AppendAllText(User_File, "Passerby detected at" + time + side + "\n");
    }
    public void begin()
    {
        User_File = string.Concat("User", user, ".txt");
        string time = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        File.WriteAllText(User_File, "Video started at" + time);
    }


}
