using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visuals : MonoBehaviour
{
    public Material Left;
    public Material Right;
    private float[] delay = { 10.0f, 70.0f, 150.0f, 230.0f, 400.0f };
    private float targetAlpha = 1.0f;

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
        while (side.color != newAlpha)
        {
            Color increment;
            increment.r = increment.b = increment.g = 0;
            increment.a = 0.01f;
            side.color = side.color + increment;
            yield return new WaitForSeconds(.01f);
        }
        // Wait for the specified amount of time
        yield return new WaitForSeconds(5);
        side.color= oldAlpha;
    }
}