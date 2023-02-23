using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private static PlayerController instance;

    private Vector2 moveDir;

    private const float DEFAULT_SPEED = 2f;

    [Header("Components")]
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _gun;
    [SerializeField] private Rigidbody2D rigidbody2D;

    public static PlayerController GetInstance()
    {
        return instance;
    }

    private void Update()
    {

        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveDir = moveInput.normalized * DEFAULT_SPEED;

        if (Input.GetKey(KeyCode.A))
        {
            _player.GetComponent<SpriteRenderer>().flipX = true;
            _gun.transform.localPosition = new Vector3(-1, -1);
            _gun.GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            _player.GetComponent<SpriteRenderer>().flipX = false;
            _gun.transform.localPosition = new Vector3(1, -1);
            _gun.GetComponent<SpriteRenderer>().flipX = false;
        }
    }

    private void FixedUpdate()
    {
        rigidbody2D.MovePosition(rigidbody2D.position + moveDir * Time.deltaTime);
    }
}
