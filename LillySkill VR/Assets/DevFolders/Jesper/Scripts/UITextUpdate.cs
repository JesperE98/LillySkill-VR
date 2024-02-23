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
                if (gameManager.PlayerScore < 7)
                {
                    answerText.text = "Du fick bara " + gameManager.PlayerScore + " po�ng.\n\n " +
                        "Feedback:\n" +
                        "� Brister i f�rberedelse: Det framg�r att du inte hade tillr�cklig kunskap om f�retaget, dess verksamhet och dess v�rderingar.\n\n" +
                        "� Svag kommunikationsf�rm�ga: Du hade sv�rt att tydligt kommunicera dina tankar och id�er, vilket gjorde det sv�rt f�r intervjuaren att f�rst� dina kvalifikationer och erfarenheter.\n\n" +
                        "� Otillr�ckliga svar: Dina svar p� intervjufr�gorna var inte tillr�ckligt detaljerade eller relevanta f�r att visa upp din kompetens och l�mplighet f�r rollen.";
                }
                else if (gameManager.PlayerScore > 7 || gameManager.PlayerScore < 14)
                {
                    answerText.text = "Du fick " + gameManager.PlayerScore + " po�ng. Bra jobbat! Men h�r har du n�got att fundera �ver.\n\n" +
                        "Feedback:\n" +
                        "� Starka kvalifikationer: Du visade upp en imponerande upps�ttning av kvalifikationer och erfarenheter som �r relevanta f�r rollen.\n\n" +
                        "� Tydlig kommunikation: Din kommunikationsstil var tydlig och professionell, vilket gjorde det l�tt f�r intervjuaren att f�lja med och f�rst� dina svar.\n\n" +
                        "� Engagemang och intresse: Det framgick tydligt att du visade ett genuint intresse f�r f�retaget och rollen, vilket �r en positiv indikator p� din motivation och potential att trivas i arbetsmilj�n.";
                }
                else if (gameManager.PlayerScore > 14)
                {
                    answerText.text = "Du fick " + gameManager.PlayerScore + " po�ng! Grymt jobbat! Du kommer acea din intervju!\n\n" +
                        "Feedback:\n" +
                        "� Exceptionell f�rberedelse: Du visade en djupg�ende f�rst�else f�r f�retaget, dess bransch och dess kultur, vilket visar p� din dedikation och intresse f�r att lyckas i rollen.\n\n" +
                        "� �vertygande kommunikation: Din f�rm�ga att artikulera dina tankar och id�er var �verl�gsen, vilket gjorde det enkelt f�r intervjuaren att f�rst� din vision och potential f�r rollen.\n\n" +
                        "� Stark matchning med f�retagets behov: Dina kvalifikationer och erfarenheter passade perfekt med vad f�retaget s�kte, vilket skapade en stark �msesidig matchning och potential f�r l�ngsiktig framg�ng.";
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
                                {// Bra svar
                                    textList[0].text = ("Jag har flera �rs arbetslivserfarenhet, utrustad med en robust kompetens och en djup" +
                                        " f�rst�else f�r olika tekniker och arbetsuppgifter.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {// D�ligt svar
                                    textList[1].text = ("Jag �r sugen p� att b�rja jobba. Trots att jag �nnu inte skaffat specifik arbetserfarenhet" +
                                        "�r jag motiverad att g�ra en positiv inverkan");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                { // Helt ok
                                    textList[2].text = ("Jag har �nnu inte skaffat mig tidigare arbetserfarenhet, " +
                                        "men jag har utvecklat relevanta f�rdigheter genom att uppr�tth�lla renlighet i mitt boende."); 
                                }
                            }
                            break;

                        case 2:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {// Helt ok
                                    textList[0].text = ("H�g arbetskapacitet och f�rm�ga att hantera fysiskt kr�vande arbetsuppgifter.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                { // D�liugt svar
                                    textList[1].text = ("God samarbetsf�rm�ga och f�rm�ga att samarbeta.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                { // Bra svar
                                    textList[2].text = ("Noggrannhet och f�rm�ga att f�lja instruktioner.");
                                }
                            }
                            break;

                        case 3:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                { //Helt ok 
                                    textList[0].text = ("Jag har aldrig r�kat ut f�r en utmanande situation tidigare.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                { // Bra svar
                                    textList[1].text = ("Jag har st�llts inf�r minst en sv�r situation tidigare och antingen " +
                                        "l�ste jag den sj�lv eller v�nde mig till mina v�nner f�r att f� st�d.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                { // D�ligt svar
                                    textList[2].text = ("Jag undviker vanligtvis utmanande situationer.");
                                }
                            }
                            break;

                        case 4:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                { //D�ligt svar
                                    textList[0].text = ("Jag brukar kontrollera teamprojekt och se till att allt g�r min v�g.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {// Helt ok
                                    textList[1].text = ("Jag f�redrar att jobba ensam.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {// Bra svar
                                    textList[2].text = ("Jag v�rdes�tter teamwork, d�r alla arbetar som ett team. ");
                                }
                            }
                            break;

                        case 5:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {// Bra svar
                                    textList[0].text = ("Jag skulle ta itu med konflikten med en kollega genom respektfull kommunikation.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {//Helt ok
                                    textList[1].text = ("Jag har aldrig haft n�gra konflikter med kollegor.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {// D�ligt svar
                                    textList[2].text = ("N�r konflikter uppst�r tenderar jag att h�lla avst�nd och hoppas att de l�ser sig p� egen hand.");
                                }
                            }
                            break;

                        case 6:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                { // D�ligt svar
                                    textList[0].text = ("Jag bryr mig inte om feedback eller kritik eftersom jag vet att jag g�r ett bra jobb.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                { // Bra svar
                                    textList[1].text = ("Jag ser feedback och kritik som n�got positivt, f�r att l�ra mig och kunna v�xa p� min arbetsplats.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {// Helt ok
                                    textList[2].text = ("Jag hanterar inte feedback eller kritik s�rskilt bra.");
                                }
                            }
                            break;

                        case 7:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {// D�ligt svar
                                    textList[0].text = ("Jag �gnar mig inte �t n�gra aktiviteter eller hobbyer p� min fritid.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {// Helt ok
                                    textList[1].text = ("Jag har n�gra aktiviteter eller hobbyer som jag �gnar mig �t p� min fritid.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {// Bra svar
                                    textList[2].text = ("Jag �gnar mig �t specifika aktiviteter eller hobbyer p� min fritid, " +
                                        "f�r min personliga utveckling och intresse.");
                                }
                            }
                            break;

                        case 8:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {// D�ligt svar
                                    textList[0].text = ("Jag har �nnu inte t�nkt p� mina planer i detalj.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {// Bra svar
                                    textList[1].text = ("Jag ser mig sj�lv v�xa tillsammans med f�retaget.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {// Helt ok
                                    textList[2].text = ("Jag t�nker mig att jag tar mig an olika roller med �kat ansvar f�r min personliga utveckling.");
                                }
                            }
                            break;

                        case 9:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {// Bra svar
                                    textList[0].text = ("Personlig utveckling �r avg�rande, och jag s�ker aktivt m�jligheter att l�ra," +
                                        " v�xa och f�rb�ttra mina f�rdigheter.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {//Helt ok
                                    textList[1].text = ("Personlig utveckling �r viktigt f�r mig, men jag har �nnu inte drivit den aktivt fram�t.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {// D�ligt svar
                                    textList[2].text = ("Personlig utveckling �r inte en prioritet f�r mig.");
                                }
                            }
                            break;

                        case 10:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {// D�ligt svar
                                    textList[0].text = ("Jag har inte avslutat n�gon formell utbildning.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {// Bra svar
                                    textList[1].text = ("Jag har avslutat h�gskole-/universitetsutbildning eller har en h�gre examen.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {// Helt ok
                                    textList[2].text = ("Jag har g�tt n�gon gymnasieutbildning eller liknande.");
                                }
                            }
                            break;

                        case 11:
                            if (uiManager.uiPrefabCopyList[1].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {//Bra svar
                                    textList[0].text = ("F�rtydliga situationen och hitta en �msesidigt acceptabel l�sning.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {//D�ligt svar
                                    textList[1].text = ("Eskalera �rendet till en arbetsledare eller chef.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {// Helt ok
                                    textList[2].text = ("Skyll p� den andra personen f�r att han inte f�rst�r.");
                                }
                            }
                            break;

                        case 12:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {// D�ligt svar
                                if (AnswerTextObject[0].activeSelf == true)
                                {
                                    textList[0].text = ("Undvik problemet och hoppas att det l�ser sig p� egen hand.");
                                }// Helt ok
                                else if (AnswerTextObject[1].activeSelf == true)
                                {
                                    textList[1].text = ("Fokusera p� att kritisera situationen s� att man inte g�r om det.");
                                }// Bra svar
                                else if (AnswerTextObject[2].activeSelf == true)
                                {
                                    textList[2].text = ("Lyssnar aktivt och s�ker en �msesidigt f�rdelaktig l�sning");
                                }
                            }
                            break;

                        case 13:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {//Helt ok
                                    textList[0].text = ("Jag skulle lyssna p� b�da teammedlemmarnas perspektiv utan att ta n�gon sida.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {// D�ligt svar
                                    textList[1].text = ("Undvika konflikten och hoppas att de l�ser det sj�lva.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {// Bra svar
                                    textList[2].text = ("Om konflikten forts�tter eller eskalerar kommer jag att kontakta " +
                                        "en l�mplig auktoritetsperson, till exempel en handledare eller chef.");
                                }
                            }
                            break;

                        case 14:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {// Bra svar
                                    textList[0].text = ("Involvera n�gon utomst�ende i projektet f�r att hitta en r�ttvis l�sning f�r oss.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {// Helt ok
                                    textList[1].text = ("Jag �r os�ker p� vad jag ska g�ra i denna situation och tar d�rf�r inte del av konflikten.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {// D�ligt svar
                                    textList[2].text = ("Undvika konflikten och hoppas att den l�ser sig sj�lv.");
                                }
                            }
                            break;

                        case 15:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {// D�ligt svar
                                    textList[0].text = ("Skylla p� externa faktorer f�r motg�ngen.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {// Bra svar
                                    textList[1].text = ("L�ra av upplevelsen och anpassa mitt tillv�gag�ngss�tt.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {// Helt ok
                                    textList[2].text = ("Ge upp och g� vidare till n�got annat.");
                                }
                            }
                            break;

                        case 16:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {// Bra svar
                                    textList[0].text = ("Jag har tidigare engagerat mig i volont�rarbete och har d�rf�r erfarenhet.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {// D�ligt svar
                                    textList[1].text = ("Jag har �nnu inte f�tt n�gon arbetslivserfarenhet eller gjort volont�rarbete.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {// Helt ok
                                    textList[2].text = ("Jag har varit involverad i aktiviteter som kan vara f�rdelaktiga p� en arbetsplats.");
                                }
                            }
                            break;

                        case 17:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {// Bra svar
                                    textList[0].text = ("Jag �r bra p� att samarbeta och har starka kommunikationsf�rdigheter.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {// Helt ok
                                    textList[1].text = ("Jag har en stark analytisk f�rm�ga och �r bra p� probleml�sning.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {// D�ligt svar
                                    textList[2].text = ("Jag h�ller fortfarande p� att best�mma mina styrkor och f�rdigheter.");
                                }
                            }
                            break;

                        case 18:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {// Bra svar
                                    textList[0].text = ("Jag �r motiverad att arbeta inom detta omr�de och bygga en framg�ngsrik karri�r.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {// Helt ok
                                    textList[1].text = ("Jag best�mmer fortfarande mina karri�rsm�l, men jag �r �ppen f�r m�jligheter och ivrig att l�ra mig mer.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {// D�ligt svar
                                    textList[2].text = ("Jag s�ker detta jobb f�r att skaffa arbetslivserfarenhet och l�ra mig nya f�rdigheter.");
                                }
                            }
                            break;

                        case 19:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {// D�ligt svar
                                    textList[0].text = ("Jag har ingen �sikt i den h�r fr�gan.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {// Bra svar
                                    textList[1].text = ("Jag ser feedback och v�gledning som m�jligheter att l�ra mig och f�rb�ttra mig sj�lv.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {// Helt ok
                                    textList[2].text = ("Jag �r �ppen f�r feedback men kan beh�va tid f�r att bearbeta och till�mpa den.");
                                }
                            }
                            break;

                        case 20:
                            if (uiManager.uiPrefabCopyList[0].activeSelf == true)
                            {
                                if (AnswerTextObject[0].activeSelf == true)
                                {// D�ligt svar
                                    textList[0].text = ("Att vara impulsiv och envis.");
                                }
                                else if (AnswerTextObject[1].activeSelf == true)
                                {// Helt ok
                                    textList[1].text = ("Att vara effektiv och organiserad.");
                                }
                                else if (AnswerTextObject[2].activeSelf == true)
                                {// Bra svar
                                    textList[2].text = ("Att ha god teamwork och kommunikation.");
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

