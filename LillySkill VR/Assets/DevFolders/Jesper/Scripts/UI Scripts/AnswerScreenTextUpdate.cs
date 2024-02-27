using JespersCode;
using JesperScriptableObject;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AnswerScreenTextUpdate : MonoBehaviour
{
    private GameManager gameManager;
    private UIManager uiManager;

    [SerializeField]
    private GameSettingsScriptableObject m_GameSettingsScriptableObject;
    [SerializeField]
    private InterviewAnswersListScriptableObject m_InterviewAnswersListScriptableObject;
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
            UpdateAnswerScreenText();
        }
    }

    private void UpdateAnswerScreenText()
    {
        switch (m_GameSettingsScriptableObject.DefaultMode)
        {
            case true:
                switch (gameManager.AnswerPageNumber)
                {
                    case 0:
                        if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {// Bra svar
                                textList[0].text = m_InterviewAnswersListScriptableObject.m_InterviewGoodAnswerList[0];
                            }
                            else if (AnswerTextObject[1].activeSelf == true)
                            {// Dåligt svar
                                textList[1].text = m_InterviewAnswersListScriptableObject.m_InterviewBadAnswerList[0];
                            }
                            else if (AnswerTextObject[2].activeSelf == true)
                            { // Helt ok
                                textList[2].text = m_InterviewAnswersListScriptableObject.m_InterviewAverageAnswerList[0];
                            }
                        }
                        break;

                    case 1:
                        if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {// Helt ok
                                textList[0].text = m_InterviewAnswersListScriptableObject.m_InterviewAverageAnswerList[1];
                            }
                            else if (AnswerTextObject[1].activeSelf == true)
                            { // Dåliugt svar
                                textList[1].text = m_InterviewAnswersListScriptableObject.m_InterviewBadAnswerList[1];
                            }
                            else if (AnswerTextObject[2].activeSelf == true)
                            { // Bra svar
                                textList[2].text = m_InterviewAnswersListScriptableObject.m_InterviewGoodAnswerList[1];
                            }
                        }
                        break;

                    case 2:
                        if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            { //Helt ok 
                                textList[0].text = m_InterviewAnswersListScriptableObject.m_InterviewAverageAnswerList[2];
                            }
                            else if (AnswerTextObject[1].activeSelf == true)
                            { // Bra svar
                                textList[1].text = m_InterviewAnswersListScriptableObject.m_InterviewGoodAnswerList[2];
                            }
                            else if (AnswerTextObject[2].activeSelf == true)
                            { // Dåligt svar
                                textList[2].text = m_InterviewAnswersListScriptableObject.m_InterviewBadAnswerList[2];
                            }
                        }
                        break;

                    case 3:
                        if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            { //Dåligt svar
                                textList[0].text = m_InterviewAnswersListScriptableObject.m_InterviewBadAnswerList[3];
                            }
                            else if (AnswerTextObject[1].activeSelf == true)
                            {// Helt ok
                                textList[1].text = m_InterviewAnswersListScriptableObject.m_InterviewAverageAnswerList[3];
                            }
                            else if (AnswerTextObject[2].activeSelf == true)
                            {// Bra svar
                                textList[2].text = m_InterviewAnswersListScriptableObject.m_InterviewGoodAnswerList[3];
                            }
                        }
                        break;

                    case 4:
                        if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {// Bra svar
                                textList[0].text = m_InterviewAnswersListScriptableObject.m_InterviewGoodAnswerList[4];
                            }
                            else if (AnswerTextObject[1].activeSelf == true)
                            {//Helt ok
                                textList[1].text = m_InterviewAnswersListScriptableObject.m_InterviewAverageAnswerList[4];
                            }
                            else if (AnswerTextObject[2].activeSelf == true)
                            {// Dåligt svar
                                textList[2].text = m_InterviewAnswersListScriptableObject.m_InterviewBadAnswerList[4];
                            }
                        }
                        break;

                    case 5:
                        if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            { // Dåligt svar
                                textList[0].text = m_InterviewAnswersListScriptableObject.m_InterviewBadAnswerList[5];
                            }
                            else if (AnswerTextObject[1].activeSelf == true)
                            { // Bra svar
                                textList[1].text = m_InterviewAnswersListScriptableObject.m_InterviewGoodAnswerList[5];
                            }
                            else if (AnswerTextObject[2].activeSelf == true)
                            {// Helt ok
                                textList[2].text = m_InterviewAnswersListScriptableObject.m_InterviewAverageAnswerList[5];
                            }
                        }
                        break;

                    case 6:
                        if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {// Dåligt svar
                                textList[0].text = m_InterviewAnswersListScriptableObject.m_InterviewBadAnswerList[6];
                            }
                            else if (AnswerTextObject[1].activeSelf == true)
                            {// Helt ok
                                textList[1].text = m_InterviewAnswersListScriptableObject.m_InterviewAverageAnswerList[6];
                            }
                            else if (AnswerTextObject[2].activeSelf == true)
                            {// Bra svar
                                textList[2].text = m_InterviewAnswersListScriptableObject.m_InterviewGoodAnswerList[6];
                            }
                        }
                        break;

                    case 7:
                        if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {// Dåligt svar
                                textList[0].text = m_InterviewAnswersListScriptableObject.m_InterviewBadAnswerList[7];
                            }
                            else if (AnswerTextObject[1].activeSelf == true)
                            {// Bra svar
                                textList[1].text = m_InterviewAnswersListScriptableObject.m_InterviewGoodAnswerList[7];
                            }
                            else if (AnswerTextObject[2].activeSelf == true)
                            {// Helt ok
                                textList[2].text = m_InterviewAnswersListScriptableObject.m_InterviewAverageAnswerList[7];
                            }
                        }
                        break;

                    case 8:
                        if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {// Bra svar
                                textList[0].text = m_InterviewAnswersListScriptableObject.m_InterviewGoodAnswerList[8];
                            }
                            else if (AnswerTextObject[1].activeSelf == true)
                            {//Helt ok
                                textList[1].text = m_InterviewAnswersListScriptableObject.m_InterviewAverageAnswerList[8];
                            }
                            else if (AnswerTextObject[2].activeSelf == true)
                            {// Dåligt svar
                                textList[2].text = m_InterviewAnswersListScriptableObject.m_InterviewBadAnswerList[8];
                            }
                        }
                        break;

                    case 9:
                        if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {// Dåligt svar
                                textList[0].text = m_InterviewAnswersListScriptableObject.m_InterviewBadAnswerList[9];
                            }
                            else if (AnswerTextObject[1].activeSelf == true)
                            {// Bra svar
                                textList[1].text = m_InterviewAnswersListScriptableObject.m_InterviewGoodAnswerList[9];
                            }
                            else if (AnswerTextObject[2].activeSelf == true)
                            {// Helt ok
                                textList[2].text = m_InterviewAnswersListScriptableObject.m_InterviewAverageAnswerList[9];
                            }
                        }
                        break;

                    case 10:
                        if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {//Bra svar
                                textList[0].text = m_InterviewAnswersListScriptableObject.m_InterviewGoodAnswerList[10];
                            }
                            else if (AnswerTextObject[1].activeSelf == true)
                            {//Dåligt svar
                                textList[1].text = m_InterviewAnswersListScriptableObject.m_InterviewBadAnswerList[10];
                            }
                            else if (AnswerTextObject[2].activeSelf == true)
                            {// Helt ok
                                textList[2].text = m_InterviewAnswersListScriptableObject.m_InterviewAverageAnswerList[10];
                            }
                        }
                        break;

                    case 11:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {// Dåligt svar
                            if (AnswerTextObject[0].activeSelf == true)
                            {
                                textList[0].text = m_InterviewAnswersListScriptableObject.m_InterviewBadAnswerList[11];
                            }// Helt ok
                            else if (AnswerTextObject[1].activeSelf == true)
                            {
                                textList[1].text = m_InterviewAnswersListScriptableObject.m_InterviewAverageAnswerList[11];
                            }// Bra svar
                            else if (AnswerTextObject[2].activeSelf == true)
                            {
                                textList[2].text = m_InterviewAnswersListScriptableObject.m_InterviewGoodAnswerList[11];
                            }
                        }
                        break;

                    case 12:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {//Helt ok
                                textList[0].text = m_InterviewAnswersListScriptableObject.m_InterviewAverageAnswerList[12];
                            }
                            else if (AnswerTextObject[1].activeSelf == true)
                            {// Dåligt svar
                                textList[1].text = m_InterviewAnswersListScriptableObject.m_InterviewBadAnswerList[12];
                            }
                            else if (AnswerTextObject[2].activeSelf == true)
                            {// Bra svar
                                textList[2].text = m_InterviewAnswersListScriptableObject.m_InterviewGoodAnswerList[12];
                            }
                        }
                        break;

                    case 13:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {// Bra svar
                                textList[0].text = m_InterviewAnswersListScriptableObject.m_InterviewGoodAnswerList[13];
                            }
                            else if (AnswerTextObject[1].activeSelf == true)
                            {// Helt ok
                                textList[1].text = m_InterviewAnswersListScriptableObject.m_InterviewAverageAnswerList[13];
                            }
                            else if (AnswerTextObject[2].activeSelf == true)
                            {// Dåligt svar
                                textList[2].text = m_InterviewAnswersListScriptableObject.m_InterviewBadAnswerList[13];
                            }
                        }
                        break;

                    case 14:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {// Dåligt svar
                                textList[0].text = m_InterviewAnswersListScriptableObject.m_InterviewBadAnswerList[14];
                            }
                            else if (AnswerTextObject[1].activeSelf == true)
                            {// Bra svar
                                textList[1].text = m_InterviewAnswersListScriptableObject.m_InterviewGoodAnswerList[14];
                            }
                            else if (AnswerTextObject[2].activeSelf == true)
                            {// Helt ok
                                textList[2].text = m_InterviewAnswersListScriptableObject.m_InterviewAverageAnswerList[14];
                            }
                        }
                        break;

                    case 15:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {// Bra svar
                                textList[0].text = m_InterviewAnswersListScriptableObject.m_InterviewGoodAnswerList[15];
                            }
                            else if (AnswerTextObject[1].activeSelf == true)
                            {// Dåligt svar
                                textList[1].text = m_InterviewAnswersListScriptableObject.m_InterviewBadAnswerList[15];
                            }
                            else if (AnswerTextObject[2].activeSelf == true)
                            {// Helt ok
                                textList[2].text = m_InterviewAnswersListScriptableObject.m_InterviewAverageAnswerList[15];
                            }
                        }
                        break;

                    case 16:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {// Bra svar
                                textList[0].text = m_InterviewAnswersListScriptableObject.m_InterviewGoodAnswerList[16];
                            }
                            else if (AnswerTextObject[1].activeSelf == true)
                            {// Helt ok
                                textList[1].text = m_InterviewAnswersListScriptableObject.m_InterviewAverageAnswerList[16];
                            }
                            else if (AnswerTextObject[2].activeSelf == true)
                            {// Dåligt svar
                                textList[2].text = m_InterviewAnswersListScriptableObject.m_InterviewBadAnswerList[16];
                            }
                        }
                        break;

                    case 17:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {// Bra svar
                                textList[0].text = m_InterviewAnswersListScriptableObject.m_InterviewGoodAnswerList[17];
                            }
                            else if (AnswerTextObject[1].activeSelf == true)
                            {// Helt ok
                                textList[1].text = m_InterviewAnswersListScriptableObject.m_InterviewAverageAnswerList[17];
                            }
                            else if (AnswerTextObject[2].activeSelf == true)
                            {// Dåligt svar
                                textList[2].text = m_InterviewAnswersListScriptableObject.m_InterviewBadAnswerList[17];
                            }
                        }
                        break;

                    case 18:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {// Dåligt svar
                                textList[0].text = m_InterviewAnswersListScriptableObject.m_InterviewBadAnswerList[18];
                            }
                            else if (AnswerTextObject[1].activeSelf == true)
                            {// Bra svar
                                textList[1].text = m_InterviewAnswersListScriptableObject.m_InterviewGoodAnswerList[18];
                            }
                            else if (AnswerTextObject[2].activeSelf == true)
                            {// Helt ok
                                textList[2].text = m_InterviewAnswersListScriptableObject.m_InterviewAverageAnswerList[18];
                            }
                        }
                        break;

                    case 19:
                        if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                        {
                            if (AnswerTextObject[0].activeSelf == true)
                            {// Dåligt svar
                                textList[0].text = m_InterviewAnswersListScriptableObject.m_InterviewBadAnswerList[19];
                            }
                            else if (AnswerTextObject[1].activeSelf == true)
                            {// Helt ok
                                textList[1].text = m_InterviewAnswersListScriptableObject.m_InterviewAverageAnswerList[19];
                            }
                            else if (AnswerTextObject[2].activeSelf == true)
                            {// Bra svar
                                textList[2].text = m_InterviewAnswersListScriptableObject.m_InterviewGoodAnswerList[19];
                            }
                        }
                        break;
                }
                break;

            case false:
                Debug.LogWarning("Easy Mode isn't true! Make sure it's true in order for code to work!");
                break;
        }

    }
}
