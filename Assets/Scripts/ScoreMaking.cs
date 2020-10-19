using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMaking : MonoBehaviour
{
  
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "ThirdPersonController")
        {
            ScoreKeeping.Score += 1;
            FindObjectOfType<AudioManager>().PlayAudio("BallCatch");
            Destroy(gameObject);

        }
    }
}
