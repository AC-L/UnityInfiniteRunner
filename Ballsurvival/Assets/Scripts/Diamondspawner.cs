using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamondspawner : MonoBehaviour
{
    //import objects to be placed into the spawner
    public GameObject Diamond;
    public GameObject HealthPickup;
    // variables to be adjusted so that the correct gap is placed between objects
    public float spawnWaitss;
    // Start is called before the first frame update
    void Start()
    {
        //run coroutine so IEnumerator works
        StartCoroutine(SpawnDiamond());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnDiamond()
    {
        while (true)
        {
            //for loop to continously go through a set of instructions over and over 
            for (int i = 0; i < 1000; i++)
            {
                //position of the spawned items
                Vector3 spawnPosition5 = new Vector3(
                    transform.position.x + Random.Range(-4, 4),
                    transform.position.y + Random.Range(-3, 3),
                    transform.position.z);

                    //random int is created and the item that spanwns is based on this number
                    int randdia = Random.Range(1, 20);
                    //spawns diamond
                    if (randdia <= 4)
                    {
                        //instantiate makes a copy of the imported game object at the predfined location and original position
                        Instantiate(Diamond, spawnPosition5, Quaternion.identity);
                        yield return new WaitForSeconds(spawnWaitss);
                    }
                    //spawns health
                    if (randdia > 4 && randdia < 6)
                    {
                    Instantiate(HealthPickup, spawnPosition5, Quaternion.identity);
                    yield return new WaitForSeconds(spawnWaitss);
                    }
                    else
                    {
                        //spawns nothing, leaves a gap
                        yield return new WaitForSeconds(spawnWaitss);
                    }
            }
        }
    }
}
