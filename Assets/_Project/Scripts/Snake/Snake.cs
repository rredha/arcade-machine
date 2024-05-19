using System.Collections.Generic;
using UnityEngine;

//using UnityEngine.Time;

namespace Arcade._Project.Snake
{
    public class Snake : MonoBehaviour
    {
        /* ToFix  
        The snake can normally move only in four direction, no need to keep holding the buttons !
        Adding a mode where the snake can go through the walls
        Adding a user interface where i can change the speed of the snake using some kind of bonuses.
            exemple Apple grow, banana would diminish the length, Raspberry would add more or less speed.
        Fix the problem where the random fruit appears in the snake length position ! 
    */
        /* Snake growing part :
        Every time we eat a fruit -> snake grows ie more segments.
        Create a list that keeps track of the segments created.
        Create objects programatically using Prefabs !
    */

        private Vector2 dir;
        private Vector2 prevDir = Vector2.right;
        protected Rigidbody2D rb;
        public float timeStep = 0.06f;
        public int score = 0;

        private Transform snakeHead;
        // just for fun 
        //private int i = 1;
        public List<Transform> segments = new List<Transform>(); //list that stores all the segments.
        public Transform segmentPrefab; // a prefab for the snake head !
        public int initSize = 4; // initial size of the snake...

    

        private void Awake()
        {
            Time.fixedDeltaTime = timeStep; // i wonder if i have to unset it when existing snake ??
            rb = GetComponent<Rigidbody2D>();
            snakeHead = GetComponent<Transform>();
            //segments.Add(snakeHead);
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
            // make the segments follows the head of the snake
            for (int i = segments.Count-1; i > 0; i--)
            {
                segments[i].position = segments[i-1].position;
            }

            this.transform.position = new Vector3(
                Mathf.Round(this.transform.position.x + dir.x),
                Mathf.Round(this.transform.position.y + dir.y),
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
        }
    
        private void growSnake()
        {
            Transform segment = Instantiate(segmentPrefab); //create a clone from the prefab !  
            // The cloned segment position will be placed as the exact same location of the last segment
            // in the list, suppose we have only one segment (index = 0),
            // segment of the new clone = position of the previous one at the time of creation (or execution of the line !)
        
            segment.position = segments[segments.Count - 1].position;
            /* that ways just for fun...right ?
        segment.position = segments[segments.Count - i].position;
        i++; 
        */
            // Since it’s a List a can add to it, there is a method i presume ....
            segments.Add(segment);
        }

    }
}
