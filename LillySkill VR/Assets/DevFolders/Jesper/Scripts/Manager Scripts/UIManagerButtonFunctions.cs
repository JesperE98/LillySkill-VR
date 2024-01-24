using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JespersCode
{
    public class UIManagerButtonFunctions : MonoBehaviour
    {
        private UIManager _uiManager;
        private GameManager _gameManager;
        private Animator _animator;

        private GameObject uiPrefabCopy;


        void Awake()
        {
            _uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
            _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            _animator = GameObject.FindGameObjectWithTag("NPC").GetComponent<Animator>();
        }

        /// <summary>
        /// Function for the Worst Answer Button alternative on the AnswerUIButton.
        /// </summary>
        public void UsedWorstAnswerButton()
        {
            _animator.SetBool("AskingQuestion", true);
            _gameManager.UsedWorstAnswer = true;
            _uiManager.UIButtonPressed();
        }

        /// <summary>
        /// Function for the Bad Answer Button alternative on the AnswerUIButton.
        /// </summary>
        public void UsedBadAnswerButton()
        {
            _animator.SetBool("AskingQuestion", true);
            _gameManager.UsedBadAnswer = true;
            _uiManager.UIButtonPressed();
        }

        /// <summary>
        /// Function for the Average Answer Button alternative on the AnswerUIButton.
        /// </summary>
        public void UsedAverageAnswerButton()
        {
            _animator.SetBool("AskingQuestion", true);
            _gameManager.UsedAverageAnswer = true;
            _uiManager.UIButtonPressed();
        }

        /// <summary>
        /// Function for the Good Answer Button alternative on the AnswerUIButton.
        /// </summary>
        public void UsedGoodAnswerButton()
        {
            _animator.SetBool("AskingQuestion", true);
            _gameManager.UsedGoodAnswer = true;
            _uiManager.UIButtonPressed();
        }

        /// <summary>
        /// Function for the Best Answer Button alternative on the AnswerUIButton.
        /// </summary>
        public void UsedBestAnswerButton()
        {
            _animator.SetBool("AskingQuestion", true);
            _gameManager.UsedBestAnswer = true;
            _uiManager.UIButtonPressed();
        }



        /// <summary>
        /// Function for a UI Button to go to the next page.
        /// </summary>
        public void NextPageButton()
        {
            gameObject.SetActive(false);

            uiPrefabCopy = Instantiate(_uiManager.UIPrefabs[1]);
        }

        //////////////////////////////////////////////// The section below are code ONLY for the Start Menu Scene UI Prefabs /////////////////////////////////////////

        /// <summary>
        /// Function for a UI Button to go to the Start Menu page.
        /// </summary>
        public void StartMenuButton()
        {
            Destroy(gameObject);
            uiPrefabCopy = Instantiate(_uiManager.UIPrefabs[0]);
        }

        /// <summary>
        /// Function for a UI Button to go to the Exercises page.
        /// </summary>
        public void ExercisesPageButton()
        {
            Destroy(gameObject);
            uiPrefabCopy = Instantiate(_uiManager.UIPrefabs[1]);
        }

        /// <summary>
        /// Function for a UI Button to go to the tutorial page.
        /// </summary>
        public void TutorialPageButton()
        {
            Destroy(gameObject);
            uiPrefabCopy = Instantiate(_uiManager.UIPrefabs[2]);
        }

        /// <summary>
        /// Function for a UI Button to go to the About page.
        /// </summary>
        public void AboutPageButton()
        {
            Destroy(gameObject);
            uiPrefabCopy = Instantiate(_uiManager.UIPrefabs[3]);
        }

        /// <summary>
        /// Function for a UI Button to go to the Settings page.
        /// </summary>
        public void SettingsPageButton()
        {
            Destroy(gameObject);
            uiPrefabCopy = Instantiate(_uiManager.UIPrefabs[4]);
        }

        /// <summary>
        /// Function for a UI Button to go to the About page.
        /// </summary>
        public void QuitTheApplicationPage()
        {
            Destroy(gameObject);
            uiPrefabCopy = Instantiate(_uiManager.UIPrefabs[5]);
        }

        /// <summary>
        /// Function for a UI Button to go to the Exercise page 1.
        /// </summary>
        public void ExercisePage1Button()
        {
            Destroy(gameObject);
            uiPrefabCopy = Instantiate(_uiManager.UIPrefabs[6]);
        }

        /// <summary>
        /// Function for a UI Button to go to the Exercise page 2.
        /// </summary>
        public void ExercisePage2Button()
        {
            Destroy(gameObject);
            uiPrefabCopy = Instantiate(_uiManager.UIPrefabs[7]);
        }

        /// <summary>
        /// Function for a UI Button to go to the Exercise page 3.
        /// </summary>
        public void ExercisePage3Button()
        {
            Destroy(gameObject);
            uiPrefabCopy = Instantiate(_uiManager.UIPrefabs[8]);
        }



        /// <summary>
        /// Function for a UI Button to go to the Main Mode page.
        /// </summary>
        public void MainModeButton()
        {
            Destroy(gameObject);
            uiPrefabCopy = Instantiate(_uiManager.UIPrefabs[9]);
        }
    }
}

