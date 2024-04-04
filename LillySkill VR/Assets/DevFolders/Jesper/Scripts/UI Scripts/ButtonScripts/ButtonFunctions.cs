using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jesper.GameSettings.Data;
using System;
using Jesper.InterviewAnswersAndQuestions.Data;
using Jesper.InterviewQuestionsList.Data;
using Unity.VisualScripting;

namespace Jesper.Collection
{
    public class ButtonFunctions : MonoBehaviour
    {
        private UIManager uiManager;
        private GameManager gameManager;
        private AudioManager audioManager;

        [SerializeField]
        private int randomListIndex;
        [SerializeField]
        private int randomSubListIndex;

        [SerializeField]
        private AnswerTypeData answerTypeData;
        [SerializeField]
        private AnswerOptions selectedAnswer;
        [SerializeField]
        private GameSettingsScriptableObject gameSettings;
        [SerializeField]
        private List<HighlightedGameObjects> highlightGameobjects, multipleHighlightedGameObjects;


        private void Awake()
        {
            if (gameSettings.GetScene != GameSettingsScriptableObject.LoadedScene.MainMenu)
            {
                gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
                uiManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
            }

            audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
        }



        void Update()
        {
            if (gameManager.InterviewAreActive)
            {
                randomListIndex = gameManager.RandomListIndex;
                randomSubListIndex = gameManager.RandomSubListIndex;
            }
            else
            {
                return;
            }

        }

        /// <summary>
        /// Shows the user what answer they selected.
        /// </summary>
        public void AnswerSelected(int selectedAnswerIndex)
        {
            if (gameManager._activeInterviewCategories[randomListIndex].interviewCategoryType == CategoriesData.InterviewCategoryType.Regular)
            {
                // Turns off all the highlight gameobjects.
                //foreach (GameObject obj in highlightGameobjects)
                //{
                //    obj.SetActive(false);
                //}

                for(int i = 0; i < highlightGameobjects.Count; i++)
                {
                    highlightGameobjects[i].highlightedGameObject.SetActive(false);
                }

                if (highlightGameobjects[selectedAnswerIndex].highlightedGameObject.activeInHierarchy == false)
                {
                    highlightGameobjects[selectedAnswerIndex].highlightedGameObject.SetActive(true);
                    selectedAnswer = (AnswerOptions)highlightGameobjects[selectedAnswerIndex].intValue; // Sets the selectedAnswer based on the selectedAnswerIndex
                }
                else if (highlightGameobjects[selectedAnswerIndex].highlightedGameObject.activeInHierarchy == true)
                {
                    highlightGameobjects[selectedAnswerIndex].highlightedGameObject.SetActive(false);
                }
            }
            else if (gameManager._activeInterviewCategories[randomListIndex].interviewCategoryType == CategoriesData.InterviewCategoryType.Situational)
            {
                if (selectedAnswerIndex >= 0 && selectedAnswerIndex < highlightGameobjects.Count) // Check for valid index
                {
                    if (multipleHighlightedGameObjects[selectedAnswerIndex].highlightedGameObject.activeInHierarchy == false)
                    {
                        multipleHighlightedGameObjects[selectedAnswerIndex].highlightedGameObject.SetActive(true);


                        selectedAnswer = (AnswerOptions)selectedAnswerIndex; // Sets the selectedAnswer based on the selectedAnswerIndex
                    }
                    else if (multipleHighlightedGameObjects[selectedAnswerIndex].highlightedGameObject.activeInHierarchy == true)
                    {
                        multipleHighlightedGameObjects[selectedAnswerIndex].highlightedGameObject.SetActive(false);
                    }
                }
                else
                {
                    Debug.LogError("Invalid selectedAnswerIndex: " + selectedAnswerIndex);
                }
            }

        }


