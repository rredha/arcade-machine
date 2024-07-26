using System;
using Arcade._Project.Breakout;
using UnityEngine;

namespace Arcade._Project.Pong
{
    public class PongBouncing : MonoBehaviour
    {
        private AudioSource _audioSource;
        public float bouncingStrength = 1.0f;

        private void Awake()
        {
            _audioSource = this.GetComponent<AudioSource>();
        }

        private void OnCollisionEnter2D(Collision2D col)
        {
            //gives us the object that collided with our object
            Ball ball = col.gameObject.GetComponent<Ball>();
        
            if (ball != null)
            {
                Vector2 normal = col.GetContact(0).normal;
                ball.AddForceBall(-normal*this.bouncingStrength);

                // Playing Hit 
                
                
                //FindObjectOfType<AudioManager>().Play("Hit_3");
                var audioManager = FindObjectOfType<AudioManager>();
                //audioManager.PlaySound(audioManager._hitAudioClip, 1);
                _audioSource.clip = audioManager._hitAudioClip;
                _audioSource.Play();
            }
        }
    }
}
