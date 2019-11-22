using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawn : MonoBehaviour
{
    //import background
    public GameObject Background;
    //to make sure the backgrounds don't overlap
    public float Backgrounddelay;
    // Start is called before the first frame update
    void Start()
    {
        //run the function
        StartCoroutine(SpawnBackground());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SpawnBackground()
    {
        while (true)
        {   Vector3 spawnPosition = new Vector3(
                    transform.position.x,
                    transform.position.y,
                    transform.position.z);
            bool z = true;           
            //for loop to continously spawn the background
            for (int i = 0; i < 10000; i++)
            {
                if (z)
                {
                        //copies the background
                        Instantiate(Background, spawnPosition, Quaternion.identity);
                        z = false;
                        yield return new WaitForSeconds(0);
                }
                else
                {
                        Instantiate(Background, spawnPosition, Quaternion.identity);
                        yield return new WaitForSeconds(Backgrounddelay);
                }
            }
        }
    }
}
