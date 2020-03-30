/*
 * Kevon Long
 * MonsterSpawner.cs
 * Assignment #5
 * Spawns the corresponding enemies in their spawners by using the monster factory
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{

    public MonsterFactory factory;

    private GameObject enemy;
    public string type;

    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1) && gameObject.tag == "DemonSpawner")
        {
            type = "Demon";
            enemy = factory.CreateEnemy(type);
            Instantiate(enemy, gameObject.transform.position, gameObject.transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && gameObject.tag == "SpiderSpawner")
        {
            type = "Spider";
            enemy = factory.CreateEnemy(type);
            Instantiate(enemy, gameObject.transform.position, gameObject.transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && gameObject.tag == "SkeletonSpawner")
        {
            type = "Skeleton";
            enemy = factory.CreateEnemy(type);
            Instantiate(enemy, gameObject.transform.position, gameObject.transform.rotation);
        }
    }
}
