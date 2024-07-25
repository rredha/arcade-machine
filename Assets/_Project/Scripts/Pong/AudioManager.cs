using Arcade._Project.Core.AudioPlayer;
using UnityEngine;

namespace Arcade._Project.Pong
{
    public class AudioManager : AudioPlayer
    {
       public AudioDataScriptableObject myAudioData;

       private string _gameName;
       private string _clipName;
       
       private AudioClip _backgroundAudioClip;
       private AudioClip HitAudioClip  { get; set; }
       private AudioClip MissAudioClip { get; set; }
       
       private AudioSource _audioSource;
       private void Awake()
       {
           _audioSource = gameObject.AddComponent<AudioSource>();
           if (myAudioData.gameName != "Pong") return;
           
           if (myAudioData.soundTrackConfigArray[0].clipName == "Background")
           {
               _backgroundAudioClip = myAudioData.soundTrackConfigArray[0].soundTracks;
           } else if (myAudioData.soundTrackConfigArray[1].clipName == "Hit")
           {
               HitAudioClip = myAudioData.soundTrackConfigArray[1].soundTracks;
           } else if (myAudioData.soundTrackConfigArray[2].clipName == "Miss")
           {
               MissAudioClip = myAudioData.soundTrackConfigArray[2].soundTracks;
           }
       }

       private void Start()
       {
           _audioSource.clip = _backgroundAudioClip;
           _audioSource.loop = myAudioData.soundTrackConfigArray[0].loop;
           _audioSource.volume = myAudioData.soundTrackConfigArray[0].volume;
           _audioSource.Play();
       }
    }
}
