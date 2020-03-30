using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Kevon Long
 * Player.cs
 * Assignment #5
 * Sets the player movement and bullet shot
 */

public class Player : MonoBehaviour
{
    private float moveInput;
    public float speed;
    public GameObject bullet;
    float fireElapsedTime;
    public float fireDelay = .5f;

    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(rb.velocity.x, moveInput * speed);
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetType() == bullet.GetType())
        {
            bullet.GetComponent<PolygonCollider2D>().isTrigger()
        }
    }*/

}
