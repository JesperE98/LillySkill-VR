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
        private bool fadeInComplete, fadeOutComplete, lillyIntroDone, interviewerIntroDone, interviewAreActive, 
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
        }

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

        protected internal bool LillyIntroDone
        {
            get
            {
                return lillyIntroDone;
            }
            set
            {
                lillyIntroDone = value;
            }
        }

        protected internal bool InterviewerIntroDone
        {
            get
            {
                return interviewerIntroDone;
            }
            set
            {
                interviewerIntroDone = value;
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
        
        protected internal void DefaultValues()
        {
            lillyIntroDone = false;
            interviewerIntroDone = false;
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

        public virtual void AddAnswerToList(string text)
        {
            answerList.Add(text);
        }

        public virtual IEnumerator InterviewIntro()
        {
            yield return new WaitForSeconds(coroutineTimer);
            interviewAreActive = true;
        }
    }
}
