using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Linq;
using Unity.VisualScripting;
using Jesper.Collection;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEditor.Experimental.GraphView;
using Jesper.GameSettings.Data;

namespace LillyCode
{
    public class LillyUI : MonoBehaviour
    {
        [SerializeField] private GameSettingsScriptableObject gameSettings;

        [Tooltip("Reference to the parent of the image gameobject")]
        [SerializeField] private GameObject lillyHelpScreen;

        [Tooltip("Reference to the information text")]
        [SerializeField] private TextMeshProUGUI canvasText;

        [Tooltip("Reference to the audio source")]
        [SerializeField] private AudioSource audioSource;

        [Tooltip("Reference to the audiomixer's voice output")]
        [SerializeField] private AudioMixerGroup voiceMixerGroup;

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

        private UIManager uiManager;
        private GameManager gameManager;
        private bool boolSwitch = false;

        private void Awake()
        {
            switch (gameSettings.GetScene)
            {
                case GameSettingsScriptableObject.LoadedScene.Office:

                    uiManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
                    gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

                    break;
            }
        }

        private void Start()
        {
            activeScreen = 0;
            DisableUIButtons();
            
            switch (gameSettings.GetScene)
            {
                case GameSettingsScriptableObject.LoadedScene.Tutorial:

                    if (!gameManager.TutorialDone)
                    {
                        ActivateHelpScreen(0);
                    }
                    else
                    {
                        return;
                    }

                    break;
            }
        }
        private void Update()
        {          
            // Checks for the active screen and shows the information
            if (informationScreenContent[activeScreen].isActive == true && informationScreenContent != null)
            {
                ShowHelpScreenInformation();
            }

            switch (gameSettings.GetScene)
            {
                case GameSettingsScriptableObject.LoadedScene.Tutorial:

                    if (gameManager.LillyIntroDone == false && gameManager.LillyOutroDone == false)
                    {
                        switch (activeScreen)
                        {
                            case 2:
                                uiManager.uiPrefabCopyList[3].SetActive(true);
                                break;

                            case 3:
                                uiManager.uiPrefabCopyList[3].SetActive(false);
                                uiManager.uiPrefabCopyList[4].SetActive(true);
                                break;

                            case 4:
                                uiManager.uiPrefabCopyList[3].SetActive(true);
                                uiManager.uiPrefabCopyList[4].SetActive(false);
                                break;

                            case 6:
                                uiManager.uiPrefabCopyList[3].SetActive(false);
                                uiManager.uiPrefabCopyList[4].SetActive(false);
                                break;
                        }
                    }
                    else
                    {
                        return;
                    }

                    break;
            }
        }

        [System.Serializable]
        public class LillyInformationScreen
        {
            [HideInInspector]
            public int index;
            public string speechText;
            public int picture;
            public AudioClip lillyAudioClip;
            public bool lastScreen;
            [HideInInspector]
            public bool isActive;
            public UnityEvent myEvent;
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
                informationScreenContent[activeScreen].myEvent.Invoke(); //Invokes the UnityEvent attached to the specific index

                audioSource.clip = informationScreenContent[activeScreen].lillyAudioClip;
                audioSource.outputAudioMixerGroup = voiceMixerGroup;

                if (audioSource.clip != null)
                {
                    StartCoroutine(PlayLillyAudio());
                }
            }
            else
                return;
        }

        public IEnumerator PlayLillyAudio()
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
            

            switch (gameSettings.GetScene)
            {
                case GameSettingsScriptableObject.LoadedScene.Tutorial:

                    gameManager.LillyIntroDone = true;

                    break;
            }
        }

        /// <summary>
        /// Enables the Lilly UI buttons
        /// </summary>
        private void EnableUIButtons()
        {
            if (informationScreenContent[activeScreen].lastScreen == true)
            {
                closeButtonGameObject.SetActive(true);
            }
            else
            {
                nextButtonGameObject.SetActive(true);
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
    }
}

