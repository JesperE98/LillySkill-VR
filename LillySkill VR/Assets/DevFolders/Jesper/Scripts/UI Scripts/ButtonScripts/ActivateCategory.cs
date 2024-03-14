using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jesper.InterviewAnswerLists.Data;
using Jesper.InterviewQuestionsList.Data;

public class ActivateCategory : MonoBehaviour
{
    [SerializeField]
    private InterviewAnswersListScriptableObject interviewAnswersList;
    [SerializeField]
    private InterviewQuestionsListScriptableObject interviewQuestionsList;

    public void ActivateAnswerCategory(int listIndex)
    {
        interviewAnswersList.categories[listIndex].CategoryIsActive = true;
    }

    public void ActivateQuestionCategory(int listIndex)
    {
        interviewQuestionsList._questionCategories[listIndex].CategoryIsActive = true;
    }

    public void ActivateDefaultMode(int listIndex)
    {
        interviewAnswersList.DefaultCategoryIsActive = true;
        interviewQuestionsList._questionCategories[0].CategoryIsActive = true;
    }
}
