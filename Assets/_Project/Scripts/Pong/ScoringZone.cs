using UnityEngine;

namespace Arcade._Project.Pong
{
    public class ScoringZone : MonoBehaviour
    {
        public enum GameResult
        {
            Init,
            Win,
            Lose,
        }
        public GameResult Result { set; get; }

        private void OnCollisionEnter2D(Collision2D col)
        {
            Ball ball = col.gameObject.GetComponent<Ball>();

            if (Result != GameResult.Init)
            {
               Debug.LogError("States Not Set Properly"); 
            }
            
            if (ball != null)
            {
                if (this.CompareTag("Player"))
                {
                    Result = GameResult.Lose;
                }
                else 
                {
                    Result = GameResult.Win;
                }
            }
        }
    }
}
