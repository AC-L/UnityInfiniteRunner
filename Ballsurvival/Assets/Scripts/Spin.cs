using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    PlayerController PC;
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
        //instead of animating the object, i rotated it many times
        transform.Rotate(0, 0, rotation*Time.deltaTime);
    }
    //push the player away on contact
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
        {
            other.transform.Translate(Vector3.right * Time.deltaTime * 50);

        }
    }
}
