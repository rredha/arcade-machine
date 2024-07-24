using TMPro;
using UnityEngine;

//using UnityEditor.UIElements;


namespace Arcade._Project.Pong
{
    public class PongGameManager : MonoBehaviour
    {
        public int playerScore;
        public int computerScore;

        [SerializeField] TextMeshProUGUI playerScoreText, computerScoreText;

        public PongBall ball;
        public PongPlayerPaddle pPaddle;
        public PongComputerPaddle cPaddle;

        public void PlayerScores()
        {
            playerScore++;
            Debug.Log("Player Scores : " + playerScore);

            playerScoreText.text = playerScore.ToString();
            this.ball.ResetPosition();
            this.pPaddle.ResetPosition();
            this.cPaddle.ResetPosition();
        }

        public void ComputerScores()
        {
            computerScore++;
            Debug.Log("Computer Scores : " + computerScore);

            computerScoreText.text = computerScore.ToString();
            this.ball.ResetPosition();
            this.pPaddle.ResetPosition();
            this.cPaddle.ResetPosition();
        }
    }
}
