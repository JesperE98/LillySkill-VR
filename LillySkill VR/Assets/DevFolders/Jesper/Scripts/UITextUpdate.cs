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
                                    textList[0].text = ("Jag har ännu inte skaffat mig tidigare arbetserfarenhet, men jag har utvecklat " +
                                        "relevanta färdigheter genom att upprätthålla renlighet i mitt boende.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Jag är sugen på att börja jobba. Trots att jag ännu inte skaffat specifik arbetserfarenhet" +
                                        "är jag motiverad att göra en positiv inverkan");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Jag har flera års arbetslivserfarenhet, utrustad med en robust kompetens och en djup" +
                                        " förståelse för olika tekniker och arbetsuppgifter. ");
                                }
                            }
                            break;

                        case 2:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Hög arbetskapacitet och förmåga att hantera fysiskt krävande arbetsuppgifter.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Noggrannhet och förmåga att följa instruktioner.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("God samarbetsförmåga och förmåga att samarbeta. ");
                                }
                            }
                            break;

                        case 3:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Jag har aldrig råkat ut för en utmanande situation tidigare. ");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Jag undviker vanligtvis utmanande situationer. ");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Jag har ställts inför minst en svår situation tidigare och antingen " +
                                        "löste jag den själv eller vände mig till mina vänner för att få stöd. ");
                                }
                            }
                            break;

                        case 4:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Jag föredrar att jobba ensam. ");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Jag brukar kontrollera teamprojekt och se till att allt går min väg. ");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Jag värdesätter teamwork, där alla arbetar som ett team. ");
                                }
                            }
                            break;

                        case 5:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Jag har aldrig haft några konflikter med kollegor.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("När konflikter uppstår tenderar jag att hålla avstånd och hoppas att de löser sig på egen hand. ");
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
                                    textList[0].text = ("Jag hanterar inte feedback eller kritik särskilt bra.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Jag bryr mig inte om feedback eller kritik eftersom jag vet att jag gör ett bra jobb.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Jag ser feedback och kritik som något positivt, för att lära sig och växa på en arbetsplats.");
                                }
                            }
                            break;

                        case 7:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Jag ägnar mig inte åt några aktiviteter eller hobbyer på min fritid.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Jag har några aktiviteter eller hobbyer som jag ägnar mig åt på min fritid.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Jag ägnar mig åt specifika aktiviteter eller hobbyer på min fritid, " +
                                        "för min personliga utveckling och intresse.");
                                }
                            }
                            break;

                        case 8:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Jag har ännu inte tänkt på mina planer i detalj.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Jag ser mig själv växa tillsammans med företaget.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Jag tänker mig att jag tar mig an olika roller med ökat ansvar för min personliga utveckling.");
                                }
                            }
                            break;

                        case 9:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Personlig utveckling är inte en prioritet för mig.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Personlig utveckling är viktigt för mig, men jag har ännu inte drivit den aktivt framåt.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Personlig utveckling är avgörande, och jag söker aktivt möjligheter att lära," +
                                        " växa och förbättra mina färdigheter.");
                                }
                            }
                            break;

                        case 10:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Jag har inte avslutat någon formell utbildning.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Jag har gått någon gymnasieutbildning eller liknande.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Jag har avslutat högskole-/universitetsutbildning eller har en högre examen.");
                                }
                            }
                            break;

                        case 11:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Skyll på den andra personen för att han inte förstår.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Förtydliga situationen och hitta en ömsesidigt acceptabel lösning.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Eskalera ärendet till en arbetsledare eller chef.");
                                }
                            }
                            break;

                        case 12:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Undvik problemet och hoppas att det löser sig på egen hand.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Lyssnar aktivt och söker en ömsesidigt fördelaktig lösning.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Fokusera på att kritisera situationen så att man inte gör om det.");
                                }
                            }
                            break;

                        case 13:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Jag skulle lyssna på båda teammedlemmarnas perspektiv utan att ta någon sida.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Undvika konflikten och hoppas att de löser det själva.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Om konflikten fortsätter eller eskalerar kommer jag att kontakta " +
                                        "en lämplig auktoritetsperson, till exempel en handledare eller chef.");
                                }
                            }
                            break;

                        case 14:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Undvika konflikten och hoppas att den löser sig själv.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Involvera någon utomstående i projektet för att hitta en rättvis lösning för oss.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Jag är osäker på vad jag ska göra i denna situation och tar därför inte del av konflikten.");
                                }
                            }
                            break;

                        case 15:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Ge upp och gå vidare till något annat.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Skylla på externa faktorer för motgången.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Lära av upplevelsen och anpassa mitt tillvägagångssätt.");
                                }
                            }
                            break;

                        case 16:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Jag har ännu inte fått någon arbetslivserfarenhet eller gjort volontärarbete.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Jag har varit involverad i aktiviteter som kan vara fördelaktiga på en arbetsplats.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Jag har tidigare engagerat mig i volontärarbete och har därför erfarenhet.");
                                }
                            }
                            break;

                        case 17:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Jag håller fortfarande på att bestämma mina styrkor och färdigheter.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Jag är bra på att samarbeta och har starka kommunikationsfärdigheter.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Jag har en stark analytisk förmåga och är bra på problemlösning.");
                                }
                            }
                            break;

                        case 18:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Jag söker detta jobb för att skaffa arbetslivserfarenhet och lära mig nya färdigheter.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Jag är motiverad att arbeta inom detta område och bygga en framgångsrik karriär.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Jag bestämmer fortfarande mina karriärsmål, men jag är öppen för möjligheter och ivrig att lära mig mer.");
                                }
                            }
                            break;

                        case 19:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Jag har ingen åsikt i den här frågan.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Jag ser feedback och vägledning som möjligheter att lära mig och förbättra mig själv.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Jag är öppen för feedback men kan behöva tid för att bearbeta och tillämpa den.");
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

