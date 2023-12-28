using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace LillyCode
{
    public class LillyUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI canvasText;
        [SerializeField] private List<GameObject> picturesOfLilly;
        [SerializeField] private List<LillyInformationScreen> informationScreenContent;

        private int activeScreen;

        [System.Serializable]
        public class LillyInformationScreen
        {
            public string speechText;
            public int picture;
            public bool isActive;
        }

        /// <summary>
        /// Updates the text shown on the Lilly help screen
        /// </summary>
        private void ShowScreenInformation()
        {
            canvasText.text = informationScreenContent[activeScreen].speechText;
            picturesOfLilly[informationScreenContent[activeScreen].picture].SetActive(true);
        }

        /// <summary>
        /// Inactivates all active Lilly help screens in the scene
        /// </summary>
        private void InactivateAllScreen()
        {
            foreach (LillyInformationScreen activeScreen in informationScreenContent)
            {
                activeScreen.isActive = false;
            }
        }

        private void ActivateScreen()
        {
            this.gameObject.SetActive(true);
            informationScreenContent[activeScreen].isActive = true;
        }

        private void Start()
        {
            activeScreen = 0;
        }

        private void Update()
        {
            ShowScreenInformation();
        }
    }
}

