using UnityEngine;

namespace Arcade.Project.Runtime.Games.Breakout
{
    public class MissZone : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D other) {
            if (other.gameObject.name == "Ball")
            {
                FindObjectOfType<GameManager>().Miss();
               // FindObjectOfType<AudioManager>().Play("Miss");
            }
        }
    }
}
