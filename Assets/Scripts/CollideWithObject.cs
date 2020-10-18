using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithObject : MonoBehaviour
{
    
    void Start()
    {
       
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        print("triggered, Position: " + transform.position);
        if (other.tag == "Player")
        {
            print("Player triggered");
            
        }
    }
}
