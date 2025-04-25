using TMPro;
using UnityEngine;



namespace Arcade._Project.Pong
{
    public class GameManager : MonoBehaviour
    {
        public int playerScore;
        public int computerScore;

        [SerializeField] TextMeshProUGUI playerScoreText, computerScoreText;

        public Ball ball;
        public PlayerPaddle pPaddle;
        public ComputerPaddle cPaddle;

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
