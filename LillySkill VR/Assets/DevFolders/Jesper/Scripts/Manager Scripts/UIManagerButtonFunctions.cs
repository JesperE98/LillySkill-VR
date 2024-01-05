using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JespersCode
{
    public class UIManagerButtonFunctions : MonoBehaviour
    {
        protected UIManager uiManager;
        protected GameManager gameManager;


        void Awake()
        {
            uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        }

        /// <summary>
        /// Function for the Worst Answer Button alternative on the AnswerUIButton.
        /// </summary>
        public void UsedWorstAnswerButton()
        {
            Debug.Log("Hi Worst Asnwer");
            gameManager.UsedWorstAnswer = true;
            uiManager.UIButtonPressed();
        }

        /// <summary>
        /// Function for the Bad Answer Button alternative on the AnswerUIButton.
        /// </summary>
        public void UsedBadAnswerButton()
        {
            Debug.Log("Hi Bad Asnwer");

            gameManager.UsedBadAnswer = true;
            uiManager.UIButtonPressed();
        }

        /// <summary>
        /// Function for the Average Answer Button alternative on the AnswerUIButton.
        /// </summary>
        public void UsedAverageAnswerButton()
        {
            Debug.Log("Hi Average Asnwer");
            gameManager.UsedAverageAnswer = true;
            uiManager.UIButtonPressed();
        }

        /// <summary>
        /// Function for the Good Answer Button alternative on the AnswerUIButton.
        /// </summary>
        public void UsedGoodAnswerButton()
        {
            Debug.Log("Hi Good Asnwer");
            gameManager.UsedGoodAnswer = true;
            uiManager.UIButtonPressed();
        }

        /// <summary>
        /// Function for the Best Answer Button alternative on the AnswerUIButton.
        /// </summary>
        public void UsedBestAnswerButton()
        {
            Debug.Log("Hi Best Asnwer");
            gameManager.UsedBestAnswer = true;
            uiManager.UIButtonPressed();
        }



        /// <summary>
        /// Function for a UI Button to go to the next page.
        /// </summary>
        public void NextPageButton()
        {
            Destroy(gameObject);

            GameObject newUIPrefabCopy = Instantiate(uiManager.UIPrefabs[2]);
        }

        //////////////////////////////////////////////// The section below are code ONLY for the Start Menu Scene UI Prefabs /////////////////////////////////////////

        /// <summary>
        /// Function for a UI Button to go to the Start Menu page.
        /// </summary>
        public void StartMenuButton()
        {
            Destroy(gameObject);

            GameObject newUIPrefabCopy = Instantiate(uiManager.UIPrefabs[0]);
        }

        /// <summary>
        /// Function for a UI Button to go to the Exercises page.
        /// </summary>
        public void ExercisesPageButton()
        {
            Destroy(gameObject);

            GameObject newUIPrefabCopy = Instantiate(uiManager.UIPrefabs[1]);
        }

        /// <summary>
        /// Function for a UI Button to go to the tutorial page.
        /// </summary>
        public void TutorialPageButton()
        {
            Destroy(gameObject);

            GameObject newUIPrefabCopy = Instantiate(uiManager.UIPrefabs[2]);
        }

        /// <summary>
        /// Function for a UI Button to go to the About page.
        /// </summary>
        public void AboutPageButton()
        {
            Destroy(gameObject);

            GameObject newUIPrefabCopy = Instantiate(uiManager.UIPrefabs[3]);
        }

        /// <summary>
        /// Function for a UI Button to go to the Settings page.
        /// </summary>
        public void SettingsPageButton()
        {
            Destroy(gameObject);

            GameObject newUIPrefabCopy = Instantiate(uiManager.UIPrefabs[4]);
        }

        /// <summary>
        /// Function for a UI Button to go to the About page.
        /// </summary>
        public void QuitTheApplicationPage()
        {
            Destroy(gameObject);

            GameObject newUIPrefabCopy = Instantiate(uiManager.UIPrefabs[5]);
        }

        /// <summary>
        /// Function for a UI Button to go to the Exercise page 1.
        /// </summary>
        public void ExercisePage1Button()
        {
            Destroy(gameObject);

            GameObject newUIPrefabCopy = Instantiate(uiManager.UIPrefabs[6]);
        }

        /// <summary>
        /// Function for a UI Button to go to the Exercise page 2.
        /// </summary>
        public void ExercisePage2Button()
        {
            Destroy(gameObject);

            GameObject newUIPrefabCopy = Instantiate(uiManager.UIPrefabs[7]);
        }

        /// <summary>
        /// Function for a UI Button to go to the Exercise page 3.
        /// </summary>
        public void ExercisePage3Button()
        {
            Destroy(gameObject);

            GameObject newUIPrefabCopy = Instantiate(uiManager.UIPrefabs[8]);
        }



        /// <summary>
        /// Function for a UI Button to go to the Main Mode page.
        /// </summary>
        public void MainModeButton()
        {
            Destroy(gameObject);

            GameObject newUIPrefabCopy = Instantiate(uiManager.UIPrefabs[9]);
        }
    }
}

