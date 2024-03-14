using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Jesper.InterviewAnswerLists.Data;
using Jesper.GameSettings.Data;


namespace Jesper.Collection
{
    public class AnswerScreenTextUpdate : MonoBehaviour
    {
        private GameManager gameManager;
        private UIManager uiManager;

        [SerializeField]
        private GameSettingsScriptableObject _gameSettings;
        [SerializeField]
        private InterviewAnswersListScriptableObject _interviewAnswerLists;
        [Tooltip("Generic List to store parent objects for the answertexts")]
        [SerializeField]
        private List<GameObject> AnswerTextObject = new List<GameObject>();
        [Tooltip("Generic TMP_Text List to store TMP_Text components")]
        [SerializeField]
        private List<TMP_Text> textList = new List<TMP_Text>();

        void Awake()
        {
            gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
            uiManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
        }


        void Update()
        {
            if (gameManager.InterviewAreActive == true)
            {
                //UpdateAnswerScreenText();
            }
        }

        //private void UpdateAnswerScreenText()
        //{
        //    switch (_gameSettings.defaultMode)
        //    {
        //        case true:
        //            switch (gameManager.AnswerPageNumber)
        //            {
        //                case 1:
        //                    if (uiManager.uiPrefabCopyList[1].activeSelf == true)
        //                    {
        //                        if (AnswerTextObject[0].activeSelf == true)
        //                        {// bra svar
        //                            textList[0].text = _interviewAnswerLists.defaultCategory[0].m_InterviewGoodAnswer;
        //                        }
        //                        else if (AnswerTextObject[1].activeSelf == true)
        //                        {// dåligt svar
        //                            textList[1].text = _interviewAnswerLists.defaultCategory[0].m_InterviewBadAnswer;
        //                        }
        //                        else if (AnswerTextObject[2].activeSelf == true)
        //                        { // helt ok
        //                            textList[2].text = _interviewAnswerLists.defaultCategory[0].m_InterviewAverageAnswer;
        //                        }
        //                    }
        //                    break;

        //                case 2:
        //                    if (uiManager.uiPrefabCopyList[1].activeSelf == true)
        //                    {
        //                        if (AnswerTextObject[0].activeSelf == true)
        //                        {// Helt ok
        //                            textList[0].text = _interviewAnswerLists.defaultCategory[1].m_InterviewAverageAnswer;
        //                        }
        //                        else if (AnswerTextObject[1].activeSelf == true)
        //                        { // Dåliugt svar
        //                            textList[1].text = _interviewAnswerLists.defaultCategory[1].m_InterviewBadAnswer;
        //                        }
        //                        else if (AnswerTextObject[2].activeSelf == true)
        //                        { // Bra svar
        //                            textList[2].text = _interviewAnswerLists.defaultCategory[1].m_InterviewGoodAnswer;
        //                        }
        //                    }
        //                    break;

        //                case 3:
        //                    if (uiManager.uiPrefabCopyList[1].activeSelf == true)
        //                    {
        //                        if (AnswerTextObject[0].activeSelf == true)
        //                        { //Helt ok 
        //                            textList[0].text = _interviewAnswerLists.defaultCategory[2].m_InterviewAverageAnswer;
        //                        }
        //                        else if (AnswerTextObject[1].activeSelf == true)
        //                        { // Bra svar
        //                            textList[1].text = _interviewAnswerLists.defaultCategory[2].m_InterviewGoodAnswer;
        //                        }
        //                        else if (AnswerTextObject[2].activeSelf == true)
        //                        { // Dåligt svar
        //                            textList[2].text = _interviewAnswerLists.defaultCategory[2].m_InterviewBadAnswer;
        //                        }
        //                    }
        //                    break;

        //                case 4:
        //                    if (uiManager.uiPrefabCopyList[1].activeSelf == true)
        //                    {
        //                        if (AnswerTextObject[0].activeSelf == true)
        //                        { //Dåligt svar
        //                            textList[0].text = _interviewAnswerLists.defaultCategory[3].m_InterviewBadAnswer;
        //                        }
        //                        else if (AnswerTextObject[1].activeSelf == true)
        //                        {// Helt ok
        //                            textList[1].text = _interviewAnswerLists.defaultCategory[3].m_InterviewAverageAnswer;
        //                        }
        //                        else if (AnswerTextObject[2].activeSelf == true)
        //                        {// Bra svar
        //                            textList[2].text = _interviewAnswerLists.defaultCategory[3].m_InterviewGoodAnswer;
        //                        }
        //                    }
        //                    break;

