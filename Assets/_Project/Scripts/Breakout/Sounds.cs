using UnityEngine;

namespace Arcade._Project.Breakout
{
    [System.Serializable]
    public class Sounds {
        public string name;
        public AudioClip clip;

        public bool loop;

        [Range(0f, 1f)]
        public float volume;

        [HideInInspector]
        public AudioSource source;
    }
}
