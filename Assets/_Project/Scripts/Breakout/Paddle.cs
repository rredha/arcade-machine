using UnityEngine;
//using System.Collections.IEnumerable;

namespace Arcade._Project.Breakout
{
    public class Paddle : MonoBehaviour
    {
        public Vector2 direction{get; private set;}
        // public Rigidbody2D rb {get; private set;}
        public Rigidbody2D rb;

        public bool isKeyboardControl = true;
        public bool isPotControl = false;
        // force with simple rate of change is perfect at 100.
        // for the true velocity version, 0.5 seems to work-ish...
        private const float force = 10.0f; //for the keyboard control way
        public float potReading;
        GameObject paddleModifier;

        public float maxBounceAngle = 75.0f;
        public float potReadingPrev = 0.0f;
        // Start is called before the first frame update
        void Awake()
        {
            this.rb = GetComponent<Rigidbody2D>();
            paddleModifier = GameObject.Find("Paddle");
        }

        // Update is called once per frame
        void Update()
        {
            if(isKeyboardControl)
            {
                if(Input.GetKey(KeyCode.LeftArrow))
                {
                    this.direction = Vector2.left;
                }
                else if(Input.GetKey(KeyCode.RightArrow))
                {
                    this.direction = Vector2.right;
                } else 
                {
                    this.direction = Vector2.zero;
                }
            }
        }

        // Invoked when a line of data is received from the serial device.
        void OnMessageArrived(string msg){
            // Debug.Log("DeltaTime" + Time.deltaTime);
            float potReading = float.Parse(msg);
            //float d_potRead = Mathf.Abs((potReading-potReadingPrev))/Time.deltaTime;
            float d_potRead = (potReading-potReadingPrev)/Time.deltaTime;
            Debug.Log(d_potRead);
            //force = 10.0f;
            if(d_potRead > 0.0f)
            {
                this.direction = Vector2.left;
            } else if (d_potRead < 0.0f)
            {
                this.direction = Vector2.right;
            } else {
                this.direction = Vector2.zero;
            }
            //Debug.Log("Force Applied: " + d_potRead);

            //paddleModifier.gameObject.transform.Translate(this.direction*Time.deltaTime*this.force, 0.0f);
            this.rb.AddForce(this.direction*Mathf.Abs(d_potRead)*force);
            potReadingPrev = potReading;
        }

        // Invoked when a connect/disconnect event occurs. The parameter 'success'
        // will be 'true' upon connection, and 'false' upon disconnection or
        // failure to connect.
        void OnConnectionEvent(bool success){
            Debug.Log(success ? "Device connected" : "Device disconnected");
        }

        public void ResetPaddle()
        {
        
            this.transform.position = new Vector2(0.0f,this.transform.position.y);
            this.rb.linearVelocity = new Vector2(0.0f,0.0f);
        }

    
        void FixedUpdate()
        {
            /*
        if(isPotControl){
        force = Mathf.Abs(potReading);
        } 
        */
            rb.AddForce(this.direction*force);
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

                // Playing Hit 
               // FindObjectOfType<AudioManager>().Play("Hit_3");
            }
        }
    }
}
