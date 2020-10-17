using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithCube : MonoBehaviour
{
    //public GameObject self;
    //private float speed = 2.0f;
    //private float pause = 2.0f;
    //public GameObject destroyedGameObject;
    // Start is called before the first frame update
    void Start()
    {
        print("collideWithCubes loades");
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
            //self.SetActive(false);
            //GetComponent < ObjectRunsRandomly > ().enabled = false;
             // 
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(215.0f, 36.42f, 225.0f), Time.deltaTime * 4);
            
            //new Vector3(215.0f, 36.42f, 225.0f);
            
            //float randomX = Random.Range(214.7f, 219.9f);
            //float randomZ = Random.Range(223.7f, 228.9f);
            //transform.position = new Vector3(randomX, 36.42f, randomZ);//Vector3.Lerp(transform.position, new Vector3(randomX, 36.42f, randomZ), 1.0f);
            //StartCoroutine(FliesToTarget(new Vector3(randomX, 36.42f, randomZ)));
        }
    }

    //private IEnumerator FliesToTarget(Vector3 target)
    //{
    //    speed = Random.Range(10.0f, 20.0f);
    //    pause = Random.Range(3.0f, 5.0f);
    //    float timer = 0.0f;
    //    Vector3 origin = transform.position;

    //    while (timer < speed)
    //    {
    //        timer += Time.deltaTime;
    //        float t = timer / speed;
    //        t = t * t * t * (t * (6f * t - 15f) + 10f);
    //        transform.position = Vector3.Lerp(origin, target, t);

    //        yield return null;
    //    }

    //    yield return new WaitForSeconds(pause);
        
    //}
}
