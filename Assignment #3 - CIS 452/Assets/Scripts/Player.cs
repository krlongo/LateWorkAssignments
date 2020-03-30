/*
 * Kevon Long
 * Player.cs
 * Assignment #3
 * Lets the player change gravity, move around, and trigger the key and goal
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    public bool isGrounded;
    private Rigidbody2D rb;
    public Key key;
    public Doors[] doors;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        doors = FindObjectsOfType<Doors>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.gravityScale *= -1;
           // rb.AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }
    }

    private void FixedUpdate()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "ground")
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "ground")
        {
            isGrounded = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "key")
        {
            Debug.Log("hit key");
            foreach(Doors door in doors)
            {
                door.UpdateData(true);
            }
        }
        else if (collision.gameObject.tag == "goal")
        {
            SceneManager.LoadScene("WinScreen");
        }
    }
}
