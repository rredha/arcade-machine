using UnityEngine;

namespace Arcade.Project.Runtime.Games.Pong
{
    public class Ball : MonoBehaviour
    {
        protected Rigidbody2D _rigidbody;

        public bool isRandom = true;

        public float ballSpeed = 100.0f;
        public float x = 0.5f;
        public float y = -0.5f;
        private float _xRandomDir, _yRandomDir;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }


        public void AddForceBall(Vector2 force)
        {
            _rigidbody.AddForce(force);
        }

        public void ResetPosition()
        {
            _rigidbody.position = Vector2.zero;
            _rigidbody.linearVelocity = Vector2.zero;
        }

        public void LaunchBall()
        {
            if (isRandom)
            {
                _xRandomDir = Random.value > 0.5f ? x = 1.0f : x = -1.0f;
                _yRandomDir = Random.value > 0.5f ? y = Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);
            }

            Vector2 direction = new Vector2(x, y);
            _rigidbody.AddForce(direction * ballSpeed);
        }
    }
}
