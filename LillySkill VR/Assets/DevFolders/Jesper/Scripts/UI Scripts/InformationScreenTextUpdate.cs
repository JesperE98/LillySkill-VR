using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Jesper.InterviewQuestionsList.Data;
using Jesper.GameSettings.Data;


namespace Jesper.Collection
{
    public class InformationScerenTextUpdate : MonoBehaviour
    {
        private GameManager gameManager;
        private TMP_Text informationPageText;
        [SerializeField]
        private InterviewQuestionsListScriptableObject _interviewQuestionsList;
        [SerializeField]
        private GameSettingsScriptableObject _gameSettings;

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
            //switch (_gameSettings.DefaultMode)
            //{
            //    case true:
            //        switch (gameManager.AnswerPageNumber)
            //        {
            //            case 1:
            //                informationPageText.text = _interviewQuestionsList._questionCategories[0].m_QuestionList[0];
            //                break;

            //            case 2:
            //                informationPageText.text = _interviewQuestionsList._questionCategories[0].m_QuestionList[1];
            //                break;

            //            case 3:
            //                informationPageText.text = _interviewQuestionsList._questionCategories[0].m_QuestionList[2];
            //                break;

            //            case 4:
            //                informationPageText.text = _interviewQuestionsList._questionCategories[0].m_QuestionList[3];
            //                break;

            //            case 5:
            //                informationPageText.text = _interviewQuestionsList._questionCategories[0].m_QuestionList[4];
            //                break;

            //            case 6:
            //                informationPageText.text = _interviewQuestionsList._questionCategories[0].m_QuestionList[5];
            //                break;

            //            case 7:
            //                informationPageText.text = _interviewQuestionsList._questionCategories[0].m_QuestionList[6];
            //                break;

            //            case 8:
            //                informationPageText.text = _interviewQuestionsList._questionCategories[0].m_QuestionList[7];
            //                break;

            //            case 9:
            //                informationPageText.text = _interviewQuestionsList._questionCategories[0].m_QuestionList[8];
            //                break;

            //            case 10:
            //                informationPageText.text = _interviewQuestionsList._questionCategories[0].m_QuestionList[9];
            //                break;

            //            case 11:
            //                informationPageText.text = _interviewQuestionsList._questionCategories[0].m_QuestionList[10];
            //                break;

            //            case 12:
            //                informationPageText.text = _interviewQuestionsList._questionCategories[0].m_QuestionList[11];
            //                break;

            //            case 13:
            //                informationPageText.text = _interviewQuestionsList._questionCategories[0].m_QuestionList[12];
            //                break;

            //            case 14:
            //                informationPageText.text = _interviewQuestionsList._questionCategories[0].m_QuestionList[13];
            //                break;

            //            case 15:
            //                informationPageText.text = _interviewQuestionsList._questionCategories[0].m_QuestionList[14];
            //                break;

            //            case 16:
            //                informationPageText.text = _interviewQuestionsList._questionCategories[0].m_QuestionList[15];
            //                break;

            //            case 17:
            //                informationPageText.text = _interviewQuestionsList._questionCategories[0].m_QuestionList[16];
            //                break;

            //            case 18:
            //                informationPageText.text = _interviewQuestionsList._questionCategories[0].m_QuestionList[17];
            //                break;

            //            case 19:
            //                informationPageText.text = _interviewQuestionsList._questionCategories[0].m_QuestionList[18];
            //                break;

            //            case 20:
            //                informationPageText.text = _interviewQuestionsList._questionCategories[0].m_QuestionList[19];
            //                break;
            //        }
            //        break;

            //    case false:
            //        Debug.LogWarning("Easy Mode isn't true! Make sure it's true in order for code to work!");
            //        break;
            //}
        }
    }
}

