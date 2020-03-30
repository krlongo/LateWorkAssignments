/*
 * Kevon Long
 * Bullet.cs
 * Assignment #5
 * Used to kill enemies and gain points
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(DestroyAfterAmountOfSeconds());
    }

    protected IEnumerator DestroyAfterAmountOfSeconds()
    {
        yield return new WaitForSeconds(3);

        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(10.0f, 0.0f);
    }
}
