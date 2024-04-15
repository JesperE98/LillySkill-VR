using Jesper.InterviewAnswersAndQuestions.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CategoryPageCategoryIsActive : MonoBehaviour
{
    /// <summary>
    /// InterviewAnswersAndQuestionsSO variable containing all the data.
    /// </summary>
    [Tooltip("Add the InterviewAnswersAndQuestionsSO Sciptable Object.")]
    [SerializeField]
    private InterviewAnswersAndQuestionsSO answersAndQuestionsSO;

    [SerializeField]
    private GameObject startButton;
    void Start()
    {
        startButton.SetActive(false);
    }

    void Update()
    {
        bool allCategoriesInactive = true;
        // Enables the start button box collider on the category Page UI ONLY IF,
        // the user has selected at least one category. If the user hasen't selected any category yet,
        // the box collied should NOT be enabled.
        foreach(var category in answersAndQuestionsSO.interviewCategories)
        {
            if(category.categoryIsActive)
            {
                allCategoriesInactive = false;
                startButton.SetActive(true);
            }
        }

        if (allCategoriesInactive)
        {
            startButton.SetActive(false);
        }
    }
}
