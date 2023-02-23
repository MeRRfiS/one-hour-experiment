using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject carrot;
    public Transform gun;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Transform bullet = Instantiate(carrot, gun.position, Quaternion.identity).transform;
        }
    }
}
