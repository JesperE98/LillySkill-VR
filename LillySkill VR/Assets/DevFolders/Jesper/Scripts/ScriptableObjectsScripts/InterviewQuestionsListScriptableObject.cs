using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

namespace JesperScriptableObject
{
    /// <summary>
    /// ScriptableObject Class that cointains a List with all the default interview questions. from Beta Version
    /// </summary>
    [CreateAssetMenu(fileName = "InterviewQuestionsListData", menuName = "ScriptableObjects/InterviewQuestionsListScriptableObject", order = 1)]
    public class InterviewQuestionsListScriptableObject : ScriptableObject
    {
        /// <summary>
        /// List that contains all the interview questions from the default exercise section.
        /// </summary>
        public List<string> m_QuestionList = new List<string>()
        {
            { "F�rest�ll dig att du �r p� en anst�llningsintervju f�r en st�dtj�nst. " +
                "Intervjuaren ber dig att g� igenom dina tidigare arbetserfarenheter. " +
                "Vilket av f�ljande alternativ beskriver b�st din situation." },
            { "Vilka egenskaper tror du att din framtida arbetsgivare skulle s�ka eller v�rdera h�gst om du s�kte jobb p� ett lager?" },
            { "Om du har r�kat ut f�r en utmanande situation tidigare, vilket av dessa svar skulle b�st beskriva dig?" },
            { "N�r det kommer till lagarbete och samarbete, vilket svar beskriver dig mest?" },
            { "Har du n�gonsin haft konflikter med kollegor f�rut? Om s� �r fallet, vilket svar beskriver din situation b�st?" },
            { "Hur skulle du vanligtvis hantera feedback eller kritik p� en arbetsplats? Vilket av dessa svar beskriver dig b�st?" },
            { "�r det n�gra aktiviteter eller hobbyer du h�ller p� med p� din fritid?" },
            { "Var ser du dig sj�lv om 5 �r?" },
            { "Ser du personlig utveckling som n�got viktigt?" },
            { "Vilken utbildningsniv� har du avslutat?" },
            { "Hur skulle du hantera en felkommunikation med en kollega?" },
            { "Vad skulle du s�ga �r det smidigaste s�ttet att l�sa en konflikt p�?" },
            { "Hur skulle du hantera en konflikt mellan tv� teammedlemmar som v�grar att samarbeta?" },
            { "En konflikt har uppst�tt under ett samarbetsprojekt. Hur skulle du reagera p� detta?" },
            { "Hur hanterar du motg�ngar i din personliga utvecklingsresa?" },
            { "Har du n�gon tidigare erfarenhet som kan vara f�rdelaktig p� en arbetsplats?" },
            { "Hur skulle du beskriva dina styrkor och f�rdigheter som kan vara v�rdefulla i en arbetsmilj�?" },
            { "Vad motiverade dig att s�ka detta jobb?" },
            { "Hur k�nner du inf�r att f� feedback och v�gledning?" },
            { "Vilka av dessa personliga egenskaper eller v�rderingar tror du kan vara viktiga f�r att uppn� en framg�ngsrik arbetsmilj�?" },
        };
    }
}

