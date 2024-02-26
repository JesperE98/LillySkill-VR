using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JespersCode
{
    public class UIManagerButtonFunctions : MonoBehaviour
    {
        private UIManager uiManager;
        private GameManager gameManager;
        private AudioManager audioManager;
        private GameObject uiPrefabCopy;


        void Awake()
        {
            uiManager = FindObjectOfType<UIManager>();
            gameManager = FindObjectOfType<GameManager>();
            audioManager = FindObjectOfType<AudioManager>();
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
               // audioManager.StartAudioCoroutine();
            }
            else { return; }
        }

        /// <summary>
        /// Method for the Bad Answer Button alternative on the AnswerUIButton.
        /// </summary>
        public void UsedBadAnswerButton()
        {
            gameManager.AddAnswerToList("Fr�ga " + gameManager.AnswerPageNumber + ": D�ligt svar.");
            gameManager.InterviewerInterest -= 1;
            gameManager.PlayerScore += 0;
            uiManager.StartUIDeactivation();

            if (gameManager.AnswerPageNumber <= 10)
            {
              // audioManager.StartAudioCoroutine();
            }
            else { return; }
        }

        /// <summary>
        /// Method for the Average Answer Button alternative on the AnswerUIButton.
        /// </summary>
        public void UsedAverageAnswerButton()
        {
            gameManager.AddAnswerToList("Fr�ga " + gameManager.AnswerPageNumber + ": Helt ok svar.");
            gameManager.InterviewerInterest += 0;
            gameManager.PlayerScore += 1;
            uiManager.StartUIDeactivation();

            if(gameManager.AnswerPageNumber <= 10)
            {
                // audioManager.StartAudioCoroutine();
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
                // audioManager.StartAudioCoroutine();
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
                // audioManager.StartAudioCoroutine();
            }
            else { return; }
        }



        /// <summary>
        /// Method for activating the Feedback UI Page.
        /// </summary>
        public void ActivateFeedbackPage()
        {
            gameManager.FeedbackPageActive = true;
            gameManager.SummaryPageActive = false;
            uiManager.uiPrefabCopyList[3].SetActive(true);
        }

        /// <summary>
        /// Method for a UI Button to go to the next page.
        /// </summary>
        public void ActivateSummaryPage()
        {
            gameManager.FeedbackPageActive = false;
            gameManager.SummaryPageActive = true;
            uiManager.uiPrefabCopyList[3].SetActive(false);
            uiManager.uiPrefabCopyList[4].SetActive(true);
        }

        //////////////////////////////////////////////// The section below are code ONLY for the Start Menu Scene UI Prefabs /////////////////////////////////////////

        ///// <summary>
        ///// Function for a UI Button to go to the Start Menu page.
        ///// </summary>
        //public void StartMenuButton()
        //{
        //    Destroy(gameObject);
        //    uiPrefabCopy = Instantiate(uiManager.UIPrefabs[0]);
        //}

        ///// <summary>
        ///// Function for a UI Button to go to the Exercises page.
        ///// </summary>
        //public void ExercisesPageButton()
        //{
        //    Destroy(gameObject);
        //    uiPrefabCopy = Instantiate(uiManager.UIPrefabs[1]);
        //}

        ///// <summary>
        ///// Function for a UI Button to go to the tutorial page.
        ///// </summary>
        //public void TutorialPageButton()
        //{
        //    Destroy(gameObject);
        //    uiPrefabCopy = Instantiate(uiManager.UIPrefabs[2]);
        //}

        ///// <summary>
        ///// Function for a UI Button to go to the About page.
        ///// </summary>
        //public void AboutPageButton()
        //{
        //    Destroy(gameObject);
        //    uiPrefabCopy = Instantiate(uiManager.UIPrefabs[3]);
        //}

        ///// <summary>
        ///// Function for a UI Button to go to the Settings page.
        ///// </summary>
        //public void SettingsPageButton()
        //{
        //    Destroy(gameObject);
        //    uiPrefabCopy = Instantiate(uiManager.UIPrefabs[4]);
        //}

        ///// <summary>
        ///// Function for a UI Button to go to the About page.
        ///// </summary>
        //public void QuitTheApplicationPage()
        //{
        //    Destroy(gameObject);
        //    uiPrefabCopy = Instantiate(uiManager.UIPrefabs[5]);
        //}

        ///// <summary>
        ///// Function for a UI Button to go to the Exercise page 1.
        ///// </summary>
        //public void ExercisePage1Button()
        //{
        //    Destroy(gameObject);
        //    uiPrefabCopy = Instantiate(uiManager.UIPrefabs[6]);
        //}

        ///// <summary>
        ///// Function for a UI Button to go to the Exercise page 2.
        ///// </summary>
        //public void ExercisePage2Button()
        //{
        //    Destroy(gameObject);
        //    uiPrefabCopy = Instantiate(uiManager.UIPrefabs[7]);
        //}

        ///// <summary>
        ///// Function for a UI Button to go to the Exercise page 3.
        ///// </summary>
        //public void ExercisePage3Button()
        //{
        //    Destroy(gameObject);
        //    uiPrefabCopy = Instantiate(uiManager.UIPrefabs[8]);
        //}



        ///// <summary>
        ///// Function for a UI Button to go to the Main Mode page.
        ///// </summary>
        //public void MainModeButton()
        //{
        //    Destroy(gameObject);
        //    uiPrefabCopy = Instantiate(uiManager.UIPrefabs[9]);
        //}
    }
}

