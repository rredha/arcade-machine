using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void PlayBreakout(){
        SceneManager.LoadScene("BreakOutGlobal");
    }

    public void PlayPong(){
        SceneManager.LoadScene("Pong");
    }

    public void PlaySnake(){
        SceneManager.LoadScene("Snake");
    }
}
