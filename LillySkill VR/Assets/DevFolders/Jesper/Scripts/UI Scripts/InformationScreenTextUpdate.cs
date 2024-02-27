using JespersCode;
using JesperScriptableObject;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace JespersCode
{
    public class InformationScerenTextUpdate : MonoBehaviour
    {
        private GameManager gameManager;
        private TMP_Text informationPageText;
        [SerializeField]
        private InterviewQuestionsListScriptableObject m_InterviewQuestionsListScriptableObject;
        [SerializeField]
        private GameSettingsScriptableObject m_GameSettingsScriptableObject;

        void Start()
        {
            gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

            informationPageText = GetComponent<TMP_Text>();
        }

        void Update()
        {
            if (gameManager.InterviewAreActive == true) { UpdateInformationScreenText(); }
        }

        private void UpdateInformationScreenText()
        {
            switch (m_GameSettingsScriptableObject.DefaultMode)
            {
                case true:
                    switch (gameManager.AnswerPageNumber)
                    {
                        case 0:
                            informationPageText.text = m_InterviewQuestionsListScriptableObject.m_QuestionList[0];
                            break;

                        case 1:
                            informationPageText.text = m_InterviewQuestionsListScriptableObject.m_QuestionList[1];
                            break;

                        case 2:
                            informationPageText.text = m_InterviewQuestionsListScriptableObject.m_QuestionList[2];
                            break;

                        case 3:
                            informationPageText.text = m_InterviewQuestionsListScriptableObject.m_QuestionList[3];
                            break;

                        case 4:
                            informationPageText.text = m_InterviewQuestionsListScriptableObject.m_QuestionList[4];
                            break;

                        case 5:
                            informationPageText.text = m_InterviewQuestionsListScriptableObject.m_QuestionList[5];
                            break;

                        case 6:
                            informationPageText.text = m_InterviewQuestionsListScriptableObject.m_QuestionList[6];
                            break;

                        case 7:
                            informationPageText.text = m_InterviewQuestionsListScriptableObject.m_QuestionList[7];
                            break;

                        case 8:
                            informationPageText.text = m_InterviewQuestionsListScriptableObject.m_QuestionList[8];
                            break;

                        case 9:
                            informationPageText.text = m_InterviewQuestionsListScriptableObject.m_QuestionList[9];
                            break;

                        case 10:
                            informationPageText.text = m_InterviewQuestionsListScriptableObject.m_QuestionList[10];
                            break;

                        case 11:
                            informationPageText.text = m_InterviewQuestionsListScriptableObject.m_QuestionList[11];
                            break;

                        case 12:
                            informationPageText.text = m_InterviewQuestionsListScriptableObject.m_QuestionList[12];
                            break;

                        case 13:
                            informationPageText.text = m_InterviewQuestionsListScriptableObject.m_QuestionList[13];
                            break;

                        case 14:
                            informationPageText.text = m_InterviewQuestionsListScriptableObject.m_QuestionList[14];
                            break;

                        case 15:
                            informationPageText.text = m_InterviewQuestionsListScriptableObject.m_QuestionList[15];
                            break;

                        case 16:
                            informationPageText.text = m_InterviewQuestionsListScriptableObject.m_QuestionList[16];
                            break;

                        case 17:
                            informationPageText.text = m_InterviewQuestionsListScriptableObject.m_QuestionList[17];
                            break;

                        case 18:
                            informationPageText.text = m_InterviewQuestionsListScriptableObject.m_QuestionList[18];
                            break;

                        case 19:
                            informationPageText.text = m_InterviewQuestionsListScriptableObject.m_QuestionList[19];
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

