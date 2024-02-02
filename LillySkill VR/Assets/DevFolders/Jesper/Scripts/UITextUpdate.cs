using JespersCode;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UITextUpdate : MonoBehaviour
{
    private GameManager gameManager;
    private UIManager uiManager;
    private TMP_Text text;
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

        text = GetComponent<TMP_Text>();


    }

    private void Update()
    {
        if(!gameManager.InterviewAreActive)
            FeedbackText();

        if(gameManager.InterviewAreActive)
        {
            UpdateAnswerScreenText();
        }
    }

    private void FeedbackText()
    {
        if (gameManager.InterviewAreActive == false)
        {
            if (gameManager.PlayerScore < 3)
            {
                text.text = "* You need to work on this.\n" +
                    "* You need to work on that.\n" +
                    "* And you need to work on how.";
            }
            else if (gameManager.PlayerScore > 3 && gameManager.PlayerScore < 8)
            {
                text.text = "* You need to work on how.\n" +
                "* You need to work on this.\n" +
                "* And you need to work on that.";
            }
            else if (gameManager.PlayerScore > 8)
            {
                text.text = "* You need to work on that. \n" +
                "* You need to work on how \n" +
                "* And you need to work on this";
            }
        }
    }

    private void UpdateAnswerScreenText()
    {
        switch(gameManager.EasyMode) 
        {
            case true:
                switch(gameManager.AnswerPageNumber)
                {
                    case 1:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {
                                textList[0].text = (gameManager.AnswerPageNumber + ": This is answer one");
                            }
                            else if (AnswerTextObject[1].activeSelf == true)
                            {
                                textList[1].text = (gameManager.AnswerPageNumber + ":This is answer two");
                            }
                            else if (AnswerTextObject[2].activeSelf == true)
                            {
                                textList[2].text = (gameManager.AnswerPageNumber + ":This is answer three");
                            }
                        }
                        break;

                    case 2:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {
                                textList[0].text = (gameManager.AnswerPageNumber + ":This is answer one");
                            }
                            else if (AnswerTextObject[1].activeSelf == true)
                            {
                                textList[1].text = (gameManager.AnswerPageNumber + ":This is answer two");
                            }
                            else if (AnswerTextObject[2].activeSelf == true)
                            {
                                textList[2].text = (gameManager.AnswerPageNumber + ":This is answer three");
                            }
                        }
                        break;

                    case 3:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {
                                textList[0].text = (gameManager.AnswerPageNumber + ":This is answer one");
                            }
                            else if (AnswerTextObject[1].activeSelf == true)
                            {
                                textList[1].text = (gameManager.AnswerPageNumber + ":This is answer two");
                            }
                            else if (AnswerTextObject[2].activeSelf == true)
                            {
                                textList[2].text = (gameManager.AnswerPageNumber + ":This is answer three");
                            }
                        }
                        break;

                    case 4:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {
                                textList[0].text = (gameManager.AnswerPageNumber + ":This is answer one");
                            }
                            else if (AnswerTextObject[1].activeSelf == true)
                            {
                                textList[1].text = (gameManager.AnswerPageNumber + ":This is answer two");
                            }
                            else if (AnswerTextObject[2].activeSelf == true)
                            {
                                textList[2].text = (gameManager.AnswerPageNumber + ":This is answer three");
                            }
                        }
                        break;

                    case 5:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {
                                textList[0].text = ("This is answer one");
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

                    case 6:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {
                                textList[0].text = ("This is answer one");
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

                    case 7:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {
                                textList[0].text = ("This is answer one");
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

                    case 8:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {
                                textList[0].text = ("This is answer one");
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

                    case 9:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {
                                textList[0].text = ("This is answer one");
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

                    case 10:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {
                                textList[0].text = ("This is answer one");
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

                    case 11:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {
                                textList[0].text = ("This is answer one");
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

                    case 12:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {
                                textList[0].text = ("This is answer one");
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

                    case 13:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {
                                textList[0].text = ("This is answer one");
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

                    case 14:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {
                                textList[0].text = ("This is answer one");
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

                    case 15:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {
                                textList[0].text = ("This is answer one");
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

                    case 16:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {
                                textList[0].text = ("This is answer one");
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
                                textList[0].text = ("This is answer one");
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

                    case 18:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {
                                textList[0].text = ("This is answer one");
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

                    case 19:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {
                                textList[0].text = ("This is answer one");
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

                    case 20:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {
                                textList[0].text = ("This is answer one");
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
                }
                break;

            case false:
                Debug.LogWarning("Easy Mode isn't true! Make sure it's true in order for code to work!");
                break;
        }

    }
}
