﻿/*
 * Kevon Long
 * Player.cs
 * Assignment #8
 * Lets the player change gravity, move around, and get hit by obstacles
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("obstacle"))
        {
            if(ObstacleBehavior.hasBeenHitOnce == false)
            {
                Destroy(collision.gameObject);
                ObstacleBehavior.hasBeenHitOnce = true;
                ObstacleBehavior.speed = 10;
            }
            else if (ObstacleBehavior.hasBeenHitOnce == true)
            {
                SceneManager.LoadScene("GameOverScreen");
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.gravityScale *= -1;
        }
    }
}
