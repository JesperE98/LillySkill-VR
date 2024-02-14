using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;

namespace JespersCode
{
    public class UITextUpdate : MonoBehaviour
    {
        private GameManager gameManager;
        private UIManager uiManager;
        private TMP_Text answerText;
        private bool loopDone = false;

        [Tooltip("Generic List to store parent objects for the answertexts")]
        [SerializeField]
        private List<GameObject> AnswerTextObject = new List<GameObject>();
        [Tooltip("Generic TMP_Text List to store TMP_Text components")]
        [SerializeField]
        private List<TMP_Text> textList = new List<TMP_Text>();

        private void Start()
        {
            gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
            uiManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();

            answerText = GetComponent<TMP_Text>();
        }

        private void Update()
        {
            if (gameManager.InterviewAreActive == true)
            {
                UpdateAnswerScreenText();
            }

            if (gameManager.FeedbackPageActive == true)
            {
                FeedbackPageText();
            }

            if (gameManager.SummaryPageActive == true)
            {
                SummaryPageText();
            }
        }

        private void SummaryPageText()
        {
            if (loopDone == false)
            {
                for (int i = 0; i < gameManager.AnswerList.Count; i++)
                {
                    answerText.text += gameManager.AnswerList[i] + "\n";
                }
                loopDone = true;
            }
        }

        private void FeedbackPageText()
        {
            if (gameManager.InterviewAreActive == false)
            {
                if (gameManager.PlayerScore < 4)
                {
                    answerText.text = "You only got " + gameManager.PlayerScore + " points.\nWork more on this";
                }
                else if (gameManager.PlayerScore > 4 || gameManager.PlayerScore < 10)
                {
                    answerText.text = "You got " + gameManager.PlayerScore + " points.\nGood job! But you need to work more on this";
                }
                else if (gameManager.PlayerScore > 10)
                {
                    answerText.text = "You got " + gameManager.PlayerScore + " points!\nFantastic job! You will ace the interview! :D";
                }
            }
        }


        private void UpdateAnswerScreenText()
        {
            switch (gameManager.EasyMode)
            {
                case true:
                    switch (gameManager.AnswerPageNumber)
                    {
                        case 1:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Jag har �nnu inte skaffat mig tidigare arbetserfarenhet, men jag har utvecklat " +
                                        "relevanta f�rdigheter genom att uppr�tth�lla renlighet i mitt boende.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Jag �r sugen p� att b�rja jobba. Trots att jag �nnu inte skaffat specifik arbetserfarenhet" +
                                        "�r jag motiverad att g�ra en positiv inverkan");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Jag har flera �rs arbetslivserfarenhet, utrustad med en robust kompetens och en djup" +
                                        " f�rst�else f�r olika tekniker och arbetsuppgifter. ");
                                }
                            }
                            break;

