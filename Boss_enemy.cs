using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_enemy : MonoBehaviour
{
    public int health = 500;
    public GameObject deathEffect;
    public GameObject Death;
    AudioSource audioSource;
    /*public bool triggered = false;*/
    public GameObject PauseMenuUi;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health == 290)
        {
            GetComponent<Animator>().SetBool("IsEnraged", true);
            audioSource.Play();
        }

        if (health <= 0)
        {
            die();
            PauseMenuUi.SetActive(true);
        }
    }

    void die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Instantiate(Death, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
