using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object colliding with the ball has the "Dog" tag
        if (other.CompareTag("Dog"))
        {
            // Destroy this ball object
            Destroy(gameObject);

            // Optional: Destroy the dog object as well
            // Destroy(other.gameObject); 
        }
    }
}