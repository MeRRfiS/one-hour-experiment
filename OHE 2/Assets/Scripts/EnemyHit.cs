using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    private bool canHit = false;
    private bool startCor = false;

    private void OnDestroy()
    {
        canHit = false;
        startCor = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.name == "Capsule")
        {
            canHit = true;
            StartCoroutine(Hit(other.GetComponent<Player>()));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Capsule")
        {
            canHit = false;
            startCor = false;
        }
    }

    IEnumerator Hit(Player player)
    {
        if (!startCor)
        {
            startCor = true;
            while (canHit)
            {
                player.health -= 50;
                yield return new WaitForSeconds(5f);
            }
        }
    }
}
