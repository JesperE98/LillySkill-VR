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
                            "� Brister i f�rberedelse: Det framg�r att du inte hade tillr�cklig kunskap om f�retaget, dess verksamhet och dess v�rderingar.\n\n" +
                            "� Svag kommunikationsf�rm�ga: Du hade sv�rt att tydligt kommunicera dina tankar och id�er, vilket gjorde det sv�rt f�r intervjuaren att f�rst� dina kvalifikationer och erfarenheter.\n\n" +
                            "� Otillr�ckliga svar: Dina svar p� intervjufr�gorna var inte tillr�ckligt detaljerade eller relevanta f�r att visa upp din kompetens och l�mplighet f�r rollen.";
        public string m_AverageResultFeedbackText = "Feedback:\n" +
                            "� Starka kvalifikationer: Du visade upp en imponerande upps�ttning av kvalifikationer och erfarenheter som �r relevanta f�r rollen.\n\n" +
                            "� Tydlig kommunikation: Din kommunikationsstil var tydlig och professionell, vilket gjorde det l�tt f�r intervjuaren att f�lja med och f�rst� dina svar.\n\n" +
                            "� Engagemang och intresse: Det framgick tydligt att du visade ett genuint intresse f�r f�retaget och rollen, vilket �r en positiv indikator p� din motivation och potential att trivas i arbetsmilj�n.";
        public string m_GoodResultFeedbackText = "Feedback:\n" +
                            "� Exceptionell f�rberedelse: Du visade en djupg�ende f�rst�else f�r f�retaget, dess bransch och dess kultur, vilket visar p� din dedikation och intresse f�r att lyckas i rollen.\n\n" +
                            "� �vertygande kommunikation: Din f�rm�ga att artikulera dina tankar och id�er var �verl�gsen, vilket gjorde det enkelt f�r intervjuaren att f�rst� din vision och potential f�r rollen.\n\n" +
                            "� Stark matchning med f�retagets behov: Dina kvalifikationer och erfarenheter passade perfekt med vad f�retaget s�kte, vilket skapade en stark �msesidig matchning och potential f�r l�ngsiktig framg�ng.";

    }
}

