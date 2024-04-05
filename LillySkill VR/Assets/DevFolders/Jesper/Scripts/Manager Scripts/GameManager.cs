using System.Collections.Generic;
using UnityEngine;
using Jesper.GameSettings.Data;
using Jesper.InterviewAnswersAndQuestions.Data;

public class GameManager : MonoBehaviour
{
    private int _randomListIndex = 0;
    private int _randomSubListIndex = 0;
    private int _answerPageNumber = 1;
    [SerializeField]
    private int _maxScore = 0;
    private bool _fadeInComplete = false;
    private bool _fadeOutComplete = false;
    private bool _lillyIntroDone = false;
    private bool _lillyOutroDone = false;
    private bool _interviewerIntro = false;
    private bool _allQuestionsAnsweredPreviously = true;
    private bool _feedbackPageAreActive = false;


    [SerializeField]
    private float _playerScore = 0;
    [SerializeField]
    private int _interviewerInterest = 2;
    [SerializeField]
    private bool _tutorialDone = false;
    [SerializeField]
    private bool _interviewAreActive = false;
    [SerializeField]
    private bool _waitForAnswer = false;
    [SerializeField]
    private GameSettingsScriptableObject _gameSettings;
    [SerializeField]
    private InterviewAnswersAndQuestionsSO interviewAnswersAndQuestions;
    [SerializeField]
    protected List<string> _answerList = new List<string>();


    public List<CategoriesData> _activeInterviewCategories = new List<CategoriesData>();


    public int MaxScore
    {
        get
        {
            return _maxScore;
        }
        set
        {
            _maxScore = value;
        }
    }

    /// <summary>
    /// Gets and sets random int number.
    /// </summary>
    public int RandomListIndex
    {
        get
        {
            return _randomListIndex;
        }
        set
        {
            _randomListIndex = value;
        }
    }

    /// <summary>
    /// Gets and sets random int number.
    /// </summary>
    public int RandomSubListIndex
    {
        get
        {
            return _randomSubListIndex;
        }
        set
        {
            _randomSubListIndex = value;
        }
    }

    /// <summary>
    /// Gets and sets int value to controll Interviewer NPC animations.
    /// </summary>
    public int InterviewerInterest 
    { 
        get 
        { 
            return _interviewerInterest; 
        } 
        set 
        {
            _interviewerInterest = value; 
        } 
    }

    /// <summary>
    /// Gets and sets int value to controll what feedback text should be displayed.
    /// </summary>
    public float PlayerScore
    {
        get
        {
            return _playerScore;
        }
        set
        {
            _playerScore = value;
        }
    }

    /// <summary>
    /// Gets and sets int value to determine which answer page the user are on and controlls which ansers that should be given to the user.
    /// </summary>
    public int AnswerPageNumber 
    { 
        get
        { 
            return _answerPageNumber;
        } 
        set 
        { 
            _answerPageNumber = value;
        } 
    }

    /// <summary>
    /// A List that stores all the wrong answers.
    /// </summary>
    public List<string> AnswerList 
    { 
        get 
        { 
            return _answerList; 
        } 
        set 
        { 
            _answerList = value; 
        }
    }

    /// <summary>
    /// Checks if the Fade in effect are active.
    /// </summary>
    public bool FadeInComplete 
    { 
        get
        {
            return _fadeInComplete;
        }
        set 
        { 
            _fadeInComplete = value; 
        } 
    }

    /// <summary>
    /// Checks if the Fade out effect are active.
    /// </summary>
    public bool FadeOutComplete 
    { 
        get 
        { 
            return _fadeOutComplete;
        } 
        set 
        { 
            _fadeOutComplete = value;
        } 
    }

    /// <summary>
    /// Checks if the Lilly Intro are active,
    /// </summary>
    public bool LillyIntroDone 
    { 
        get 
        { 
            return _lillyIntroDone; 
        } 
        set 
        { 
            _lillyIntroDone = value; 
        } 
    }

    /// <summary>
    /// Checks if the Lilly Outro are active.
    /// </summary>
    public bool LillyOutroDone 
    { 
        get 
        { 
            return _lillyOutroDone; 
        }
        set 
        { 
            _lillyOutroDone = value; 
        } 
    }

    /// <summary>
    /// Checks if the Interviewer introduction are active.
    /// </summary>
    public bool InterviewerIntro 
    { 
        get 
        { 
            return _interviewerIntro; 
        } 
        set 
        { 
            _interviewerIntro = value;
        } 
    }

