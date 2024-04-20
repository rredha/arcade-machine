using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    private TMPro.TMP_Text _scoreText;


    private void Awake() {
        _scoreText = GetComponent<TMP_Text>();

    }
    // Update is called once per frame
    void FixedUpdate() {
    
        int score = GameManager.Instance.GetScore();
        _scoreText.SetText(score.ToString());
        
    }
}
