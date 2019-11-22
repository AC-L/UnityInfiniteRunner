using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin2 : MonoBehaviour
{
    PlayerController PC;
    // to control rotation
    public float rotation;
    // Start is called before the first frame update
    void Start()
    {
        //find the player
        PC = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //rotate object for effects
        transform.Rotate(0, 0, rotation * Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
        {
            //move player away on contact
            other.transform.Translate(Vector3.left * Time.deltaTime * 50);
        }
    }
}