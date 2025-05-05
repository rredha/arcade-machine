using UnityEngine;
using UnityEngine.SceneManagement;

namespace Arcade.Project.Runtime.Games.Breakout
{
    public class PauseMenu : MonoBehaviour
    {
        public static bool IsGamePaused = false;

        [SerializeField] private GameObject PauseMenuUI;
        private void Update() {
            if (Input.GetKeyDown(KeyCode.Escape)) {
                if (IsGamePaused) {
                    Resume();
                } else {
                    Pause();
                }
            }
        }

        public void Resume() {
            PauseMenuUI.SetActive(false);
            Time.timeScale= 1f;
            IsGamePaused = false;
        }

        public void Pause() {
            PauseMenuUI.SetActive(true);
            Time.timeScale= 0f;
            IsGamePaused = true;
        }

        public void Quit() {
            Time.timeScale = 1f;
            SceneManager.LoadScene(0);
        }

        public void Settings() {
            Debug.Log("Settings Menu triggered, to be implemented soon");
        }
    }
}
