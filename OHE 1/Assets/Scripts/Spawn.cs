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
            yield return new WaitForSeconds(1f);

            int rand = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy, spawnPoints[rand].position, enemy.transform.rotation);
        }
    }
}
