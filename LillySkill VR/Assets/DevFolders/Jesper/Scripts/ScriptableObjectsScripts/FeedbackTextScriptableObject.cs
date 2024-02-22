using JespersCode;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace JesperScriptableObject
/// <summary>
/// ScriptableObject Class that contains strings with feedback text from Beta Version
/// </summary>
{
    [CreateAssetMenu(fileName = "FeedbackTextData", menuName = "ScriptableObjects/FeedbackTextScriptableObject", order = 3)]
    public class FeedbackTextScriptableObject : ScriptableObject
    {

        public string m_BadResultFeedbackText = "Feedback:\n" +
                            "• Brister i förberedelse: Det framgår att du inte hade tillräcklig kunskap om företaget, dess verksamhet och dess värderingar.\n\n" +
                            "• Svag kommunikationsförmåga: Du hade svårt att tydligt kommunicera dina tankar och idéer, vilket gjorde det svårt för intervjuaren att förstå dina kvalifikationer och erfarenheter.\n\n" +
                            "• Otillräckliga svar: Dina svar på intervjufrågorna var inte tillräckligt detaljerade eller relevanta för att visa upp din kompetens och lämplighet för rollen.";
        public string m_AverageResultFeedbackText = "Feedback:\n" +
                            "• Starka kvalifikationer: Du visade upp en imponerande uppsättning av kvalifikationer och erfarenheter som är relevanta för rollen.\n\n" +
                            "• Tydlig kommunikation: Din kommunikationsstil var tydlig och professionell, vilket gjorde det lätt för intervjuaren att följa med och förstå dina svar.\n\n" +
                            "• Engagemang och intresse: Det framgick tydligt att du visade ett genuint intresse för företaget och rollen, vilket är en positiv indikator på din motivation och potential att trivas i arbetsmiljön.";
        public string m_GoodResultFeedbackText = "Feedback:\n" +
                            "• Exceptionell förberedelse: Du visade en djupgående förståelse för företaget, dess bransch och dess kultur, vilket visar på din dedikation och intresse för att lyckas i rollen.\n\n" +
                            "• Övertygande kommunikation: Din förmåga att artikulera dina tankar och idéer var överlägsen, vilket gjorde det enkelt för intervjuaren att förstå din vision och potential för rollen.\n\n" +
                            "• Stark matchning med företagets behov: Dina kvalifikationer och erfarenheter passade perfekt med vad företaget sökte, vilket skapade en stark ömsesidig matchning och potential för långsiktig framgång.";

    }
}