        //                case 5:
        //                    if (uiManager.uiPrefabCopyList[1].activeSelf == true)
        //                    {
        //                        if (AnswerTextObject[0].activeSelf == true)
        //                        {// Bra svar
        //                            textList[0].text = _interviewAnswerLists.defaultCategory[4].m_InterviewGoodAnswer;
        //                        }
        //                        else if (AnswerTextObject[1].activeSelf == true)
        //                        {//Helt ok
        //                            textList[1].text = _interviewAnswerLists.defaultCategory[4].m_InterviewAverageAnswer;
        //                        }
        //                        else if (AnswerTextObject[2].activeSelf == true)
        //                        {// Dåligt svar
        //                            textList[2].text = _interviewAnswerLists.defaultCategory[4].m_InterviewBadAnswer;
        //                        }
        //                    }
        //                    break;

        //                case 6:
        //                    if (uiManager.uiPrefabCopyList[1].activeSelf == true)
        //                    {
        //                        if (AnswerTextObject[0].activeSelf == true)
        //                        { // Dåligt svar
        //                            textList[0].text = _interviewAnswerLists.defaultCategory[5].m_InterviewBadAnswer;
        //                        }
        //                        else if (AnswerTextObject[1].activeSelf == true)
        //                        { // Bra svar
        //                            textList[1].text = _interviewAnswerLists.defaultCategory[5].m_InterviewGoodAnswer;
        //                        }
        //                        else if (AnswerTextObject[2].activeSelf == true)
        //                        {// Helt ok
        //                            textList[2].text = _interviewAnswerLists.defaultCategory[5].m_InterviewAverageAnswer;
        //                        }
        //                    }
        //                    break;

        //                case 7:
        //                    if (uiManager.uiPrefabCopyList[1].activeSelf == true)
        //                    {
        //                        if (AnswerTextObject[0].activeSelf == true)
        //                        {// Dåligt svar
        //                            textList[0].text = _interviewAnswerLists.defaultCategory[6].m_InterviewBadAnswer;
        //                        }
        //                        else if (AnswerTextObject[1].activeSelf == true)
        //                        {// Helt ok
        //                            textList[1].text = _interviewAnswerLists.defaultCategory[6].m_InterviewAverageAnswer;
        //                        }
        //                        else if (AnswerTextObject[2].activeSelf == true)
        //                        {// Bra svar
        //                            textList[2].text = _interviewAnswerLists.defaultCategory[6].m_InterviewGoodAnswer;
        //                        }
        //                    }
        //                    break;

        //                case 8:
        //                    if (uiManager.uiPrefabCopyList[1].activeSelf == true)
        //                    {
        //                        if (AnswerTextObject[0].activeSelf == true)
        //                        {// Dåligt svar
        //                            textList[0].text = _interviewAnswerLists.defaultCategory[7].m_InterviewBadAnswer;
        //                        }
        //                        else if (AnswerTextObject[1].activeSelf == true)
        //                        {// Bra svar
        //                            textList[1].text = _interviewAnswerLists.defaultCategory[7].m_InterviewGoodAnswer;
        //                        }
        //                        else if (AnswerTextObject[2].activeSelf == true)
        //                        {// Helt ok
        //                            textList[2].text = _interviewAnswerLists.defaultCategory[7].m_InterviewAverageAnswer;
        //                        }
        //                    }
        //                    break;

        //                case 9:
        //                    if (uiManager.uiPrefabCopyList[1].activeSelf == true)
        //                    {
        //                        if (AnswerTextObject[0].activeSelf == true)
        //                        {// Bra svar
        //                            textList[0].text = _interviewAnswerLists.defaultCategory[8].m_InterviewGoodAnswer;
        //                        }
        //                        else if (AnswerTextObject[1].activeSelf == true)
        //                        {//Helt ok
        //                            textList[1].text = _interviewAnswerLists.defaultCategory[8].m_InterviewAverageAnswer;
        //                        }
        //                        else if (AnswerTextObject[2].activeSelf == true)
        //                        {// Dåligt svar
        //                            textList[2].text = _interviewAnswerLists.defaultCategory[8].m_InterviewBadAnswer;
        //                        }
        //                    }
        //                    break;

