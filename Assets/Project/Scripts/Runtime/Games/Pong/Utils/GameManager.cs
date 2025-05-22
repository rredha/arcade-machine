//using TMPro;
using UnityEngine;

namespace Arcade.Project.Runtime.Games.Pong
{
    public class GameManager : MonoBehaviour
    {
        public int playerScore;
        public int computerScore;
        public Ball ball;
        public PlayerPaddle pPaddle;
        public ComputerPaddle cPaddle;

        public void PlayerScores()
        {
            playerScore++;
            Debug.Log("Player Scores : " + playerScore);

            this.ball.ResetPosition();
            this.pPaddle.ResetPosition();
            this.cPaddle.ResetPosition();
        }

        public void ComputerScores()
        {
            computerScore++;
            Debug.Log("Computer Scores : " + computerScore);

            this.ball.ResetPosition();
            this.pPaddle.ResetPosition();
            this.cPaddle.ResetPosition();
        }
    }
}
