using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    private Rigidbody2D rb;

    private SpriteRenderer sprite;
     private Animator anim;

     private float dirX = 0f;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * 7f, rb.velocity.y);

        if(Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 7f);

        }

        if (dirX > 0f)
        {
            anim.SetBool("walking", true);
            sprite.flipX = false;

        }
        else if (dirX < 0f)
        {
            anim.SetBool("walking", true);
            sprite.flipX = true;

        }
        else
        {
            anim.SetBool("walking", false);

        }
    }
}
