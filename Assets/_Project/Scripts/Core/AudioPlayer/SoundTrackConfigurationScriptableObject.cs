using UnityEngine;

namespace Arcade._Project.Core.AudioPlayer
{
    [CreateAssetMenu(fileName = "SoundTrackConfig", menuName = "Audio/SoundTrackConfig", order = 100)]
    public class SoundTrackConfigurationScriptableObject : ScriptableObject
    {
        public string clipName;
        public AudioClip soundTracks;
        public bool loop;
        
        [field: Range(0f, 1f)]
        public float volume;
    }
}