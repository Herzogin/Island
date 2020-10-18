using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeping : MonoBehaviour
{
    public static int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        print("loaded ScoreKeeping");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        GUI.Box(new Rect(100, 100, 100, 100), "Score: "+ Score.ToString());
    }
}
