using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemy;

    void Start()
    {
        StartCoroutine(ToSpawn());
    }

    IEnumerator ToSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);

            int rand = UnityEngine.Random.Range(0, spawnPoints.Length);

            try
            {
                Instantiate(enemy, spawnPoints[rand].position, enemy.transform.rotation);
            }
            catch (Exception)
            {
                
            }
        }
    }
}