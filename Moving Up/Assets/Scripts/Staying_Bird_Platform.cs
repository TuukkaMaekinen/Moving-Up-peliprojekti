using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staying_Bird_Platform : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Moving platform"))
            this.transform.parent = collision.transform;


    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Moving platform"))
            this.transform.parent = null;
    }

}
