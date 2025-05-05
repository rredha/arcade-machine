using UnityEngine;

/* @brief : track position of the ball, either move up or down depending on that
            else idle in the middle of the screen.
*/
namespace Arcade.Project.Runtime.Games.Pong
{
    public class ComputerPaddle : Paddle
    {
        public Rigidbody2D ball;

        public void ResetPosition(){
            tr.position = new Vector2 (8.0f,0.0f);
        }

        private void Update()
        {
            FollowBall();
        }

        public void FollowBall()
        {
            if (this.ball.position.x > 0.0f)
            {
                if (this.ball.position.y > _rigidbody.transform.position.y)
                {
                    _rigidbody.AddForce(Vector2.up * speed);
                } else if (this.ball.position.y < _rigidbody.transform.position.y)
                {
                    _rigidbody.AddForce(Vector2.down * speed);
                }
            } else
            {
                if (_rigidbody.transform.position.y > 0.0f)
                {
                    _rigidbody.AddForce(Vector2.down*speed);
                } else
                {
                    _rigidbody.AddForce(Vector2.up*speed);
                }
            }
        }
    }
}
