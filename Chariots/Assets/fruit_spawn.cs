using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Instrumentation;
using UnityEngine;
using UnityEngine.UIElements;

public class fruit_spawn : MonoBehaviour
{
    public GameObject[] Fruits;
    public GameObject[] SpawnPoint;
    
   
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Fruit_Spawning());
       
    }

    void Update()
    {
        
    }

    private IEnumerator Fruit_Spawning()
    { while (true)
        {
            Vector3 position = SpawnPoint[UnityEngine.Random.Range(0, SpawnPoint.Length - 1)].transform.position;
            Instantiate(Fruits[UnityEngine.Random.Range(0, Fruits.Length - 1)],position,Quaternion.identity);
            yield return new WaitForSeconds(2);
        }
    }
}
