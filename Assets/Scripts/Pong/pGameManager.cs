using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEditor.UIElements;



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
