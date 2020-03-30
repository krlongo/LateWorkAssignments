/*
 * Kevon Long
 * MonsterFactory.cs
 * Assignment #5
 * Sets the enemies to spawn as one of the prefabs you set, which is then used by the MonsterSpawner class
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterFactory : MonoBehaviour
{
    public GameObject DemonPrefab;
    public GameObject SkeletonPrefab;
    public GameObject SpiderPrefab;

    private GameObject enemyToSpawn;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject CreateEnemy(string type)
    {
        Debug.Log("Creating " + type);
        enemyToSpawn = null;

        if (type.Equals("Demon"))
        {
            enemyToSpawn = DemonPrefab;

            if (enemyToSpawn.GetComponent<Demon>() == null)
            {
                enemyToSpawn.AddComponent<Demon>();
            }
        }
        else if (type.Equals("Skeleton"))
        {
            enemyToSpawn = SkeletonPrefab;

            if (enemyToSpawn.GetComponent<Skeleton>() == null)
            {
                enemyToSpawn.AddComponent<Skeleton>();
            }
        }
        else if (type.Equals("Spider"))
        {
            enemyToSpawn = SpiderPrefab;

            if (enemyToSpawn.GetComponent<Spider>() == null)
            {
                enemyToSpawn.AddComponent<Spider>();
            }
        }
            return enemyToSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
