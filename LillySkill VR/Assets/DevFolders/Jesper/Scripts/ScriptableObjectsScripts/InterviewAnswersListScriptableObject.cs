using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

namespace Jesper.InterviewAnswerLists.Data
{
    /// <summary>
    /// ScriptableObject Class that contains Lists with answers.
    /// </summary>
    [CreateAssetMenu(fileName = "InterviewAnswersListData", menuName = "ScriptableObjects/InterviewAnswersListScriptableObject", order = 2)]
    public class InterviewAnswersListScriptableObject : ScriptableObject
    {
        /// <summary>
        /// Determines if the default category are active or not.
        /// </summary>
        [Tooltip("Determines if the default category are active.")]
        public bool DefaultCategoryIsActive = false;

        /// <summary>
        /// Contains a list with the default answers from Version 0.1.0 which itself contains it's own answers.
        /// </summary>
        [Tooltip("Contains a list with the default answers from Version 0.1.0 which itself contains it's own answers.")]
        public List<DefaultCategoryData> defaultCategory = new List<DefaultCategoryData>();

        /// <summary>
        /// Contains a list with each category which itself contains it's own answers.
        /// </summary>
        [Tooltip("Contains a list with each category which itself contains it's own answers.")]
        public List<CategoriesData> categories = new List<CategoriesData>();

        /// <summary>
        /// Contains a list with each category which itself contains it's own answers.
        /// </summary>
        [Tooltip("Contains a list with each category which itself contains it's own answers.")]
        public List<SituationBasedCategoriesData> SituationBasedCategories = new List<SituationBasedCategoriesData>();
    }

    /// <summary>
    /// Contains the default category with the interview answer text data.
    /// </summary>
    [System.Serializable]
    public class DefaultCategoryData
    {
        [Tooltip("What question the answers are for. (Optional)")]
        public string QuestionNumber;

        /// <summary>
        /// Contains all the bad answers.
        /// </summary>
        [Tooltip("Contains all the bad answers.")]
        public InterviewAnswer AnswerA;

        /// <summary>
        /// Contains all the average answers.
        /// </summary>
        [Tooltip("Contains all the average answers.")]
        public InterviewAnswer AnswerB;

        /// <summary>
        /// Contains all the good answers.
        /// </summary>
        [Tooltip("Contains all the good answers.")]
        public InterviewAnswer AnswerC;
    }

    /// <summary>
    /// Contains all the categories for the interview answer text data.
    /// </summary>
    [System.Serializable]
    public class CategoriesData
    {
        [Tooltip("Name the category. (Optional)")]
        [SerializeField]
        private CategoryName CategoryName;
        [Tooltip("Add a description for the categorie. (Optional)")]
        [SerializeField]
        private string Description;
        public bool CategoryIsActive = false;

        public List<AnswersData> m_Answers;
    }

    /// <summary>
    /// Contains all the situation based categories for the interview answer text data.
    /// </summary>
    [System.Serializable]
    public class SituationBasedCategoriesData
    {
        [Tooltip("Name the category. (Optional)")]
        [SerializeField]
        private CategoryName CategoryName;
        [Tooltip("Add a description for the categorie. (Optional)")]
        [SerializeField]
        private string Description;
        public bool CategoryIsActive = false;

        public List<SituationBasedAnswersData> m_Answers;
    }

    /// <summary>
    /// Contains all the answer alternatives.
    /// </summary>
    [System.Serializable]
    public class AnswersData
    {
        [Tooltip("What question the answers are for. (Optional)")]
        public string QuestionNumber;
        [Tooltip("Choose which answer that is correct.")]
        public CorrectAnswerData CorrectAnswer;

        /// <summary>
        /// Answer alternative A
        /// </summary>
        [Tooltip("Answer alternative A")]
        public string A;

        /// <summary>
        /// Answer alternative B.
        /// </summary>
        [Tooltip("Answer alternative B")]
        public string B;

        /// <summary>
        /// Answer alternative C.
        /// </summary>
        [Tooltip("Answer alternative C")]
        public string C;

        /// <summary>
        /// Answer alternative D.
        /// </summary>
        [Tooltip("Answer alternative D")]
        public string D;
    }

    /// <summary>
    /// Contains all the answer alternatives.
    /// </summary>
    [System.Serializable]
    public class SituationBasedAnswersData
    {
        [Tooltip("What question the answers are for. (Optional)")]
        public string QuestionNumber;

        /// <summary>
        /// Answer alternative A
        /// </summary>
        [Tooltip("Answer alternative A")]
        public InterviewAnswer A;

        /// <summary>
        /// Answer alternative B.
        /// </summary>
        [Tooltip("Answer alternative B")]
        public InterviewAnswer B;

        /// <summary>
        /// Answer alternative C.
        /// </summary>
        [Tooltip("Answer alternative C")]
        public InterviewAnswer C;

        /// <summary>
        /// Answer alternative D.
        /// </summary>
        [Tooltip("Answer alternative D")]
        public InterviewAnswer D;
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

    /// <summary>
    /// Class to represent an answer option.
    /// </summary>
    [Serializable]
    public class InterviewAnswer
    {
        public string AnswerText;
        [Tooltip("Choose what answer type the answer is")]
        public AnswerTypeData AnswerType;
    }

    /// <summary>
    /// Enum to indicate answer quality (bad, average, good).
    /// </summary>
    public enum AnswerTypeData
    {
        Bad,
        Average,
        Good
    }

    /// <summary>
    /// Enum to specify the correct answer.
    /// </summary>
    public enum CorrectAnswerData
    {
        None,
        A,
        B,
        C,
        D,
        All
    }
}

