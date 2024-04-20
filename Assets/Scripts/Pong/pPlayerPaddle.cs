using UnityEngine;
using System.Collections;

public class pPlayerPaddle : pPaddle
{
    // variable that stores the paddles direction
    private Vector2 direction;

    // function that gets called by unity automatically @ every single frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            direction = Vector2.down;
        } else
        {
            direction = Vector2.zero;
        }
    }

    // function that gets called at a fixed deltaT
    // mostly used to compute physics related stuff
    private void FixedUpdate()
    {
        // apply force if we are moving
        if (direction.sqrMagnitude > 0) {
            _rigidbody.AddForce(direction * speed);
        } 
    }
}
