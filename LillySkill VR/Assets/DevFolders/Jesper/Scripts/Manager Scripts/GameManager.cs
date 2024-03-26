using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;
using Jesper.GameSettings.Data;
using Jesper.InterviewAnswersAndQuestions.Data;
using Jesper.InterviewQuestionsList.Data;
using UnityEditor.Profiling.Memory.Experimental;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    private int _randomListIndex = 0;
    private int _randomSubListIndex = 0;
    private int _answerPageNumber = 1;
    private bool _fadeInComplete = false;
    private bool _fadeOutComplete = false;
    private bool _lillyIntroDone = false;
    private bool _lillyOutroDone = false;
    private bool _interviewerIntro = false;
    //private CorrectAnswerData _getCorrectAnswerData;


    [SerializeField]
    private float _playerScore = 0;
    [SerializeField]
    private int _interviewerInterest = 2;
    [SerializeField]
    private bool _interviewAreActive = false;
    [SerializeField]
    private bool _waitForAnswer = false;
    [SerializeField]
    private GameSettingsScriptableObject _gameSettings;
    [SerializeField]
    private InterviewAnswersAndQuestionsSO interviewAnswersAndQuestions;
    [SerializeField]
    private InterviewQuestionsListScriptableObject interviewQuestionList;
    [SerializeField]
    protected List<string> _answerList = new List<string>();


    public List<CategoriesData> _activeInterviewCategories = new List<CategoriesData>();


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

    //public CorrectAnswerData GetCorrectAnswerData
    //{
    //    get
    //    {
    //        return _getCorrectAnswerData;
    //    }
    //    set
    //    {
    //        _getCorrectAnswerData = value;
    //    }
    //}

    private void Start()
    {
        ResetInterviewData();
        //CheckAllAnswers();
        GetRandomListIndex();
        GetRandomSubListIndex();
    }

    private void Update()
    {
        if(PlayerScore > _gameSettings.PlayerHighScore)
        {
            _gameSettings.PlayerHighScore = PlayerScore;
        }

        InterviewerInterest = Mathf.Clamp(InterviewerInterest, 1, 5);
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
            Debug.Log(data.ToString());
            allQuestionsAnswered &= data.allAnswersAnswered; // Efficiently check if all elements are true using bitwise AND.
            Debug.Log(allQuestionsAnswered.ToString());

            if (!allQuestionsAnswered)
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
            Debug.Log("All interview questions have been answered!");
            // Handle the case where all questions are answered (e.g., display congratulations)
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
    }

    /// <summary>
    /// Method that stores wrong answers to a list.
    /// </summary>
    /// <param name="text"></param>
    public virtual void AddAnswerToList(string text)
    {
        AnswerList.Add(text);
    }

    private void ResetInterviewData()
    {
        // Resets all necessary bool values back to false.
        for (int i = 0; i < interviewAnswersAndQuestions.categoriesDatas.Length; i++)
        {
            if (interviewAnswersAndQuestions.categoriesDatas[i].categoryIsActive == true)
            {
                interviewAnswersAndQuestions.categoriesDatas[i].allAnswersAnswered = false;

                for (int j = 0; j < interviewAnswersAndQuestions.categoriesDatas[i].interviewQuestionData.Count; j++)
                {
                    interviewAnswersAndQuestions.categoriesDatas[i].interviewQuestionData[j].QuestionAsked = false;
                }
            }
        }

        _activeInterviewCategories.Clear();
        Debug.Log("All values reseted!");

        // Goes through all data in InterviewAnswersAndQuestions list categoriesDatas and creates deep copies of the categorys
        // that are active and adds them to the GameManagers list _activeInterviewCategories.
        foreach (CategoriesData data in interviewAnswersAndQuestions.categoriesDatas)
        {
            if (data.categoryIsActive == true)
            {
                data.Clone();

                _activeInterviewCategories.Add(data);
            }

        }
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
