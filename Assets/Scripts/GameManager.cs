using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int totalscore = 0;

    private void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle(); 
        myStyle.fontSize = 80;
        GUI.Box(new Rect(60, 60, 400, 400), "Score : " + totalscore.ToString(),myStyle);
    }
}
