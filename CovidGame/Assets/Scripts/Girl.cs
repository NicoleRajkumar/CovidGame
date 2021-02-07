using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxSpeed = 3;
    public float speed = 50f;
    public float JumpPower = 550f;

    public bool isJumping;
    public bool isSpraying;
    public bool isDead;

    public bool becauseidk;

    //stats
    public int currentHealth;
    public int maxHealth = 100;

    private Rigidbody2D girlrb2d;
    private Animator anim;
    void Start()
    {
        girlrb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        currentHealth = maxHealth;
        isDead = false;
        becauseidk = false;
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("isJumping", isJumping);
        anim.SetFloat("walkSpeed", Mathf.Abs(Input.GetAxis("Horizontal")));
        anim.SetBool("isSpray", isSpraying);
        anim.SetBool("isDead", isDead);

        if (Input.GetAxis("Horizontal") < -0.1f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (Input.GetAxis("Horizontal") > 0.1f)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            girlrb2d.AddForce(Vector2.up* JumpPower);
            becauseidk = true;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            isSpraying = true;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            isSpraying = false;
        }
    }
    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

        girlrb2d.AddForce((Vector2.right * speed) * h);

        if (girlrb2d.velocity.x > maxSpeed)
        {
            girlrb2d.velocity = new Vector2(maxSpeed, girlrb2d.velocity.y);
        }

        if (girlrb2d.velocity.x < -maxSpeed) {

            girlrb2d.velocity = new Vector2(-maxSpeed, girlrb2d.velocity.y);
        }
    }

    void Die()
    {
        if(currentHealth <= 0)
        {
            isDead = true;
        }
    }
}
