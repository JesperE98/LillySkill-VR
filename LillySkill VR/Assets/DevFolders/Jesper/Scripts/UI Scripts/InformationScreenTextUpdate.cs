using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Jesper.InterviewQuestionsList.Data;
using Jesper.GameSettings.Data;
using Jesper.InterviewAnswersAndQuestions.Data;


namespace Jesper.Collection
{
    public class InformationScerenTextUpdate : MonoBehaviour
    {
        private GameManager gameManager;
        private TMP_Text informationPageText;
        [SerializeField]
        private InterviewAnswersAndQuestionsSO interviewAnswersAndQuestions;
        [SerializeField]
        private GameSettingsScriptableObject _gameSettings;

        void Awake()
        {
            gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

            informationPageText = GetComponent<TMP_Text>();
        }

        void Update()
        {
            if (gameManager.WaitForAnswer == false)
            {
                GenerateQuestionText(gameManager.RandomListIndex, gameManager.RandomSubListIndex);
            }
        }

        private void GenerateQuestionText(int listIndex, int subListIndex)
        {
            informationPageText.text = gameManager._activeInterviewCategories[listIndex].interviewQuestionData[subListIndex].QuestionText;
        }
    }
}

