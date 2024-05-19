using UnityEngine;

/* 
    @brief : defines Paddle’s behaviour shared between
             Players and Computers Paddle.
*/

namespace Arcade._Project.Pong
{
    public class PongPaddle : MonoBehaviour
    {
        // get a rigidbody handler from unity RigidBody component
        // protected vs private, the first one means 
        // that all children objects can use that
        protected Rigidbody2D  _rigidbody;
        protected Transform tr;

        // Speed of the paddle must be accessible through other classes 
        public float speed = 10.0f;

        // this function get executed once in the life time of the app
        // unity gonna search on the unity object that this script is attached to
        // find the component that is of a type RigidBody2D, returns a handle
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            tr = GetComponent<Transform>();
        }    
    }
}
