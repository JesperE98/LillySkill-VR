using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jesper.GameSettings.Data;
using System;
using Jesper.InterviewAnswersAndQuestions.Data;

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
        private AnswerOption answerOption;
        [SerializeField]
        private SelectedAnswer selectedAnswer;
        [SerializeField]
        private GameSettingsScriptableObject gameSettings;
        [SerializeField]
        private List<GameObject> highlightGameobjects;


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
            // Turns off all the highlight gameobjects.
            foreach (GameObject obj in highlightGameobjects)
            {
                obj.SetActive(false);
            }

            if (highlightGameobjects[selectedAnswerIndex].activeInHierarchy == false)
            {
                highlightGameobjects[selectedAnswerIndex].SetActive(true);
                selectedAnswer = (SelectedAnswer)selectedAnswerIndex; // Sets the selectedAnswer based on the selectedAnswerIndex
            }
            else if (highlightGameobjects[selectedAnswerIndex].activeInHierarchy == true)
            {
                highlightGameobjects[selectedAnswerIndex].SetActive(false);
            }
        }


        public void OnConfirmChoisePressed()
        {
            gameManager._activeInterviewCategories[randomListIndex].interviewQuestionData[randomSubListIndex].QuestionAsked = true;

            if (gameManager._activeInterviewCategories[randomListIndex].interviewCategoryType == CategoriesData.InterviewCategoryType.Regular)
            {
                var categoryName = gameManager._activeInterviewCategories[randomListIndex].categoryName;

                if(categoryName == CategoriesData.CategoryName.Default)
                {
                    switch (selectedAnswer)
                    {
                        case SelectedAnswer.A:
                            if (gameManager._activeInterviewCategories[randomListIndex].interviewQuestionData[randomSubListIndex].correctAnswer == CategoriesData.CorrectAnswer.A)
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

                        case SelectedAnswer.B:
                            if (gameManager._activeInterviewCategories[randomListIndex].interviewQuestionData[randomSubListIndex].correctAnswer == CategoriesData.CorrectAnswer.B)
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

                        case SelectedAnswer.C:
                            if (gameManager._activeInterviewCategories[randomListIndex].interviewQuestionData[randomSubListIndex].correctAnswer == CategoriesData.CorrectAnswer.C)
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
                        case SelectedAnswer.A:
                            if (gameManager._activeInterviewCategories[randomListIndex].interviewQuestionData[randomSubListIndex].correctAnswer == CategoriesData.CorrectAnswer.A)
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

                        case SelectedAnswer.B:
                            if (gameManager._activeInterviewCategories[randomListIndex].interviewQuestionData[randomSubListIndex].correctAnswer == CategoriesData.CorrectAnswer.B)
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

                        case SelectedAnswer.C:
                            if (gameManager._activeInterviewCategories[randomListIndex].interviewQuestionData[randomSubListIndex].correctAnswer == CategoriesData.CorrectAnswer.C)
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

                        case SelectedAnswer.D:
                            if (gameManager._activeInterviewCategories[randomListIndex].interviewQuestionData[randomSubListIndex].correctAnswer == CategoriesData.CorrectAnswer.D)
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
            //else if (_gameManager._questionsAndAnswersCopy[_gameManager.RandomListIndex].interviewCategoryType == CategoriesData.InterviewCategoryType.Situational)
            //{

            //}

            // Turns off all the highlight gameobjects.
            foreach (GameObject obj in highlightGameobjects)
            {
                obj.SetActive(false);
            }

            this.gameObject.SetActive(false);
            gameManager.AnswerPageNumber++;
            selectedAnswer = SelectedAnswer.None;
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

        private enum SelectedAnswer
        {
            A,
            B,
            C,
            D,
            All,
            None
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
        private enum AnswerOption
        {
            OneAnswerOption,
            MultipeChoiceOption
        }
    }
}

