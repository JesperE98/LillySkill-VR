using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jesper.InterviewAnswersAndQuestions.Data;
using Jesper.InterviewQuestionsList.Data;
using System;

namespace Jesper.Collection
{
    public class ActivateCategory : MonoBehaviour
    {
        [SerializeField]
        private InterviewAnswersAndQuestions.Data.InterviewAnswersAndQuestionsSO interviewAnswersList;
        [SerializeField]
        private InterviewQuestionsListScriptableObject interviewQuestionsList;
        [SerializeField]
        private GameObject _checkMark;
        private bool activateDeactivateAnswerCategory = false;
        private bool activateDeactivateQuestionCategory = false;
        private bool activateDeactivateDefaultMode = false;

        public void ActivateAnswerCategory(int listIndex)
        {
            //if (activateDeactivateAnswerCategory == false)
            //{
            //    interviewAnswersList.categories[listIndex].CategoryIsActive = true;
            //    _checkMark.SetActive(true);
            //    activateDeactivateAnswerCategory = true;
            //}
            //else if(activateDeactivateAnswerCategory == true)
            //{
            //    interviewAnswersList.categories[listIndex].CategoryIsActive = false;
            //    _checkMark.SetActive(false);
            //    activateDeactivateAnswerCategory = false;
            //}
        }

        public void ActivateQuestionCategory(int listIndex)
        {
            if (activateDeactivateQuestionCategory == false)
            {
                interviewQuestionsList._questionCategories[listIndex].CategoryIsActive = true;
                _checkMark.SetActive(true);
                activateDeactivateQuestionCategory = true;
            }
            else if (activateDeactivateQuestionCategory == true)
            {
                interviewQuestionsList._questionCategories[listIndex].CategoryIsActive = false;
                _checkMark.SetActive(false);
                activateDeactivateQuestionCategory = false;
            }
        }

        public void ActivateDefaultMode(int listIndex)
        {
            //if (activateDeactivateDefaultMode == false)
            //{
            //    interviewAnswersList.DefaultCategoryIsActive = true;
            //    interviewQuestionsList._questionCategories[listIndex].CategoryIsActive = true;
            //    _checkMark.SetActive(true);
            //    activateDeactivateDefaultMode = true;
            //}
            //else if (activateDeactivateDefaultMode == true)
            //{
            //    interviewAnswersList.DefaultCategoryIsActive = false;
            //    interviewQuestionsList._questionCategories[listIndex].CategoryIsActive = false;
            //    _checkMark.SetActive(false);
            //    activateDeactivateDefaultMode = false;
            //}
        }
    }
}

