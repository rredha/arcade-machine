using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D col)
    {
        Ball ball = col.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
           // Playing Hit 
            FindObjectOfType<AudioManager>().Play("Hit_2");
        }
    }
}
