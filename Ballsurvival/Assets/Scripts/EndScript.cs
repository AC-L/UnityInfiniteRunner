using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScript : MonoBehaviour
{
    //to convert TextMeshPro to normal text commands
    public TextMeshProUGUI scoreEnd;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        // When health = 0
        if (HealthCount.Healthvalue <= 0)
        {
            //font becomes opaque. display text with score. font set to transparent in unity.
            scoreEnd = gameObject.GetComponent<TextMeshProUGUI>();
            scoreEnd.color = new Color(1f, 1f, 1f, 1f);
            scoreText.text = "You Died     Score: " + Mathf.Round(ScoreCount.scorecount);
        }
    }
}
