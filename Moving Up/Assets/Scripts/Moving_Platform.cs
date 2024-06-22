using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class Moving_Platform : MonoBehaviour
{
    public float speed; //Inspectorissa saa määritellä nopeuden.
    public int startingPoint; 
    public Transform[] points; //Laitetaan inspectoriin pisteet, joiden välillä platform kulkee.

    private int i;

    private void Start()
    {
        {
            transform.position = points[startingPoint].position; //Tämä asettaa platformin lähtöpisteeseensä.
        }
    }

    public void FixedUpdate() //Funktio, jolla saadaan platform liikkeeseen.
    {
        if (Vector2.Distance(transform.position, points[i].position) < 0.02f)
        {


            i++;
            if (i == points.Length)
            {
                i = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }


    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    print("jes");

    //    if (other.tag == "Player")
    //    {
    //        other.transform.SetParent(transform);
    //        Debug.Log("Moving platform");
    //    }
    //}

    //private void OnTriggerExit2D(Collider2D other)
    //{
    //    if (other.tag == "Player")
    //    {
    //        print("NYT!");
    //        other.transform.SetParent(null);
    //    }
    //}


}
