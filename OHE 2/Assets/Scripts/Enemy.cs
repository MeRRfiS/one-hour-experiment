using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int heath = 500;
    public GameObject book;
    private Vector3 spawn;

    private void Start()
    {
        spawn = new Vector3(gameObject.transform.position.x,
                            gameObject.transform.position.y + 1,
                            gameObject.transform.position.z);
    }

    private void Update()
    {
        if(heath <= 0)
        {
            var a = Random.Range(0, 11);
            if(a < 8)
            {
                Instantiate(book, spawn, book.transform.rotation);
            }

            Destroy(gameObject);
        }
    }
}
