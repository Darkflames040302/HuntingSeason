using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    private Transform playerTransform;
    public Vector3 offset;
    [Range(0, 10)]
    public float smoothFactor;

    public Transform CamP;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void FixedUpdate()
    {
        Follow();
    }

    void Follow()
    {
        Vector3 temp = playerTransform.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(playerTransform.position, temp, smoothFactor * Time.fixedDeltaTime);
        temp.x = playerTransform.position.x;
        temp.y = playerTransform.position.y;

        transform.position = smoothPosition;
    }

    public void BgCam()
    {
        transform.position = CamP.position;
        transform.rotation = CamP.rotation;
    }

}
