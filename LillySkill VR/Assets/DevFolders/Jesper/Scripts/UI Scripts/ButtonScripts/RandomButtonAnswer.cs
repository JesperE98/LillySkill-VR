using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Jesper.Collection
{
    public class RandomButtonAnswer : MonoBehaviour
    {
        private GameManager _gameManager;
        private ButtonFunctions _buttonFunctions;

        [SerializeField]
        private List<GameObject> _answerButtons = new List<GameObject>();

        void Awake()
        {
            _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
            _buttonFunctions = FindObjectOfType<ButtonFunctions>();
        }

        /// <summary>
        /// Method for Manually make the answers more "Random".
        /// </summary>
        public void ButtonRandomiser()
        {
            if(_gameManager.InterviewAreActive == true)
            {
                switch (_gameManager.AnswerPageNumber)
                {
                    case 1:
                        if (_answerButtons[0].activeInHierarchy == true) { _buttonFunctions.UsedGoodAnswerButton(); }
                        if (_answerButtons[1].activeInHierarchy == true) { _buttonFunctions.UsedBadAnswerButton(); }
                        if (_answerButtons[2].activeInHierarchy == true) { _buttonFunctions.UsedAverageAnswerButton(); }
                        break;
                    case 2:
                        if (_answerButtons[0].activeInHierarchy == true) { _buttonFunctions.UsedAverageAnswerButton(); }
                        if (_answerButtons[1].activeInHierarchy == true) { _buttonFunctions.UsedBadAnswerButton(); }
                        if (_answerButtons[2].activeInHierarchy == true) { _buttonFunctions.UsedGoodAnswerButton(); }
                        break;
                    case 3:
                        if (_answerButtons[0].activeInHierarchy == true) { _buttonFunctions.UsedAverageAnswerButton(); }
                        if (_answerButtons[1].activeInHierarchy == true) { _buttonFunctions.UsedGoodAnswerButton(); }
                        if (_answerButtons[2].activeInHierarchy == true) { _buttonFunctions.UsedBadAnswerButton(); }
                        break;
                    case 4:
                        if (_answerButtons[0].activeInHierarchy == true) { _buttonFunctions.UsedBadAnswerButton(); }
                        if (_answerButtons[1].activeInHierarchy == true) { _buttonFunctions.UsedAverageAnswerButton(); }
                        if (_answerButtons[2].activeInHierarchy == true) { _buttonFunctions.UsedGoodAnswerButton(); }
                        break;
                    case 5:
                        if (_answerButtons[0].activeInHierarchy == true) { _buttonFunctions.UsedGoodAnswerButton(); }
                        if (_answerButtons[1].activeInHierarchy == true) { _buttonFunctions.UsedAverageAnswerButton(); }
                        if (_answerButtons[2].activeInHierarchy == true) { _buttonFunctions.UsedBadAnswerButton(); }
                        break;
                    case 6:
                        if (_answerButtons[0].activeInHierarchy == true) { _buttonFunctions.UsedBadAnswerButton(); }
                        if (_answerButtons[1].activeInHierarchy == true) { _buttonFunctions.UsedGoodAnswerButton(); }
                        if (_answerButtons[2].activeInHierarchy == true) { _buttonFunctions.UsedAverageAnswerButton(); }
                        break;
                    case 7:
                        if (_answerButtons[0].activeInHierarchy == true) { _buttonFunctions.UsedBadAnswerButton(); }
                        if (_answerButtons[1].activeInHierarchy == true) { _buttonFunctions.UsedAverageAnswerButton(); }
                        if (_answerButtons[2].activeInHierarchy == true) { _buttonFunctions.UsedGoodAnswerButton(); }
                        break;
                    case 8:
                        if (_answerButtons[0].activeInHierarchy == true) { _buttonFunctions.UsedBadAnswerButton(); }
                        if (_answerButtons[1].activeInHierarchy == true) { _buttonFunctions.UsedGoodAnswerButton(); }
                        if (_answerButtons[2].activeInHierarchy == true) { _buttonFunctions.UsedAverageAnswerButton(); }
                        break;
                    case 9:
                        if (_answerButtons[0].activeInHierarchy == true) { _buttonFunctions.UsedGoodAnswerButton(); }
                        if (_answerButtons[1].activeInHierarchy == true) { _buttonFunctions.UsedAverageAnswerButton(); }
                        if (_answerButtons[2].activeInHierarchy == true) { _buttonFunctions.UsedBadAnswerButton(); }
                        break;
                    case 10:
                        if (_answerButtons[0].activeInHierarchy == true) { _buttonFunctions.UsedBadAnswerButton(); }
                        if (_answerButtons[1].activeInHierarchy == true) { _buttonFunctions.UsedGoodAnswerButton(); }
                        if (_answerButtons[2].activeInHierarchy == true) { _buttonFunctions.UsedAverageAnswerButton(); }
                        break;
                    case 11:
                        if (_answerButtons[0].activeInHierarchy == true) { _buttonFunctions.UsedGoodAnswerButton(); }
                        if (_answerButtons[1].activeInHierarchy == true) { _buttonFunctions.UsedBadAnswerButton(); }
                        if (_answerButtons[2].activeInHierarchy == true) { _buttonFunctions.UsedAverageAnswerButton(); }
                        break;
                    case 12:
                        if (_answerButtons[0].activeInHierarchy == true) { _buttonFunctions.UsedBadAnswerButton(); }
                        if (_answerButtons[1].activeInHierarchy == true) { _buttonFunctions.UsedAverageAnswerButton(); }
                        if (_answerButtons[2].activeInHierarchy == true) { _buttonFunctions.UsedGoodAnswerButton(); }
                        break;
                    case 13:
                        if (_answerButtons[0].activeInHierarchy == true) { _buttonFunctions.UsedAverageAnswerButton(); }
                        if (_answerButtons[1].activeInHierarchy == true) { _buttonFunctions.UsedBadAnswerButton(); }
                        if (_answerButtons[2].activeInHierarchy == true) { _buttonFunctions.UsedGoodAnswerButton(); }
                        break;
                    case 14:
                        if (_answerButtons[0].activeInHierarchy == true) { _buttonFunctions.UsedGoodAnswerButton(); }
                        if (_answerButtons[1].activeInHierarchy == true) { _buttonFunctions.UsedAverageAnswerButton(); }
                        if (_answerButtons[2].activeInHierarchy == true) { _buttonFunctions.UsedBadAnswerButton(); }
                        break;
                    case 15:
                        if (_answerButtons[0].activeInHierarchy == true) { _buttonFunctions.UsedBadAnswerButton(); }
                        if (_answerButtons[1].activeInHierarchy == true) { _buttonFunctions.UsedGoodAnswerButton(); }
                        if (_answerButtons[2].activeInHierarchy == true) { _buttonFunctions.UsedAverageAnswerButton(); }
                        break;
                    case 16:
                        if (_answerButtons[0].activeInHierarchy == true) { _buttonFunctions.UsedGoodAnswerButton(); }
                        if (_answerButtons[1].activeInHierarchy == true) { _buttonFunctions.UsedBadAnswerButton(); }
                        if (_answerButtons[2].activeInHierarchy == true) { _buttonFunctions.UsedAverageAnswerButton(); }
                        break;
                    case 17:
                        if (_answerButtons[0].activeInHierarchy == true) { _buttonFunctions.UsedGoodAnswerButton(); }
                        if (_answerButtons[1].activeInHierarchy == true) { _buttonFunctions.UsedAverageAnswerButton(); }
                        if (_answerButtons[2].activeInHierarchy == true) { _buttonFunctions.UsedBadAnswerButton(); }
                        break;
                    case 18:
                        if (_answerButtons[0].activeInHierarchy == true) { _buttonFunctions.UsedGoodAnswerButton(); }
                        if (_answerButtons[1].activeInHierarchy == true) { _buttonFunctions.UsedAverageAnswerButton(); }
                        if (_answerButtons[2].activeInHierarchy == true) { _buttonFunctions.UsedBadAnswerButton(); }
                        break;
                    case 19:
                        if (_answerButtons[0].activeInHierarchy == true) { _buttonFunctions.UsedBadAnswerButton(); }
                        if (_answerButtons[1].activeInHierarchy == true) { _buttonFunctions.UsedGoodAnswerButton(); }
                        if (_answerButtons[2].activeInHierarchy == true) { _buttonFunctions.UsedAverageAnswerButton(); }
                        break;
                    case 20:
                        if (_answerButtons[0].activeInHierarchy == true) { _buttonFunctions.UsedBadAnswerButton(); }
                        if (_answerButtons[1].activeInHierarchy == true) { _buttonFunctions.UsedAverageAnswerButton(); }
                        if (_answerButtons[2].activeInHierarchy == true) { _buttonFunctions.UsedGoodAnswerButton(); }
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

