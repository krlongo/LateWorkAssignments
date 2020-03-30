/*
 * Kevon Long
 * Spawner.cs
 * Assignment #8
 * Spawns the obstacles
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float firerate;
    float nextFire;
    public GameObject topObstacle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFire)
        {
            if (gameObject.tag == "TopSpawner")
            {
                Instantiate(topObstacle, transform.position, transform.rotation);
            }

            nextFire = Time.time + firerate;
        }
    }
}
