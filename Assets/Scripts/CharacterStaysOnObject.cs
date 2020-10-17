using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStaysOnObject : MonoBehaviour
{

    public GameObject Player;
    [SerializeField] private Animator animatorPlatform;
     

    void Start()
    {
        animatorPlatform = GetComponent<Animator>();
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Player.transform.parent = transform;
            animatorPlatform.SetBool("CharacterOnPlatform", true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Player.transform.parent = null;
            animatorPlatform.SetBool("CharacterOnPlatform", false);
        }
    }

   

}

//    //public CharacterController player;

//    void OnCollisionEnter(Collision other)
//    {
//        if (other.gameObject.tag == "Player")
//        {
//            other.collider.transform.SetParent(transform);
//        }
        
//    }

//    void OnCollisionExit(Collision other)
//    {
//        if (other.gameObject.tag == "Player")
//        {
//            other.collider.transform.SetParent(null);
//        }
//    }
//}
