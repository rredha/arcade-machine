using System;
using Arcade.Project.Runtime.Core.AudioPlayer;
using UnityEngine;

namespace Arcade.Project.Runtime.Games.Breakout
{
    public class AudioManager : AudioPlayer
    {
       [SerializeField] private AudioDataScriptableObject audioData;
        // Start is called before the first frame update
        /*
        void Awake()
        {
            foreach(Sounds s in audioData) {
                s.source = gameObject.AddComponent<AudioSource>();
                s.source.clip = s.clip;
                s.source.volume = s.volume;
                s.source.loop = s.loop;
            }
        }

    */
    }
}
        /*
        void Start() {
            Play("Cave");
        }

        public void Play(string name) {
            Sounds s =  Array.Find(sounds, sound => sound.name == name);
            if (s == null) {
                Debug.LogWarning("Sound: " + name + " not found.");
                return;
            }

            if (PauseMenu.IsGamePaused) {
                s.source.volume *= 0.25f;
            }
            s.source.Play();
        }
        */