    /// <summary>
    /// Gets and sets bool value that determines if a interview is active.
    /// </summary>
    public bool InterviewAreActive 
    { 
        get 
        {
            return _interviewAreActive;
        } 
        set
        { 
            _interviewAreActive = value; 
        } 
    }

    public bool WaitForAnswer 
    { 
        get 
        { 
            return _waitForAnswer;
        } 
        set
        { 
            _waitForAnswer = value;
        } 
    }

    public bool FeedbackPageAreActive
    {
        get
        {
            return _feedbackPageAreActive;
        }
        set
        {
            _feedbackPageAreActive = value;
        }
    }

    public bool TutorialDone
    {
        get
        {
            return _tutorialDone;
        }
        set
        {
            _tutorialDone = value;
        }
    }

    private void Start()
    {
        switch (_gameSettings.GetScene)
        {
            case GameSettingsScriptableObject.LoadedScene.MainMenu:

                break;

            case GameSettingsScriptableObject.LoadedScene.Office:
                ResetInterviewData();
                GetRandomListIndex();
                GetRandomSubListIndex();
                MaxScoreCalculator();
                break;

            case GameSettingsScriptableObject.LoadedScene.Tutorial:
                ResetAllValues();
                break;
        }

    }

    private void Update()
    {
        if(PlayerScore > _gameSettings.PlayerHighScore)
        {
            _gameSettings.PlayerHighScore = PlayerScore;
        }

        InterviewerInterest = Mathf.Clamp(InterviewerInterest, 1, 5);

        CheckAllAnswers();

        if (!InterviewAreActive && _allQuestionsAnsweredPreviously)
        {
            

            // Interview ended (or extra question triggered)
            // Handle the case where all questions are answered (e.g., display feedback page)

            // Optional: Repeat the last question
            // InterviewAreActive = true;
        }

        //_allQuestionsAnsweredPreviously = InterviewAreActive; // Update previous state
    }

    /// <summary>
    /// Calculates what the max score should be.
    /// </summary>
    public void MaxScoreCalculator()
    {
        // Goes through all active categoires and increment max score based on how many questions there is.
        for(int i = 0; i < _activeInterviewCategories.Count; i++)
        {
            for(int j = 0; j < _activeInterviewCategories[i].interviewQuestionData.Count; j++)
            {
                _maxScore++;
            }
        }
    }

    /// <summary>
    /// Checks if all the answers are answered.
    /// </summary>
    public void CheckAllAnswers()
    {
        if(_activeInterviewCategories == null || _activeInterviewCategories.Count == 0)
        {
            return;
        }

        bool anyUnansweredQuestions = false;
        bool allQuestionsAnswered = true; // Flag to track if all questions are answered.

        foreach (var data in _activeInterviewCategories)
        {
            allQuestionsAnswered &= data.allAnswersAnswered; // Efficiently check if all elements are true using bitwise AND.

            if (allQuestionsAnswered)
            {
                anyUnansweredQuestions = true;
                break; // Exit after encountering an unanswered category (optimization)
            }

            // Additionally check if all questions within the category are answered.
            if (data.categoryIsActive)
            {
                bool allCategoryQuestionsAnswered = true;

                foreach (var question in data.interviewQuestionData)
                {
                    allCategoryQuestionsAnswered &= question.QuestionAsked;

                    if (!allCategoryQuestionsAnswered)
                    {
                        break; // No need to continue checking questions within the category.
                    }
                }
                data.allAnswersAnswered = allCategoryQuestionsAnswered; // Update category flag.
            }
        }

        InterviewAreActive = !anyUnansweredQuestions; // Set interview active based on overall answered state.

        if (!anyUnansweredQuestions)
        {
            // Handle the case where all questions are answered (e.g., display congratulations)
            FeedbackPageAreActive = true;
        }
    }

    /// <summary>
    /// Checks if all the questions in a specific category are answered.
    /// </summary>
    public void CheckAllQuestions()
    {
        if (_activeInterviewCategories == null || _activeInterviewCategories.Count == 0)
        {
            return;
        }

        foreach (var data in _activeInterviewCategories[RandomListIndex].interviewQuestionData)
        {
            if (!data.QuestionAsked)
            {
                _activeInterviewCategories[RandomListIndex].allAnswersAnswered = true;
                return;
            }
        }

        _activeInterviewCategories[RandomListIndex].allAnswersAnswered = false;
    }

    /// <summary>
    /// Method with default values if user wants to restart current active scene.
    /// </summary>
    public virtual void DefaultValues()
    {
        AnswerList.Clear();
        ResetInterviewData();
    }

    /// <summary>
    /// Method that stores wrong answers to a list.
    /// </summary>
    /// <param name="text"></param>
    public virtual void AddAnswerToList(string text)
    {
        AnswerList.Add(text);
    }

