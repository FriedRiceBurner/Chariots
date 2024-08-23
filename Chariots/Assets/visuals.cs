using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visuals : MonoBehaviour
{
    public Material Left;
    public Material Right;
    private float[] delay = { 10.0f, 60.0f, 80.0f, 85.0f, 145.0f };
    private float targetAlpha = 125.0f;

    private Color originalColor;

    private void Start()
    {
        Debug.Log("Here!");
        StartCoroutine(AdjustTransparencyCoroutine(delay[0],Left));
        Debug.Log("Here!");
        StartCoroutine(AdjustTransparencyCoroutine(delay[1],Right));
        Debug.Log("Here!");
        StartCoroutine(AdjustTransparencyCoroutine(delay[2],Left));
        Debug.Log("Here!");
        StartCoroutine(AdjustTransparencyCoroutine(delay[3],Left));
        Debug.Log("Here!");
        StartCoroutine(AdjustTransparencyCoroutine(delay[4],Right));
        Debug.Log("Here!");
    }

    private IEnumerator AdjustTransparencyCoroutine(float delay,Material side)
    {
        // Wait for the specified amount of time
        yield return new WaitForSeconds(delay);

        // Change transparency of the material
        StartCoroutine(AdjustTransparency(targetAlpha,side));
    }

    private IEnumerator AdjustTransparency(float alpha, Material side)
    {
        Debug.Log("Here!");
        // Create a new color with the desired alpha value
        Color newAlpha = side.color;
        newAlpha.a = alpha;
        Color oldAlpha = side.color;

        // Apply the new color to the material
        side.color = newAlpha;
        // Wait for the specified amount of time
        yield return new WaitForSeconds(5);
        side.color= oldAlpha;
    }
}