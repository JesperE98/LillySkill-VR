using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;

namespace JespersCode
{
    public class UITextUpdate : MonoBehaviour
    {
        private GameManager gameManager;
        private UIManager uiManager;
        private TMP_Text answerText;
        private bool loopDone = false;

        [Tooltip("Generic List to store parent objects for the answertexts")]
        [SerializeField]
        private List<GameObject> AnswerTextObject = new List<GameObject>();
        [Tooltip("Generic TMP_Text List to store TMP_Text components")]
        [SerializeField]
        private List<TMP_Text> textList = new List<TMP_Text>();

        private void Start()
        {
            gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
            uiManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();

            answerText = GetComponent<TMP_Text>();
        }

        private void Update()
        {
            if (gameManager.InterviewAreActive)
            {
                UpdateAnswerScreenText();
            }

            if (gameManager.FeedbackPageActive == true)
            {
                FeedbackPageText();
            }

            if (gameManager.SummaryPageActive == true)
            {
                SummaryPageText();
            }
        }

        private void SummaryPageText()
        {
            if (loopDone == false)
            {
                for (int i = 0; i < gameManager.AnswerList.Count; i++)
                {
                    answerText.text += gameManager.AnswerList[i] + "\n";
                }
                loopDone = true;
            }
        }

        private void FeedbackPageText()
        {
            if (gameManager.InterviewAreActive == false)
            {
                if (gameManager.PlayerScore < 4)
                {
                    answerText.text = "You only got " + gameManager.PlayerScore + " points.\nWork more on this";
                }
                else if (gameManager.PlayerScore > 4 || gameManager.PlayerScore < 10)
                {
                    answerText.text = "You got " + gameManager.PlayerScore + " points.\nGood job! But you need to work more on this";
                }
                else if (gameManager.PlayerScore > 10)
                {
                    answerText.text = "You got " + gameManager.PlayerScore + " points!\nFantastic job! You will ace the interview! :D";
                }
            }
        }


        private void UpdateAnswerScreenText()
        {
            switch (gameManager.EasyMode)
            {
                case true:
                    switch (gameManager.AnswerPageNumber)
                    {
                        case 1:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer one");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer two");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer three");
                                }
                            }
                            break;

                        case 2:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer one");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer two");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer three");
                                }
                            }
                            break;

                        case 3:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer one");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer two");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer three");
                                }
                            }
                            break;

                        case 4:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer one");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer two");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer three");
                                }
                            }
                            break;

                        case 5:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer one");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer two");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer three");
                                }
                            }
                            break;

                        case 6:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer one");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer two");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer three");
                                }
                            }
                            break;

                        case 7:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer one");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer two");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer three");
                                }
                            }
                            break;

                        case 8:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer one");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer two");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer three");
                                }
                            }
                            break;

                        case 9:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer one");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer two");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer three");
                                }
                            }
                            break;

                        case 10:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer one");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer two");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer three");
                                }
                            }
                            break;

                        case 11:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer one");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer two");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer three");
                                }
                            }
                            break;

                        case 12:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer one");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer two");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer three");
                                }
                            }
                            break;

                        case 13:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer one");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer two");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer three");
                                }
                            }
                            break;

                        case 14:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer one");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer two");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer three");
                                }
                            }
                            break;

                        case 15:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer one");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer two");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer three");
                                }
                            }
                            break;

                        case 16:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer one");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("This is answer two");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("This is answer three");
                                }
                            }
                            break;

                        case 17:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer one");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer two");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer three");
                                }
                            }
                            break;

                        case 18:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer one");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer two");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer three");
                                }
                            }
                            break;

                        case 19:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer one");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer two");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer three");
                                }
                            }
                            break;

                        case 20:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer one");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer two");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Page " + gameManager.AnswerPageNumber + ": This is answer three");
                                }
                            }
                            break;
                    }
                    break;

                case false:
                    Debug.LogWarning("Easy Mode isn't true! Make sure it's true in order for code to work!");
                    break;
            }

        }
    }
}

