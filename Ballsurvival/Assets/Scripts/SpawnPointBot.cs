using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointBot : MonoBehaviour
{
    //import objects to be placed into the spawner
    public GameObject Floor;
    public GameObject Floor2;
    public GameObject FloorSpike;
    public GameObject FloorBlock;
    public Vector3 spawnValues;
    // variables to be adjusted so that the correct gap is placed between objects
    public float blocksize;
    public float spawnWait;
    public float StartGap;

    // Start is called before the first frame update

    void Start()
    {
        //run coroutine so IEnumerator works
        StartCoroutine(SpawnWaves());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SpawnWaves()
    {
        while (true)
        {
            //for loop to continously go through a set of instructions over and over 
            for (int i = 0; i < 10000; i++)
            {
                //position of the spawned items
                Vector3 spawnPosition = new Vector3(
                    transform.position.x -StartGap,
                    transform.position.y,
                    transform.position.z);
                Vector3 spikePosition = new Vector3(
                    transform.position.x - StartGap,
                    transform.position.y+blocksize,
                    transform.position.z);
                Vector3 platPosition = new Vector3(
                    transform.position.x - StartGap,
                    transform.position.y+5,
                    transform.position.z);

                //random int is created and the item that spanwns is based on this number
                int rand = Random.Range(0, 80);
                // spawns a spike
                if (rand <= 20)
                {
                    //instantiate makes a copy of the imported game object at the predfined location and original position
                    Instantiate(FloorBlock, spawnPosition, Quaternion.identity);
                    Instantiate(FloorSpike, spikePosition, Quaternion.identity);
                    yield return new WaitForSeconds(spawnWait);
                    int rand2 = Random.Range(0, 10);
                    //spawns a spike ontop of a block 
                    if (rand2 < 5) {
                        Instantiate(FloorBlock, spawnPosition, Quaternion.identity);
                        Instantiate(FloorSpike, spikePosition, Quaternion.identity);
                        yield return new WaitForSeconds(spawnWait);
                        int rand3 = Random.Range(0, 10);
                        // addition chance for another spike
                        if (rand3 < 5)
                        {
                            Instantiate(FloorBlock, spawnPosition, Quaternion.identity);
                            Instantiate(FloorSpike, spikePosition, Quaternion.identity);
                            yield return new WaitForSeconds(spawnWait);
                        }
                        else { yield return new WaitForSeconds(0); }
                    }
                    else { yield return new WaitForSeconds(0); }
                }
                else
                {
                    Instantiate(Floor, spawnPosition, Quaternion.identity);
                    yield return new WaitForSeconds(spawnWait);
                }
            }
        }
    }
}