using UnityEngine;

namespace Arcade._Project.Pong
{
    public class PlayerPaddle : Paddle
    {
        // variable that stores the paddles direction
        private Vector2 direction;

        public void ResetPosition(){
            tr.position = new Vector2 (-8.0f,0.0f);
        }

        // function that gets called by unity automatically @ every single frame
        private void Update()
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                direction = Vector2.up;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                direction = Vector2.down;
            } else
            {
                direction = Vector2.zero;
            }
        }

        // function that gets called at a fixed deltaT
        // mostly used to compute physics related stuff
        private void FixedUpdate()
        {
            // apply force if we are moving
            if (direction.sqrMagnitude > 0) {
                _rigidbody.AddForce(direction * speed);
            } 
        }
    }
}
