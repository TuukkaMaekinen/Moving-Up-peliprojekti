using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class Moving_Platform : MonoBehaviour
{
    public float speed;
    public int startingPoint;
    public Transform[] points; //Laitetaan inspectoriin pisteet, joiden välillä platform kulkee.

    private int i;

    private void Start()
    {
        {
            transform.position = points[startingPoint].position; //Tämä asettaa platformin lähtöpisteeseensä.
        }
    }

    public void movingPlatform() //Funktio, jolla saadaan platform liikkeeseen.
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

    void Update()
    {
        movingPlatform();
    }
}
