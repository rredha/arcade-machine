using UnityEngine;
using UnityEngine.InputSystem;

namespace Arcade._Project.Breakout
{
    public class Paddle : MonoBehaviour
    {
        public Vector2 direction{get; private set;}
        public Rigidbody2D rb {get; private set;}
        private InputAction moveAction;

        private const float force = 10.0f; //for the keyboard control way
        GameObject paddleModifier;

        public float maxBounceAngle = 75.0f;
        void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
            paddleModifier = GameObject.Find("Paddle");
        }

        private void Start()
        {
          moveAction = InputSystem.actions.FindAction("Move");
        }

        private void Update()
        {
          direction = moveAction.ReadValue<Vector2>();

        }


        public void ResetPaddle()
        {
            transform.position = new Vector2(0.0f,transform.position.y);
            rb.linearVelocity = new Vector2(0.0f,0.0f);
        }


        void FixedUpdate()
        {
            rb.AddForce(direction*force);
        }


        private void OnCollisionEnter2D(Collision2D col)
        {
            Ball ball = col.gameObject.GetComponent<Ball>();

            if (ball != null)
            {
                Vector2 paddlePosition = transform.position;
                Vector2 contactPoints = col.GetContact(0).point;

                float offset = paddlePosition.x - contactPoints.x;

                float currentAngle = Vector2.SignedAngle(Vector2.up, ball.GetComponent<Rigidbody2D>().linearVelocity);
                float maxOffset = col.otherCollider.bounds.size.x /2;


                float bounceAngle = (offset / maxOffset) * maxBounceAngle;
                float newAngle = Mathf.Clamp(currentAngle + bounceAngle, -maxBounceAngle, maxBounceAngle);

                Quaternion rotation = Quaternion.AngleAxis(newAngle, Vector3.forward);
                ball.GetComponent<Rigidbody2D>().linearVelocity = rotation * Vector2.up * ball.GetComponent<Rigidbody2D>().linearVelocity.magnitude;
            }
        }
    }
}
