using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSaws : MonoBehaviour
{
    PlayerController PC;
    //variables to control movement
    private float rotation = 20000;
    private float speed = 3;
    // Start is called before the first frame update
    private float lifetime = 12;
    void Start()
    {
        //destroys object after it goes out of the visible area
        Destroy(gameObject, lifetime);
        //find player 
        PC = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //rotates and moves the object instead of moving the spawnpoint
        transform.position += Vector3.left * Time.deltaTime * speed;
        transform.Rotate(0, 0, rotation * Time.deltaTime);
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
        {
            //repels the player
            other.transform.Translate(Vector3.right * Time.deltaTime * 50);

        }
    }
}
