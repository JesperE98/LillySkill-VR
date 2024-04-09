using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jesper.GameSettings.Data;
using System;
using Jesper.InterviewAnswersAndQuestions.Data;
using Jesper.InterviewQuestionsList.Data;
using Unity.VisualScripting;
using static Jesper.InterviewAnswersAndQuestions.Data.CategoriesData;

namespace Jesper.Collection
{
    public class ButtonFunctions : MonoBehaviour
    {
        private UIManager uiManager;
        private GameManager gameManager;
        private AudioManager audioManager;
        private CategoriesData.CategoryName categoryName;

        /// <summary>
        /// Controls Update Method.
        /// </summary>
        [SerializeField]
        private bool loopDone = false;

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
        private List<HighlightedGameObjects> highlightGameobjects; /*multipleHighlightedGameObjects*/


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
            switch (gameSettings.GetScene)
            {
                case GameSettingsScriptableObject.LoadedScene.Office:
                    if (gameManager.InterviewAreActive && loopDone == false)
                    {
                        randomListIndex = gameManager.RandomListIndex;
                        randomSubListIndex = gameManager.RandomSubListIndex;
                        categoryName = gameManager._activeInterviewCategories[randomListIndex].categoryName;
                        loopDone = true;
                    }
                    else
                    {
                        return;
                    }
                    break;
            }


        }

        /// <summary>
        /// Shows the user what answer they selected.
        /// </summary>
        public void AnswerSelected(int selectedAnswerIndex)
        {
            if (gameManager._activeInterviewCategories[randomListIndex].interviewCategoryType == InterviewCategoryType.Regular)
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
                    selectedAnswer = (AnswerOptions)highlightGameobjects[selectedAnswerIndex].intValue; // Sets the selectedAnswer based on the intValue in the HighlightedGameObject class.
                }
                else if (highlightGameobjects[selectedAnswerIndex].highlightedGameObject.activeInHierarchy == true)
                {
                    highlightGameobjects[selectedAnswerIndex].highlightedGameObject.SetActive(false);
                }
            }
            else if (gameManager._activeInterviewCategories[randomListIndex].interviewCategoryType == InterviewCategoryType.Situational)
            {
                if (selectedAnswerIndex >= 0 && selectedAnswerIndex < highlightGameobjects.Count) // Check for valid index
                {
                    if (highlightGameobjects[selectedAnswerIndex].highlightedGameObject.activeInHierarchy == false)
                    {
                        highlightGameobjects[selectedAnswerIndex].highlightedGameObject.SetActive(true);
                        selectedAnswer = (int)selectedAnswer + (AnswerOptions)highlightGameobjects[selectedAnswerIndex].intValue; // Sets the selectedAnswer based on the selectedAnswerIndex
                        
                        gameManager._activeInterviewCategories[randomListIndex].interviewQuestionData[randomSubListIndex].answers[selectedAnswerIndex].AnswerSelected = true;
                    }
                    else if (highlightGameobjects[selectedAnswerIndex].highlightedGameObject.activeInHierarchy == true)
                    {
                        highlightGameobjects[selectedAnswerIndex].highlightedGameObject.SetActive(false);
                        selectedAnswer = (int)selectedAnswer - (AnswerOptions)highlightGameobjects[selectedAnswerIndex].intValue; // Sets the selectedAnswer based on the selectedAnswerIndex

                        gameManager._activeInterviewCategories[randomListIndex].interviewQuestionData[randomSubListIndex].answers[selectedAnswerIndex].AnswerSelected = false;
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

            // Start evaluating the answers. Checks if the question is is a regular question or a situational question and then
            // determines if the user choosed the Correct Answer (if question was regular) or choosed Good, Average or Bad answers (Situational question).
            EvaluateAnswers(); 

            for (int i = 0; i < highlightGameobjects.Count; i++)
            {
                highlightGameobjects[i].highlightedGameObject.SetActive(false);
            }

            loopDone = false;
            this.gameObject.SetActive(false);
            gameManager.AnswerPageNumber++;
            selectedAnswer = 0;
            gameManager.WaitForAnswer = false;
            gameManager.CheckAllAnswers();
            gameManager.GetRandomListIndex();
            gameManager.GetRandomSubListIndex();
            audioManager.PlayingAudioClip = !audioManager.PlayingAudioClip;
        }

        /// <summary>
        /// Checks if the question is is a regular question or a situational question and then
        /// determines if the user choosed the Correct Answer (if question was regular) or choosed Good, Average or Bad answers (Situational question).
        /// </summary>
        private void EvaluateAnswers()
        {
            var correctAnswer = gameManager._activeInterviewCategories[randomListIndex].interviewQuestionData[randomSubListIndex].correctAnswer;

            if (gameManager._activeInterviewCategories[randomListIndex].interviewCategoryType == InterviewCategoryType.Regular)
            {
                if (categoryName == CategoriesData.CategoryName.Default)
                {
                    switch (selectedAnswer)
                    {
                        case AnswerOptions.A:
                            if (correctAnswer == CorrectAnswer.A)
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
                            if (correctAnswer == CorrectAnswer.B)
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
                            if (correctAnswer == CorrectAnswer.C)
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
                            if (correctAnswer == CorrectAnswer.A)
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
                            if (correctAnswer == CorrectAnswer.B)
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
                            if (correctAnswer == CorrectAnswer.C)
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
                            if (correctAnswer == CorrectAnswer.D)
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
            else if (gameManager._activeInterviewCategories[randomListIndex].interviewCategoryType == InterviewCategoryType.Situational)
            {
                foreach (var answer in gameManager._activeInterviewCategories[randomListIndex].interviewQuestionData[randomSubListIndex].answers)
                {
                    if (answer.AnswerSelected == true)
                    {
                        if (answer.answerType == AnswerType.Good)
                        {
                            gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Rätt svar!");
                            gameManager.InterviewerInterest += 1;
                            gameManager.PlayerScore += 1;
                        }
                        else if (answer.answerType == AnswerType.Average)
                        {
                            gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Helt ok svar.");
                            gameManager.InterviewerInterest -= 1;
                            gameManager.PlayerScore += 0.5f;
                        }
                        else
                        {
                            gameManager.AddAnswerToList("Fråga " + gameManager.AnswerPageNumber + ": Fel svar.");
                            gameManager.InterviewerInterest -= 1;
                            gameManager.PlayerScore += 0;
                        }
                    }
                    else
                    {
                        Debug.Log($"Answer was not selected: {answer.AnswerAlternative}: {answer.AnswerSelected}");
                        continue;
                    }
                }
            }
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

