using JesperScriptableObject;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JespersCode
{
    public class ButtonFunctions : MonoBehaviour
    {
        private UIManager uiManager;
        private GameManager gameManager;
        private AudioManager audioManager;

        [SerializeField]
        private GameSettingsScriptableObject m_GameSettings;


        void Awake()
        {
            if (m_GameSettings.LoadedScene != 0)
            {
                gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
            }

            uiManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
            audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
        }

        /// <summary>
        /// Method for the Worst Answer Button alternative on the AnswerUIButton.
        /// </summary>
        public void UsedWorstAnswerButton()
        {
            gameManager.InterviewerInterest -= 1;
            gameManager.PlayerScore += 0;
            uiManager.StartUIDeactivation();

            if (gameManager.AnswerPageNumber <= 10)
            {
                audioManager.StartAudioCoroutine();
            }
            else { return; }
        }

        /// <summary>
        /// Method for the Bad Answer Button alternative on the AnswerUIButton.
        /// </summary>
        public void UsedBadAnswerButton()
        {
            gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Dåligt svar.");
            gameManager.InterviewerInterest -= 1;
            gameManager.PlayerScore += 0;
            uiManager.StartUIDeactivation();

            if (gameManager.AnswerPageNumber <= 10)
            {
                audioManager.StartAudioCoroutine();
            }
            else { return; }
        }

        /// <summary>
        /// Method for the Average Answer Button alternative on the AnswerUIButton.
        /// </summary>
        public void UsedAverageAnswerButton()
        {
            gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Helt ok svar.");
            gameManager.InterviewerInterest += 0;
            gameManager.PlayerScore += 1;
            uiManager.StartUIDeactivation();

            if(gameManager.AnswerPageNumber <= 10)
            {
                audioManager.StartAudioCoroutine();
            }
            else { return; }
        }

        /// <summary>
        /// Method for the Good Answer Button alternative on the AnswerUIButton.
        /// </summary>
        public void UsedGoodAnswerButton()
        {
            gameManager.InterviewerInterest += 1;
            gameManager.PlayerScore += 2;
            uiManager.StartUIDeactivation();

            if (gameManager.AnswerPageNumber <= 10)
            {
                audioManager.StartAudioCoroutine();
            }
            else { return; }
        }

        /// <summary>
        /// Method for the Best Answer Button alternative on the AnswerUIButton.
        /// </summary>
        public void UsedBestAnswerButton()
        {
            gameManager.InterviewerInterest += 1;
            gameManager.PlayerScore += 3;
            uiManager.StartUIDeactivation();

            if (gameManager.AnswerPageNumber <= 10)
            {
                audioManager.StartAudioCoroutine();
            }
            else { return; }
        }



        /// <summary>
        /// Method for activating the Feedback UI Page.
        /// </summary>
        public void ActivateFeedbackPage()
        {
            uiManager.uiPrefabCopyList[3].SetActive(true);
        }

        /// <summary>
        /// Method for a UI Button to go to the next page.
        /// </summary>
        public void ActivateSummaryPage()
        {
            gameObject.SetActive(false);
            uiManager.uiPrefabCopyList[4].SetActive(true);
        }

        //////////////////////////////////////////////// The section below are code ONLY for the Start Menu Scene UI Prefabs /////////////////////////////////////////

        /// <summary>
        /// Deactivates current page and activates Start Menu page.
        /// </summary>
        public void StartMenuButton()
        {
            gameObject.SetActive(false);
            uiManager.uiPrefabCopyList[0].SetActive(true);
        }

        /// <summary>
        /// Deactivates current page and activates Exercises page.
        /// </summary>
        public void ExercisesPageButton()
        {
            gameObject.SetActive(false);
            uiManager.uiPrefabCopyList[1].SetActive(true);
        }

        /// <summary>
        /// Deactivates current page and activates Tutorial page.
        /// </summary>
        public void TutorialPageButton()
        {
            gameObject.SetActive(false);
            uiManager.uiPrefabCopyList[2].SetActive(true);
        }

        /// <summary>
        /// Deactivates current page and activates About page.
        /// </summary>
        public void AboutPageButton()
        {
            gameObject.SetActive(false);
            uiManager.uiPrefabCopyList[3].SetActive(true);
        }

        /// <summary>
        /// Deactivates current page and activates Settings page.
        /// </summary>
        public void SettingsPageButton()
        {
            gameObject.SetActive(false);
            uiManager.uiPrefabCopyList[4].SetActive(true);
        }

        /// <summary>
        /// Deactivates current page and activates Main Mode page.
        /// </summary>
        public void MainModeButton()
        {
            gameObject.SetActive(false);
            uiManager.uiPrefabCopyList[5].SetActive(true);
        }

        /// <summary>
        /// Deactivates current page and activates About page.
        /// </summary>
        public void QuitTheApplicationPage()
        {
            gameObject.SetActive(false);
            uiManager.uiPrefabCopyList[6].SetActive(true);
        }

        /// <summary>
        /// Quits the application.
        /// </summary>
        public void QuitApplication()
        {
            Application.Quit();
        }
    }
}

