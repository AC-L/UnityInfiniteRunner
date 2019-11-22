using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float speed=3;
    // Start is called before the first frame update
    private float lifetime = 12;
    void Start()
    {       
        //kill the object after a set time to save memory
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        // instead of moving the spawnpoint and camere, we move the object it spawns left to a fix rate. Easier to code.
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        
    }
}
