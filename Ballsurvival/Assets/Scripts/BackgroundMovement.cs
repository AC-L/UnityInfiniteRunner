using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    //controls speed of background moving left
    private float speeds;
    // Start is called before the first frame update
    private float lifetimes = 30;
    void Start()
    {
        //kill the object after a set time 
        Destroy(gameObject, lifetimes);
    }

    // Update is called once per frame
    void Update()
    {
        // instead of moving the spawnpoint and camere, we move the object it spawns left to a fix rate. Easier to code.
        speeds = 3;
        transform.Translate(Vector3.left * Time.deltaTime * speeds);

    }
}
