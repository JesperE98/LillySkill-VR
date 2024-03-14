using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jesper.GameSettings.Data;

namespace Jesper.Collection
{
    public class ButtonFunctions : MonoBehaviour
    {
        private UIManager _uiManager;
        private GameManager _gameManager;
        private AudioManager _audioManager;

        [SerializeField]
        private GameSettingsScriptableObject _gameSettings;


        void Start()
        {
            if (_gameSettings.LoadedScene != "Main Menu")
            {
                _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
                _uiManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
            }

            _audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
        }

        /// <summary>
        /// Method for the Worst Answer Button alternative on the AnswerUIButton.
        /// </summary>
        //public void UsedWorstAnswerButton()
        //{
        //    gameManager.InterviewerInterest -= 1;
        //    gameManager.PlayerScore += 0;
        //    uiManager.StartUIDeactivation();

        //    if (gameManager.AnswerPageNumber <= 10)
        //    {
        //       audioManager.StartAudioCoroutine();
        //    }
        //    else { return; }
        //}

        /// <summary>
        /// Method for the Bad Answer Button alternative on the AnswerUIButton.
        /// </summary>
        public void UsedBadAnswerButton()
        {
            _gameManager.AddAnswerToList("Fråga " + _gameManager.AnswerPageNumber + ": Dåligt svar.");
            _gameManager.InterviewerInterest -= 1;
            _gameManager.PlayerScore += 0;
            _uiManager.StartUIDeactivation();

            if (_gameManager.AnswerPageNumber <= 10)
            {
              _audioManager.StartAudioCoroutine();
            }
            else { return; }
        }

        /// <summary>
        /// Method for the Average Answer Button alternative on the AnswerUIButton.
        /// </summary>
        public void UsedAverageAnswerButton()
        {
            _gameManager.AddAnswerToList("Fråga " + _gameManager.AnswerPageNumber + ": Helt ok svar.");
            _gameManager.InterviewerInterest += 0;
            _gameManager.PlayerScore += 1;
            _uiManager.StartUIDeactivation();

            if(_gameManager.AnswerPageNumber <= 10)
            {
                _audioManager.StartAudioCoroutine();
            }
            else { return; }
        }

        /// <summary>
        /// Method for the Good Answer Button alternative on the AnswerUIButton.
        /// </summary>
        public void UsedGoodAnswerButton()
        {
            _gameManager.AddAnswerToList("Fråga " + _gameManager.AnswerPageNumber + ": Bra svar.");
            _gameManager.InterviewerInterest += 1;
            _gameManager.PlayerScore += 2;
            _uiManager.StartUIDeactivation();

            if (_gameManager.AnswerPageNumber <= 10)
            {
                _audioManager.StartAudioCoroutine();
            }
            else { return; }
        }

        /// <summary>
        /// Method for the Best Answer Button alternative on the AnswerUIButton.
        /// </summary>
        //public void UsedBestAnswerButton()
        //{
        //    gameManager.InterviewerInterest += 1;
        //    gameManager.PlayerScore += 3;
        //    uiManager.StartUIDeactivation();

        //    if (gameManager.AnswerPageNumber <= 10)
        //    {
        //        audioManager.StartAudioCoroutine();
        //    }
        //    else { return; }
        //}



        /// <summary>
        /// Method for activating the Feedback UI Page.
        /// </summary>
        public void ActivateFeedbackPage()
        {
            _uiManager.uiPrefabCopyList[3].SetActive(true);
        }

        /// <summary>
        /// Method for a UI Button to go to the next page.
        /// </summary>
        public void ActivateSummaryPage()
        {
            gameObject.SetActive(false);
            _uiManager.uiPrefabCopyList[4].SetActive(true);
        }

        //////////////////////////////////////////////// The section below are code ONLY for the Start Menu Scene UI Prefabs /////////////////////////////////////////
        //////////////////////////////////////////////// Saving code in case of future usage ////////////////////////////////////////////////////
        ///// <summary>
        ///// Deactivates current page and activates Start Menu page.
        ///// </summary>
        //public void StartMenuButton()
        //{
        //    gameObject.SetActive(false);
        //    _uiManager.uiPrefabCopyList[0].SetActive(true);
        //}

        ///// <summary>
        ///// Deactivates current page and activates Exercises page.
        ///// </summary>
        //public void ExercisesPageButton()
        //{
        //    gameObject.SetActive(false);
        //    _uiManager.uiPrefabCopyList[1].SetActive(true);
        //}

        ///// <summary>
        ///// Deactivates current page and activates Tutorial page.
        ///// </summary>
        //public void TutorialPageButton()
        //{
        //    gameObject.SetActive(false);
        //    _uiManager.uiPrefabCopyList[2].SetActive(true);
        //}

        ///// <summary>
        ///// Deactivates current page and activates About page.
        ///// </summary>
        //public void AboutPageButton()
        //{
        //    gameObject.SetActive(false);
        //    _uiManager.uiPrefabCopyList[3].SetActive(true);
        //}

        ///// <summary>
        ///// Deactivates current page and activates Settings page.
        ///// </summary>
        //public void SettingsPageButton()
        //{
        //    gameObject.SetActive(false);
        //    _uiManager.uiPrefabCopyList[4].SetActive(true);
        //}

        ///// <summary>
        ///// Deactivates current page and activates Main Mode page.
        ///// </summary>
        //public void MainModeButton()
        //{
        //    gameObject.SetActive(false);
        //    _uiManager.uiPrefabCopyList[5].SetActive(true);
        //}

        ///// <summary>
        ///// Deactivates current page and activates About page.
        ///// </summary>
        //public void QuitTheApplicationPage()
        //{
        //    gameObject.SetActive(false);
        //    _uiManager.uiPrefabCopyList[6].SetActive(true);
        //}

        ///// <summary>
        ///// Quits the application.
        ///// </summary>
        //public void QuitApplication()
        //{
        //    Application.Quit();
        //}
    }
}

