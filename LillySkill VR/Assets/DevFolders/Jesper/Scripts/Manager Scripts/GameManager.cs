using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JespersCode
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager gameManager;

        protected List<string> answerList = new List<string>();
        protected internal float coroutineTimer = 3f;
        private bool fadeInComplete, fadeOutComplete, lillyIntro, lillyOutro,  interviewerIntro, interviewAreActive, 
            feedbackPageActive, summaryPageActive, informationPageActive, easyMode, mediumMode, hardMode;
        private int interviewerInterest, playerScore, loadedScene, answerPageNumber;

        private void Awake()
        {
            if(gameManager == null) 
            { 
                DontDestroyOnLoad(gameObject);
            }
            else 
            { 
                Object.Destroy(gameObject);
            }

            DefaultValues();

            // Will be removed if everything works.
            //lillyIntroDone = true;
            //InterviewerIntroDone = true;
            //AnswerPageNumber = 8;
        }

        /// <summary>
        /// Checks if the Fade in effect are active.
        /// </summary>
        protected internal bool FadeInComplete
        {
            get
            {
                return fadeInComplete;
            }
            set
            {
                fadeInComplete = value;
            }
        }

        /// <summary>
        /// Checks if the Fade Out Effect are active.
        /// </summary>
        protected internal bool FadeOutComplete
        {
            get
            {
                return fadeOutComplete;
            }
            set
            {
                fadeOutComplete = value;
            }
        }

        /// <summary>
        /// Checks if the Lilly Intro are active,
        /// </summary>
        protected internal bool LillyIntro
        {
            get
            {
                return lillyIntro;
            }
            set
            {
                lillyIntro = value;
            }
        }

        /// <summary>
        /// Checks if the Lilly Outro are active.
        /// </summary>
        protected internal bool LillyOutro
        {
            get
            {
                return lillyOutro;
            }
            set
            {
                lillyOutro = value;
            }
        }

        /// <summary>
        /// Checks if the Interviewer introduction are active.
        /// </summary>
        protected internal bool InterviewerIntro
        {
            get
            {
                return interviewerIntro;
            }
            set
            {
                interviewerIntro = value;
            }
        }

        /// <summary>
        /// Gets and sets bool value that determines if a interview is active.
        /// </summary>
        protected internal bool InterviewAreActive 
        {
            get 
            {
                return interviewAreActive;
            }
            set 
            {
                interviewAreActive = value;
            }
        }

        /// <summary>
        /// Gets and sets bool value that determines if a interview is active.
        /// </summary>
        protected internal bool FeedbackPageActive
        {
            get
            {
                return feedbackPageActive;
            }
            set
            {
                feedbackPageActive = value;
            }
        }

        /// <summary>
        /// Gets and sets bool value that determines if a interview is active.
        /// </summary>
        protected internal bool SummaryPageActive
        {
            get
            {
                return summaryPageActive;
            }
            set
            {
                summaryPageActive = value;
            }
        }

        /// <summary>
        /// Gets and sets bool value for initiating Easy Mode interview.
        /// </summary>
        protected internal bool EasyMode
        {
            get
            {
                return easyMode;
            }
            set
            {
                easyMode = value;
            }
        }

        /// <summary>
        /// Gets and sets bool value for initiating Medium Mode interview.
        /// </summary>
        protected internal bool MediumMode
        {
            get
            {
                return mediumMode;
            }
            set
            {
                mediumMode = value;
            }
        }

        /// <summary>
        /// Gets and sets bool value for initiating Hard Mode interview.
        /// </summary>
        protected internal bool HardMode
        {
            get
            {
                return hardMode;
            }
            set
            {
                hardMode = value;
            }
        }

        /// <summary>
        /// Gets and sets int value to controll Interviewer NPC animations.
        /// </summary>
        protected internal int InterviewerInterest
        {
            get
            {
                return interviewerInterest;
            }
            set
            {
                interviewerInterest = value;
            }
        }

        /// <summary>
        /// Gets and sets int value to controll what feedback text should be displayed.
        /// </summary>
        protected internal int PlayerScore
        {
            get
            {
                return playerScore;
            }
            set
            {
                playerScore = value;
            }
        }

        /// <summary>
        /// Gets and sets int value for each individual scene and what Game mode it should be.
        /// </summary>
        protected internal int LoadedScene
        {
            get
            {
                return loadedScene;
            }
            set
            {
                loadedScene = value;
            }
        }

        /// <summary>
        /// Gets and sets int value to determine which answer page the user are on and controlls which ansers that should be given to the user.
        /// </summary>
        protected internal int AnswerPageNumber
        {
            get
            {
                return answerPageNumber;
            }
            set
            {
                answerPageNumber = value;
            }
        }

        protected internal bool InformationPageActive
        {
            get
            {
                return informationPageActive;
            }
            set
            {
                informationPageActive = value;
            }
        }

        /// <summary>
        /// A List that stores all the wrong answers.
        /// </summary>
        protected internal List<string> AnswerList 
        {
            get 
            {
                return answerList;
            } 
            set 
            {
                answerList = value;
            } 
        }
        
        /// <summary>
        /// Method with default values if user wants to restart current active scene.
        /// </summary>
        protected internal void DefaultValues()
        {
            lillyIntro = false;
            lillyOutro = false;
            interviewerIntro = false;
            loadedScene = 1;
            easyMode = true;
            interviewerInterest = 2;
            answerPageNumber = 1;
            playerScore = 0;
            feedbackPageActive = false;
            summaryPageActive = false;
            informationPageActive = false;
            answerList.Clear();
            fadeInComplete = false;
            fadeOutComplete = false;
        }

        /// <summary>
        /// Method that stores wrong answers to a list.
        /// </summary>
        /// <param name="text"></param>
        public virtual void AddAnswerToList(string text)
        {
            answerList.Add(text);
        }

        /// <summary>
        /// IEnumerator that starts the interview.
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerator InterviewIntro()
        {
            yield return new WaitForSeconds(coroutineTimer);
            interviewAreActive = true;
        }
    }
}