        //                case 10:
        //                    if (uiManager.uiPrefabCopyList[1].activeSelf == true)
        //                    {
        //                        if (AnswerTextObject[0].activeSelf == true)
        //                        {// Dåligt svar
        //                            textList[0].text = _interviewAnswerLists.defaultCategory[9].m_InterviewBadAnswer;
        //                        }
        //                        else if (AnswerTextObject[1].activeSelf == true)
        //                        {// Bra svar
        //                            textList[1].text = _interviewAnswerLists.defaultCategory[9].m_InterviewGoodAnswer;
        //                        }
        //                        else if (AnswerTextObject[2].activeSelf == true)
        //                        {// Helt ok
        //                            textList[2].text = _interviewAnswerLists.defaultCategory[9].m_InterviewAverageAnswer;
        //                        }
        //                    }
        //                    break;

        //                case 11:
        //                    if (uiManager.uiPrefabCopyList[1].activeSelf == true)
        //                    {
        //                        if (AnswerTextObject[0].activeSelf == true)
        //                        {//Bra svar
        //                            textList[0].text = _interviewAnswerLists.defaultCategory[10].m_InterviewGoodAnswer;
        //                        }
        //                        else if (AnswerTextObject[1].activeSelf == true)
        //                        {//Dåligt svar
        //                            textList[1].text = _interviewAnswerLists.defaultCategory[10].m_InterviewBadAnswer;
        //                        }
        //                        else if (AnswerTextObject[2].activeSelf == true)
        //                        {// Helt ok
        //                            textList[2].text = _interviewAnswerLists.defaultCategory[10].m_InterviewAverageAnswer;
        //                        }
        //                    }
        //                    break;

        //                case 12:
        //                    if (uiManager.uiPrefabCopyList[0].activeSelf == true)
        //                    {// Dåligt svar
        //                        if (AnswerTextObject[0].activeSelf == true)
        //                        {
        //                            textList[0].text = _interviewAnswerLists.defaultCategory[11].m_InterviewBadAnswer;
        //                        }// Helt ok
        //                        else if (AnswerTextObject[1].activeSelf == true)
        //                        {
        //                            textList[1].text = _interviewAnswerLists.defaultCategory[11].m_InterviewAverageAnswer;
        //                        }// Bra svar
        //                        else if (AnswerTextObject[2].activeSelf == true)
        //                        {
        //                            textList[2].text = _interviewAnswerLists.defaultCategory[11].m_InterviewGoodAnswer;
        //                        }
        //                    }
        //                    break;

        //                case 13:
        //                    if (uiManager.uiPrefabCopyList[0].activeSelf == true)
        //                    {
        //                        if (AnswerTextObject[0].activeSelf == true)
        //                        {//Helt ok
        //                            textList[0].text = _interviewAnswerLists.defaultCategory[12].m_InterviewAverageAnswer;
        //                        }
        //                        else if (AnswerTextObject[1].activeSelf == true)
        //                        {// Dåligt svar
        //                            textList[1].text = _interviewAnswerLists.defaultCategory[12].m_InterviewBadAnswer;
        //                        }
        //                        else if (AnswerTextObject[2].activeSelf == true)
        //                        {// Bra svar
        //                            textList[2].text = _interviewAnswerLists.defaultCategory[12].m_InterviewGoodAnswer;
        //                        }
        //                    }
        //                    break;

        //                case 14:
        //                    if (uiManager.uiPrefabCopyList[0].activeSelf == true)
        //                    {
        //                        if (AnswerTextObject[0].activeSelf == true)
        //                        {// Bra svar
        //                            textList[0].text = _interviewAnswerLists.defaultCategory[13].m_InterviewGoodAnswer;
        //                        }
        //                        else if (AnswerTextObject[1].activeSelf == true)
        //                        {// Helt ok
        //                            textList[1].text = _interviewAnswerLists.defaultCategory[13].m_InterviewAverageAnswer;
        //                        }
        //                        else if (AnswerTextObject[2].activeSelf == true)
        //                        {// Dåligt svar
        //                            textList[2].text = _interviewAnswerLists.defaultCategory[13].m_InterviewBadAnswer;
        //                        }
        //                    }
        //                    break;

        //                case 15:
        //                    if (uiManager.uiPrefabCopyList[0].activeSelf == true)
        //                    {
        //                        if (AnswerTextObject[0].activeSelf == true)
        //                        {// Dåligt svar
        //                            textList[0].text = _interviewAnswerLists.defaultCategory[14].m_InterviewBadAnswer;
        //                        }
        //                        else if (AnswerTextObject[1].activeSelf == true)
        //                        {// Bra svar
        //                            textList[1].text = _interviewAnswerLists.defaultCategory[14].m_InterviewGoodAnswer;
        //                        }
        //                        else if (AnswerTextObject[2].activeSelf == true)
        //                        {// Helt ok
        //                            textList[2].text = _interviewAnswerLists.defaultCategory[14].m_InterviewAverageAnswer;
        //                        }
        //                    }
        //                    break;

