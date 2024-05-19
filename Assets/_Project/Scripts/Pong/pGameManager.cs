using UnityEngine;
using UnityEngine.UI;

//using UnityEditor.UIElements;



namespace Arcade._Project.Pong
{
    public class pGameManager : MonoBehaviour
    {
        public int playerScore;
        public int computerScore;

        protected Text playerScoreText;
        protected Text computerScoreText;

        public pBall ball;

        public void PlayerScores()
        {
            playerScore++;
       
            //  playerScoreText.text = IntegerField.ValueToString(playerScore);
            this.ball.ResetPosition();
        }

        public void ComputerScores()
        {
            computerScore++;
            //computerScoreText.text = IntegerField.ValueToString(computerScore);
            this.ball.ResetPosition();
        }
    }
}
