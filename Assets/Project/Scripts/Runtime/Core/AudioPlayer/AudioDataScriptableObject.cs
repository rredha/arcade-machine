using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Arcade.Project.Runtime.Core.AudioPlayer
{
    [CreateAssetMenu(fileName = "SoundTrack", menuName = "Audio/SoundTrack", order = 100)]
    public class AudioDataScriptableObject : ScriptableObject
    {
        public string gameName;
        public SoundTrackConfigurationScriptableObject[] soundTrackConfigArray;
    }
}
