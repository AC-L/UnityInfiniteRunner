using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCount : MonoBehaviour
{
    // variables to control base score and score gained over time
    public static float scorecount = 0;
    public float scorepersecond = 2;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        //so that i can use TMP instead of normal text
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (HealthCount.Healthvalue > 0)
        {
            //adds score over time
            scorecount += scorepersecond * Time.deltaTime;
            //displays score
            scoreText.text = "Score:" + Mathf.Round(scorecount);
        }       
    }
}
