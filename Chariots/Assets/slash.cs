using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slash : MonoBehaviour
{
    private AudioSource Sound;
    private void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Fruit")
        {
            Debug.Log("Hit fruit");
            //yield return new WaitForSeconds(2);
            //Instantiate(Particles, col.gameObject.transform.position, Quaternion.identity); 
            Sound = col.gameObject.GetComponent<AudioSource>();
            Sound.Play();
            Destroy(col.gameObject);
            

        }
    }
}
