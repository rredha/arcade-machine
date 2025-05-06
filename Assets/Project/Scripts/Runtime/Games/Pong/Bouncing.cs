using System;
using UnityEngine;

namespace Arcade.Project.Runtime.Games.Pong
{
    public class Bouncing : MonoBehaviour
    {
        public float bouncingStrength = 1.0f;
        private AudioSource _audioSource;

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

                var audioManager = FindObjectOfType<AudioManager>();
                _audioSource.clip = audioManager._hitAudioClip;
                _audioSource.Play();
            }
        }
    }
}
