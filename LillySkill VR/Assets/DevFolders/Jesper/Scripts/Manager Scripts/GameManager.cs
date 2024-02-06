using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JespersCode
{
    public class GameManager : MonoBehaviour
    {
        protected List<string> answerList = new List<string>();

        /// <summary>
        /// Gets and sets bool value that determines if a interview is active.
        /// </summary>
        public bool InterviewAreActive { get; set; }

        /// <summary>
        /// Gets and sets bool value that determines if a interview is active.
        /// </summary>
        public bool FeedbackPageActive { get; set; }

        /// <summary>
        /// Gets and sets bool value that determines if a interview is active.
        /// </summary>
        public bool SummaryPageActive { get; set; }

        /// <summary>
        /// Gets and sets bool value for initiating Easy Mode interview.
        /// </summary>
        public bool EasyMode { get; set; }

        /// <summary>
        /// Gets and sets bool value for initiating Medium Mode interview.
        /// </summary>
        public bool MediumMode { get; set; }

        /// <summary>
        /// Gets and sets bool value for initiating Hard Mode interview.
        /// </summary>
        public bool HardMode { get; set; }

        /// <summary>
        /// Gets and Sets bool value for UI Buttons.
        /// </summary>
        public bool UsedWorstAnswer { get; set; }

        /// <summary>
        /// Gets and Sets bool value UI Buttons.
        /// </summary>
        public bool UsedBadAnswer { get; set; }

        /// <summary>
        /// Gets and Sets bool value UI Buttons.
        /// </summary>
        public bool UsedAverageAnswer { get; set; }

        /// <summary>
        /// Gets and Sets bool value UI Buttons.
        /// </summary>
        public bool UsedGoodAnswer { get; set; }

        /// <summary>
        /// Gets and Sets bool value UI Buttons.
        /// </summary>
        public bool UsedBestAnswer { get; set; }

        /// <summary>
        /// Gets and sets int value to controll Interviewer NPC animations.
        /// </summary>
        public int InterviewerInterest { get; set; }

        /// <summary>
        /// Gets and sets int value to controll what feedback text should be displayed.
        /// </summary>
        public int PlayerScore { get; set; }

        /// <summary>
        /// Gets and sets int value for each individual scene and what Game mode it should be.
        /// </summary>
        public int LoadedScene { get; set; }

        /// <summary>
        /// Gets and sets int value to determine which answer page the user are on and controlls which ansers that should be given to the user.
        /// </summary>
        public int AnswerPageNumber { get; set; }

        public List<string> AnswerList 
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

       
        public void AddAnswerToList(string text)
        {

            answerList.Add(text);
        }
    }
}
