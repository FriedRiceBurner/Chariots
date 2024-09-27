using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_Bullet : MonoBehaviour
{
    public Rigidbody Bullet;
    public GameObject controller;
    public float speed;
    public AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    
    public void Shoot()
    {
        sound.Play(0);
        // Spawn the object at the spawn point
        var shuriken = Instantiate(Bullet, controller.transform.position, controller.transform.rotation);
        shuriken.AddForce(controller.transform.forward * speed);
    }

    


}


