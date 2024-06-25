using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Eating_Fireflies : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Firefly"+"FireflyLight"))
        {
            print("Tulikarpanen");
            Destroy(other.gameObject);

        }
    }
    
}
