using UnityEngine;

namespace Arcade._Project.Pong
{
    public class PlayerPaddle : Paddle
    {
        public Vector2 direction { private set; get; }

        public void ResetPosition(){
            tr.position = new Vector2 (-8.0f,0.0f);
        }

        private void Update()
        {
            direction = GetPlayerInputDirection();
        }

        private Vector2 GetPlayerInputDirection()
        {

            if (Input.GetKey(KeyCode.UpArrow))
            {
                return Vector2.up;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                return Vector2.down;
            } else
            {
                return Vector2.zero;
            }
        }
        public void MovePaddle(Vector2 dir)
        {
            if (dir.sqrMagnitude > 0) {
                _rigidbody.AddForce(dir * speed);
            }
        }
    }
}
