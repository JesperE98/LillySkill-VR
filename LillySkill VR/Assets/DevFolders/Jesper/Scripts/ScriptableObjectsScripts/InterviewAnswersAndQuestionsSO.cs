using Jesper.InterviewQuestionsList.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using static UnityEngine.UI.Image;

namespace Jesper.InterviewAnswersAndQuestions.Data
{
    /// <summary>
    /// ScriptableObject Class that contains Lists with answers.
    /// </summary>
    [CreateAssetMenu(fileName = "InterviewAnswersAndQuestionsSO", menuName = "ScriptableObjects/InterviewAnswersAndQuestionsSO", order = 2)]
    public class InterviewAnswersAndQuestionsSO : ScriptableObject
    {
        /// <summary>
        /// Contains a list with each category which itself contains it's own answers.
        /// </summary>
        [Tooltip("Contains a list with each category which itself contains it's own answers.")]
        public CategoriesData[] interviewCategories;
    }
}

