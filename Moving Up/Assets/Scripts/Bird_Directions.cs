using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Directions : MonoBehaviour
{

    public float speed;


    public float direction;
    private Rigidbody2D player;
   

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
       
    }

    void Update()
    {
        if (direction > 0f)
        {
            print("Jepjee");
            player.velocity = new Vector2(direction * speed, player.velocity.y);
            transform.localScale = new Vector2(1, -1);
        }
        if (direction < 0f)
        {
            print("kakkakakaka");
            player.velocity = new Vector2(direction * speed, player.velocity.y);
            transform.localScale = new Vector2(-1, 1);

        }
    }
}
