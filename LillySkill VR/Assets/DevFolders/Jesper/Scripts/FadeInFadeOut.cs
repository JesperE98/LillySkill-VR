using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JespersCode
{
    public class FadeInFadeOut : MonoBehaviour
    {
        private Renderer fadeInFadeOutMaterial;
        private GameManager gameManager;

    private void Awake()
        {
            gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
            fadeInFadeOutMaterial = GetComponent<Renderer>();
        }

        public void StartFadeInRoutine()
        {
            StartCoroutine(FadeInRoutine(true));
        }

        private IEnumerator FadeInRoutine(bool fadeAway)
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
            gameManager.FadeInComplete = true;
        }

        public IEnumerator FadeOutRoutine(bool fadeAway)
        {
            if (fadeAway == true)
            {
                for (float i = 0; i <= 1; i += Time.deltaTime)
                {
                    fadeInFadeOutMaterial.material.color = new Color(0, 0, 0, i);
                    yield return null;
                }
            }
            gameManager.FadeOutComplete = true;
        }
    }
}

