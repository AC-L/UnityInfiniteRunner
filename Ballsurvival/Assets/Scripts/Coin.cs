using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
   //variables to control the coins movement
    private float rotation=50;
    private float speed = 3;
    //after a set time it kills the object to avoid waste
    private float lifetime = 12;
    void Start()
    {
        Destroy(gameObject, lifetime);
        
    }

    // Update is called once per frame
    void Update()
    {
        // instead of moving the spawnpoint and camere, we move the object it spawns left to a fix rate. Easier to code.
        transform.position += Vector3.left * Time.deltaTime * speed;
        int rand3 = Random.Range(1,2);
        //randomise rotation direction
        if (rand3 == 1)
        {
            transform.Rotate(0, 0, rotation * Time.deltaTime);
        }
        else
        {
            transform.Rotate(0, 0, -rotation * Time.deltaTime);
        }
           

    }
   
}
