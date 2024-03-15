using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;
using Jesper.GameSettings.Data;
using Jesper.InterviewAnswerLists.Data;
using Jesper.InterviewQuestionsList.Data;
using System;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameSettingsScriptableObject _gameSettings;
    [SerializeField]
    private InterviewAnswersListScriptableObject interviewAnswersList;
    [SerializeField]
    private InterviewQuestionsListScriptableObject interviewQuestionList;

    
    [SerializeField]
    protected List<string> _answerList = new List<string>();
    [SerializeField]
    private List<Categories> _questions = new List<Categories>();

    private int _playerScore = 0;
    private int _interviewerInterest = 2;
    private int _answerPageNumber = 1;
    private bool _fadeInComplete = false;
    private bool _fadeOutComplete = false;
    private bool _lillyIntroDone = false;
    private bool _lillyOutroDone = false;
    private bool _interviewerIntro = false;
    private bool _interviewAreActive = false;
    private bool _informationPageActive = false;

    private void Awake()
    {
        if (_gameSettings.LoadedScene == "Office")
        {
            Debug.Log("Starting for loop");
            for (int i = 0; i < interviewQuestionList._questionCategories.Count; i++)
            {
                if (interviewQuestionList._questionCategories[i].CategoryIsActive == true)
                {
                    _questions.Add(interviewQuestionList._questionCategories[i]);
                }
                Debug.Log("Added: " + interviewQuestionList._questionCategories[i] + " to new list");
            }

            Debug.Log("For Loop done");
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
    public int PlayerScore
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

    public bool InformationPageActive 
    { 
        get 
        { 
            return _informationPageActive;
        } 
        set
        { 
            _informationPageActive = value;
        } 
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


}