        public void OnConfirmChoisePressed()
        {
            gameManager._activeInterviewCategories[randomListIndex].interviewQuestionData[randomSubListIndex].QuestionAsked = true;
            var categoryName = gameManager._activeInterviewCategories[randomListIndex].categoryName;
            var correctAnswer = gameManager._activeInterviewCategories[randomListIndex].interviewQuestionData[randomSubListIndex].correctAnswer;
            var answerType = gameManager._activeInterviewCategories[randomListIndex].interviewQuestionData[randomSubListIndex].answers[(int)selectedAnswer].answerType;

            if (gameManager._activeInterviewCategories[randomListIndex].interviewCategoryType == CategoriesData.InterviewCategoryType.Regular)
            {
                if (categoryName == CategoriesData.CategoryName.Default)
                {
                    switch (selectedAnswer)
                    {
                        case AnswerOptions.A:
                            if (correctAnswer == CategoriesData.CorrectAnswer.A)
                            {
                                gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Rätt svar!");
                                gameManager.InterviewerInterest += 1;
                                gameManager.PlayerScore += 1;
                            }
                            else
                            {
                                gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Fel svar.");
                                gameManager.InterviewerInterest -= 1;
                                gameManager.PlayerScore += 0;
                            }
                            break;

                        case AnswerOptions.B:
                            if (correctAnswer == CategoriesData.CorrectAnswer.B)
                            {
                                gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Rätt svar!");
                                gameManager.InterviewerInterest += 1;
                                gameManager.PlayerScore += 1;
                            }
                            else
                            {
                                gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Fel svar.");
                                gameManager.InterviewerInterest -= 1;
                                gameManager.PlayerScore += 0;
                            }
                            break;

                        case AnswerOptions.C:
                            if (correctAnswer == CategoriesData.CorrectAnswer.C)
                            {
                                gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Rätt svar!");
                                gameManager.InterviewerInterest += 1;
                                gameManager.PlayerScore += 1;
                            }
                            else
                            {
                                gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Fel svar.");
                                gameManager.InterviewerInterest -= 1;
                                gameManager.PlayerScore += 0;
                            }
                            break;

                        default:
                            Debug.LogError("Unexpected selectedAnswer value: " + selectedAnswer);
                            break;
                    }
                }
                else
                {
                    switch (selectedAnswer)
                    {
                        case AnswerOptions.A:
                            if (correctAnswer == CategoriesData.CorrectAnswer.A)
                            {
                                gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Rätt svar!");
                                gameManager.InterviewerInterest += 1;
                                gameManager.PlayerScore += 1;
                            }
                            else
                            {
                                gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Fel svar.");
                                gameManager.InterviewerInterest -= 1;
                                gameManager.PlayerScore += 0;
                            }
                            break;

                        case AnswerOptions.B:
                            if (correctAnswer == CategoriesData.CorrectAnswer.B)
                            {
                                gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Rätt svar!");
                                gameManager.InterviewerInterest += 1;
                                gameManager.PlayerScore += 1;
                            }
                            else
                            {
                                gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Fel svar.");
                                gameManager.InterviewerInterest -= 1;
                                gameManager.PlayerScore += 0;
                            }
                            break;

                        case AnswerOptions.C:
                            if (correctAnswer == CategoriesData.CorrectAnswer.C)
                            {
                                gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Rätt svar!");
                                gameManager.InterviewerInterest += 1;
                                gameManager.PlayerScore += 1;
                            }
                            else
                            {
                                gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Fel svar.");
                                gameManager.InterviewerInterest -= 1;
                                gameManager.PlayerScore += 0;
                            }
                            break;

                        case AnswerOptions.D:
                            if (correctAnswer == CategoriesData.CorrectAnswer.D)
                            {
                                gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Rätt svar!");
                                gameManager.InterviewerInterest += 1;
                                gameManager.PlayerScore += 1;
                            }
                            else
                            {
                                gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Fel svar.");
                                gameManager.InterviewerInterest -= 1;
                                gameManager.PlayerScore += 0;
                            }
                            break;

                        default:
                            Debug.LogError("Unexpected selectedAnswer value: " + selectedAnswer);
                            break;
                    }
                }

            }
            else if (gameManager._activeInterviewCategories[gameManager.RandomListIndex].interviewCategoryType == CategoriesData.InterviewCategoryType.Situational)
            {
                switch (selectedAnswer)
                {
                    case AnswerOptions.A:
                        if (answerType == CategoriesData.AnswerType.Good)
                        {
                            gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Rätt svar!");
                            gameManager.InterviewerInterest += 1;
                            gameManager.PlayerScore += 1;
                        }
                        else if(answerType == CategoriesData.AnswerType.Average)
                        {
                            gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Fel svar.");
                            gameManager.InterviewerInterest -= 1;
                            gameManager.PlayerScore += 0.5f;
                        }
                        else
                        {
                            gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Fel svar.");
                            gameManager.InterviewerInterest -= 1;
                            gameManager.PlayerScore += 0;
                        }
                        break;

                    case AnswerOptions.B:
                        if (answerType == CategoriesData.AnswerType.Good)
                        {
                            gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Rätt svar!");
                            gameManager.InterviewerInterest += 1;
                            gameManager.PlayerScore += 1;
                        }
                        else if (answerType == CategoriesData.AnswerType.Average)
                        {
                            gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Fel svar.");
                            gameManager.InterviewerInterest -= 1;
                            gameManager.PlayerScore += 0.5f;
                        }
                        else
                        {
                            gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Fel svar.");
                            gameManager.InterviewerInterest -= 1;
                            gameManager.PlayerScore += 0;
                        }
                        break;

                    case AnswerOptions.C:
                        if (answerType == CategoriesData.AnswerType.Good)
                        {
                            gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Rätt svar!");
                            gameManager.InterviewerInterest += 1;
                            gameManager.PlayerScore += 1;
                        }
                        else if (answerType == CategoriesData.AnswerType.Average)
                        {
                            gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Fel svar.");
                            gameManager.InterviewerInterest -= 1;
                            gameManager.PlayerScore += 0.5f;
                        }
                        else
                        {
                            gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Fel svar.");
                            gameManager.InterviewerInterest -= 1;
                            gameManager.PlayerScore += 0;
                        }
                        break;

                    case AnswerOptions.D:
                        if (answerType == CategoriesData.AnswerType.Good)
                        {
                            gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Rätt svar!");
                            gameManager.InterviewerInterest += 1;
                            gameManager.PlayerScore += 1;
                        }
                        else if(answerType == CategoriesData.AnswerType.Average)
                        {
                            gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Fel svar.");
                            gameManager.InterviewerInterest -= 1;
                            gameManager.PlayerScore += 0.5f;
                        }
                        else
                        {
                            gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Fel svar.");
                            gameManager.InterviewerInterest -= 1;
                            gameManager.PlayerScore += 0;
                        }
                        break;

                    default:
                        Debug.LogError("Unexpected selectedAnswer value: " + selectedAnswer);
                        break;
                }
            }

            // Turns off all the highlight gameobjects.
            //foreach (GameObject obj in highlightGameobjects)
            //{
            //    obj.SetActive(false);
            //}

            for (int i = 0; i < highlightGameobjects.Count; i++)
            {
                highlightGameobjects[i].highlightedGameObject.SetActive(false);
            }

            this.gameObject.SetActive(false);
            gameManager.AnswerPageNumber++;
            gameManager.WaitForAnswer = false;
            gameManager.CheckAllAnswers();
            gameManager.GetRandomListIndex();
            gameManager.GetRandomSubListIndex();
            audioManager.PlayingAudioClip = !audioManager.PlayingAudioClip;
        }

        /// <summary>
        /// Activates the Feedback UI Page.
        /// </summary>
        public void ActivateFeedbackPage()
        {
            uiManager.uiPrefabCopyList[2].SetActive(true);
        }

        /// <summary>
        /// Deactivates Feedback Page and activates the Summary Page.
        /// </summary>
        public void ActivateSummaryPage()
        {
            gameObject.SetActive(false);
            uiManager.uiPrefabCopyList[3].SetActive(true);
        }

        [Flags]
        private enum AnswerOptions
        {
            A = 1,
            B = 2,
            C = 4,
            D = 8
        }

        /// <summary>
        /// Enum to indicate answer quality (bad, average, good).
        /// </summary>
        private enum AnswerTypeData
        {
            Bad,
            Average,
            Good
        }

        [Serializable]
        public class HighlightedGameObjects
        {
            public int intValue;
            public GameObject highlightedGameObject;

            public HighlightedGameObjects(int intValue, GameObject highLightedGameObject)
            {
                this.intValue = intValue;
                this.highlightedGameObject = highLightedGameObject;
            }
        }
    }
}

