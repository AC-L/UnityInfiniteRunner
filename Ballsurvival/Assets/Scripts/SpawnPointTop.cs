using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointTop : MonoBehaviour
{
    //import objects to be placed into the spawner
    public GameObject Ceiling;
    public GameObject CeilingSpike;
    public GameObject CeilingBlock;
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
                //positions of the spawned items
                Vector3 spawnPosition = new Vector3(
                    transform.position.x - StartGap,
                    transform.position.y,
                    transform.position.z);
                Vector3 spikePosition = new Vector3(
                    transform.position.x - StartGap,
                    transform.position.y + blocksize,
                    transform.position.z);
                //random int is created and the item that spanwns is based on this number
                int rand = Random.Range(0, 100);
                if (rand < 40)
                {
                    //instantiate makes a copy of the imported game object at the predfined location and original position
                    //spawns a block and then a spike below it
                    Instantiate(CeilingBlock, spawnPosition, Quaternion.identity);
                    Instantiate(CeilingSpike, spikePosition, Quaternion.Euler(0f, 0f, 180f));
                    yield return new WaitForSeconds(spawnWait);
                    int rand2 = Random.Range(0, 10);
                    //code so that there is an additional chance to spawn another of the same item
                    if (rand2 < 4)
                    {
                        Instantiate(CeilingBlock, spawnPosition, Quaternion.identity);
                        Instantiate(CeilingSpike, spikePosition, Quaternion.Euler(0f, 0f, 180f));
                        yield return new WaitForSeconds(spawnWait);
                        int rand3 = Random.Range(0, 10);
                        if (rand3 < 4)
                        {
                            Instantiate(CeilingBlock, spawnPosition, Quaternion.identity);
                            Instantiate(CeilingSpike, spikePosition, Quaternion.Euler(0f, 0f, 180f));
                            yield return new WaitForSeconds(spawnWait);
                        }
                        else { yield return new WaitForSeconds(0); }
                    }
                    else { yield return new WaitForSeconds(0); }

                }
                else 
                {
                    //else fill in the gaps
                    Instantiate(Ceiling, spawnPosition, Quaternion.identity);
                    yield return new WaitForSeconds(spawnWait);
                }
                
            }
        }
    }
}
