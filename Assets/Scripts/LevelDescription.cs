using System.Collections;
using UnityEngine;

public class LevelDescription : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(VanishGUIbox());
    }
    private void OnGUI()
    {
        // Create style 
        GUIStyle fontStyle = new GUIStyle(GUI.skin.box);
        fontStyle.fontSize = 20;
        // Load and set Font
        Font font = (Font)Resources.Load("Fonts/comic", typeof(Font));
        fontStyle.font = font;
        // Set color 
        fontStyle.normal.textColor = Color.white;
        // use style 
        GUI.Box(new Rect(50, 200, 700, 40), "Try to catch 5 purple balls, but watch out for the small red ones!", fontStyle);
    }

    private IEnumerator VanishGUIbox()
    {
        yield return new WaitForSeconds(5);
        gameObject.SetActive(false);
    }
}
