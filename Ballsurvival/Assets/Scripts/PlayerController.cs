using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool isRun = true;
    bool isLeft;
    int isRunKey = Animator.StringToHash("isRun");
    public AnimationCurve curve;
    public static int Health = 100;
    public Rigidbody2D r ;
    //Update is called once per frame
    void Start()
    {
    }
    void FixedUpdate()
    {
        // the new velocity to apply to the character
        Vector2 physicsVelocity = Vector2.zero;
        // move to the left 
        Rigidbody2D r = GetComponent<Rigidbody2D>();
        if (Input.GetKey(KeyCode.A))
        {
            isRun = true;
            isLeft = false;
            physicsVelocity.x -= 5;
        }
        // move to the right
        else if (Input.GetKey(KeyCode.D))
        {
            isRun = true;
            isLeft = false;
            physicsVelocity.x += 8;
        }
        // move down 
        else if (Input.GetKey(KeyCode.S))
        {
            isRun = false;
            isLeft = false;
            r.velocity = new Vector2(physicsVelocity.x, -6);
        }
        // move to the up 
        else if (Input.GetKey(KeyCode.W))
        {
            isRun = false;
            isLeft = false;
            r.velocity = new Vector2(physicsVelocity.x, 6);
        }
        else
        {
            isRun = false;
        }

       //vertical velocity
        r.velocity = new Vector2(physicsVelocity.x,
        r.velocity.y);
    }

    void Update()
    {
        Animator a = GetComponent<Animator>();
        a.SetBool(isRunKey, isRun);
        SpriteRenderer r = GetComponent<SpriteRenderer>();
       r.flipX = isLeft;
    }
    //controls what happens when the player collides with and object, whether thats effecting health or score
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Coin")
        {
            ScoreCount.scorecount += 2;
            Destroy(other.gameObject);
        }
        if (other.transform.tag == "Spike")
        {
            HealthCount.Healthvalue -= 10;
        }
        if (other.transform.tag == "BigSpinner")
        {
            HealthCount.Healthvalue -= 50;
        }
        if (other.transform.tag == "SmallSpinner")
        {
            HealthCount.Healthvalue -= 20;
            Destroy(other.gameObject);
        }
        if (HealthCount.Healthvalue <= 0)
        {
            Debug.Log("Player is Dead");
            HealthCount.Healthvalue = 0;
            Destroy(gameObject);

        }
        if (other.transform.tag == "Diamond")
        {
            ScoreCount.scorecount += 50;
            Destroy(other.gameObject);
        }
        if (other.transform.tag == "HealthPick")
        {
            if (HealthCount.Healthvalue <= 100) ;
                HealthCount.Healthvalue += 20;
                Destroy(other.gameObject);
        }
    }
}
