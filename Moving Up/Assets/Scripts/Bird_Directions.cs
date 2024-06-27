using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Directions : MonoBehaviour
{
    [SerializeField]
    float moveX;
    [SerializeField]
    float moveY;

    public bool isFacingLeft;
    public float movespeed;
    public Rigidbody2D rb;

    SpriteRenderer spriteRenderer;




    void Start()
    {
        isFacingLeft = !isFacingLeft; // eli isFacingLeft on senhetkinen vasta-arvo
                                      // 3 tapaa referoida alustettuun spriteRendereriin:
                                      //  // Jos flippaus 1.vaihtoehto käytössä
        rb.GetComponent<SpriteRenderer>();
        spriteRenderer = rb.GetComponent<SpriteRenderer>();
    }

    void Move()
    {

        if (moveX < 0)
        {
            spriteRenderer.flipX = false;
            isFacingLeft = true;
        }
        if (moveX > 0)
        {
            spriteRenderer.flipX = true;
            isFacingLeft = false;
        }

        // Tai sitten vain:
        //else
        //{
        //    spriteRenderer.flipX = true;
        //}
        //-----------------------------
        // Hahmon flippaus vaihtoehto 2:
        //if (rb.velocity.x < 0)
        //{
        //    // Hyväksyy myös new Vector2(x,y)
        //    transform.localScale = new(-1, transform.localScale.y);
        //}
        //else if (rb.velocity.x > 0)
        //{
        //    transform.localScale = new(1, transform.localScale.y);
        //}
        //-----------------------------
        // Hahmon flippaus vaihtoehto 3:
        //if (rb.velocity.x < 0)
        //{
        //    transform.rotation = Quaternion.Euler(0, 180f, 0);
        //}
        //else if (rb.velocity.x > 0)
        //{
        //    transform.rotation = Quaternion.Euler(0, 0, 0);
        //}


    }

    void Update()
    {
        Move();
    }
}
