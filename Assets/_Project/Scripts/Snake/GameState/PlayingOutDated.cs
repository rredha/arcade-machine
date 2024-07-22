using System.Collections.Generic;
using Arcade._Project.Core.StateMachine;
using UnityEngine;

namespace Arcade._Project.Snake.GameState
{
    /*
    public class Playing:State<LevelManager.LevelState>
    {
        
        public Playing(LevelManager.LevelState key, Transform snakeHead, Transform segmentPrefab) : base(key, snakeHead, segmentPrefab)
        {
        }
        private Vector2 dir;
        private Vector2 prevDir = Vector2.right;
        public List<Transform> segments = new List<Transform>(); //list that stores all the segments.
        
        public override void EnterState()
        {
            Time.fixedDeltaTime = 0.3f;
            Debug.Log("Hello from Playing State EnterState");
        }

        public override void ExitState()
        {
            Debug.Log("Exiting Playing");
        }

        public override void UpdateState()
        {
            Update();
            FixedUpdate();
        }

        public override LevelManager.LevelState GetNextState()
        {
            return LevelManager.LevelState.Playing;
        }

        public override void OnTriggerEnter(Collider other)
        {
            throw new System.NotImplementedException();
        }

        private void FixedUpdate()
        {
            for (int i = segments.Count-1; i > 0; i--)
            {
                segments[i].position = segments[i-1].position;
            }

            SnakeHead.transform.position = new Vector3(
                Mathf.Round(SnakeHead.transform.position.x + dir.x),
                Mathf.Round(SnakeHead.transform.position.y + dir.y),
                0.0f);
        }
        public void Update()
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
        public override void OnTriggerStay(Collider other)
        {
            throw new System.NotImplementedException();
        }

        public override void OnTriggerExit(Collider other)
        {
            throw new System.NotImplementedException();
        }

    }
    */
}