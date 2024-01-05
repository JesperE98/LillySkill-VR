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

        [Tooltip("reference to the ''Next Button'' gameobject")]
        [SerializeField] private GameObject nextButtonGameObject;

        [Tooltip("reference to the ''Close Button'' gameobject")]
        [SerializeField] private GameObject closeButtonGameObject;

        [Header("Bild 0: Lilly som vinkar, ler med öppna ögon.")]
        [Space(10)]

        [Tooltip("A list containing all the different pictures of Lilly")]
        [SerializeField] private List<GameObject> picturesOfLilly;

        [Header("Anropa \n''ActivateHelpScreen(index)''\n för att skapa en Lilly UI i scenen med vald index.")]
        [Space(10)]

        [Tooltip("A list containing information from each screen element")]
        [SerializeField] private List<LillyInformationScreen> informationScreenContent;

        // Keeps track of the active screen
        private int activeScreen;

        [System.Serializable]
        public class LillyInformationScreen
        {
            public string speechText;
            public int picture;
            public bool isActive;
            public bool proceedToNextIndex;
        }

        /// <summary>
        /// Activates the Lilly help screen with the respective index number
        /// </summary>
        public void ActivateHelpScreen(int screenIndex)
        {
            lillyHelpScreen.SetActive(true);
            activeScreen = screenIndex;
            informationScreenContent[activeScreen].isActive = true;
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

        private void Start()
        {
            ActivateHelpScreen(0);
        }

        private void Update()
        {
            // Checks for the active screen and shows the information
            if (informationScreenContent[activeScreen].isActive == true)
            {
                ShowHelpScreenInformation();

                if(informationScreenContent[activeScreen].proceedToNextIndex == true)
                {
                    nextButtonGameObject.SetActive(true);
                }
                else
                {
                    closeButtonGameObject.SetActive(true);
                }
            }

            // Deactivates the active help screen
            else
            {
                DeactivateLillyHelpScreen();
            }
        }
    }
}

