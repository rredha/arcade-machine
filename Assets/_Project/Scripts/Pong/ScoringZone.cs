using UnityEngine;
using UnityEngine.EventSystems;

namespace Arcade._Project.Pong
{
    public class ScoringZone : MonoBehaviour
    {
        public EventTrigger.TriggerEvent scoreTrigger;

        private AudioSource _audioSource;

        private void Awake()
        {
            _audioSource = this.GetComponent<AudioSource>();
            var audioManager = FindObjectOfType<AudioManager>();
            _audioSource.clip = audioManager._missAudioClip;
        }
        private void OnCollisionEnter2D(Collision2D col)
        {
            //gives us the object that collided with our object
            Ball ball = col.gameObject.GetComponent<Ball>();

            if (ball != null)
            {
                BaseEventData eventData = new BaseEventData(EventSystem.current);
                scoreTrigger.Invoke(eventData);
                _audioSource.Play();
            }
        }
    }
}
