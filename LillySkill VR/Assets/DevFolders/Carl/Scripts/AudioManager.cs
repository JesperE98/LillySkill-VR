using JespersCode;
using System;
using System.Collections;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class AudioManager : MonoBehaviour
{
    [Tooltip("A list containing all the soundsources from the AudioManager. " +
        "\n\nCall function: FindObjectOfType<AudioManager>().Play('NAME'); " +
        "\nWhere NAME is the name of the sound.")]
    public Sound[] sounds;
    private GameManager gameManager;
    private UIManager uiManager;

    private void Awake()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        uiManager = FindAnyObjectByType<UIManager>();
        // Adds an audiosource to the AudioManager. Also makes that, for each audiosource,
        // the data in the list updates the audiosource component values.  
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.spatialBlend = s.spatialBlend;
            s.source.loop = s.loop;
        }
    }

    private void Start()
    {
        Play("Ambience");
    }

    private void Update()
    {
        foreach (Sound s in sounds)
        {
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.spatialBlend = s.spatialBlend;
            s.source.loop = s.loop;
        }

        if (gameManager.LillyIntroDone == true)
        {
            Play("Hej och v�lkommen");
            StartCoroutine(InterviewerIntro(10f));
            gameManager.LillyIntroDone = false;
        }
    }

    /// <summary>
    /// Plays an audioclip with the given name from the AudioManager 
    /// </summary>
    /// <param name="name"></param>
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            // Is written in the console if the name of the audioclip wasn't found
            Debug.LogWarning("Sound: '" + name + "' was not found!");
            return;
        }
        s.source.Play();
    }

    public virtual void PlayAudioClip()
    {
        switch (gameManager.EasyMode)
        {
            case true:
                switch (gameManager.AnswerPageNumber)
                {
                    case 2:
                        Play("Vilka egenskaper tror du att din framtida arbetsgivare skulle s�ka eller v�rdera h�gst om du s�kte jobb p� ett lager");
                        break;

                    case 3:
                        Play("Om du har r�kat ut f�r en utmanande situation tidigare, vilket av dessa svar skulle b�st beskriva dig");
                        break;

                    case 4:
                        Play("N�r det kommer till lagarbete och samarbete, vilket svar beskriver dig mest");
                        break;

                    case 5:
                        Play("Har du n�gonsin haft konflikter med kollegor f�rut Om s� �r fallet, vilket svar beskriver din situation b�st");
                        break;

                    case 6:
                        Play("Hur skulle du vanligtvis hantera feedback eller kritik p� en arbetsplats...");
                        break;

                    case 7:
                        Play("�r det n�gon speciell aktivitet eller hobby du engagerar dig i p� din fritid");
                        break;

                    case 8:
                        Play("Var ser du dig sj�lv om 5 �r");
                        break;

                    case 9:
                        Play("Ser du personlig utveckling som n�got viktigt");
                        break;

                    case 10:
                        Play("Vilken utbildningsniv� har du avslutat");
                        break;

                    case 11:
                        Play("Hur skulle du hantera en felkommunikation med en kollega");
                        break;

                    case 12:
                        Play("Vad skulle du s�ga �r det smidigaste s�ttet att l�sa en konflikt p�");
                        break;

                    case 13:
                        Play("Hur skulle du hantera en konflikt mellan tv� teammedlemmar som v�grar att samarbeta");
                        break;

                    case 14:
                        Play("En konflikt har uppst�tt under ett samarbetsprojekt. Hur skulle du reagera p� detta");
                        break;

                    case 15:
                        Play("Hur hanterar du motg�ngar i din personliga utvecklingsresa");
                        break;

                    case 16:
                        Play("Har du n�gon tidigare erfarenhet som kan vara f�rdelaktig p� en arbetsplats");
                        break;

                    case 17:
                        Play("Hur skulle du beskriva dina styrkor och f�rdigheter som kan vara v�rdefulla i en arbetsmilj�");
                        break;

                    case 18:
                        Play("Vad motiverade dig att s�ka detta jobb");
                        break;

                    case 19:
                        Play("Hur k�nner du inf�r att f� feedback och v�gledning");
                        break;

                    case 20:
                        Play("Vilka av dessa personliga egenskaper eller v�rderingar tror du kan vara viktiga f�r att uppn� en framg�ngsrik arbetsmilj�");
                        break;
                }
                break;

            case false:
                Debug.LogWarning("Easy Mode isn't true! Make sure it's true in order for code to work!");
                break;
        }

    }

    private IEnumerator  InterviewerIntro(float time)
    {
        yield return new WaitForSeconds(time);
        gameManager.InterviewerIntroDone = true;
        Play("F�rest�ll dig att du �r p� en anst�llningsintervju f�r en st�dtj�nst...");
    }
}
