using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBook : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Dest());
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Capsule")
        {
            other.GetComponent<Player>().numberOfBook++;
            Destroy(gameObject);
        }
    }

    IEnumerator Dest()
    {
        yield return new WaitForSeconds(15);

        Destroy(gameObject);
    }
}
