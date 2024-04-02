using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Jesper.InterviewAnswersAndQuestions.Data;
using Jesper.GameSettings.Data;


namespace Jesper.Collection
{
    public class AnswerScreenTextUpdate : MonoBehaviour
    {
        private GameManager gameManager;
        private UIManager uiManager;
        private CategoriesData.CategoryName categoryName;
        private CategoriesData.InterviewQuestion activeCategory;

        [SerializeField]
        private GameSettingsScriptableObject _gameSettings;
        [SerializeField]
        private InterviewAnswersAndQuestionsSO interviewAnswersAndQuestions;
        //[Tooltip("Generic List to store parent objects for the answertexts")]
        //[SerializeField]
        //private List<GameObject> AnswerTextObject = new List<GameObject>();
        [Tooltip("Generic TMP_Text List to store TMP_Text components")]
        [SerializeField]
        private List<TMP_Text> textList;

        void Awake()
        {
            gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
            uiManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
        }

        void Update()
        {
            switch (_gameSettings.GetScene)
            {
                case GameSettingsScriptableObject.LoadedScene.MainMenu:

                    break;

                case GameSettingsScriptableObject.LoadedScene.Office:
                    if (gameManager.WaitForAnswer == false && uiManager.uiPrefabCopyList[0].activeInHierarchy == true || uiManager.uiPrefabCopyList[1].activeInHierarchy == true)
                    {
                        GenerateAnswerText(gameManager.RandomListIndex, gameManager.RandomSubListIndex);
                    }
                    break;

                case GameSettingsScriptableObject.LoadedScene.Tutorial:

                    break;

                default:
                    Debug.LogWarning("Invalid Loaded Scene value! Please check the GameSettings ScriptableObject.");
                    break;
            }

        }

        private void GenerateAnswerText(int listIndex, int subListIndex)
        {
            categoryName = gameManager._activeInterviewCategories[gameManager.RandomListIndex].categoryName;
            activeCategory = gameManager._activeInterviewCategories[listIndex].interviewQuestionData[subListIndex];

            if (listIndex < 0 || subListIndex < 0)
            {
                return;
            }

            if (categoryName == CategoriesData.CategoryName.Default)
            {
                textList[0].text = activeCategory.answers[0].AnswerText;
                textList[1].text = activeCategory.answers[1].AnswerText;
                textList[2].text = activeCategory.answers[2].AnswerText;
            }
            else
            {
                textList[0].text = activeCategory.answers[0].AnswerText;
                textList[1].text = activeCategory.answers[1].AnswerText;
                textList[2].text = activeCategory.answers[2].AnswerText;
                textList[3].text = activeCategory.answers[3].AnswerText;
            }

            gameManager.WaitForAnswer = true;
        }
    }

}
