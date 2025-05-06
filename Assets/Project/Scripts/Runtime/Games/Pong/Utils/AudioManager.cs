using UnityEngine;
using Arcade.Project.Runtime.Core.AudioPlayer;

namespace Arcade.Project.Runtime.Games.Pong
{
    public class AudioManager : AudioPlayer
    {
       public AudioDataScriptableObject myAudioData;

       private string _gameName;
       private string _clipName;

       private AudioClip[] soundTracks;
       private AudioClip _backgroundAudioClip;
       public AudioClip _hitAudioClip {  get; private set; }
       public AudioClip _missAudioClip { get; private set; }

       private AudioSource _audioSource;
       private void Awake()
       {
           _audioSource = gameObject.AddComponent<AudioSource>();
           if (myAudioData.gameName != "Pong") return;
           foreach (var soundTrack in myAudioData.soundTrackConfigArray)
           {
               if (soundTrack.clipName == "Background")
               {
                   _backgroundAudioClip = soundTrack.soundTracks;
               } else if (soundTrack.clipName == "Hit")
               {
                   _hitAudioClip = soundTrack.soundTracks;
               } else if (soundTrack.clipName == "Miss")
               {
                   _missAudioClip = soundTrack.soundTracks;
               }
           }
       }

       private void Start()
       {
           PlaySound(_backgroundAudioClip, 0);
       }

       public void PlaySound(AudioClip audioClip, int idx)
       {
           _audioSource.clip = audioClip;
           _audioSource.loop = myAudioData.soundTrackConfigArray[idx].loop;
           _audioSource.volume = myAudioData.soundTrackConfigArray[idx].volume;
           _audioSource.Play();
       }

     }

}
