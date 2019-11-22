using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    PlayerController PC;
    //controls variables for the object
    private float speed = -3;
    private float lifetime = 12;
    // Start is called before the first frame update
    void Start()
    {
        //destroys after it leaves the screen
        Destroy(gameObject, lifetime);
        //find player
        PC = GameObject.Find("Player").GetComponent<PlayerController>();
    }


    // Update is called once per frame
    void Update()
    {
        //moves object left
        transform.Translate(Vector3.left * Time.deltaTime * speed);

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
        {
            //repels on collision
            other.transform.Translate(Vector3.right * Time.deltaTime * 50);

        }
    }
}
