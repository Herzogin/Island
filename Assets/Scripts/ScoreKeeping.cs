using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeping : MonoBehaviour
{
    public GameObject Gate;
    [SerializeField] private Animator animatorGate;

    public static int Score = 0;
    public int highscore = 0;
    bool hitHighscore = false;
    
    void Start()
    {
        print("loaded ScoreKeeping");
        animatorGate = Gate.GetComponent<Animator>();
    }

    void Update()
    {
        if (Score == highscore && !hitHighscore)
        {
            Gate.SetActive(true);
            FindObjectOfType<AudioManager>().PlayAudio("Gate");
            animatorGate.SetBool("gateAppears", true);
            hitHighscore = true;
        }
    }

    void OnGUI()
    {
        GUI.Box(new Rect(100, 100, 100, 100), "Score: " + Score.ToString());
    }

}
