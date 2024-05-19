using System.Collections;
using System.Collections.Generic;
using Arcade._Project.Core.StateMachine;
using UnityEngine;

namespace Arcade._Project.Snake.GameState
{
    public class Init : State
    {
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
    }
}