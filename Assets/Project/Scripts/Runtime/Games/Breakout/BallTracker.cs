using UnityEngine;

namespace Arcade.Project.Runtime.Games.Breakout
{
    public class BallTracker : MonoBehaviour
    {
        [SerializeField] private GameObject _ball1, _ball2;

        void FixedUpdate() {
            if (GameManager.Instance.lives == 2) {
                _ball1.SetActive(false);
            }

            if (GameManager.Instance.lives == 1) {
                _ball2.SetActive(false);
            }
        }
    }
}
