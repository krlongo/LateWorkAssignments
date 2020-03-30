/*
 * Kevon Long
 * Doors.cs
 * Assignment #3
 * The observers that update their lock state based on the key subject
 */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour, IObserver
{
    private BoxCollider2D boxCollider;
    //public bool unlocked;
    public ISubject key;

    public Doors(ISubject key)
    {
        this.key = key;
        key.registerObserver(this);
    }

    public void UpdateData(bool unlocked)
    {
        Debug.Log("updating");
        Debug.Log(unlocked);
       // this.unlocked = unlocked;
        unlockDoor(unlocked);
    }

    private void unlockDoor(bool unlocked)
    {
        
        Debug.Log(unlocked);
        if (unlocked == true)
        {
            Debug.Log("should be unlocking");
            if (gameObject.tag == "blue")
            {
                Debug.Log("locking blue");
                boxCollider.isTrigger = false;
                GetComponent<SpriteRenderer>().color = new Color(0, 0, 1, 1.0f);
                Debug.Log("blue is open ");
            }

            if (gameObject.tag == "red")
            {
                boxCollider.isTrigger = true;
                GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 0.3f);
                Debug.Log("red is open ");
            }

        }
        else if (unlocked == false)
        {
            Debug.Log("should be locking");
            if (gameObject.tag == "red")
            {
                boxCollider.isTrigger = false;
                GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 1.0f);
            }
            if (gameObject.tag == "blue")
            {
                boxCollider.isTrigger = true;
                GetComponent<SpriteRenderer>().color = new Color(0, 0, 1, 0.3f);
            }
        }

    }

    // Start is called before the first frame update
    void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();

        Debug.Log("doors set");
        Debug.Log(GetComponent<SpriteRenderer>().color.a);
        if (gameObject.tag == "red")
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 1.0f);
        }
        if (gameObject.tag == "blue")
        {
            GetComponent<SpriteRenderer>().color = new Color(0, 0, 1, 0.3f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(unlocked);
    }
}
