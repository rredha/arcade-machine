using System.Collections.Generic;
using UnityEngine;

namespace Arcade.Project.Runtime.Games.Snake
{
    public class Apple : MonoBehaviour
    {
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
    }
}
