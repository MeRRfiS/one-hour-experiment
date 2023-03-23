using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMiv : MonoBehaviour
{
    public Transform spawnPoints;
    public GameObject miv;
    private GameObject mivObj;

    void Start()
    {
        StartCoroutine(ToSpawn());
    }

    IEnumerator ToSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(60);

            if(mivObj == null)
            {
                mivObj = Instantiate(miv, spawnPoints.position, miv.transform.rotation);
            }
        }
    }
}
