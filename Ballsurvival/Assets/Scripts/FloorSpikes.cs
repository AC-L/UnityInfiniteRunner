using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpikes : MonoBehaviour
{
    //vector to move the player in desired direction
    private Vector3 repel = new Vector3(0, 5, 0);
    PlayerController PC;
    //controls speed to move object left
    private float speed=3;
    public Transform start;
    // Start is called before the first frame update
    private float lifetime = 12;
    void Start()
    {
        //kills after it leaves the screen
        Destroy(gameObject, lifetime);
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
            Debug.Log("playerhit");
            //repels player if hit
            other.transform.Translate(Vector3.up * Time.deltaTime * 50);
            
        }
    }
}