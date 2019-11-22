using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Middlespawn : MonoBehaviour
{
    //import objects to be placed into the spawner
    public GameObject coin;
    public GameObject saw;
    public GameObject spikedblock;
    // variables to be adjusted so that the correct gap is placed between objects
    public float spawnWaits;
    public float sawint;
    // Start is called before the first frame update
    void Start()
    {
        //run coroutine so IEnumerator works
        StartCoroutine(SpawnMiddle());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnMiddle()
    {  
        while (true)
        {
            //for loop to continously go through a set of instructions over and over 
            for (int i = 0; i < 10000; i++)
            {
                //position of the spawned items
                Vector3 spawnPosition1 = new Vector3(
                    transform.position.x,
                    transform.position.y,
                    transform.position.z);
                //random int is created and the item that spanwns is based on this number
                int rand = Random.Range(0, 110);
                if (rand <= 60)
                {
                    int randcoin = Random.Range(1, 3);
                    //instantiate makes a copy of the imported game object at the predfined location and original position
                    Instantiate(coin, spawnPosition1, Quaternion.identity);
                    if (randcoin == 1)
                    { 
                        //spawn 1 coin
                        Instantiate(coin, spawnPosition1, Quaternion.identity);
                        yield return new WaitForSeconds(spawnWaits);
                    }
                    if (randcoin == 2)
                    {
                        //spawn 2 coins
                        Instantiate(coin, spawnPosition1, Quaternion.identity);
                        //wait is required to avoid overlapping and correct spacing
                        yield return new WaitForSeconds(spawnWaits);
                        Instantiate(coin, spawnPosition1, Quaternion.identity);
                        yield return new WaitForSeconds(spawnWaits);
                    }
                    else
                    {
                        //spawn 3 coins
                        Instantiate(coin, spawnPosition1, Quaternion.identity);
                        yield return new WaitForSeconds(spawnWaits);
                        Instantiate(coin, spawnPosition1, Quaternion.identity);
                        yield return new WaitForSeconds(spawnWaits);
                        Instantiate(coin, spawnPosition1, Quaternion.identity);
                        yield return new WaitForSeconds(0);
                    }
                }
                else if (rand > 60 & rand <= 80)
                {
                    //spawns a saw
                    int randsaw = Random.Range(1, 10);
                    if (randsaw <= 8)
                    {
                        yield return new WaitForSeconds(sawint);
                        Instantiate(saw, spawnPosition1, Quaternion.identity);
                        yield return new WaitForSeconds(sawint);
                    }
                    else
                    {
                        //spawnes 2 saws
                        yield return new WaitForSeconds(sawint);
                        Instantiate(saw, spawnPosition1, Quaternion.identity);
                        yield return new WaitForSeconds(sawint);
                        Instantiate(saw, spawnPosition1, Quaternion.identity);
                        yield return new WaitForSeconds(sawint);
                    }

                }
                else
                {
                    //spawns nothing, leaves a gap
                    yield return new WaitForSeconds(spawnWaits);
                }
            }
        }
    }
}
