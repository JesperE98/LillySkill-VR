using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Linq;

namespace LillyCode
{
    public class LillyUI : MonoBehaviour
    {
        [Tooltip("Reference to the parent of the image gameobject")]
        [SerializeField] private GameObject lillyHelpScreen;

        [Tooltip("Reference to the information text")]
        [SerializeField] private TextMeshProUGUI canvasText;

        [Tooltip("Reference to the audio source")]
        [SerializeField] private AudioSource audioSource;

        [Tooltip("reference to the ''Next Button'' gameobject")]
        [SerializeField] private GameObject nextButtonGameObject;

        [Tooltip("reference to the ''Close Button'' gameobject")]
        [SerializeField] private GameObject closeButtonGameObject;

        [Header("All different pictures of Lilly")]
        [Space(10)]

        [Tooltip("A list containing all the different pictures of Lilly")]
        [SerializeField] private List<GameObject> picturesOfLilly;

        [Tooltip("A list containing information from each screen element. \n\nCall function: ActivateHelpScreen(index) " +
            "\nto create a Lilly UI in the scene with the chosen index.")]
        [SerializeField] private List<LillyInformationScreen> informationScreenContent;

        // Keeps track of the active screen
        private int activeScreen;

        [System.Serializable]
        public class LillyInformationScreen
        {
            [HideInInspector]
            public int index;
            public string speechText;
            public int picture;
            public AudioClip lillyAudioClip;
            public bool proceedToNextIndex;
            [HideInInspector]
            public bool isActive;
        }

        /// <summary>
        /// Activates the Lilly help screen with the respective index number
        /// </summary>
        public void ActivateHelpScreen(int screenIndex)
        {
            if (informationScreenContent != null)
            {
                lillyHelpScreen.SetActive(true);
                activeScreen = screenIndex;
                informationScreenContent[activeScreen].isActive = true;
                audioSource.clip = informationScreenContent[activeScreen].lillyAudioClip;
                if (audioSource.clip != null)
                {
                    StartCoroutine(PlayLillyAudio());
                }
            }
            else
                return;
        }

        IEnumerator PlayLillyAudio()
        {
            audioSource.Play();
            yield return new WaitForSeconds(audioSource.clip.length);
            EnableUIButtons();
        }

        /// <summary>
        /// Shows the added text and picture of Lilly from the respective screen element
        /// </summary>
        public void ShowHelpScreenInformation()
        {
            canvasText.text = informationScreenContent[activeScreen].speechText;
            picturesOfLilly[informationScreenContent[activeScreen].picture].SetActive(true);
        }

        /// <summary>
        /// Proceeds to the next screen element if 'proceed to next image' is ticked
        /// </summary>
        public void ProceedToNextLillyHelpScreen()
        {
            picturesOfLilly[informationScreenContent[activeScreen].picture].SetActive(false);
            informationScreenContent[activeScreen].isActive = false;
            DisableUIButtons();
            activeScreen++;
            ActivateHelpScreen(activeScreen);
        }

        /// <summary>
        /// Deactivates the active help screen
        /// </summary>
        public void DeactivateLillyHelpScreen()
        {
            informationScreenContent[activeScreen].isActive = false;
            lillyHelpScreen.SetActive(false);
        }

        /// <summary>
        /// Enables the Lilly UI buttons
        /// </summary>
        private void EnableUIButtons()
        {
            if (informationScreenContent[activeScreen].proceedToNextIndex == true)
            {
                nextButtonGameObject.SetActive(true);
            }
            else
            {
                closeButtonGameObject.SetActive(true);
            }
        }

        /// <summary>
        /// Disables the Lilly UI buttons
        /// </summary>
       private void DisableUIButtons()
        {
            nextButtonGameObject.SetActive(false);
            closeButtonGameObject.SetActive(false);
        }

        private void Start()
        {
            ActivateHelpScreen(0);
        }

        private void Update()
        {
            // Checks for the active screen and shows the information
            if (informationScreenContent[activeScreen].isActive == true && informationScreenContent != null)
            {
                ShowHelpScreenInformation();
            }

            // Deactivates the active help screen
            else
            {
                DeactivateLillyHelpScreen();
            }
        }
    }
}

