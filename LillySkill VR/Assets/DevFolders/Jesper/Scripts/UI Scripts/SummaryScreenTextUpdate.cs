using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.Timeline.AnimationPlayableAsset;

namespace JespersCode
{
    public class SummaryScreenTextUpdate : MonoBehaviour
    {
        private GameManager gameManager;
        private bool loopDone = false;
        private TMP_Text answerText;
        // Start is called before the first frame update
        void Start()
        {
            gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
            SummaryPageText();
        }

        private void SummaryPageText()
        {
            if (loopDone == false)
            {
                for (int i = 0; i < gameManager.AnswerList.Count; i++)
                {
                    answerText.text += gameManager.AnswerList[i] + "\n";
                }
                loopDone = true;
            }
        }
    }
}

