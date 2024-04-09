using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Jesper.InterviewQuestionsList.Data;
using Jesper.GameSettings.Data;
using Jesper.InterviewAnswersAndQuestions.Data;


namespace Jesper.Collection
{
    public class InformationScreenTextUpdate : MonoBehaviour
    {
        private GameManager gameManager;
        private TMP_Text informationPageText;
        [SerializeField]
        private InterviewAnswersAndQuestionsSO interviewAnswersAndQuestions;
        [SerializeField]
        private GameSettingsScriptableObject _gameSettings;

        void Awake()
        {
            switch (_gameSettings.GetScene)
            {
                case GameSettingsScriptableObject.LoadedScene.Office:
                    gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
                    break;

                case GameSettingsScriptableObject.LoadedScene.Tutorial:
                    gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
                    break;
            }

            informationPageText = GetComponent<TMP_Text>();
        }

        void Update()
        {
            switch (_gameSettings.GetScene)
            {
                case GameSettingsScriptableObject.LoadedScene.Office:
                    if (gameManager.WaitForAnswer == false)
                    {
                        GenerateQuestionText(gameManager.RandomListIndex, gameManager.RandomSubListIndex);
                    }
                    break;
            }
        }

        private void GenerateQuestionText(int listIndex, int subListIndex)
        {
            switch (_gameSettings.GetScene)
            {
                case GameSettingsScriptableObject.LoadedScene.Office:
                    informationPageText.text = gameManager._activeInterviewCategories[listIndex].interviewQuestionData[subListIndex].QuestionText;
                    break;

                case GameSettingsScriptableObject.LoadedScene.Tutorial:

                    break;

                default:
                    Debug.LogWarning("Invalid Loaded Scene value! Please check the GameSettings ScriptableObject.");
                    break;
            }
            
        }
    }
}

