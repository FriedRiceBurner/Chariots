using System.Collections;
using System.IO;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Playables;
using Uduino;
using UnityEngine.UIElements;
using System;

public class Playback : MonoBehaviour
{
    public GameObject Game;
    public VideoPlayer Videoscreen;
    public GameObject[] spawners;
    public bool Play_Video;
    public bool Play_Haptics;
    public bool Play_Visuals;
    public GameObject Left;
    public GameObject Right;
    public bool Play_Game;
    public string user;
    string User_File;
    private float[] delay = { 100.0f, 110.0f, 120.0f, 130.0f, 90.0f };
    private float[] delay2 = { 80.0f, 95.0f, 115.0f, 135.0f, 125.0f };
    private string start_time;
    private DateTime Starting_time;
    private Color originalColor;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UduinoDevice lefty = UduinoManager.Instance.GetBoard("Lefty");
        UduinoDevice righty = UduinoManager.Instance.GetBoard("Righty");
        if (Play_Video){
            Videoscreen.Play();
            Debug.Log("begin called now");
            begin(1);
            StartCoroutine(User_timer());


        }
        if (Play_Game){
            Game.SetActive(true);
            spawners[0].SetActive(true);
            spawners[1].SetActive(true);
            spawners[2].SetActive(true);
            spawners[3].SetActive(true);
            begin(2);
            StartCoroutine(User_timer());
        }
            
        
        if (Play_Visuals && Play_Video)
        {
            Visual_stimuli(1);
            Play_Video = false;
           
        }
        if (Play_Visuals && Play_Game)
        {
            Visual_stimuli(2);
            Play_Game = false;

        }
        if (Play_Haptics && Play_Video || Play_Game && Play_Haptics) {
            if (Play_Video)
            {
                UduinoManager.Instance.sendCommand(lefty, "hi", 1);
                UduinoManager.Instance.sendCommand(righty, "hi", 2);
            }
            if (Play_Game) {
                UduinoManager.Instance.sendCommand(lefty, "hi", 3);
                UduinoManager.Instance.sendCommand(righty, "hi", 4);
            }
            Play_Video = false;
            Play_Game = false;
        }
    }

    public void Count(string side)
    {
        string time = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        DateTime intrustion_time = DateTime.Parse(time);
        TimeSpan x = intrustion_time - Starting_time;
        File.AppendAllText(User_File, "Passerby detected at" + x + " seconds on the " +side + "\n");
    }
    public void begin(int mode)
    {
        User_File = string.Concat("User", user, ".txt");
        start_time = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        Starting_time = DateTime.Parse(start_time);
        if (mode == 1)
        {
            File.WriteAllText(User_File, "Video started at" + start_time+ "\n");
        }
        else
        {
            File.WriteAllText(User_File, "Game started at" + start_time + "\n");
        }
    }

    public void Visual_stimuli(int scenario)
    {
        GameObject[] side = null;
        if (scenario == 1)
        {
            side = new GameObject[] { Left, Right, Right, Left, Right };
            for (int i = 0; i < delay.Length; i++)
            {
                Debug.Log("Here!");
                StartCoroutine(AdjustTransparencyCoroutine(delay[i], side[i]));
            }
        }

        if (scenario == 2)
        {
            side = new GameObject[] { Right, Left, Left, Right, Left };
            for (int i = 0; i < delay2.Length; i++)
            {
                Debug.Log("Here!");
                StartCoroutine(AdjustTransparencyCoroutine(delay[i], side[i]));
            }
        }
    }

    private IEnumerator AdjustTransparencyCoroutine(float delay, GameObject side)
    {
        // Wait for the specified amount of time
        yield return new WaitForSeconds(delay);

        // Change transparency of the material
        StartCoroutine(AdjustTransparency(side));
    }

    private IEnumerator AdjustTransparency(GameObject side)
    {
        Debug.Log("Here!");
        // Create a new color with the desired alpha value
        side.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        side.SetActive(false);
    }

    private IEnumerator User_timer() {
        yield return new WaitForSeconds(600);
        Debug.Log("10 minutes has passed!!");

    }

}
