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
        private UIManager _uiManager;
        private GameManager _gameManager;
        private AudioManager _audioManager;
        [SerializeField]
        private AnswerTypeData answerTypeData;
        [SerializeField]
        private AnswerOption answerOption;
        [SerializeField]
        private SelectedAnswer selectedAnswer;
        [SerializeField]
        private GameSettingsScriptableObject _gameSettings;
        [SerializeField]
        private List<GameObject> highlightGameobjects;

        void Start()
        {
            if (_gameSettings.LoadedScene != "Main Menu")
            {
                _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
                _uiManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
            }

            _audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
        }

        /// <summary>
        /// Method for the Worst Answer Button alternative on the AnswerUIButton.
        /// </summary>
        //public void UsedWorstAnswerButton()
        //{
        //    gameManager.InterviewerInterest -= 1;
        //    gameManager.PlayerScore += 0;
        //    uiManager.StartUIDeactivation();

        //    if (gameManager.AnswerPageNumber <= 10)
        //    {
        //       audioManager.StartAudioCoroutine();
        //    }
        //    else { return; }
        //}

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
            _gameManager._questionsAndAnswersCopy[_gameManager.RandomListIndex].interviewQuestionData[_gameManager.RandomSubListIndex].QuestionAsked = true;

            if (_gameManager._questionsAndAnswersCopy[_gameManager.RandomListIndex].interviewCategoryType == CategoriesData.InterviewCategoryType.Regular)
            {
                switch (selectedAnswer)
                {
                    case SelectedAnswer.A:
                        if (_gameManager._questionsAndAnswersCopy[_gameManager.RandomListIndex].interviewQuestionData[_gameManager.RandomSubListIndex].correctAnswer == CategoriesData.CorrectAnswer.A)
                        {
                            _gameManager.AddAnswerToList("Fråga " + _gameManager.AnswerPageNumber + ": Rätt svar!");
                            _gameManager.InterviewerInterest += 1;
                            _gameManager.PlayerScore += 1;
                        }
                        else
                        {
                            _gameManager.AddAnswerToList("Fråga " + _gameManager.AnswerPageNumber + ": Fel svar.");
                            _gameManager.InterviewerInterest -= 1;
                            _gameManager.PlayerScore += 0;
                        }
                        break;

                    case SelectedAnswer.B:
                        if (_gameManager._questionsAndAnswersCopy[_gameManager.RandomListIndex].interviewQuestionData[_gameManager.RandomSubListIndex].correctAnswer == CategoriesData.CorrectAnswer.B)
                        {
                            _gameManager.AddAnswerToList("Fråga " + _gameManager.AnswerPageNumber + ": Rätt svar!");
                            _gameManager.InterviewerInterest += 1;
                            _gameManager.PlayerScore += 1;
                        }
                        else
                        {
                            _gameManager.AddAnswerToList("Fråga " + _gameManager.AnswerPageNumber + ": Fel svar.");
                            _gameManager.InterviewerInterest -= 1;
                            _gameManager.PlayerScore += 0;
                        }
                        break;

                    case SelectedAnswer.C:
                        if (_gameManager._questionsAndAnswersCopy[_gameManager.RandomListIndex].interviewQuestionData[_gameManager.RandomSubListIndex].correctAnswer == CategoriesData.CorrectAnswer.C)
                        {
                            _gameManager.AddAnswerToList("Fråga " + _gameManager.AnswerPageNumber + ": Rätt svar!");
                            _gameManager.InterviewerInterest += 1;
                            _gameManager.PlayerScore += 1;
                        }
                        else
                        {
                            _gameManager.AddAnswerToList("Fråga " + _gameManager.AnswerPageNumber + ": Fel svar.");
                            _gameManager.InterviewerInterest -= 1;
                            _gameManager.PlayerScore += 0;
                        }
                        break;

                    case SelectedAnswer.D:
                        if (_gameManager._questionsAndAnswersCopy[_gameManager.RandomListIndex].interviewQuestionData[_gameManager.RandomSubListIndex].correctAnswer == CategoriesData.CorrectAnswer.D)
                        {
                            _gameManager.AddAnswerToList("Fråga " + _gameManager.AnswerPageNumber + ": Rätt svar!");
                            _gameManager.InterviewerInterest += 1;
                            _gameManager.PlayerScore += 1;
                        }
                        else
                        {
                            _gameManager.AddAnswerToList("Fråga " + _gameManager.AnswerPageNumber + ": Fel svar.");
                            _gameManager.InterviewerInterest -= 1;
                            _gameManager.PlayerScore += 0;
                        }
                        break;

                    default:
                        Debug.LogError("Unexpected selectedAnswer value: " + selectedAnswer);
                        break;
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

            _gameManager.GetRandomListIndex();
            _gameManager.GetRandomSubListIndex();

            _gameManager.AnswerPageNumber++;
            selectedAnswer = SelectedAnswer.None;
            _gameManager.WaitForAnswer = false;
            //_gameManager.CheckAllAnswers();
            _uiManager.StartUIDeactivation();
        }

        /// <summary>
        /// Method for activating the Feedback UI Page.
        /// </summary>
        public void ActivateFeedbackPage()
        {
            _uiManager.uiPrefabCopyList[3].SetActive(true);
        }

        /// <summary>
        /// Method for a UI Button to go to the next page.
        /// </summary>
        public void ActivateSummaryPage()
        {
            gameObject.SetActive(false);
            _uiManager.uiPrefabCopyList[4].SetActive(true);
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

        //////////////////////////////////////////////////////////////////////////////////// OLD SYSTEM FROM DEMO VERSION ////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Method for the Bad Answer Button alternative on the AnswerUIButton.
        /// </summary>
        //public void UsedBadAnswerButton()
        //{
        //    _gameManager.AddAnswerToList("Fråga " + _gameManager.AnswerPageNumber + ": Dåligt svar.");
        //    _gameManager.InterviewerInterest -= 1;
        //    _gameManager.PlayerScore += 0;
        //    _uiManager.StartUIDeactivation();

        //    if (_gameManager.AnswerPageNumber <= 10)
        //    {
        //        _audioManager.StartAudioCoroutine();
        //    }
        //    else { return; }
        //}

        ///// <summary>
        ///// Method for the Average Answer Button alternative on the AnswerUIButton.
        ///// </summary>
        //public void UsedAverageAnswerButton()
        //{
        //    _gameManager.AddAnswerToList("Fråga " + _gameManager.AnswerPageNumber + ": Helt ok svar.");
        //    _gameManager.InterviewerInterest += 0;
        //    _gameManager.PlayerScore += 1;
        //    _uiManager.StartUIDeactivation();

        //    if (_gameManager.AnswerPageNumber <= 10)
        //    {
        //        _audioManager.StartAudioCoroutine();
        //    }
        //    else { return; }
        //}

        ///// <summary>
        ///// Method for the Good Answer Button alternative on the AnswerUIButton.
        ///// </summary>
        //public void UsedGoodAnswerButton()
        //{
        //    _gameManager.AddAnswerToList("Fråga " + _gameManager.AnswerPageNumber + ": Bra svar.");
        //    _gameManager.InterviewerInterest += 1;
        //    _gameManager.PlayerScore += 2;
        //    _uiManager.StartUIDeactivation();

        //    if (_gameManager.AnswerPageNumber <= 10)
        //    {
        //        _audioManager.StartAudioCoroutine();
        //    }
        //    else { return; }
        //}

        /// <summary>
        /// Method for the Best Answer Button alternative on the AnswerUIButton.
        /// </summary>
        //public void UsedBestAnswerButton()
        //{
        //    gameManager.InterviewerInterest += 1;
        //    gameManager.PlayerScore += 3;
        //    uiManager.StartUIDeactivation();

        //    if (gameManager.AnswerPageNumber <= 10)
        //    {
        //        audioManager.StartAudioCoroutine();
        //    }
        //    else { return; }
        //}

        //////////////////////////////////////////////////////////////////////////////////// OLD SYSTEM FROM DEMO VERSION ////////////////////////////////////////////////////////////////////////////////////////////////////////

        //////////////////////////////////////////////// The section below are code ONLY for the Start Menu Scene UI Prefabs /////////////////////////////////////////
        //////////////////////////////////////////////// Saving code in case of future usage ////////////////////////////////////////////////////
        ///// <summary>
        ///// Deactivates current page and activates Start Menu page.
        ///// </summary>
        //public void StartMenuButton()
        //{
        //    gameObject.SetActive(false);
        //    _uiManager.uiPrefabCopyList[0].SetActive(true);
        //}

        ///// <summary>
        ///// Deactivates current page and activates Exercises page.
        ///// </summary>
        //public void ExercisesPageButton()
        //{
        //    gameObject.SetActive(false);
        //    _uiManager.uiPrefabCopyList[1].SetActive(true);
        //}

        ///// <summary>
        ///// Deactivates current page and activates Tutorial page.
        ///// </summary>
        //public void TutorialPageButton()
        //{
        //    gameObject.SetActive(false);
        //    _uiManager.uiPrefabCopyList[2].SetActive(true);
        //}

        ///// <summary>
        ///// Deactivates current page and activates About page.
        ///// </summary>
        //public void AboutPageButton()
        //{
        //    gameObject.SetActive(false);
        //    _uiManager.uiPrefabCopyList[3].SetActive(true);
        //}

        ///// <summary>
        ///// Deactivates current page and activates Settings page.
        ///// </summary>
        //public void SettingsPageButton()
        //{
        //    gameObject.SetActive(false);
        //    _uiManager.uiPrefabCopyList[4].SetActive(true);
        //}

        ///// <summary>
        ///// Deactivates current page and activates Main Mode page.
        ///// </summary>
        //public void MainModeButton()
        //{
        //    gameObject.SetActive(false);
        //    _uiManager.uiPrefabCopyList[5].SetActive(true);
        //}

        ///// <summary>
        ///// Deactivates current page and activates About page.
        ///// </summary>
        //public void QuitTheApplicationPage()
        //{
        //    gameObject.SetActive(false);
        //    _uiManager.uiPrefabCopyList[6].SetActive(true);
        //}

        ///// <summary>
        ///// Quits the application.
        ///// </summary>
        //public void QuitApplication()
        //{
        //    Application.Quit();
        //}
    }
}

