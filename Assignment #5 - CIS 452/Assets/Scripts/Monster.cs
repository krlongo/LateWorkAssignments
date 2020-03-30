/*
 * Kevon Long
 * Restart.cs
 * Assignment #5
 * Abstract parent class that sets the enemy types of the child Monster types
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Monster : MonoBehaviour
{
    protected string EnemyType { get; set; }

    protected void Start()
    {
        StartCoroutine(DestroyAfterAmountOfSeconds());
    }

    protected IEnumerator DestroyAfterAmountOfSeconds()
    {
        yield return new WaitForSeconds(3);

        Destroy(gameObject);

    }

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            ScoreAndTime.score -= 100;
        }
        else if (collision.gameObject.tag == "bullet")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            ScoreAndTime.score += 50;
        }
    }
}
