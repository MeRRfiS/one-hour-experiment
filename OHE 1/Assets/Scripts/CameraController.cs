using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraController : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private GameObject camera;
    [SerializeField] private GameObject player;

    [Header("Settings")]
    [SerializeField] private float offsetSmoothing = 1f;
    [SerializeField] private Vector2 maxPosition;

    void FixedUpdate()
    {
        var newPosition = new Vector3();

        newPosition = new Vector3(Mathf.Clamp(player.transform.position.x, -maxPosition.x, maxPosition.x),
                                          Mathf.Clamp(player.transform.position.y, -maxPosition.y, maxPosition.y),
                                          -10);

        camera.transform.position = Vector3.Lerp(camera.transform.position,
                                                         newPosition,
                                                         offsetSmoothing * Time.deltaTime);
    }
}
