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
            { "Jag �r sugen p� att b�rja jobba. " +
                "Trots att jag �nnu inte skaffat specifik arbetserfarenhet " +
                "�r jag motiverad att g�ra en positiv inverkan." },
            { "God samarbetsf�rm�ga och f�rm�ga att samarbeta." },
            { "Jag undviker vanligtvis utmanande situationer." },
            { "Jag brukar kontrollera teamprojekt och se till att allt g�r min v�g." },
            { "N�r konflikter uppst�r tenderar jag att h�lla avst�nd och hoppas att de l�ser sig p� egen hand." },
            { "Jag bryr mig inte om feedback eller kritik eftersom jag vet att jag g�r ett bra jobb." },
            { "Jag �gnar mig inte �t n�gra aktiviteter eller hobbyer p� min fritid." },
            { "Jag har �nnu inte t�nkt p� mina planer i detalj." },
            { "Personlig utveckling �r inte en prioritet f�r mig." },
            { "Jag har inte avslutat n�gon formell utbildning." },
            { "Eskalera �rendet till en arbetsledare eller chef." },
            { "Undvik problemet och hoppas att det l�ser sig p� egen hand." },
            { "Undvika konflikten och hoppas att de l�ser det sj�lva." },
            { "Undvika konflikten och hoppas att den l�ser sig sj�lv." },
            { "Skylla p� externa faktorer f�r motg�ngen." },
            { "Jag har �nnu inte f�tt n�gon arbetslivserfarenhet eller gjort volont�rarbete." },
            { "Jag h�ller fortfarande p� att best�mma mina styrkor och f�rdigheter." },
            { "Jag s�ker detta jobb f�r att skaffa arbetslivserfarenhet och l�ra mig nya f�rdigheter." },
            { "Jag har ingen �sikt i den h�r fr�gan." },
            { "Att vara impulsiv och envis." }
        };

        /// <summary>
        /// List that contains all teh average answers.
        /// </summary>
        public List<string> m_InterviewAverageAnswerList = new List<string>()
        {
            { "Jag har �nnu inte skaffat mig tidigare arbetserfarenhet, " +
                "men jag har utvecklat relevanta f�rdigheter genom " +
                "att uppr�tth�lla renlighet i mitt boende." },
            { "H�g arbetskapacitet och f�rm�ga att hantera fysiskt kr�vande arbetsuppgifter." },
            { "Jag har aldrig r�kat ut f�r en utmanande situation tidigare." },
            { "Jag f�redrar att jobba ensam." },
            { "Jag har aldrig haft n�gra konflikter med kollegor." },
            { "Jag hanterar inte feedback eller kritik s�rskilt bra." },
            { "Jag har n�gra aktiviteter eller hobbyer som jag �gnar mig �t p� min fritid." },
            { "Jag t�nker mig att jag tar mig an olika roller med �kat ansvar f�r min personliga utveckling." },
            { "Personlig utveckling �r viktigt f�r mig, men jag har �nnu inte drivit den aktivt fram�t." },
            { "Jag har g�tt n�gon gymnasieutbildning eller liknande." },
            { "Skyll p� den andra personen f�r att han inte f�rst�r." },
            { "Fokusera p� att kritisera situationen s� att man inte g�r om det." },
            { "Jag skulle lyssna p� b�da teammedlemmarnas perspektiv utan att ta n�gon sida." },
            { "Jag �r os�ker p� vad jag ska g�ra i denna situation och tar d�rf�r inte del av konflikten." },
            { "Ge upp och g� vidare till n�got annat." },
            { "Jag har varit involverad i aktiviteter som kan vara f�rdelaktiga p� en arbetsplats." },
            { "Jag har en stark analytisk f�rm�ga och �r bra p� probleml�sning." },
            { "Jag best�mmer fortfarande mina karri�rsm�l, men jag �r �ppen f�r m�jligheter och ivrig att l�ra mig mer." },
            { "Jag �r �ppen f�r feedback men kan beh�va tid f�r att bearbeta och till�mpa den." },
            { "Att vara effektiv och organiserad." }
        };

        /// <summary>
        /// List that contains all the good answers.
        /// </summary>
        public List<string> m_InterviewGoodAnswerList = new List<string>()
        {
            { "Jag har flera �rs arbetslivserfarenhet, " +
                "utrustad med en robust kompetens och en djup " +
                "f�rst�else f�r olika tekniker och arbetsuppgifter." },
            { "Noggrannhet och f�rm�ga att f�lja instruktioner." },
            { "Jag har st�llts inf�r minst en sv�r situation tidigare och " +
                "antingen l�ste jag den sj�lv eller v�nde mig till mina v�nner f�r att f� st�d." },
            { "Jag v�rdes�tter teamwork, d�r alla arbetar som ett team." },
            { "Jag skulle ta itu med konflikten med en kollega genom respektfull kommunikation." },
            { "Jag ser feedback och kritik som n�got positivt, f�r att l�ra mig och kunna v�xa p� min arbetsplats." },
            { "Jag �gnar mig �t specifika aktiviteter eller hobbyer p� min fritid, f�r min personliga utveckling och intresse." },
            { "Jag ser mig sj�lv v�xa tillsammans med f�retaget." },
            { "Personlig utveckling �r avg�rande, och jag s�ker aktivt m�jligheter att l�ra, v�xa och f�rb�ttra mina f�rdigheter." },
            { "Jag har avslutat h�gskole-/universitetsutbildning eller har en h�gre examen." },
            { "F�rtydliga situationen och hitta en �msesidigt acceptabel l�sning." },
            { "Lyssnar aktivt och s�ker en �msesidigt f�rdelaktig l�sning." },
            { "Om konflikten forts�tter eller eskalerar kommer jag att kontakta en l�mplig auktoritetsperson, " +
                "till exempel en handledare eller chef." },
            { "Involvera n�gon utomst�ende i projektet f�r att hitta en r�ttvis l�sning f�r oss." },
            { "L�ra av upplevelsen och anpassa mitt tillv�gag�ngss�tt." },
            { "Jag har tidigare engagerat mig i volont�rarbete och har d�rf�r erfarenhet." },
            { "Jag �r bra p� att samarbeta och har starka kommunikationsf�rdigheter." },
            { "Jag �r motiverad att arbeta inom detta omr�de och bygga en framg�ngsrik karri�r." },
            { "Jag ser feedback och v�gledning som m�jligheter att l�ra mig och f�rb�ttra mig sj�lv." },
            { "Att ha god teamwork och kommunikation." }
        };
    }
}

