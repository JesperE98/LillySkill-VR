using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

namespace Jesper.InterviewQuestionsList.Data
{
    /// <summary>
    /// ScriptableObject Class that cointains a List with all the interview questions.
    /// </summary>
    [CreateAssetMenu(fileName = "InterviewQuestionsListData", menuName = "ScriptableObjects/InterviewQuestionsListScriptableObject", order = 1)]
    public class InterviewQuestionsListScriptableObject : ScriptableObject
    {
        [Tooltip("Contains a list with each category which itself contains it's own questions")]
        public List<Categories> _questionCategories;
    }

    /// <summary>
    /// Contains all the interview question text data.
    /// </summary>
    [System.Serializable]
    public class Categories
    {
        [Tooltip("Name the category. (Optional)")]
        public CategoryName CategoryName;
        [Tooltip("Add a description for the categorie. (Optional)")]
        public string Description;
        public bool CategoryIsActive = false;

        /// <summary>
        /// List that contains all the interview questions from the exercise section.
        /// </summary>
        public List<string> m_QuestionList = new List<string>();

        /// <summary>
        /// Clones the original list.
        /// </summary>
        /// <returns></returns>
        public Categories Clone()
        {
            return new Categories
            {
                CategoryName = this.CategoryName,
                Description = this.Description,
                CategoryIsActive = this.CategoryIsActive,
                m_QuestionList = new List<string>(this.m_QuestionList)
            };
        }
    }

    /// <summary>
    /// Enum to specify the category name.
    /// </summary>
    public enum CategoryName
    {
        Default, AnalyticalThinking, Adaptability, Customization, DecisionMaking,
        Empathy, EthicsAndIntegrity, Flexibility, CommunicationSkills, CollaborativeSkills,
        ProblemSolving, Accuracy, SelfLeadership, InitiativeTaking, TimeManagement,
        Creativity, StreesResistence, PossitiveAttitude, Leadership, Endurance,
        WarehouseWork, RestaurantEmployee, CustomerServiceAndAdmin, HousekeepingAndHomeCleaning, ProductionAndFitter
    }

    public enum QuestionAnswered
    {
        Yes,
        No
    }
}

