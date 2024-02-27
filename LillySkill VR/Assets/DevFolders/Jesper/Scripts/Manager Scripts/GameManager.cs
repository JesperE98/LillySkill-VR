using JesperScriptableObject;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameSettingsScriptableObject m_GameSettingsScriptableObject;

    protected List<string> answerList = new List<string>();
    protected internal int playerScore, interviewerInterest, answerPageNumber;
    protected internal bool fadeInComplete, lillyIntro, lillyOutro, interviewerIntro, interviewAreActive, informationPageActive;

    /// <summary>
    /// Gets and sets int value to determine which answer page the user are on and controlls which ansers that should be given to the user.
    /// </summary>
    public int AnswerPageNumber { get { return answerPageNumber; } set { answerPageNumber = value; } }

    /// <summary>
    /// A List that stores all the wrong answers.
    /// </summary>
    protected internal List<string> AnswerList { get { return answerList; } set { answerList = value; } }

    /// <summary>
    /// Checks if the Fade in effect are active.
    /// </summary>
    public bool FadeInComplete { get { return fadeInComplete; } set { fadeInComplete = value; } }

    /// <summary>
    /// Checks if the Lilly Intro are active,
    /// </summary>
    public bool LillyIntro { get { return lillyIntro; } set { lillyIntro = value; } }

    /// <summary>
    /// Checks if the Lilly Outro are active.
    /// </summary>
    public bool LillyOutro { get { return lillyOutro; } set { lillyOutro = value; } }

    /// <summary>
    /// Checks if the Interviewer introduction are active.
    /// </summary>
    public bool InterviewerIntro { get { return interviewerIntro; } set { interviewerIntro = value; } }

    /// <summary>
    /// Gets and sets bool value that determines if a interview is active.
    /// </summary>
    public bool InterviewAreActive { get { return interviewAreActive; } set { interviewAreActive = value; } }

    public bool InformationPageActive { get { return informationPageActive; } set { informationPageActive = value; } }


    /// <summary>
    /// Gets and sets int value to controll Interviewer NPC animations.
    /// </summary>
    public int InterviewerInterest { get { return interviewerInterest; } set { interviewerInterest = value; } }

    /// <summary>
    /// Gets and sets int value to controll what feedback text should be displayed.
    /// </summary>
    public int PlayerScore 
    { 
        get 
        { 
            if(playerScore > m_GameSettingsScriptableObject.PlayerHighScore)
            {
                return m_GameSettingsScriptableObject.PlayerHighScore;
            }
            else
            {
                return playerScore;
            }
            
        } 
        set 
        { 
            playerScore = value; 
        } 
    }

    void Awake()
    {
        DefaultValues();
    }

    private void Update()
    {
        // If statements to make sure the value stays between the values 1 to 5.
        if (interviewerInterest >= 5)
            interviewerInterest = 5;
        else if (interviewerInterest <= 1)
            interviewerInterest = 1;
    }

    /// <summary>
    /// Method with default values if user wants to restart current active scene.
    /// </summary>
    protected internal void DefaultValues()
    {
        lillyIntro = false;
        lillyOutro = false;
        interviewerIntro = false;
        interviewAreActive = false;
        m_GameSettingsScriptableObject.loadedScene = 1;
        m_GameSettingsScriptableObject.defaultMode = true;
        interviewerInterest = 2;
        answerPageNumber = 0;
        playerScore = 0;
        informationPageActive = false;
        answerList.Clear();
        fadeInComplete = false;
    }

    /// <summary>
    /// Method that stores wrong answers to a list.
    /// </summary>
    /// <param name="text"></param>
    public virtual void AddAnswerToList(string text)
    {
        answerList.Add(text);
    }
}
