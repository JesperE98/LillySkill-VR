using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JespersCode
{
    public class GameManager : MonoBehaviour
    {
        protected static GameManager _gameManager;

        private void Awake()
        {
            if (_gameManager == null)
            {
                _gameManager = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
        /// <summary>
        /// Get and Set property that checks if an interview are still active.
        /// </summary>
        public bool InterviewAreActive { get; set; }
        /// <summary>
        /// Get and Set property that initiates EasyMode interview.
        /// </summary>
        public bool EasyMode { get; set; }

        /// <summary>
        /// Get and Set property that initiates MediumMode interview.
        /// </summary>
        public bool MediumMode { get; set; }

        /// <summary>
        /// Get and Set property that initiates HardMode interview.
        /// </summary>
        public bool HardMode { get; set; }

        /// <summary>
        /// Get and Set property that checks if the user used the worst possible answer to the interviewer.
        /// </summary>
        public bool UsedWorstAnswer { get; set; }

        /// <summary>
        /// Get and Set property that checks if the user used a bad answer to the interviewer.
        /// </summary>
        public bool UsedBadAnswer { get; set; }

        /// <summary>
        /// Get and Set property that checks if the user used an average answer to the interviewer.
        /// </summary>
        public bool UsedAverageAnswer { get; set; }

        /// <summary>
        /// Get and Set property that checks if the user used a good answer to the interviewer.
        /// </summary>
        public bool UsedGoodAnswer { get; set; }

        /// <summary>
        /// Get and Set property that checks if the user used the best possible answer to the interviewer.
        /// </summary>
        public bool UsedBestAnswer { get; set; }

        /// <summary>
        /// Get and Set property that determines how interested the interviewer are and controlls the NPC animator.
        /// </summary>
        public int InterviewerInterest { get; set; }

        /// <summary>
        /// Get and Set property that determines what feedback the user should get based on the PlayerScore value.
        /// </summary>
        public int PlayerScore { get; set; }

        /// <summary>
        /// Get and Set property that checks what scene that is currently loaded.
        /// </summary>
        public int LoadedScene { get; set; }
    }

}
