using JespersCode;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InformationScerenTextUpdate : MonoBehaviour
{
    private GameManager gameManager;
    private TMP_Text informationPageText;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

        informationPageText = GetComponent<TMP_Text>();
    }

    void Update()
    {
        if(gameManager.InterviewAreActive == true) { UpdateInformationScreenText(); }
    }

    private void UpdateInformationScreenText()
    {
        switch (gameManager.EasyMode)
        {
            case true:
                switch (gameManager.AnswerPageNumber)
                {
                    case 1:
                        informationPageText.text = "Föreställ dig att du är på en anställningsintervju för en städtjänst. Intervjuaren ber dig att gå " +
                            "igenom dina tidigare arbetserfarenheter. Vilket av följande alternativ beskriver bäst din situation.";
                        break;

                    case 2:
                        informationPageText.text = "Vilka egenskaper tror du att din framtida arbetsgivare skulle söka eller värdera högst om du sökte jobb på ett lager?";
                        break;

                    case 3:
                        informationPageText.text = "Om du har råkat ut för en utmanande situation tidigare, vilket av dessa svar skulle bäst beskriva dig?";
                        break;

                    case 4:
                        informationPageText.text = "När det kommer till lagarbete och samarbete, vilket svar beskriver dig bäst?";
                        break;

                    case 5:
                        informationPageText.text = "Har du någonsin haft konflikter med kollegor förut? Om så är fallet, vilket svar beskriver din situation bäst?";
                        break;

                    case 6:
                        informationPageText.text = "Hur skulle du vanligtvis hantera feedback eller kritik på en arbetsplats? Vilket av dessa svar beskriver dig bäst?";
                        break;

                    case 7:
                        informationPageText.text = "Är det några aktiviteter eller hobbyer du håller på med på din fritid?";
                        break;

                    case 8:
                        informationPageText.text = "Var ser du dig själv om 5 år?";
                        break;

                    case 9:
                        informationPageText.text = "Ser du personlig utveckling som något viktigt?";
                        break;

                    case 10:
                        informationPageText.text = "Vilken utbildningsnivå har du avslutat?";
                        break;

                    case 11:
                        informationPageText.text = "Hur skulle du hantera en felkommunikation med en kollega?";
                        break;

                    case 12:
                        informationPageText.text = "Vad skulle du säga är det smidigaste sättet att lösa en konflikt på?";
                        break;

                    case 13:
                        informationPageText.text = "Hur skulle du hantera en konflikt mellan två teammedlemmar som vägrar att samarbeta?";
                        break;

                    case 14:
                        informationPageText.text = "En konflikt har uppstått under ett samarbetsprojekt. Hur skulle du reagera på detta?";
                        break;

                    case 15:
                        informationPageText.text = "Hur hanterar du motgångar i din personliga utvecklingsresa?";
                        break;

                    case 16:
                        informationPageText.text = "Har du någon tidigare erfarenhet som kan vara fördelaktig på en arbetsplats?";
                        break;

                    case 17:
                        informationPageText.text = "Hur skulle du beskriva dina styrkor och färdigheter som kan vara värdefulla i en arbetsmiljö?";
                        break;

                    case 18:
                        informationPageText.text = "Vad motiverade dig att söka detta jobb?";
                        break;

                    case 19:
                        informationPageText.text = "Hur känner du inför att få feedback och vägledning?";
                        break;

                    case 20:
                        informationPageText.text = "Vilka av dessa personliga egenskaper eller värderingar tror du kan vara viktiga för att uppnå en framgångsrik arbetsmiljö?";
                        break;
                }
                break;

            case false:
                Debug.LogWarning("Easy Mode isn't true! Make sure it's true in order for code to work!");
                break;
        }
    }
}
