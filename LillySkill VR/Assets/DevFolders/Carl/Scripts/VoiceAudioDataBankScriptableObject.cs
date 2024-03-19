using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "VoiceAudioDataBank", menuName = "ScriptableObjects/VoiceAudioDataBankScriptableObject", order = 2)]
public class VoiceAudioDataBankScriptableObject : ScriptableObject
{
    public List<DefaultAudioScriptableObject> questions;
}
