using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGUI : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(VanishGUIbox());
    }
    private void OnGUI()
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
        GUI.Box(new Rect(100, 200, 600, 55), "You won! Enjoy the island!", fontStyle);
    }

    private IEnumerator VanishGUIbox()
    {
        yield return new WaitForSeconds(5);
        gameObject.SetActive(false);
    }
}
