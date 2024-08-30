using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.GraphicsBuffer;

public class movement : MonoBehaviour
{
    public Rigidbody fruit;
    public float rotationSpeed = 3f;
    public float speed = 1f;
    //public GameObject Spawnpoint;
    public GameObject Target;
    //public int rate_of_fire;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Get the direction to the target
        Vector3 direction = Target.transform.position - fruit.transform.position;
        // Create a rotation to look at the target
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        // Slerp to interpolate smoothly towards the target rotation
        fruit.transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        fruit.AddForce(transform.forward * speed);
    }
}