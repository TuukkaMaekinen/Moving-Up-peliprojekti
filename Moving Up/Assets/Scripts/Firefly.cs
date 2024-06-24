using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firefly : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        Firefly_Counter.fireflyAmount++;
    }
}
