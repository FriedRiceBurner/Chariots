using System.Collections;
using System.IO;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Playables;
using Uduino;

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
    private float[] delay = { 10.0f, 70.0f, 150.0f, 230.0f, 400.0f };

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
            
        
        if (Play_Visuals && Play_Video || Play_Game && Play_Visuals)
        {
            Visual_stimuli();
            Play_Video = false;
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
        File.AppendAllText(User_File, "Passerby detected at" + time + side + "\n");
    }
    public void begin(int mode)
    {
        User_File = string.Concat("User", user, ".txt");
        string time = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        if (mode == 1)
        {
            File.WriteAllText(User_File, "Video started at" + time);
        }
        else
        {
            File.WriteAllText(User_File, "Game started at" + time);
        }
    }

    public void Visual_stimuli()
    {
        Debug.Log("Here!");
        StartCoroutine(AdjustTransparencyCoroutine(delay[0], Right));
        Debug.Log("Here!");
        StartCoroutine(AdjustTransparencyCoroutine(delay[1], Left));
        Debug.Log("Here!");
        StartCoroutine(AdjustTransparencyCoroutine(delay[2], Left));
        Debug.Log("Here!");
        StartCoroutine(AdjustTransparencyCoroutine(delay[3], Right));
        Debug.Log("Here!");
        StartCoroutine(AdjustTransparencyCoroutine(delay[4], Right));
        Debug.Log("Here!");
       
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
