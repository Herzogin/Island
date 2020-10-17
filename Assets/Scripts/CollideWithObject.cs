using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithObject : MonoBehaviour
{
    ParticleSystem exp;
    //public GameObject destroyedGameObject;
    // Start is called before the first frame update
    void Start()
    {
       exp = GetComponent<ParticleSystem>();
        exp.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        print("triggered, Position: " + transform.position);
        if (other.tag == "Player")
        {
            print("Player triggered");
            //destroyedGameObject.SetActive(false);
            //GetComponent<Rigidbody>().useGravity = true;
            exp.Play();
        }//else if (other.tag == "Cube")
    }
}
