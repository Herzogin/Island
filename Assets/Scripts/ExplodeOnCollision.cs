using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeOnCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "ThirdPersonController")
        {
            ScoreKeeping.Score =0;
            FindObjectOfType<AudioManager>().PlayAudio("BallExplode");
            
            Destroy(gameObject);

        }
    }
}
