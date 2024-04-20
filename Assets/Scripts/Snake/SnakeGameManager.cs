using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeGameManager : MonoBehaviour
{
    public int score = 0;
    public Transform snakeHead;
    // just for fun 
    //private int i = 1;
    public List<Transform> segments = new List<Transform>(); //list that stores all the segments.
    public Transform segmentPrefab; // a prefab for the snake head !
    public int initSize = 4; // initial size of the snake...
    
    public void Awake()
    {
        resetGame();
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
}
