using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staying_Bird_Platform : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Moving_Platform"))
            this.transform.parent = collision.transform;


    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Moving_Platform"))
            this.transform.parent = null;
    }

}
