using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GateEnter : MonoBehaviour
{
    void Start()
    {
        print("gate enter loaded");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //print("inside OnTrigger");
        //SceneManager.LoadScene("SampleScene");

        if (other.tag == "Player")
        {
            SceneManager.LoadScene("FlyingSpheres");

        }
    }

    //private void SwitchScene(int sceneNumber)
    //{
    //    SceneManager.LoadScene("SampleScene");
    //}
}
