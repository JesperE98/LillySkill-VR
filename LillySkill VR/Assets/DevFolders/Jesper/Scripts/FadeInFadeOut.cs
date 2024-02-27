using JesperScriptableObject;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JespersCode
{
    public class FadeInFadeOut : MonoBehaviour
    {
        private Renderer fadeInFadeOutMaterial;
        private GameManager gameManager;

        [SerializeField]
        private GameSettingsScriptableObject m_GameSettings;

        private void Awake()
        {
            if(m_GameSettings.LoadedScene != 0)
            {
                gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
            }

            fadeInFadeOutMaterial = GetComponent<Renderer>();
        }

        private void Start()
        {
            StartCoroutine(FadeInRoutine(true));
        }

        public void StartFadeOutRoutine()
        {
            StartCoroutine(FadeOutRoutine(true));
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

            if (m_GameSettings.LoadedScene != 0)
            {
                gameManager.FadeInComplete = true;
            }
        }

        private IEnumerator FadeOutRoutine(bool fadeAway)
        {
            if (fadeAway == true)
            {
                for (float i = 0; i <= 1; i += Time.deltaTime)
                {
                    fadeInFadeOutMaterial.material.color = new Color(0, 0, 0, i);
                    yield return null;
                }
            }
        }
    }
}

