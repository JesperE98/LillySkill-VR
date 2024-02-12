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
            Play("Hej och välkommen");
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
                        Play("Vilka egenskaper tror du att din framtida arbetsgivare skulle söka eller värdera högst om du sökte jobb på ett lager");
                        break;

                    case 3:
                        Play("Om du har råkat ut för en utmanande situation tidigare, vilket av dessa svar skulle bäst beskriva dig");
                        break;

                    case 4:
                        Play("När det kommer till lagarbete och samarbete, vilket svar beskriver dig mest");
                        break;

                    case 5:
                        Play("Har du någonsin haft konflikter med kollegor förut Om så är fallet, vilket svar beskriver din situation bäst");
                        break;

                    case 6:
                        Play("Hur skulle du vanligtvis hantera feedback eller kritik på en arbetsplats...");
                        break;

                    case 7:
                        Play("Är det någon speciell aktivitet eller hobby du engagerar dig i på din fritid");
                        break;

                    case 8:
                        Play("Var ser du dig själv om 5 år");
                        break;

                    case 9:
                        Play("Ser du personlig utveckling som något viktigt");
                        break;

                    case 10:
                        Play("Vilken utbildningsnivå har du avslutat");
                        break;

                    case 11:
                        Play("Hur skulle du hantera en felkommunikation med en kollega");
                        break;

                    case 12:
                        Play("Vad skulle du säga är det smidigaste sättet att lösa en konflikt på");
                        break;

                    case 13:
                        Play("Hur skulle du hantera en konflikt mellan två teammedlemmar som vägrar att samarbeta");
                        break;

                    case 14:
                        Play("En konflikt har uppstått under ett samarbetsprojekt. Hur skulle du reagera på detta");
                        break;

                    case 15:
                        Play("Hur hanterar du motgångar i din personliga utvecklingsresa");
                        break;

                    case 16:
                        Play("Har du någon tidigare erfarenhet som kan vara fördelaktig på en arbetsplats");
                        break;

                    case 17:
                        Play("Hur skulle du beskriva dina styrkor och färdigheter som kan vara värdefulla i en arbetsmiljö");
                        break;

                    case 18:
                        Play("Vad motiverade dig att söka detta jobb");
                        break;

                    case 19:
                        Play("Hur känner du inför att få feedback och vägledning");
                        break;

                    case 20:
                        Play("Vilka av dessa personliga egenskaper eller värderingar tror du kan vara viktiga för att uppnå en framgångsrik arbetsmiljö");
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
        Play("Föreställ dig att du är på en anställningsintervju för en städtjänst...");
    }
}