        //                case 16:
        //                    if (uiManager.uiPrefabCopyList[0].activeSelf == true)
        //                    {
        //                        if (AnswerTextObject[0].activeSelf == true)
        //                        {// Bra svar
        //                            textList[0].text = _interviewAnswerLists.defaultCategory[15].m_InterviewGoodAnswer;
        //                        }
        //                        else if (AnswerTextObject[1].activeSelf == true)
        //                        {// Dåligt svar
        //                            textList[1].text = _interviewAnswerLists.defaultCategory[15].m_InterviewBadAnswer;
        //                        }
        //                        else if (AnswerTextObject[2].activeSelf == true)
        //                        {// Helt ok
        //                            textList[2].text = _interviewAnswerLists.defaultCategory[15].m_InterviewAverageAnswer;
        //                        }
        //                    }
        //                    break;

        //                case 17:
        //                    if (uiManager.uiPrefabCopyList[0].activeSelf == true)
        //                    {
        //                        if (AnswerTextObject[0].activeSelf == true)
        //                        {// Bra svar
        //                            textList[0].text = _interviewAnswerLists.defaultCategory[16].m_InterviewGoodAnswer;
        //                        }
        //                        else if (AnswerTextObject[1].activeSelf == true)
        //                        {// Helt ok
        //                            textList[1].text = _interviewAnswerLists.defaultCategory[16].m_InterviewAverageAnswer;
        //                        }
        //                        else if (AnswerTextObject[2].activeSelf == true)
        //                        {// Dåligt svar
        //                            textList[2].text = _interviewAnswerLists.defaultCategory[16].m_InterviewBadAnswer;
        //                        }
        //                    }
        //                    break;

        //                case 18:
        //                    if (uiManager.uiPrefabCopyList[0].activeSelf == true)
        //                    {
        //                        if (AnswerTextObject[0].activeSelf == true)
        //                        {// Bra svar
        //                            textList[0].text = _interviewAnswerLists.defaultCategory[17].m_InterviewGoodAnswer;
        //                        }
        //                        else if (AnswerTextObject[1].activeSelf == true)
        //                        {// Helt ok
        //                            textList[1].text = _interviewAnswerLists.defaultCategory[17].m_InterviewAverageAnswer;
        //                        }
        //                        else if (AnswerTextObject[2].activeSelf == true)
        //                        {// Dåligt svar
        //                            textList[2].text = _interviewAnswerLists.defaultCategory[17].m_InterviewBadAnswer;
        //                        }
        //                    }
        //                    break;

        //                case 19:
        //                    if (uiManager.uiPrefabCopyList[0].activeSelf == true)
        //                    {
        //                        if (AnswerTextObject[0].activeSelf == true)
        //                        {// Dåligt svar
        //                            textList[0].text = _interviewAnswerLists.defaultCategory[18].m_InterviewBadAnswer;
        //                        }
        //                        else if (AnswerTextObject[1].activeSelf == true)
        //                        {// Bra svar
        //                            textList[1].text = _interviewAnswerLists.defaultCategory[18].m_InterviewGoodAnswer;
        //                        }
        //                        else if (AnswerTextObject[2].activeSelf == true)
        //                        {// Helt ok
        //                            textList[2].text = _interviewAnswerLists.defaultCategory[18].m_InterviewAverageAnswer;
        //                        }
        //                    }
        //                    break;

        //                case 20:
        //                    if (uiManager.uiPrefabCopyList[0].activeSelf == true)
        //                    {
        //                        if (AnswerTextObject[0].activeSelf == true)
        //                        {// Dåligt svar
        //                            textList[0].text = _interviewAnswerLists.defaultCategory[19].m_InterviewBadAnswer;
        //                        }
        //                        else if (AnswerTextObject[1].activeSelf == true)
        //                        {// Helt ok
        //                            textList[1].text = _interviewAnswerLists.defaultCategory[19].m_InterviewAverageAnswer;
        //                        }
        //                        else if (AnswerTextObject[2].activeSelf == true)
        //                        {// Bra svar
        //                            textList[2].text = _interviewAnswerLists.defaultCategory[19].m_InterviewGoodAnswer;
        //                        }
        //                    }
        //                    break;
        //            }
        //            break;

        //        case false:
        //                    Debug.LogWarning("Easy Mode isn't true! Make sure it's true in order for code to work!");
        //                    break;
        //            }

        //    }
        }

}
