using System.Collections.Generic;
using Arcade._Project.Core.StateMachine;
using UnityEngine;

namespace Arcade._Project.Snake.GameState
{
    public class Init : State<LevelManager.LevelState>
    {
        public Init(LevelManager.LevelState key) : base(key)
        {
        }

        private Vector2 dir;
        private Vector2 prevDir = Vector2.right;
        protected Rigidbody2D rb;
        public float timeStep = 0.06f;
        public int score = 0;
        
        private GameObject _snakeHead;
        public List<GameObject> segments = new List<GameObject>(); 
        public GameObject _segmentPrefab; 
        
        public int initSize = 4; 

    

        private void Awake()
        {
            Time.fixedDeltaTime = timeStep; // i wonder if i have to unset it when existing snake ??
            rb = _snakeHead.GetComponent<Rigidbody2D>();
            _snakeHead.GetComponent<Transform>();
            resetGame();
        }

        private void Update()
        {
            if ( Input.GetKey(KeyCode.DownArrow) & (prevDir != Vector2.up) & (prevDir != Vector2.down))
            {
                dir = Vector2.down;
                prevDir = dir;
            } else if ( Input.GetKey(KeyCode.UpArrow) & (prevDir != Vector2.up) & (prevDir != Vector2.down))
            {
                dir = Vector2.up;
                prevDir = dir;
            } else if ( Input.GetKey(KeyCode.LeftArrow) & (prevDir != Vector2.left) & (prevDir != Vector2.right))
            {
                dir = Vector2.left;
                prevDir = dir;
            } else if ( Input.GetKey(KeyCode.RightArrow) & (prevDir != Vector2.right) & (prevDir != Vector2.left))
            {
                dir = Vector2.right;
                prevDir = dir;
            } else 
            {
                dir = Vector2.zero;
            }
            dir=prevDir;
        }

        private void FixedUpdate()
        {
            for (int i = segments.Count-1; i > 0; i--)
            {
                segments[i].transform.position = segments[i-1].transform.position;
            }

            _snakeHead.transform.position = new Vector3(
                Mathf.Round(_snakeHead.transform.position.x + dir.x),
                Mathf.Round(_snakeHead.transform.position.y + dir.y),
                0.0f);
        }

        void OnTriggerEnter2D(Collider2D col)
        {
            if (col.tag == "Food")
            {
                growSnake();
                score =+ 10;
            } else if (col.tag == "Obstacle")
            {
                resetGame();
            }
   
        }
    
        private void resetGame()
        {
            for (int i = 1; i < segments.Count; i++)
            {
                Object.Destroy(segments[i].gameObject);
            }
            segments.Clear();
            segments.Add(_snakeHead);

            for (int i = 1; i < initSize; i++)
            {
                GameObject segment = Instantiate(_segmentPrefab);
                segment.transform.position = segments[segments.Count - 1].transform.position;
                segments.Add(segment);
            }

            _snakeHead.transform.position = Vector3.zero;
        }
    
        private void growSnake()
        {
            GameObject segment = Instantiate(_segmentPrefab); 
        
            segment.transform.position = segments[segments.Count - 1].transform.position;
            segments.Add(segment);
        }



        public override void EnterState()
        {
        }

        public override void ExitState()
        {
        }

        public override void UpdateState()
        {
        }

        public override LevelManager.LevelState GetNextState()
        {
            return LevelManager.LevelState.Init;
        }

        public override void OnTriggerEnter(Collider other)
        {
            throw new System.NotImplementedException();
        }

        public override void OnTriggerStay(Collider other)
        {
            throw new System.NotImplementedException();
        }

        public override void OnTriggerExit(Collider other)
        {
            throw new System.NotImplementedException();
        }

    }
}
