using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Instrumentation;
using UnityEngine;
using UnityEngine.UIElements;

public class fruit_spawn : MonoBehaviour
{
    public GameObject[] Fruits;
    private GameObject Spawned;
    public GameObject[] SpawnPoint;
    public GameObject Post;
    float rotation;
    Vector3 angles;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Fruit_Spawning());
        angles = new Vector3(0.0f, 0.0f, 0.0f);
    }

    void Update()
    {
        rotation = UnityEngine.Random.Range(15.0f, 65.0f);
        angles= new Vector3(0,rotation, 0);
        Post.transform.eulerAngles = angles;
    }

    private IEnumerator Fruit_Spawning()
    { while (true)
        {
            Vector3 position = SpawnPoint[UnityEngine.Random.Range(0, SpawnPoint.Length - 1)].transform.position;
            Instantiate(Fruits[UnityEngine.Random.Range(0, Fruits.Length - 1)],position,Quaternion.identity);
            yield return new WaitForSeconds(5);
        }
    }
}
