using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jesper.InterviewAnswersAndQuestions.Data;
using System;
using Unity.VisualScripting;

namespace Jesper.Collection
{
    public class ActivateCategory : MonoBehaviour
    {
        [SerializeField]
        private InterviewAnswersAndQuestionsSO interviewAnswersAndQuestions;
        [SerializeField]
        private VoiceAudioDataBankScriptableObject voiceAudioDataBankScriptableObject;
        [SerializeField]
        private GameObject _checkMark;
        private bool activateDeactivateQuestionCategory = false;


        public void Activate(int listIndex)
        {
            var categoryUI = interviewAnswersAndQuestions.interviewCategories[listIndex];
            var categoryAudio = voiceAudioDataBankScriptableObject.questions[listIndex];

            if (listIndex < 0)
            {
                Debug.LogWarning("The given value isn't a valid number: " + listIndex);
                return;
            }

            if (activateDeactivateQuestionCategory == false)
            {
                categoryUI.categoryIsActive = true;
                categoryAudio.audioCategoryIsActive = true;
                _checkMark.SetActive(true);
                activateDeactivateQuestionCategory = true;
            }
            else if (activateDeactivateQuestionCategory == true)
            {
                categoryUI.categoryIsActive = false;
                categoryAudio.audioCategoryIsActive = false;
                _checkMark.SetActive(false);
                activateDeactivateQuestionCategory = false;
            }
        }
    }
}

