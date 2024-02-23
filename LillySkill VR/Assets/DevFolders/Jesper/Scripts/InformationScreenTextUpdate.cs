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
                        informationPageText.text = "F�rest�ll dig att du �r p� en anst�llningsintervju f�r en st�dtj�nst. Intervjuaren ber dig att g� " +
                            "igenom dina tidigare arbetserfarenheter. Vilket av f�ljande alternativ beskriver b�st din situation.";
                        break;

                    case 2:
                        informationPageText.text = "Vilka egenskaper tror du att din framtida arbetsgivare skulle s�ka eller v�rdera h�gst om du s�kte jobb p� ett lager?";
                        break;

                    case 3:
                        informationPageText.text = "Om du har r�kat ut f�r en utmanande situation tidigare, vilket av dessa svar skulle b�st beskriva dig?";
                        break;

                    case 4:
                        informationPageText.text = "N�r det kommer till lagarbete och samarbete, vilket svar beskriver dig b�st?";
                        break;

                    case 5:
                        informationPageText.text = "Har du n�gonsin haft konflikter med kollegor f�rut? Om s� �r fallet, vilket svar beskriver din situation b�st?";
                        break;

                    case 6:
                        informationPageText.text = "Hur skulle du vanligtvis hantera feedback eller kritik p� en arbetsplats? Vilket av dessa svar beskriver dig b�st?";
                        break;

                    case 7:
                        informationPageText.text = "�r det n�gra aktiviteter eller hobbyer du h�ller p� med p� din fritid?";
                        break;

                    case 8:
                        informationPageText.text = "Var ser du dig sj�lv om 5 �r?";
                        break;

                    case 9:
                        informationPageText.text = "Ser du personlig utveckling som n�got viktigt?";
                        break;

                    case 10:
                        informationPageText.text = "Vilken utbildningsniv� har du avslutat?";
                        break;

                    case 11:
                        informationPageText.text = "Hur skulle du hantera en felkommunikation med en kollega?";
                        break;

                    case 12:
                        informationPageText.text = "Vad skulle du s�ga �r det smidigaste s�ttet att l�sa en konflikt p�?";
                        break;

                    case 13:
                        informationPageText.text = "Hur skulle du hantera en konflikt mellan tv� teammedlemmar som v�grar att samarbeta?";
                        break;

                    case 14:
                        informationPageText.text = "En konflikt har uppst�tt under ett samarbetsprojekt. Hur skulle du reagera p� detta?";
                        break;

                    case 15:
                        informationPageText.text = "Hur hanterar du motg�ngar i din personliga utvecklingsresa?";
                        break;

                    case 16:
                        informationPageText.text = "Har du n�gon tidigare erfarenhet som kan vara f�rdelaktig p� en arbetsplats?";
                        break;

                    case 17:
                        informationPageText.text = "Hur skulle du beskriva dina styrkor och f�rdigheter som kan vara v�rdefulla i en arbetsmilj�?";
                        break;

                    case 18:
                        informationPageText.text = "Vad motiverade dig att s�ka detta jobb?";
                        break;

                    case 19:
                        informationPageText.text = "Hur k�nner du inf�r att f� feedback och v�gledning?";
                        break;

                    case 20:
                        informationPageText.text = "Vilka av dessa personliga egenskaper eller v�rderingar tror du kan vara viktiga f�r att uppn� en framg�ngsrik arbetsmilj�?";
                        break;
                }
                break;

            case false:
                Debug.LogWarning("Easy Mode isn't true! Make sure it's true in order for code to work!");
                break;
        }
    }
}