    /// <summary>
    /// Resets all category data except for the CategoryIsActive variable.
    /// </summary>
    private void ResetInterviewData()
    {
        // Resets all necessary bool values back to false.
        for (int i = 0; i < interviewAnswersAndQuestions.interviewCategories.Length; i++)
        {
            if (interviewAnswersAndQuestions.interviewCategories[i].categoryIsActive == true)
            {
                interviewAnswersAndQuestions.interviewCategories[i].allAnswersAnswered = false;

                for (int j = 0; j < interviewAnswersAndQuestions.interviewCategories[i].interviewQuestionData.Count; j++)
                {
                    interviewAnswersAndQuestions.interviewCategories[i].interviewQuestionData[j].QuestionAsked = false;

                    // Loop through this for block only if the category type is situational.
                    if (interviewAnswersAndQuestions.interviewCategories[i].interviewCategoryType == CategoriesData.InterviewCategoryType.Situational)
                    {
                        for (int k = 0; k < interviewAnswersAndQuestions.interviewCategories[i].interviewQuestionData[j].answers.Length; k++)
                        {
                            interviewAnswersAndQuestions.interviewCategories[i].interviewQuestionData[j].answers[k].AnswerSelected = false;
                        }
                    }
                    else // Continue the loop if the category type isn't situational.
                    {
                        continue;
                    }
                }
            }
            else
            {
                // Break out of loop if no category is active.
                break;
            }
        }

        _activeInterviewCategories.Clear();
        Debug.Log("All values reseted!");

        // Goes through all data in InterviewAnswersAndQuestions list categoriesDatas and creates deep copies of the categorys
        // that are active and adds them to the GameManagers list _activeInterviewCategories.
        foreach (CategoriesData data in interviewAnswersAndQuestions.interviewCategories)
        {
            if (data.categoryIsActive == true)
            {
                data.Clone();

                _activeInterviewCategories.Add(data);
            }

        }
    }

    /// <summary>
    /// Resets ALL categoryIsActive values back to false.
    /// </summary>
    public void ResetAllValues()
    {
        foreach (var item in interviewAnswersAndQuestions.interviewCategories)
        {
            item.categoryIsActive = false;
        }
        ResetInterviewData();
    }

    /// <summary>
    /// Generate a random int value for the list index.
    /// </summary>
    public void GetRandomListIndex()
    {
        if (!InterviewAreActive)
        {
            return;
        }

        if(_activeInterviewCategories.Count == 0)
        {
            // Handle case where no active categories are available
            return;
        }

        int tries = 0;// Track loop iterations to avoid infinite loops.

        do
        {
            _randomListIndex = Random.Range(0, _activeInterviewCategories.Count);
        } while (_activeInterviewCategories[_randomListIndex].allAnswersAnswered && tries++ < 100); // Limit retries to prevent infinite loops

        if(tries >= 100)
        {
            // Handle case where no un-answered questions are found after retries (unlikely scenario)
        }
        else
        {
            Debug.Log("Random List Index: " + _randomListIndex);
            ReturnRandomListIndex();
        }
    }

    /// <summary>
    /// Generates a random int value for the sub list index.
    /// </summary>
    public void GetRandomSubListIndex()
    {
        if (!InterviewAreActive)
        {
            return;
        }

        if(_randomListIndex < 0 || _randomListIndex >= _activeInterviewCategories.Count)
        {
            // Handles invalid list index.
            return;
        }

        var currentCategory = _activeInterviewCategories[_randomListIndex];

        if (currentCategory.categoryIsActive)
        {
            int tries = 0;

            do
            {
                _randomSubListIndex = Random.Range(0, currentCategory.interviewQuestionData.Count);
            } while (currentCategory.interviewQuestionData[_randomSubListIndex].QuestionAsked && tries++ < 100); // Limit retries to prevent infinite loops

            if(tries >= 100)
            {
                // Handle case where no un-answered questions are found after retries (unlikely scenario)
            }
            else
            {
                Debug.Log("Random Sub List Index: " + _randomSubListIndex);
                ReturnRandomSubListIndex();
            }
        }
    }

    /// <summary>
    /// Returns varaible _randomListIndex value.
    /// </summary>
    /// <returns></returns>
    private int ReturnRandomListIndex()
    {
        return _randomListIndex;
    }

    /// <summary>
    /// Returns variable _randomSubListIndex value.
    /// </summary>
    /// <returns></returns>
    private int ReturnRandomSubListIndex()
    {
        return _randomSubListIndex;
    }
}
