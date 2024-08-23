using System.Collections;
using System.Collections.Generic;
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
        }
        if (Play_Visuals && Play_Video)
        {
            Visuals.SetActive(true);
        }
        if (Play_Haptics && Play_Haptics) {
            Haptics.SetActive(true);    
        }
    
    }
}
