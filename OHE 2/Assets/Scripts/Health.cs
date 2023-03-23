using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Capsule")
        {
            other.GetComponent<Player>().health += (int)(other.GetComponent<Player>().maxHealt / 2);
            if(other.GetComponent<Player>().health >= other.GetComponent<Player>().maxHealt)
            {
                other.GetComponent<Player>().health = other.GetComponent<Player>().maxHealt;
            }
            Destroy(gameObject);
        }
    }
}
