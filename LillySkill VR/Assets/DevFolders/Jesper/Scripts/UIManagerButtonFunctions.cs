using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JespersCode
{
    public class UIManagerButtonFunctions : MonoBehaviour
    {
        private UIManager uiManager;
        private GameManager gameManager;

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
    }
}

