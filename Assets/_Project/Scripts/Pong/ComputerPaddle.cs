using UnityEngine;

/* @brief : track position of the ball, either move up or down depending on that
            else it’s gonna idle in the middle of the screen.
*/      
namespace Arcade._Project.Pong
{
    public class ComputerPaddle : Paddle
    {
    
        // first we need to get a reference to the ball, this script doesnt inherite from Ball.cs
        // this way i can access by droping the rigidbody from my hierarchy to the ComputerPaddle object rigidbody
        public Rigidbody2D ball;

        public void ResetPosition(){
            tr.position = new Vector2 (8.0f,0.0f);
        }

        private void FixedUpdate() 
        {
            // if the ball get’s moving toward the computer paddle the do something
            // it implies that i need a vector to take it into account
            // simplest vector maybe the velocitie vector
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
                // that works but it doesnt feel right... also i should use the velocity in the first if statement, it’s all about vectors...
                // _rigidbody.MovePosition(new Vector2 (8.0f, 0.0f));
           
                //Debug.Log(_rigidbody.transform.position.y);
           
                if (_rigidbody.transform.position.y > 0.0f)
                {
                    _rigidbody.AddForce(Vector2.down*speed);
                } else
                {
                    _rigidbody.AddForce(Vector2.up*speed);
                }
                //Debug.Log(this.ball.position);

                // to use Debug it has to be running inside the gameengine i suppose !
                //Debug.Log(this.ball.position);
            }


        }
    }
}