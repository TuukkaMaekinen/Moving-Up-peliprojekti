using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Eating_Fireflies : MonoBehaviour
{
    bool isEating;

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Firefly"))
        {
            print("Tulikarpanen");
            Destroy(other.gameObject);
            Firefly_Counter.fireflyAmount++;
        }
    }
    
}
