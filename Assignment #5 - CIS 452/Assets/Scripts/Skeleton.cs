/*
 * Kevon Long
 * Skeleton.cs
 * Assignment #5
 * the skeleon enemy type
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : Monster
{
    float moveSpeed = 7f;

    //Player target;
    Vector2 moveDirection;
    float dirX, dirY;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        this.EnemyType = "Skeleton";
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-10.0f, 0.0f);
        Debug.Log(moveDirection);
        Debug.Log(rb.velocity);
    }
}