                        case 2:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("H�g arbetskapacitet och f�rm�ga att hantera fysiskt kr�vande arbetsuppgifter.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Noggrannhet och f�rm�ga att f�lja instruktioner.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("God samarbetsf�rm�ga och f�rm�ga att samarbeta. ");
                                }
                            }
                            break;

                        case 3:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Jag har aldrig r�kat ut f�r en utmanande situation tidigare. ");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Jag undviker vanligtvis utmanande situationer. ");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Jag har st�llts inf�r minst en sv�r situation tidigare och antingen " +
                                        "l�ste jag den sj�lv eller v�nde mig till mina v�nner f�r att f� st�d. ");
                                }
                            }
                            break;

                        case 4:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Jag f�redrar att jobba ensam. ");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Jag brukar kontrollera teamprojekt och se till att allt g�r min v�g. ");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Jag v�rdes�tter teamwork, d�r alla arbetar som ett team. ");
                                }
                            }
                            break;

                        case 5:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Jag har aldrig haft n�gra konflikter med kollegor.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("N�r konflikter uppst�r tenderar jag att h�lla avst�nd och hoppas att de l�ser sig p� egen hand. ");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Jag skulle ta itu med konflikten med en kollega genom respektfull kommunikation.");
                                }
                            }
                            break;

                        case 6:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Jag hanterar inte feedback eller kritik s�rskilt bra.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Jag bryr mig inte om feedback eller kritik eftersom jag vet att jag g�r ett bra jobb.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Jag ser feedback och kritik som n�got positivt, f�r att l�ra sig och v�xa p� en arbetsplats.");
                                }
                            }
                            break;

                        case 7:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Jag �gnar mig inte �t n�gra aktiviteter eller hobbyer p� min fritid.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Jag har n�gra aktiviteter eller hobbyer som jag �gnar mig �t p� min fritid.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Jag �gnar mig �t specifika aktiviteter eller hobbyer p� min fritid, " +
                                        "f�r min personliga utveckling och intresse.");
                                }
                            }
                            break;

                        case 8:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Jag har �nnu inte t�nkt p� mina planer i detalj.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Jag ser mig sj�lv v�xa tillsammans med f�retaget.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Jag t�nker mig att jag tar mig an olika roller med �kat ansvar f�r min personliga utveckling.");
                                }
                            }
                            break;

                        case 9:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Personlig utveckling �r inte en prioritet f�r mig.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Personlig utveckling �r viktigt f�r mig, men jag har �nnu inte drivit den aktivt fram�t.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Personlig utveckling �r avg�rande, och jag s�ker aktivt m�jligheter att l�ra," +
                                        " v�xa och f�rb�ttra mina f�rdigheter.");
                                }
                            }
                            break;

                        case 10:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Jag har inte avslutat n�gon formell utbildning.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Jag har g�tt n�gon gymnasieutbildning eller liknande.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Jag har avslutat h�gskole-/universitetsutbildning eller har en h�gre examen.");
                                }
                            }
                            break;

                        case 11:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Skyll p� den andra personen f�r att han inte f�rst�r.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("F�rtydliga situationen och hitta en �msesidigt acceptabel l�sning.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Eskalera �rendet till en arbetsledare eller chef.");
                                }
                            }
                            break;

                        case 12:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Undvik problemet och hoppas att det l�ser sig p� egen hand.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Lyssnar aktivt och s�ker en �msesidigt f�rdelaktig l�sning.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Fokusera p� att kritisera situationen s� att man inte g�r om det.");
                                }
                            }
                            break;

                        case 13:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Jag skulle lyssna p� b�da teammedlemmarnas perspektiv utan att ta n�gon sida.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Undvika konflikten och hoppas att de l�ser det sj�lva.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Om konflikten forts�tter eller eskalerar kommer jag att kontakta " +
                                        "en l�mplig auktoritetsperson, till exempel en handledare eller chef.");
                                }
                            }
                            break;

                        case 14:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Undvika konflikten och hoppas att den l�ser sig sj�lv.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Involvera n�gon utomst�ende i projektet f�r att hitta en r�ttvis l�sning f�r oss.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Jag �r os�ker p� vad jag ska g�ra i denna situation och tar d�rf�r inte del av konflikten.");
                                }
                            }
                            break;

                        case 15:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Ge upp och g� vidare till n�got annat.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Skylla p� externa faktorer f�r motg�ngen.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("L�ra av upplevelsen och anpassa mitt tillv�gag�ngss�tt.");
                                }
                            }
                            break;

                        case 16:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Jag har �nnu inte f�tt n�gon arbetslivserfarenhet eller gjort volont�rarbete.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Jag har varit involverad i aktiviteter som kan vara f�rdelaktiga p� en arbetsplats.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Jag har tidigare engagerat mig i volont�rarbete och har d�rf�r erfarenhet.");
                                }
                            }
                            break;

                        case 17:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Jag h�ller fortfarande p� att best�mma mina styrkor och f�rdigheter.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Jag �r bra p� att samarbeta och har starka kommunikationsf�rdigheter.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Jag har en stark analytisk f�rm�ga och �r bra p� probleml�sning.");
                                }
                            }
                            break;

                        case 18:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Jag s�ker detta jobb f�r att skaffa arbetslivserfarenhet och l�ra mig nya f�rdigheter.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Jag �r motiverad att arbeta inom detta omr�de och bygga en framg�ngsrik karri�r.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Jag best�mmer fortfarande mina karri�rsm�l, men jag �r �ppen f�r m�jligheter och ivrig att l�ra mig mer.");
                                }
                            }
                            break;

                        case 19:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Jag har ingen �sikt i den h�r fr�gan.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Jag ser feedback och v�gledning som m�jligheter att l�ra mig och f�rb�ttra mig sj�lv.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Jag �r �ppen f�r feedback men kan beh�va tid f�r att bearbeta och till�mpa den.");
                                }
                            }
                            break;

                        case 20:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Att vara impulsiv och envis.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Att ha god teamwork och kommunikation.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Att vara effektiv och organiserad.");
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
}

