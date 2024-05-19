using System.Collections.Generic;
using UnityEngine;

namespace Arcade._Project.Snake
{
    public class Apple : MonoBehaviour
    {
        /*
    get reference to the transform of the food [DONE]
        make a function that gets me the reference of the food object,
        i only need the position so a transform will do 
    begin with a random food positon
        the position should be outside the bounds [DONE]
    if there is a collision then reset to another random position
        get the collider2D from the game object [Done].
        try to use isTrigger instead of a rigid collision [DONE]
    */

        /* Hi’s solution is more elegent, defines a gridArea + BoxCollider2D that fits well
       get it’s reference and then use it the the setRandomPosition() using properties of the BoxCollider2D 
       Another cool thing that he did and i didnt, was to make sure that the thing that collided with the food 
       is actually the snake, by using tag (that i’m gonna try to replicate it !)
    */
        // Start is called before the first frame update

        public Transform appleTr;
        public Collider2D appleCol;

        public List<Transform> segments = new List<Transform>();

        void Start()
        {
            setRandomPosition();
        }

        // Update is called once per frame
        void OnTriggerEnter2D(Collider2D col)
        {
        
            if (col.tag == "Player")
            {
                setRandomPosition();
                /*
            if (isInSegmentsRange())
            {
                setRandomPosition();
            }
            */
            }
   
        }

        void setRandomPosition()
        {
            appleTr.position = new Vector3 (Mathf.Round(Random.Range(-22.0f,22.0f)),
                Mathf.Round(Random.Range(-10.0f,10.0f)),
                0.0f);
        }

        void getFoodTransform()
        {
            appleTr = GetComponent<Transform>();
        }

        void getFoodCollider()
        {
            appleCol = GetComponent<Collider2D>();
        } 
/*
    bool isInSegmentsRange()
    {
        for (int i = 0; i < segments.Count; i++)
        {
            if (segments[i].position == appleTr.position)
            {
                return true;
            } 
            return false;
        }
    }
    */
    }
}
