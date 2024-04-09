using Jesper.GameSettings.Data;
using Jesper.InterviewAnswersAndQuestions.Data;
using System;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace Jesper.Collection
{
    public class SummaryScreenTextUpdate : MonoBehaviour
    {
        private GameManager gameManager;
        private GameObject objCopy;
        
        [SerializeField]
        private GameSettingsScriptableObject gameSettings;
        [SerializeField]
        private InterviewAnswersAndQuestionsSO interviewAnswersAndQuestions;
        [SerializeField]
        private TMP_Text informationText;
        /// <summary>
        /// Instantiate a GameObject per active interview category.
        /// </summary>
        [Tooltip("Add a button GameObject to instantiate per active category.")]
        [SerializeField]
        private GameObject obj, subMenu, buttonTransform;
        [SerializeField]
        private List<GameObject> objCopyList = new List<GameObject>();

        /// <summary>
        /// Contains copies of the active interview categories.
        /// </summary>
        [Tooltip("List that contains copies of each active interview category.")]
        [SerializeField]
        private List<CategoriesData> categories = new List<CategoriesData>();

        void Start()
        {
            switch(gameSettings.GetScene)
            {
                case GameSettingsScriptableObject.LoadedScene.Office:
                    gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
                    break;
            }

            foreach(var activeCategory in interviewAnswersAndQuestions.interviewCategories)
            {
                if(activeCategory.categoryIsActive == true)
                {
                    activeCategory.Clone();

                    categories.Add(activeCategory);
                }
            }
            SummaryPageText();
        }

        private void SummaryPageText()
        {
            for(int i = 0; i < categories.Count; i++)
            {
                Vector3 positionOffset = new Vector3(0.0f, i * 0.04f, 0.0f);

                objCopy = Instantiate(obj, buttonTransform.transform);
                objCopy.transform.position -= positionOffset;

                objCopyList.Add(objCopy);

                objCopyList[i].GetComponentInChildren<TMP_Text>().text = categories[i].categoryName.ToString();
            }
            obj.SetActive(false);

            
        }

        public void ButtonPressed()
        {
            for (int i = 0; i < gameManager.AnswerList.Count; i++)
            {
                //if (objCopyList[i].GetComponentInChildren<TMP_Text>().text == gameManager.AnswerList[i].categoryName.ToString())
                //{
                    
                //}

                //for (int j = 0; gameManager.AnswerList[i].answerListTexts.Count; j++)
                //{
                //    informationText.text += gameManager.AnswerList[i].answerListTexts[j] + "\n";
                //}
            }


            subMenu.SetActive(true);
        }
    }
}

