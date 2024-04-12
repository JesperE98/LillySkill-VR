using Jesper.GameSettings.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAudioLevel : MonoBehaviour
{
    [SerializeField]
    private GameSettingsScriptableObject m_GameSettings;

    public void SetMusicVolume(float setMusicVolume)
    {
        m_GameSettings.ChangeMusicLevel(setMusicVolume);
    }

    public void SetVoiceVolume(float setVoiceVolume)
    {
        m_GameSettings.ChangeVoiceLevel(setVoiceVolume);
    }

    public void SetSFXVolume(float setSFXVolume)
    {
        m_GameSettings.ChangeSFXLevel(setSFXVolume);
    }
}
