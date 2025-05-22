using UnityEngine;

namespace Arcade.Project.Runtime.Games.Pong
{
    public class Paddle : MonoBehaviour
    {
        protected Rigidbody2D  _rigidbody;
        protected Transform tr;

        public float speed = 10.0f;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            tr = GetComponent<Transform>();
        }
    }
}
