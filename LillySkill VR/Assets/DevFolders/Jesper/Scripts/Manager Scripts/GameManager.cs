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

        public bool InterviewAreActive { get; set; }
        public bool EasyMode { get; set; }
        public bool MediumMode { get; set; }
        public bool HardMode { get; set; }
        public bool UsedWorstAnswer { get; set; }
        public bool UsedBadAnswer { get; set; }
        public bool UsedAverageAnswer { get; set; }
        public bool UsedGoodAnswer { get; set; }
        public bool UsedBestAnswer { get; set; }
        public int InterviewerInterest { get; set; }
        public int PlayerScore { get; set; }
        public int LoadedScene { get; set; }
    }

}
