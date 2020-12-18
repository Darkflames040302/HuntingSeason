using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform playerTransform;
    public Vector3 offset;
    [Range(0,10)]
    public float smoothFactor;

    public Transform CamP;
    public bool isStarted = true;
    /*public bool sesuatu = true;*/

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    /*public static void CamChange(string state)
    {
        switch (state)
        {
            case "normal":
                Follow();
                break;
            case "bossFight":
                BossCam();
                break;
        }
    }*/

    void FixedUpdate()
    {
        if (isStarted = true)
        {
            Follow();
        }
        else if (isStarted = false)
        {
            BossCam();
            Debug.Log("if bekerja");
        }

    }
    void Follow()
    {
        Vector3 temp = playerTransform.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(playerTransform.position, temp,smoothFactor*Time.fixedDeltaTime);
        temp.x = playerTransform.position.x;
        temp.y = playerTransform.position.y;

        transform.position = smoothPosition;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("masuk if");
        if (col.CompareTag("Ngetest"))
        {
            isStarted = false;
            Debug.Log("ini kenak");
        }
    }

    public void BossCam()
    {
        transform.position = CamP.position;
        transform.rotation = CamP.rotation;
    }
}
