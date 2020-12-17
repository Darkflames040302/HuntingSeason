using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyYourself : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Taken)
    {
        if (Taken.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
