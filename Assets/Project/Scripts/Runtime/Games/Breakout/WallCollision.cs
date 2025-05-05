using UnityEngine;

namespace Arcade.Project.Runtime.Games.Breakout
{
    public class WallCollision : MonoBehaviour
    {

        private void OnCollisionEnter2D(Collision2D col)
        {
            Ball ball = col.gameObject.GetComponent<Ball>();

            if (ball != null)
            {
                // Playing Hit
              //  FindObjectOfType<AudioManager>().Play("Hit_2");
            }
        }
    }
}
