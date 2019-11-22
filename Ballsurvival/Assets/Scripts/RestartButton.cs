using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestartLevel()
    {
        //restarts level on click. Resets health and score to original values.
        Application.LoadLevel(Application.loadedLevel);
        ScoreCount.scorecount = 0;
        HealthCount.Healthvalue = 100;
    }
}
