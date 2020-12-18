using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Fight : MonoBehaviour
{
    public GameObject Boss;
    public Transform spawnPoint;
    public GameObject Wall;

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Wall.SetActive(true);
            Boss.SetActive(true);
            Destroy(gameObject);
        }
    }
}
