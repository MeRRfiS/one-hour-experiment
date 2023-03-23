using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    private bool isAttacking = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isAttacking)
        {
            isAttacking = true;
            StartCoroutine(AttackCoroutine());
        }

        IEnumerator AttackCoroutine()
        {
            HitDamage();
            transform.localPosition = new Vector3(-transform.localPosition.x,
                                             transform.localPosition.y,
                                             transform.localPosition.z);
            yield return new WaitForSeconds(0.5f);
            isAttacking = false;
        }
    }

    private void HitDamage()
    {
        var hits = Physics.SphereCastAll(transform.position,
                                     3,
                                     transform.position,
                                     0);

        foreach (RaycastHit hit in hits)
        {
            if (hit.collider.tag == "Enemy")
            {
                Enemy enemy = hit.collider.GetComponent<Enemy>();
                enemy.heath -= 100;
                Debug.Log(enemy.heath);
            }
        }
    }
}
