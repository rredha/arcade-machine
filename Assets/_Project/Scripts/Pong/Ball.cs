using UnityEngine;

namespace Arcade._Project.Pong
{
    public class Ball : MonoBehaviour
    {
        /* @brief : implements the ball initial starting direction
                the physics is taken into account by the unity physics engine
    */
        protected Rigidbody2D _rigidbody;

        public bool isRandom = true;

        public float ballSpeed = 100.0f;
        public float x=0.5f;
        public float y=-0.5f;
        private float xRandomDir, yRandomDir;

     
        private void Start()
        {
            ResetPosition();
        }
    

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        } 

        // the problem here is that this speed is not used anywhere eles ! 
        // it is just incremented, hence i should add something to modify the ball speed.

        /* old version, bugged

    private void OnCollisionEnter2D(Collision2D col)
    {
        ballSpeed += 500.0f;
        Debug.Log("Collision Speed = " + ballSpeed);
    }
    */

        // to accelerate the ball, i can break encapsulation by making 
        // the ball object accessible from other scripts, 
        // a better way is to create a method that lets me add a force to the ball.

        public void AddForceBall(Vector2 force)
        {
            // here it’s important to note that force is in fact Force*direction (vector2D)
            _rigidbody.AddForce(force);
        }

        public void ResetPosition()
        {
            _rigidbody.position = Vector2.zero;
            _rigidbody.velocity = Vector2.zero;


            if (isRandom)
            {
                xRandomDir = Random.value > 0.5f ? x = 1.0f : x = -1.0f;
                yRandomDir = Random.value > 0.5f ? y = Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);
            }
            Vector2 direction = new Vector2(x,y);
            _rigidbody.AddForce(direction*ballSpeed);    }

    }
}
