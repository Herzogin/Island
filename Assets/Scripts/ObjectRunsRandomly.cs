using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRunsRandomly : MonoBehaviour
{
    private bool stopped = false;
    private float speed = 2.0f;
    private float pause = 2.0f;


    void Update()
    {
        if (!stopped)
        {
            stopped = true;
            float randomX = Random.Range(235.0f, 255.0f);
            //float randomY = Random.Range(36.0f, 39.0f);
            float randomZ = Random.Range(217.0f, 227.0f);
            StartCoroutine(FliesToTarget(new Vector3(randomX, 13.0f, randomZ)));
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
}
