using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "VoiceAudioData", menuName = "ScriptableObjects/VoiceAudioScriptableObject", order = 2)]
public class VoiceAudioScriptableObject : ScriptableObject
{
    public List<DefaultAudioScriptableObject> questions;
}
