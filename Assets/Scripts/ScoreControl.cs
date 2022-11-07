using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{
    public Text ShowScore;
    public static int Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        ShowScore.text = Score.ToString();
        //textScore.text = "Score: " + score;
    }
}