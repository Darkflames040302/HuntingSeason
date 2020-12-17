using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public GameObject impactEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Boss_enemy Boss = hitInfo.GetComponent<Boss_enemy>();
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(52);
        }

        if (Boss != null)
        {
            Boss.TakeDamage(30);
        }


        Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    } 
}
