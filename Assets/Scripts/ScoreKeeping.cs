using UnityEngine;

public class ScoreKeeping : MonoBehaviour
{
    public GameObject Gate;
    [SerializeField] 
    private Animator animatorGate;

    public static int Score = 0;
    public int highscore = 0;
    bool hitHighscore = false;
    
    void Start()
    {
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
        // Create style 
        GUIStyle fontStyle = new GUIStyle(GUI.skin.box);
        fontStyle.fontSize = 40;
        // Load and set Font
        Font font = (Font)Resources.Load("Fonts/comic", typeof(Font));
        fontStyle.font = font;
        // Set color 
        fontStyle.normal.textColor = Color.white;
        // use style 
        GUI.Box(new Rect(20, 20, 200, 50), "Score: " + Score.ToString(), fontStyle);
    }
}
