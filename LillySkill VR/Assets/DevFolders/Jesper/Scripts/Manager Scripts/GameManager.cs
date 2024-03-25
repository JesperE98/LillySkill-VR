using JesperScriptableObject;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameSettingsScriptableObject m_GameSettingsScriptableObject;

    protected List<string> _answerList = new List<string>();
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
        if(PlayerScore > m_GameSettingsScriptableObject.PlayerHighScore)
        {
            m_GameSettingsScriptableObject.PlayerHighScore = PlayerScore;
        }

        InterviewerInterest = Mathf.Clamp(InterviewerInterest, 1, 5);
        // If statements to make sure the value stays between the values 1 to 5.
        //if (interviewerInterest >= 5)
        //    interviewerInterest = 5;
        //else if (interviewerInterest <= 1)
        //    interviewerInterest = 1;
    }

    /// <summary>
    /// Method with default values if user wants to restart current active scene.
    /// </summary>
    public virtual void DefaultValues()
    {
        m_GameSettingsScriptableObject.defaultMode = true;
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
