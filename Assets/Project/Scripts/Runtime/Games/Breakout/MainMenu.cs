using UnityEngine;
using UnityEngine.SceneManagement;

namespace Arcade.Project.Runtime.Games.Breakout
{
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
}
