using UnityEngine;
using UnityEngine.SceneManagement;

namespace Arcade._Project.Breakout
{
    public class GameManager : MonoBehaviour
    {

        public static GameManager Instance;

        public int score = 0;
        public int lives = 3;
        public int level = 1;

        public Ball ball {get; private set;}
        public Paddle paddle {get; private set;}
        public Brick[] bricks {get; private set;}


        private void Awake()
        {
            // do not destroy the attached gameobject, because when loading a new scene, it deletes the other ones.
            Instance = this;
            DontDestroyOnLoad(this.gameObject);

        }

        private void Start()
        {
            NewGame();
        }

        private void NewGame()
        {
            this.score = 0;
            this.lives = 3;

            LoadLevel(1);
        }

        private void ResetGame()
        {
            /* we have a problem here...
        as the game manager script is called first
        then loads the level1 scene, we cannot reset the ball & paddle position
        because we need references to these two,
        which means getting the reference from other gameobject or functions
        that does not exist at the time of starting the GameManager.cs script
        (Awake() or Start()).

        To get the reference to these we follow these steps :
            - Subscribe to the unity event : SceneManager.Sceneloaded ! from LoadLevel() func.
            - Create a function that gets called any time the scene is loaded.
            - Then we can find the Ojects using FindObjectOfType<gameObject.name>();
        */
            this.ball.ResetBall(); //need to be public
            this.paddle.ResetPaddle();
        }

        private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
        {
            this.ball = FindObjectOfType<Ball>();
            this.paddle = FindObjectOfType<Paddle>();
            this.bricks = FindObjectsOfType<Brick>(); // this refers to the prefab, bc GameManager uses it to infer everything about all the bricks.
        }

        private void GameOver()
        {
            // would probably load a game over scene.
            // SceneManager.LoadScene("GameOver");

            NewGame();
        }

        public void Miss()
        {
           // FindObjectOfType<AudioManager>().Play("Miss");
            this.paddle.ResetPaddle();
            this.lives--;
            ResetGame();
            if (this.lives <= 0)
            {
                this.lives = 0;
                Debug.Log("You LOST !!!");
                GameOver();
            }
        }

        public void Hit(Brick brick)
        {
            this.score += brick.hitValue;
            // Debug.Log(this.score);
            if(ClearedBoard())
            {
                LoadLevel(this.level+1);
            }
        }

        public bool ClearedBoard()
        {
            for (int i=0; i<this.bricks.Length; i++)
            {
                if(this.bricks[i].gameObject.activeInHierarchy && !this.bricks[i].unbreakable)
                {
                    return false;
                }
            }
            return true;

        }


        public int GetScore() {
            return this.score;
        }

        private void LoadLevel(int level)
        {
            this.level = level;
            // in files, build settings, we should add the scenes that will be included in the executable.
            // drag and drop them into the interface.
            // better to load them by name.
            SceneManager.LoadScene("BreakOutLevel"+level);

            // subscribe to the event when the scene is loaded.
            SceneManager.sceneLoaded += OnLevelLoaded;
        }
    }
}
