using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slash : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Fruits")
        {
            Debug.Log("Hit fruit");
            //yield return new WaitForSeconds(2);
            //Instantiate(Particles, col.gameObject.transform.position, Quaternion.identity); 
            Destroy(col.gameObject);
            //Sound = GetComponent<AudioSource>();
           // Sound.Play(0);

        }
    }
