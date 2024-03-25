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
            { "Föreställ dig att du är på en anställningsintervju för en städtjänst. " +
                "Intervjuaren ber dig att gå igenom dina tidigare arbetserfarenheter. " +
                "Vilket av följande alternativ beskriver bäst din situation." },
            { "Vilka egenskaper tror du att din framtida arbetsgivare skulle söka eller värdera högst om du sökte jobb på ett lager?" },
            { "Om du har råkat ut för en utmanande situation tidigare, vilket av dessa svar skulle bäst beskriva dig?" },
            { "När det kommer till lagarbete och samarbete, vilket svar beskriver dig mest?" },
            { "Har du någonsin haft konflikter med kollegor förut? Om så är fallet, vilket svar beskriver din situation bäst?" },
            { "Hur skulle du vanligtvis hantera feedback eller kritik på en arbetsplats? Vilket av dessa svar beskriver dig bäst?" },
            { "Är det några aktiviteter eller hobbyer du håller på med på din fritid?" },
            { "Var ser du dig själv om 5 år?" },
            { "Ser du personlig utveckling som något viktigt?" },
            { "Vilken utbildningsnivå har du avslutat?" },
            { "Hur skulle du hantera en felkommunikation med en kollega?" },
            { "Vad skulle du säga är det smidigaste sättet att lösa en konflikt på?" },
            { "Hur skulle du hantera en konflikt mellan två teammedlemmar som vägrar att samarbeta?" },
            { "En konflikt har uppstått under ett samarbetsprojekt. Hur skulle du reagera på detta?" },
            { "Hur hanterar du motgångar i din personliga utvecklingsresa?" },
            { "Har du någon tidigare erfarenhet som kan vara fördelaktig på en arbetsplats?" },
            { "Hur skulle du beskriva dina styrkor och färdigheter som kan vara värdefulla i en arbetsmiljö?" },
            { "Vad motiverade dig att söka detta jobb?" },
            { "Hur känner du inför att få feedback och vägledning?" },
            { "Vilka av dessa personliga egenskaper eller värderingar tror du kan vara viktiga för att uppnå en framgångsrik arbetsmiljö?" },
        };
    }
}

