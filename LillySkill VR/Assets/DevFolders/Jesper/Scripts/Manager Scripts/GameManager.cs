using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;
using Jesper.GameSettings.Data;
using Jesper.InterviewAnswersAndQuestions.Data;
using Jesper.InterviewQuestionsList.Data;
using static UnityEngine.Timeline.AnimationPlayableAsset;
using System.Linq;
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


    public List<CategoriesData> _questionsAndAnswersCopy;
    public List<Categories> _questionsCopy = new List<Categories>();
    //public List<DefaultCategoryData> _defaultAnswersCopy = new List<DefaultCategoryData>();
    //public List<SituationBasedCategoriesData> _situationBasedAnswersCopy = new List<SituationBasedCategoriesData>();

    //public List<SituationBasedCategoriesData> UsedAnswer = new List<SituationBasedCategoriesData>();


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

        //if (_gameSettings.LoadedScene == "Office")
        //{
        //    //foreach(CategoriesData data in interviewAnswersAndQuestions.categoriesDatas)
        //    //{
        //    //    if (data.categoryIsActive == true)
        //    //    {
        //    //        _questionsAndAnswersCopy.Add(data.Clone());

        //    //    }
        //    //}

        //    //// Loops through the scriptable object and checks which categories are activated
        //    //// and adds them into a new List.
        //    //for (int i = 0; i < interviewQuestionList._questionCategories.Count; i++)
        //    //{
        //    //    if (interviewQuestionList._questionCategories[i].CategoryIsActive == true)
        //    //    {
        //    //        _questionsCopy.Add(interviewQuestionList._questionCategories[i].Clone());
        //    //    }
        //    //}

        //    //for (int i = 0; i < interviewAnswersAndQuestions.categoriesDatas.Length; i++)
        //    //{
        //    //    if (interviewAnswersAndQuestions.categoriesDatas[i].categoryIsActive == true)
        //    //    {

        //    //        _questionsAndAnswersCopy.Add(interviewAnswersAndQuestions.categoriesDatas[i].Clone());
        //    //        _questionsAndAnswersCopy.Add(_questionsAndAnswersCopy[i]);

        //    //    }
        //    //}

        //    //This statement is true if the DefaultCategory are activated.
        //    //if (interviewAnswersList.DefaultCategoryIsActive == true)
        //    //{
        //    //    // Loops through the scriptable object and checks which categories are activated
        //    //    // and adds them into a new List.
        //    //    for (int i = 0; i < interviewAnswersList.defaultCategory.Count; i++)
        //    //    {
        //    //        _defaultAnswersCopy.Add(interviewAnswersList.defaultCategory[i].Clone());
        //    //    }
        //    //}

        //    //// Loops through the scriptable object and checks which categories are activated
        //    //// and adds them into a new List.
        //    //for (int i = 0; i < interviewAnswersList.categories.Count; i++)
        //    //{
        //    //    if (interviewAnswersList.categories[i].CategoryIsActive == true)
        //    //    {
        //    //        _answersCopy.Add(interviewAnswersList.categories[i].Clone());
        //    //    }
        //    //}

        //    //// Loops through the scriptable object and checks which categories are activated
        //    //// and adds them into a new List.
        //    //for (int i = 0; i < interviewAnswersList.SituationBasedCategories.Count; i++)
        //    //{
        //    //    if (interviewAnswersList.SituationBasedCategories[i].CategoryIsActive == true)
        //    //    {
        //    //        _situationBasedAnswersCopy.Add(interviewAnswersList.SituationBasedCategories[i].Clone());
        //    //    }
        //    //}
        //}

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

        Debug.Log("All values reseted!");

        foreach(CategoriesData data in interviewAnswersAndQuestions.categoriesDatas)
        {
            if(data.categoryIsActive == true)
            {
                data.Clone();

                _questionsAndAnswersCopy.Add(data);
            }

        }

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
        foreach (var data in _questionsAndAnswersCopy.GetRange(0, _questionsAndAnswersCopy.Count))
        {
            if (data.allAnswersAnswered == true)
            {
                InterviewAreActive = false;
            }
        }

        //for (int i = 0; i < _questionsAndAnswersCopy.Count; i++)
        //{
        //    if (interviewAnswersAndQuestions.categoriesDatas[interviewAnswersAndQuestions.categoriesDatas.Length].categoryIsActive == true)
        //    {
        //        if (_questionsAndAnswersCopy[i].allAnswersAnswered == true)
        //        {
        //            InterviewAreActive = false;
        //        }
        //    }
        //}
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

    public void GetRandomListIndex()
    {
        if(InterviewAreActive == true)
        {
            _randomListIndex = Random.Range(0, _questionsAndAnswersCopy.Count);

            if (_questionsAndAnswersCopy[_randomListIndex].allAnswersAnswered == false)
            {
                Debug.Log("Random List Index: " + _randomListIndex);
                ReturnRandomListIndex();
            }
            else
            {
                GetRandomListIndex();
            }

            foreach (var data in _questionsAndAnswersCopy[_randomListIndex].interviewQuestionData.GetRange(0, _questionsAndAnswersCopy[_randomListIndex].interviewQuestionData.Count))
            {
                if (data.QuestionAsked == true)
                {
                    _questionsAndAnswersCopy[_randomListIndex].allAnswersAnswered = true;
                }
            }

            //for (int i = 0; i < interviewAnswersAndQuestions.categoriesDatas[RandomListIndex].interviewQuestionData.Count; i++)
            //{
            //    if (listRange[i].QuestionAsked == true)
            //    {

            //    }
            //}
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

    public void GetRandomSubListIndex()
    {
        if(InterviewAreActive == true)
        {
            if (_questionsAndAnswersCopy[_randomListIndex].categoryIsActive == true)
            {
                _randomSubListIndex = Random.Range(0, _questionsAndAnswersCopy[_randomListIndex].interviewQuestionData.Count);
                Debug.Log("Random Sub List Index: " + _randomSubListIndex);
                if (_questionsAndAnswersCopy[_randomListIndex].interviewQuestionData[RandomSubListIndex].QuestionAsked == false)
                {
                    ReturnRandomSubListIndex();
                }
                else
                {
                    GetRandomSubListIndex();
                }
            }

            //foreach(var data in interviewAnswersAndQuestions.categoriesDatas[_randomListIndex].interviewQuestionData)
            //{
            //    if(data.QuestionAsked == false)
            //    {
            //        interviewAnswersAndQuestions.categoriesDatas[_randomListIndex].allAnswersAnswered = true;
            //    }
            //    else
            //    {
            //        return;
            //    }
            //}
        }
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
