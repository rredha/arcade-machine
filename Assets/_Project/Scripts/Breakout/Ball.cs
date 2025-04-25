using UnityEngine;

namespace Arcade._Project.Breakout
{
    public class Ball : MonoBehaviour
    {
        public Rigidbody2D rb {get; private set;}
        public float speed = 1.0f;


        // Start is called before the first frame update
        void Awake()
        {
            this.rb = GetComponent<Rigidbody2D>();
        }

        void Start()
        {
            ResetBall();
        }

        private void SetRandomTrajectory()
        {
            Vector2 force = Vector2.zero;

            force.x = Random.Range(-1f, 1f);
            force.y = -1f;

            this.rb.AddForce(force.normalized*this.speed);
        }

        private void FixedUpdate()
        {
            rb.linearVelocity = rb.linearVelocity.normalized * speed;
        }

        public void ResetBall()
        {
            rb.linearVelocity = Vector2.zero;
            rb.position = Vector2.zero;

            Invoke(nameof(SetRandomTrajectory), 1f);
        }
    }
}
