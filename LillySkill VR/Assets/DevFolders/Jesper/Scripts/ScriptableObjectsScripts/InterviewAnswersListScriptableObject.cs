using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

namespace JesperScriptableObject
{
    /// <summary>
    /// ScriptableObject Class that contains Lists with answers from Beta Version
    /// </summary>
    [CreateAssetMenu(fileName = "InterviewAnswersListData", menuName = "ScriptableObjects/InterviewAnswersListScriptableObject", order = 2)]
    public class InterviewAnswersListScriptableObject : ScriptableObject
    {
        /// <summary>
        /// List that contains all the bad answers.
        /// </summary>
        public List<string> m_InterviewBadAnswerList = new List<string>()
        {
            { "Jag är sugen på att börja jobba. " +
                "Trots att jag ännu inte skaffat specifik arbetserfarenhet " +
                "är jag motiverad att göra en positiv inverkan." },
            { "God samarbetsförmåga och förmåga att samarbeta." },
            { "Jag undviker vanligtvis utmanande situationer." },
            { "Jag brukar kontrollera teamprojekt och se till att allt går min väg." },
            { "När konflikter uppstår tenderar jag att hålla avstånd och hoppas att de löser sig på egen hand." },
            { "Jag bryr mig inte om feedback eller kritik eftersom jag vet att jag gör ett bra jobb." },
            { "Jag ägnar mig inte åt några aktiviteter eller hobbyer på min fritid." },
            { "Jag har ännu inte tänkt på mina planer i detalj." },
            { "Personlig utveckling är inte en prioritet för mig." },
            { "Jag har inte avslutat någon formell utbildning." },
            { "Eskalera ärendet till en arbetsledare eller chef." },
            { "Undvik problemet och hoppas att det löser sig på egen hand." },
            { "Undvika konflikten och hoppas att de löser det själva." },
            { "Undvika konflikten och hoppas att den löser sig själv." },
            { "Skylla på externa faktorer för motgången." },
            { "Jag har ännu inte fått någon arbetslivserfarenhet eller gjort volontärarbete." },
            { "Jag håller fortfarande på att bestämma mina styrkor och färdigheter." },
            { "Jag söker detta jobb för att skaffa arbetslivserfarenhet och lära mig nya färdigheter." },
            { "Jag har ingen åsikt i den här frågan." },
            { "Att vara impulsiv och envis." }
        };

        /// <summary>
        /// List that contains all teh average answers.
        /// </summary>
        public List<string> m_InterviewAverageAnswerList = new List<string>()
        {
            { "Jag har ännu inte skaffat mig tidigare arbetserfarenhet, " +
                "men jag har utvecklat relevanta färdigheter genom " +
                "att upprätthålla renlighet i mitt boende." },
            { "Hög arbetskapacitet och förmåga att hantera fysiskt krävande arbetsuppgifter." },
            { "Jag har aldrig råkat ut för en utmanande situation tidigare." },
            { "Jag föredrar att jobba ensam." },
            { "Jag har aldrig haft några konflikter med kollegor." },
            { "Jag hanterar inte feedback eller kritik särskilt bra." },
            { "Jag har några aktiviteter eller hobbyer som jag ägnar mig åt på min fritid." },
            { "Jag tänker mig att jag tar mig an olika roller med ökat ansvar för min personliga utveckling." },
            { "Personlig utveckling är viktigt för mig, men jag har ännu inte drivit den aktivt framåt." },
            { "Jag har gått någon gymnasieutbildning eller liknande." },
            { "Skyll på den andra personen för att han inte förstår." },
            { "Fokusera på att kritisera situationen så att man inte gör om det." },
            { "Jag skulle lyssna på båda teammedlemmarnas perspektiv utan att ta någon sida." },
            { "Jag är osäker på vad jag ska göra i denna situation och tar därför inte del av konflikten." },
            { "Ge upp och gå vidare till något annat." },
            { "Jag har varit involverad i aktiviteter som kan vara fördelaktiga på en arbetsplats." },
            { "Jag har en stark analytisk förmåga och är bra på problemlösning." },
            { "Jag bestämmer fortfarande mina karriärsmål, men jag är öppen för möjligheter och ivrig att lära mig mer." },
            { "Jag är öppen för feedback men kan behöva tid för att bearbeta och tillämpa den." },
            { "Att vara effektiv och organiserad." }
        };

        /// <summary>
        /// List that contains all the good answers.
        /// </summary>
        public List<string> m_InterviewGoodAnswerList = new List<string>()
        {
            { "Jag har flera års arbetslivserfarenhet, " +
                "utrustad med en robust kompetens och en djup " +
                "förståelse för olika tekniker och arbetsuppgifter." },
            { "Noggrannhet och förmåga att följa instruktioner." },
            { "Jag har ställts inför minst en svår situation tidigare och " +
                "antingen löste jag den själv eller vände mig till mina vänner för att få stöd." },
            { "Jag värdesätter teamwork, där alla arbetar som ett team." },
            { "Jag skulle ta itu med konflikten med en kollega genom respektfull kommunikation." },
            { "Jag ser feedback och kritik som något positivt, för att lära mig och kunna växa på min arbetsplats." },
            { "Jag ägnar mig åt specifika aktiviteter eller hobbyer på min fritid, för min personliga utveckling och intresse." },
            { "Jag ser mig själv växa tillsammans med företaget." },
            { "Personlig utveckling är avgörande, och jag söker aktivt möjligheter att lära, växa och förbättra mina färdigheter." },
            { "Jag har avslutat högskole-/universitetsutbildning eller har en högre examen." },
            { "Förtydliga situationen och hitta en ömsesidigt acceptabel lösning." },
            { "Lyssnar aktivt och söker en ömsesidigt fördelaktig lösning." },
            { "Om konflikten fortsätter eller eskalerar kommer jag att kontakta en lämplig auktoritetsperson, " +
                "till exempel en handledare eller chef." },
            { "Involvera någon utomstående i projektet för att hitta en rättvis lösning för oss." },
            { "Lära av upplevelsen och anpassa mitt tillvägagångssätt." },
            { "Jag har tidigare engagerat mig i volontärarbete och har därför erfarenhet." },
            { "Jag är bra på att samarbeta och har starka kommunikationsfärdigheter." },
            { "Jag är motiverad att arbeta inom detta område och bygga en framgångsrik karriär." },
            { "Jag ser feedback och vägledning som möjligheter att lära mig och förbättra mig själv." },
            { "Att ha god teamwork och kommunikation." }
        };
    }
}

