using UnityEngine;
using UnityEngine.SceneManagement;

namespace Arcade._Project.Core.UI.PauseMenu
{
    public class PauseMenu : MonoBehaviour
    {
        public static bool IsGamePaused = false;

        [SerializeField] private GameObject pauseMenuUI;
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
            pauseMenuUI.SetActive(false);
            Time.timeScale= 1f;
            IsGamePaused = false;
        }

        public void Pause() {
            pauseMenuUI.SetActive(true);
            Time.timeScale= 0f;
            IsGamePaused = true;
        }

        public void Quit() {
            Time.timeScale = 1f;
            //SceneManager.LoadScene(0);
        }

        public void Settings() {
            Debug.Log("Settings Menu triggered, to be implemented soon");
        }
    }
}
