using JespersCode;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace JespersCode
{
    public class RandomButtonAnswer : MonoBehaviour
    {
        private GameManager gameManager;
        private UIManagerButtonFunctions uiManagerButtonFunctions;

        [SerializeField]
        private List<GameObject> answerButtons = new List<GameObject>();

        void Awake()
        {
            gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
            uiManagerButtonFunctions = FindObjectOfType<UIManagerButtonFunctions>();
        }

        /// <summary>
        /// Method for Manually make the answers more "Random".
        /// </summary>
        public void ButtonRandomiser()
        {
            if(gameManager.InterviewAreActive == true)
            {
                switch (gameManager.AnswerPageNumber)
                {
                    case 0:
                        if (answerButtons[0].activeInHierarchy == true) { uiManagerButtonFunctions.UsedGoodAnswerButton(); }
                        if (answerButtons[1].activeInHierarchy == true) { uiManagerButtonFunctions.UsedBadAnswerButton(); }
                        if (answerButtons[2].activeInHierarchy == true) { uiManagerButtonFunctions.UsedAverageAnswerButton(); }
                        break;
                    case 1:
                        if (answerButtons[0].activeInHierarchy == true) { uiManagerButtonFunctions.UsedAverageAnswerButton(); }
                        if (answerButtons[1].activeInHierarchy == true) { uiManagerButtonFunctions.UsedBadAnswerButton(); }
                        if (answerButtons[2].activeInHierarchy == true) { uiManagerButtonFunctions.UsedGoodAnswerButton(); }
                        break;
                    case 2:
                        if (answerButtons[0].activeInHierarchy == true) { uiManagerButtonFunctions.UsedAverageAnswerButton(); }
                        if (answerButtons[1].activeInHierarchy == true) { uiManagerButtonFunctions.UsedGoodAnswerButton(); }
                        if (answerButtons[2].activeInHierarchy == true) { uiManagerButtonFunctions.UsedBadAnswerButton(); }
                        break;
                    case 3:
                        if (answerButtons[0].activeInHierarchy == true) { uiManagerButtonFunctions.UsedBadAnswerButton(); }
                        if (answerButtons[1].activeInHierarchy == true) { uiManagerButtonFunctions.UsedAverageAnswerButton(); }
                        if (answerButtons[2].activeInHierarchy == true) { uiManagerButtonFunctions.UsedGoodAnswerButton(); }
                        break;
                    case 4:
                        if (answerButtons[0].activeInHierarchy == true) { uiManagerButtonFunctions.UsedGoodAnswerButton(); }
                        if (answerButtons[1].activeInHierarchy == true) { uiManagerButtonFunctions.UsedAverageAnswerButton(); }
                        if (answerButtons[2].activeInHierarchy == true) { uiManagerButtonFunctions.UsedBadAnswerButton(); }
                        break;
                    case 5:
                        if (answerButtons[0].activeInHierarchy == true) { uiManagerButtonFunctions.UsedBadAnswerButton(); }
                        if (answerButtons[1].activeInHierarchy == true) { uiManagerButtonFunctions.UsedGoodAnswerButton(); }
                        if (answerButtons[2].activeInHierarchy == true) { uiManagerButtonFunctions.UsedAverageAnswerButton(); }
                        break;
                    case 6:
                        if (answerButtons[0].activeInHierarchy == true) { uiManagerButtonFunctions.UsedBadAnswerButton(); }
                        if (answerButtons[1].activeInHierarchy == true) { uiManagerButtonFunctions.UsedAverageAnswerButton(); }
                        if (answerButtons[2].activeInHierarchy == true) { uiManagerButtonFunctions.UsedGoodAnswerButton(); }
                        break;
                    case 7:
                        if (answerButtons[0].activeInHierarchy == true) { uiManagerButtonFunctions.UsedBadAnswerButton(); }
                        if (answerButtons[1].activeInHierarchy == true) { uiManagerButtonFunctions.UsedGoodAnswerButton(); }
                        if (answerButtons[2].activeInHierarchy == true) { uiManagerButtonFunctions.UsedAverageAnswerButton(); }
                        break;
                    case 8:
                        if (answerButtons[0].activeInHierarchy == true) { uiManagerButtonFunctions.UsedGoodAnswerButton(); }
                        if (answerButtons[1].activeInHierarchy == true) { uiManagerButtonFunctions.UsedAverageAnswerButton(); }
                        if (answerButtons[2].activeInHierarchy == true) { uiManagerButtonFunctions.UsedBadAnswerButton(); }
                        break;
                    case 9:
                        if (answerButtons[0].activeInHierarchy == true) { uiManagerButtonFunctions.UsedBadAnswerButton(); }
                        if (answerButtons[1].activeInHierarchy == true) { uiManagerButtonFunctions.UsedGoodAnswerButton(); }
                        if (answerButtons[2].activeInHierarchy == true) { uiManagerButtonFunctions.UsedAverageAnswerButton(); }
                        break;
                    case 10:
                        if (answerButtons[0].activeInHierarchy == true) { uiManagerButtonFunctions.UsedGoodAnswerButton(); }
                        if (answerButtons[1].activeInHierarchy == true) { uiManagerButtonFunctions.UsedBadAnswerButton(); }
                        if (answerButtons[2].activeInHierarchy == true) { uiManagerButtonFunctions.UsedAverageAnswerButton(); }
                        break;
                    case 11:
                        if (answerButtons[0].activeInHierarchy == true) { uiManagerButtonFunctions.UsedBadAnswerButton(); }
                        if (answerButtons[1].activeInHierarchy == true) { uiManagerButtonFunctions.UsedAverageAnswerButton(); }
                        if (answerButtons[2].activeInHierarchy == true) { uiManagerButtonFunctions.UsedGoodAnswerButton(); }
                        break;
                    case 12:
                        if (answerButtons[0].activeInHierarchy == true) { uiManagerButtonFunctions.UsedAverageAnswerButton(); }
                        if (answerButtons[1].activeInHierarchy == true) { uiManagerButtonFunctions.UsedBadAnswerButton(); }
                        if (answerButtons[2].activeInHierarchy == true) { uiManagerButtonFunctions.UsedGoodAnswerButton(); }
                        break;
                    case 13:
                        if (answerButtons[0].activeInHierarchy == true) { uiManagerButtonFunctions.UsedGoodAnswerButton(); }
                        if (answerButtons[1].activeInHierarchy == true) { uiManagerButtonFunctions.UsedAverageAnswerButton(); }
                        if (answerButtons[2].activeInHierarchy == true) { uiManagerButtonFunctions.UsedBadAnswerButton(); }
                        break;
                    case 14:
                        if (answerButtons[0].activeInHierarchy == true) { uiManagerButtonFunctions.UsedBadAnswerButton(); }
                        if (answerButtons[1].activeInHierarchy == true) { uiManagerButtonFunctions.UsedGoodAnswerButton(); }
                        if (answerButtons[2].activeInHierarchy == true) { uiManagerButtonFunctions.UsedAverageAnswerButton(); }
                        break;
                    case 15:
                        if (answerButtons[0].activeInHierarchy == true) { uiManagerButtonFunctions.UsedGoodAnswerButton(); }
                        if (answerButtons[1].activeInHierarchy == true) { uiManagerButtonFunctions.UsedBadAnswerButton(); }
                        if (answerButtons[2].activeInHierarchy == true) { uiManagerButtonFunctions.UsedAverageAnswerButton(); }
                        break;
                    case 16:
                        if (answerButtons[0].activeInHierarchy == true) { uiManagerButtonFunctions.UsedGoodAnswerButton(); }
                        if (answerButtons[1].activeInHierarchy == true) { uiManagerButtonFunctions.UsedAverageAnswerButton(); }
                        if (answerButtons[2].activeInHierarchy == true) { uiManagerButtonFunctions.UsedBadAnswerButton(); }
                        break;
                    case 17:
                        if (answerButtons[0].activeInHierarchy == true) { uiManagerButtonFunctions.UsedGoodAnswerButton(); }
                        if (answerButtons[1].activeInHierarchy == true) { uiManagerButtonFunctions.UsedAverageAnswerButton(); }
                        if (answerButtons[2].activeInHierarchy == true) { uiManagerButtonFunctions.UsedBadAnswerButton(); }
                        break;
                    case 18:
                        if (answerButtons[0].activeInHierarchy == true) { uiManagerButtonFunctions.UsedBadAnswerButton(); }
                        if (answerButtons[1].activeInHierarchy == true) { uiManagerButtonFunctions.UsedGoodAnswerButton(); }
                        if (answerButtons[2].activeInHierarchy == true) { uiManagerButtonFunctions.UsedAverageAnswerButton(); }
                        break;
                    case 19:
                        if (answerButtons[0].activeInHierarchy == true) { uiManagerButtonFunctions.UsedBadAnswerButton(); }
                        if (answerButtons[1].activeInHierarchy == true) { uiManagerButtonFunctions.UsedAverageAnswerButton(); }
                        if (answerButtons[2].activeInHierarchy == true) { uiManagerButtonFunctions.UsedGoodAnswerButton(); }
                        break;
                }
            }
            else
            {
                Debug.LogWarning("Interview Are Active are false!");
            }
            
        }

    }
}

