using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFliesRandomly : MonoBehaviour
{
    public float minimumX;
    public float maximumX;
    public float minimumAltitude;
    public float maximumAltitude;
    public float minimumZ;
    public float maximumZ;
    private bool stopped = false;
    public float speed = 1.0f;
    private float pause = 2.0f;

    private void Start()
    {
        //print("min X: " + minimumX);
        //print("max X: " + maximumX);
        //print("min Alti: " + minimumAltitude);
        //print("max Alti: " + maximumAltitude);
        //print("min Z: " + minimumZ);
        //print("max Z: " + maximumZ);
    }
    void Update()
    {
        
        if (!stopped)
        {
            stopped = true;
            StartCoroutine(FliesToTarget(randomVector3InRange()));
        }
    }

    private IEnumerator FliesToTarget(Vector3 target)
    {
        speed = Random.Range(10.0f, 20.0f);
        pause = Random.Range(3.0f, 5.0f);
        float timer = 0.0f;
        Vector3 origin = transform.position;

        while (timer < speed)
        {
            timer += Time.deltaTime;
            float t = timer / speed;
            t = t * t * t * (t * (6f * t - 15f) + 10f);
            transform.position = Vector3.Lerp(origin, target, t);

            yield return null;
        }

        yield return new WaitForSeconds(pause);

        stopped = false;
    }

    Vector3 randomVector3InRange()
    {
        float randomX = Random.Range(minimumX, maximumX);
        float randomY = Random.Range(minimumAltitude, maximumAltitude); 
        float randomZ = Random.Range(minimumZ, maximumZ);

        return new Vector3(randomX, randomY, randomZ);
    }
}
