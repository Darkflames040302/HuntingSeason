using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public GameObject deathEffect;

    public void TakeDamage (int damage)
    {
        health -= damage;

        /*if (health <= 200)
        {
            GetComponent<Animator>().SetBool("IsEnraged", true);
        }*/

        if (health <= 0)
        {
            /*SoundManager1.PlaySound("enemyDie");*/
            die();
        }
    }

    void die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
