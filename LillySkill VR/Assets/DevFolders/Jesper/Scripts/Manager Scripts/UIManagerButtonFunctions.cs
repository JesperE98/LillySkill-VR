using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JespersCode
{
    public class UIManagerButtonFunctions : MonoBehaviour
    {
        private UIManager uiManager;
        private GameManager gameManager;
        private Animator animator;

        private GameObject uiPrefabCopy;


        void Awake()
        {
            uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            animator = GameObject.FindGameObjectWithTag("NPC").GetComponent<Animator>();
        }

        /// <summary>
        /// Function for the Worst Answer Button alternative on the AnswerUIButton.
        /// </summary>
        public void UsedWorstAnswerButton()
        {
            animator.SetBool("AskingQuestion", true);
            gameManager.UsedWorstAnswer = true;
            uiManager.UIButtonPressed();
        }

        /// <summary>
        /// Function for the Bad Answer Button alternative on the AnswerUIButton.
        /// </summary>
        public void UsedBadAnswerButton()
        {
            animator.SetBool("AskingQuestion", true);
            gameManager.UsedBadAnswer = true;
            gameManager.AddAnswerToList("Fr�ga " + gameManager.AnswerPageNumber + ": D�ligt svar.");
            uiManager.UIButtonPressed();
        }

        /// <summary>
        /// Function for the Average Answer Button alternative on the AnswerUIButton.
        /// </summary>
        public void UsedAverageAnswerButton()
        {
            animator.SetBool("AskingQuestion", true);
            gameManager.UsedAverageAnswer = true;
            gameManager.AddAnswerToList("Fr�ga " + gameManager.AnswerPageNumber + ": Helt ok svar.");
            uiManager.UIButtonPressed();
        }

        /// <summary>
        /// Function for the Good Answer Button alternative on the AnswerUIButton.
        /// </summary>
        public void UsedGoodAnswerButton()
        {
            animator.SetBool("AskingQuestion", true);
            gameManager.UsedGoodAnswer = true;
            uiManager.UIButtonPressed();
        }

        /// <summary>
        /// Function for the Best Answer Button alternative on the AnswerUIButton.
        /// </summary>
        public void UsedBestAnswerButton()
        {
            animator.SetBool("AskingQuestion", true);
            gameManager.UsedBestAnswer = true;
            uiManager.UIButtonPressed();
        }



        /// <summary>
        /// Function for a UI Button to go to the next page.
        /// </summary>
        public void NextPageButton()
        {
            gameObject.SetActive(false);
            gameManager.FeedbackPageActive = false;
            gameManager.SummaryPageActive = true;
            uiManager.uiPrefabCopyList[2].SetActive(true);
        }

        //////////////////////////////////////////////// The section below are code ONLY for the Start Menu Scene UI Prefabs /////////////////////////////////////////

        /// <summary>
        /// Function for a UI Button to go to the Start Menu page.
        /// </summary>
        public void StartMenuButton()
        {
            Destroy(gameObject);
            uiPrefabCopy = Instantiate(uiManager.UIPrefabs[0]);
        }

        /// <summary>
        /// Function for a UI Button to go to the Exercises page.
        /// </summary>
        public void ExercisesPageButton()
        {
            Destroy(gameObject);
            uiPrefabCopy = Instantiate(uiManager.UIPrefabs[1]);
        }

        /// <summary>
        /// Function for a UI Button to go to the tutorial page.
        /// </summary>
        public void TutorialPageButton()
        {
            Destroy(gameObject);
            uiPrefabCopy = Instantiate(uiManager.UIPrefabs[2]);
        }

        /// <summary>
        /// Function for a UI Button to go to the About page.
        /// </summary>
        public void AboutPageButton()
        {
            Destroy(gameObject);
            uiPrefabCopy = Instantiate(uiManager.UIPrefabs[3]);
        }

        /// <summary>
        /// Function for a UI Button to go to the Settings page.
        /// </summary>
        public void SettingsPageButton()
        {
            Destroy(gameObject);
            uiPrefabCopy = Instantiate(uiManager.UIPrefabs[4]);
        }

        /// <summary>
        /// Function for a UI Button to go to the About page.
        /// </summary>
        public void QuitTheApplicationPage()
        {
            Destroy(gameObject);
            uiPrefabCopy = Instantiate(uiManager.UIPrefabs[5]);
        }

        /// <summary>
        /// Function for a UI Button to go to the Exercise page 1.
        /// </summary>
        public void ExercisePage1Button()
        {
            Destroy(gameObject);
            uiPrefabCopy = Instantiate(uiManager.UIPrefabs[6]);
        }

        /// <summary>
        /// Function for a UI Button to go to the Exercise page 2.
        /// </summary>
        public void ExercisePage2Button()
        {
            Destroy(gameObject);
            uiPrefabCopy = Instantiate(uiManager.UIPrefabs[7]);
        }

        /// <summary>
        /// Function for a UI Button to go to the Exercise page 3.
        /// </summary>
        public void ExercisePage3Button()
        {
            Destroy(gameObject);
            uiPrefabCopy = Instantiate(uiManager.UIPrefabs[8]);
        }



        /// <summary>
        /// Function for a UI Button to go to the Main Mode page.
        /// </summary>
        public void MainModeButton()
        {
            Destroy(gameObject);
            uiPrefabCopy = Instantiate(uiManager.UIPrefabs[9]);
        }
    }
}

