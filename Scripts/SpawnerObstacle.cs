using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerObstacle : MonoBehaviour
{

    public GameObject[] obstacles;
    public Vector3 spawnValues;
    public float spawnWait;
    public float mostWait;
    public float leastWait;
    public int startWait;
    private int randObstacle;
    public int positionXMin;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    
    void Update()
    {
        spawnWait = Random.Range(leastWait,mostWait);
    }

   private IEnumerator Spawn()
    {
        yield return new WaitForSeconds(startWait);
        while(true)
        {
            randObstacle = Random.Range(0, obstacles.Length);
            Vector3 spawnPosition = new Vector3(Random.Range(positionXMin, spawnValues.x), 1, Random.Range(-spawnValues.z, spawnValues.z));
            Instantiate(obstacles[randObstacle], spawnPosition, obstacles[randObstacle].transform.rotation);
            yield return new WaitForSeconds(spawnWait);
        }
    }
}
