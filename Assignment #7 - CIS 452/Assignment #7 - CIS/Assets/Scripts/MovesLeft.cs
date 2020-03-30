/*
 * Kevon Long
 * MoveLeft.cs
 * Assignment #8
 * The child of obstacle behavior that tells the obstacle to go left
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovesLeft : ObstacleBehavior
{
    private Rigidbody2D rb;
    public static bool hasBeenHit = false;

    public override void MoveLeft()
    {
        rb.velocity = new Vector2(-speed, rb.velocity.y);
    }

    public static bool HitOnce()
    {
        return true;
    }

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveLeft();
        HitOnce();
    }

    //dosen't use it
    public override void MoveRight()
    {
        throw new System.NotImplementedException();
    }
}
