using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInFadeOut : MonoBehaviour
{
    private Renderer fadeInFadeOutMaterial;   

    private void Awake()
    {
        fadeInFadeOutMaterial = GetComponent<Renderer>();
        StartCoroutine(FadeOutRoutine(true));
    }

    private IEnumerator FadeOutRoutine(bool fadeAway)
    {
        // Fade from opaque to transparent
        if (fadeAway)
        {
            // Loop over 3 seconds backwards
            for (float i = 1; i >= 0; i -= Time.deltaTime)
            {
                fadeInFadeOutMaterial.material.color = new Color(0, 0, 0, i);
                yield return null;

            }
        }
        Debug.Log("Fade Out Complete");
    }

    public IEnumerator FadeInRoutine(bool fadeAway)
    {
        if(fadeAway == true)
        {
            for(float i = 0; i <= 1; i += Time.deltaTime)
            {
                fadeInFadeOutMaterial.material.color = new Color(0, 0, 0, i);
                yield return null;
            }
        }
        Debug.Log("Fade In Complete");
    }
}
