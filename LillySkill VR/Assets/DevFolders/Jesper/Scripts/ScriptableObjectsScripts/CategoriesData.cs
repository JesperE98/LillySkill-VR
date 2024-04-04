using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jesper.InterviewAnswersAndQuestions.Data
{
    [CreateAssetMenu(fileName = "CategoriesData", menuName = "ScriptableObjects/InterviewAnswersAndQuestionsSO/CategoriesData", order = 0)]
    public class CategoriesData : ScriptableObject
    {

        [Tooltip("Name the category. (Optional)")]
        public CategoryName categoryName;
        /// <summary>
        /// Choose if the category has regular or situational questions.
        /// </summary>
        [Tooltip("Choose if the category has regular or situational questions.")]
        public InterviewCategoryType interviewCategoryType;
        [Tooltip("Add a description for the categorie. (Optional)")]
        [SerializeField]
        private string description;
        /// <summary>
        /// On/Off switch for the category.
        /// </summary>
        [Tooltip("On/Off switch for the category.")]
        public bool categoryIsActive = false;
        [Tooltip("On/Off switch for the category.")]
        public bool allAnswersAnswered = false;

        [Tooltip("Contains the category questions and answers.")]
        public List<InterviewQuestion> interviewQuestionData;

        /// <summary>
        /// Clones the original Categories Data List.
        /// </summary>
        /// <returns></returns>
        public CategoriesData Clone()
        {
            CategoriesData copy = CreateInstance<CategoriesData>();
            copy.interviewCategoryType = this.interviewCategoryType;
            copy.categoryName = this.categoryName;
            copy.description = this.description;
            copy.categoryIsActive = this.categoryIsActive;
            copy.interviewQuestionData = new List<InterviewQuestion>(this.interviewQuestionData);
            return copy;
        }

        /// <summary>
        /// Enum to differentiate between regular and situational categories.
        /// </summary>
        public enum InterviewCategoryType
        {
            Regular,
            Situational
        }

        /// <summary>
        /// Class to hold question data, including question text and reference number.
        /// </summary>
        [Serializable]
        public class InterviewQuestion
        {
            public bool QuestionAsked = false;
            public string QuestionText;
            /// <summary>
            /// Chooses the correct answer.
            /// </summary>
            [Tooltip("Choose the correct answer. (If the category type is regular).")]
            public CorrectAnswer correctAnswer;
            /// <summary>
            /// Array that contains the answers.
            /// </summary>
            [Tooltip("Contains the answers to the question.")]
            public InterviewAnswer[] answers;
        }

        /// <summary>
        /// Class to represent an answer option.
        /// </summary>
        [Serializable]
        public class InterviewAnswer
        {
            public string AnswerAlternative;
            public string AnswerText;
            [Tooltip("Define the answer quality. (If the category type are situational).")]
            public AnswerType answerType;
        }

        /// <summary>
        /// Enum to indicate answer quality (bad, average, good).
        /// </summary>
        [Serializable]
        public enum AnswerType
        {
            Bad,
            Average,
            Good
        }

        /// <summary>
        /// Enum to specify the correct answer.
        /// </summary>
        [Flags]
        [Serializable]
        public enum CorrectAnswer
        {
            A = 1,
            B = 2,
            C = 4,
            D = 8
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
    }

}
