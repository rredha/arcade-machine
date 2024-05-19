using System.Collections.Generic;
using UnityEngine;
using Arcade._Project.Core.StateMachine;
using Arcade._Project.Snake.GameState;

namespace Arcade._Project.Snake
{
    public class SnakeGameManager : MonoBehaviour
    {
        [SerializeField] private LevelManager _levelManager;
    
        public void Awake()
        {
            _levelManager.SetState(new Playing(_levelManager));
            
        }
        /*
        public int score = 0;
        public Transform snakeHead;
        // just for fun 
        //private int i = 1;
        public List<Transform> segments = new List<Transform>(); //list that stores all the segments.
        public Transform segmentPrefab; // a prefab for the snake head !
        public int initSize = 4; // initial size of the snake...
        private void resetGame()
        {
            // We do not want to destroy the head of the snake (index = 0)
            // Use the Destroy method.
            for (int i = 1; i < segments.Count; i++)
            {
                Destroy(segments[i].gameObject);
            }
            segments.Clear();
            segments.Add(snakeHead);

            for (int i = 1; i < initSize; i++)
            {
                Transform segment = Instantiate(segmentPrefab);
                segment.position = segments[segments.Count - 1].position;
                segments.Add(segment);
            }

            snakeHead.position = Vector3.zero;
            */
        }
    
}
