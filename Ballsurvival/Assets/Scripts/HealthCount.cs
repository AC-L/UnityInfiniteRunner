using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthCount : MonoBehaviour
{
    //base Health
    public static float Healthvalue = 100;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //Displays Health as part of the UI
        scoreText.text = "Health:" + Healthvalue;
    }
}