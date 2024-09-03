using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visuals : MonoBehaviour
{
    public GameObject Left;
    public GameObject Right;
    public Material Original;
    public Material notification;
    private string user;
    private float[] delay = { 10.0f, 70.0f, 150.0f, 230.0f, 400.0f };
    private float targetAlpha = 1.0f;

    private Color originalColor;

    private void Start()
    {
        
        Debug.Log(user);
        Debug.Log("Here!");
        StartCoroutine(AdjustTransparencyCoroutine(delay[0],Right));
        Debug.Log("Here!");
        StartCoroutine(AdjustTransparencyCoroutine(delay[1],Left));
        Debug.Log("Here!");
        StartCoroutine(AdjustTransparencyCoroutine(delay[2],Left));
        Debug.Log("Here!");
        StartCoroutine(AdjustTransparencyCoroutine(delay[3],Right));
        Debug.Log("Here!");
        StartCoroutine(AdjustTransparencyCoroutine(delay[4],Right));
        Debug.Log("Here!");
        StartCoroutine(AdjustTransparencyCoroutine(delay[2],Left ));
        Debug.Log("Here!");
        StartCoroutine(AdjustTransparencyCoroutine(delay[4], Right));
        Debug.Log("Here!");
        StartCoroutine(AdjustTransparencyCoroutine(delay[0], Left));
        Debug.Log("Here!");
        StartCoroutine(AdjustTransparencyCoroutine(delay[1], Left));
        Debug.Log("Here!");
        StartCoroutine(AdjustTransparencyCoroutine(delay[3], Right));
        Debug.Log("Here!");
    }

    private IEnumerator AdjustTransparencyCoroutine(float delay,GameObject side)
    {
        // Wait for the specified amount of time
        yield return new WaitForSeconds(delay);

        // Change transparency of the material
        StartCoroutine(AdjustTransparency(targetAlpha,side));
    }

    private IEnumerator AdjustTransparency(float alpha, GameObject side)
    {
        Debug.Log("Here!");
        // Create a new color with the desired alpha value
       side.GetComponent<MeshRenderer>().material = notification;
            yield return new WaitForSeconds(1.0f);
    }

}