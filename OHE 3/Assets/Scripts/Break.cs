using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Break : MonoBehaviour
{
    private void Update()
    {
        var hits = Physics2D.CircleCastAll(transform.position, 1f, transform.position, 0);

        if (Input.GetMouseButtonDown(0))
        {
            foreach (var hit in hits) 
            {
                if(hit.collider.tag == "block")
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
