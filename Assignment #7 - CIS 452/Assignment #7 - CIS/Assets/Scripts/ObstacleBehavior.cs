/*
 * Kevon Long
 * ObstacleBehavior.cs
 * Assignment #8
 * This is the template method that's an abstract class that gives the obstacles their behaviours depending on what type they are.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public abstract class ObstacleBehavior : MonoBehaviour
{
    public static bool hasBeenHitOnce = false;
    private PolygonCollider2D polygonCollider;
    public static int speed = 5;

    protected void Start()
    {
        polygonCollider = GetComponent<PolygonCollider2D>();
        ObstacleBehaviour();
        hasBeenHitOnce = false;
        speed = 5;
    }

    protected void ObstacleBehaviour()
    {
        StartCoroutine(DestroyAfterAmountOfSeconds());
        TurnOnTrigger();
        if(HitOnce())
        {
            SpeedUp();
        }
    }

    public static void SpeedUp()
    {
        speed = 10;
    }

    //the hook
    protected virtual bool HitOnce()
    {
        return hasBeenHitOnce;
    }

    protected IEnumerator DestroyAfterAmountOfSeconds()
    {
        yield return new WaitForSeconds(5);

         Destroy(gameObject);
        
    }

    public void TurnOnTrigger()
    {
        polygonCollider.isTrigger = true;
    }

    public abstract void MoveLeft();

    public abstract void MoveRight();
}
