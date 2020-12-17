using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;

    //public float invinsibleTimeAfterHurt = 2;
    private Rigidbody2D rb2d;

    public float runSpeed = 40f;

    float horizontalMove = 0f;

    bool jump = false;

    bool crouch = false;

    public AudioSource audioSource;

    public AudioClip Move;
    public AudioClip Jump;

    /*public AudioClip Walking;
    public AudioClip Jump;*/

    bool isMoving = false;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
  
        //clip1 = audioClip[0];
        //clip2 = audio[1];
    }

    // Update is called once per frame
    void Update()
    {
        //horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("speed", Mathf.Abs(Input.GetAxisRaw("Horizontal") * runSpeed));

        if (Input.GetButtonDown("Horizontal"))
        {
            audioSource.PlayOneShot(Move);
        }
        


        /*if (rb2d.velocity.x >= 0.01)
        {
            isMoving = true;
        }
        else if (rb2d.velocity.x <= -0.01)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        if (isMoving)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }

        else
        {
            audioSource.Stop();
        }*/

        if (Input.GetButtonDown("Jump"))
        {
            audioSource.PlayOneShot(Jump);
            jump = true;
            animator.SetBool("IsJumping", true);
        }


        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }

        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching (bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }

    void FixedUpdate()
    {
        controller.Move((Input.GetAxisRaw("Horizontal") * runSpeed) * Time.fixedDeltaTime,crouch,jump);
        jump = false;

    }

    //knockback test

    public IEnumerator Knockback(float knockDur, float knockbackPwr, Vector3 knockbackDir)
    {
        float timer = 0;

        while (knockDur > timer)
        {
            timer += Time.deltaTime;

            rb2d.AddForce(new Vector3(knockbackDir.x + -100, knockbackDir.y + knockbackPwr, transform.position.z));

        }

        yield return 0;
    }

    //invinsibleTest

    /*public void TriggerHurt(float hurtTime)
    {
        StartCoroutine(HurtBlinker(hurtTime));
    }

    IEnumerator HurtBlinker(float hurtTime)
    {
        //ignore damage
        int enemyLayer = LayerMask.NameToLayer("Enemy1");
        int playerLayer = LayerMask.NameToLayer("Player");
        Physics2D.IgnoreLayerCollision(enemyLayer, playerLayer);

        //start blink
        animator.SetLayerWeight(1, 1);

        //waktu invis
        yield return new WaitForSeconds(hurtTime);

        //berhenti invis dan anim, hilangkan ignore damage
        Physics2D.IgnoreLayerCollision(enemyLayer, playerLayer, false);
        animator.SetLayerWeight(1, 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Enemy enemy = collision.collider.GetComponent<Enemy>();
        if(enemy != null)
        {
            TriggerHurt(invinsibleTimeAfterHurt);
        }
        
    }*/
}
