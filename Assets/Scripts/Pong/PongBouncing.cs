using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBouncing : MonoBehaviour
{
    public float bouncingStrength = 1.0f;

    private void OnCollisionEnter2D(Collision2D col)
    {
        //’gives us the object that collided with our object
        PongBall ball = col.gameObject.GetComponent<PongBall>();
        
        if (ball != null)
        {
            Vector2 normal = col.GetContact(0).normal;
            ball.AddForceBall(-normal*this.bouncingStrength);

           // Playing Hit 
            FindObjectOfType<AudioManager>().Play("Hit_3");
        }
    }
}
