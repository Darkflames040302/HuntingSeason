using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour
{
    private Player_Movement player;
    private Transform transform;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Movement>();
        //Player_Movement this = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Movement>();
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            HealthManagement.health -= 1;
            Vector3 ini = transform.position;

            //StartCoroutine(GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Movement>().Knockback(0.02f, 350, player.transform.position));
            StartCoroutine(player.Knockback(0.02f, 350, ini));
        }
    }
}