using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMaking : MonoBehaviour
{
    //public GameObject AudioManager;
    //private AudioSource source;
    
    // Start is called before the first frame update
    void Start()
    {
        //source = AudioManager.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
