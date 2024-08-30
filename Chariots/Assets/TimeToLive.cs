using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToLive : MonoBehaviour
{
    public int time;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
