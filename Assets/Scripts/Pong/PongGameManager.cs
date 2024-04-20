using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using UnityEditor.UIElements;


public class PongGameManager : MonoBehaviour
{
    public int playerScore;
    public int computerScore;

    [SerializeField] TextMeshProUGUI playerScoreText, computerScoreText;
    //public string computerScoreText;

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
