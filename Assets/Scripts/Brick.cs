using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    // each time the brick is hit increase the hitValue.
    public int hitValue = 100;

    // keep track of how much health the brick has.
    public int health {get; private set;}

    // swap the sprite every time the ball hits the brick
    public SpriteRenderer sp {get; private set;}

    // array of sprites to store the sprites of the bricks
    public Sprite[] state;

    // some bricks are unbreakable 
    public bool unbreakable;
    private void Awake() {
        this.sp = GetComponent<SpriteRenderer>();
    }

    private void Start() {
        if (!this.unbreakable)
        {
            this.health = this.state.Length;
            this.sp.sprite = this.state[this.health - 1];
        }
    }
     
    private void Hit(){
        if (this.unbreakable)
        {
            return;
        }
        this.health--;

        if (this.health <= 0)
        {
            this.gameObject.SetActive(false);
        } else
        {
           this.sp.sprite = this.state[this.health - 1];

        }
        FindObjectOfType<GameManager>().Hit(this);

    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.name == "Ball")
        {
            Hit();
            // Playing Hit
            FindObjectOfType<AudioManager>().Play("Hit_1");

        }
}
}
