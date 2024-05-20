using System.Collections.Generic;
using Arcade._Project.Core.StateMachine;
using UnityEngine;

namespace Arcade._Project.Snake.GameState
{
    public class Init : State<LevelManager.LevelState>
    {
        public Init(LevelManager.LevelState key, Transform snakeHead, Transform segmentPrefab) : base(key, snakeHead, segmentPrefab)
        {
            _snakeHead = snakeHead;
            _segmentPrefab = segmentPrefab;

        }
        /*
        public Init(LevelManager.LevelState key) : base(key)
        {
        }
        */

        //[SerializeField] private Snake snake;
        private Vector2 dir;
        private Vector2 prevDir = Vector2.right;
        protected Rigidbody2D rb;
        public float timeStep = 0.06f;
        public int score = 0;

        [SerializeField] private Transform _snakeHead;
        // just for fun 
        //private int i = 1;
        public List<Transform> segments = new List<Transform>(); //list that stores all the segments.
        [SerializeField] private Transform _segmentPrefab; // a prefab for the snake head !
        public int initSize = 4; // initial size of the snake...

        public void Awake()
        {
            Time.fixedDeltaTime = timeStep; // i wonder if i have to unset it when existing snake ??
            rb = _snakeHead.GetComponent<Rigidbody2D>();
            _snakeHead = _snakeHead.GetComponent<Transform>();
        }
        public override void EnterState()
        {
            Debug.Log("Hello From Init State");
        }

        public override void ExitState()
        {
            Debug.Log("Exiting Init");
        }

        public override void UpdateState()
        {
            resetGame();
        }

        public override LevelManager.LevelState GetNextState()
        {
            return LevelManager.LevelState.Playing;
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
        private void resetGame()
        {
            // We do not want to destroy the head of the snake (index = 0)
            // Use the Destroy method.
            for (int i = 1; i < segments.Count; i++)
            {
                Object.Destroy(segments[i].gameObject);
            }
            segments.Clear();
            segments.Add(_snakeHead);

            for (int i = 1; i < initSize; i++)
            {
                Transform segment = Object.Instantiate(_segmentPrefab);
                segment.position = segments[segments.Count - 1].position;
                segments.Add(segment);
            }

            _snakeHead.position = Vector3.zero;
        }

    }
}
        /*
        public int score = 0;
        public Transform snakeHead;
        // just for fun 
        //private int i = 1;
        public List<Transform> segments = new List<Transform>(); //list that stores all the segments.
        public Transform segmentPrefab; // a prefab for the snake head !
        public int initSize = 4; // initial size of the snake...
        public Init(LevelManager levelManager) : base(levelManager)
        {
            _levelManager = levelManager;
        }

        private LevelManager _levelManager; 
        
        public override void Start()
        {
            resetGame();
            _levelManager.SetState(new Init(_levelManager));
        }
        private void resetGame()
        {
            // We do not want to destroy the head of the snake (index = 0)
            // Use the Destroy method.
            for (int i = 1; i < _levelManager.segments.Count; i++)
            {
                Object.Destroy(_levelManager.segments[i].gameObject);
            }
            _levelManager.segments.Clear();
            _levelManager.segments.Add(_levelManager.snakeHead);

            for (int i = 1; i < _levelManager.initSize; i++)
            {
                Transform segment = Object.Instantiate(_levelManager.segmentPrefab);
                segment.position = _levelManager.segments[_levelManager.segments.Count - 1].position;
                _levelManager.segments.Add(segment);
            }

            _levelManager.snakeHead.position = Vector3.zero;
        }
        */
