using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Spawns objects that fly towards the player
 */
public class ObjectSpawner : MonoBehaviour
{
    private const float heightVariation = 5; // how far the enemy can spawn from y0
    private const float xVariation = 12; //Where on the x-axis the enemy spawns
    public GameObject Prefab;
    public GameObject Player;

    private float totalEnemyTime;      // time elapsed since last enemy spawn
    public float spawnerInterval; // amount of time needed for an enemy to spawn

    // Update is called once per frame
    void Update()
    {
        // spawn an enemy if the time reaches the spawner interval
        if(totalEnemyTime > spawnerInterval) 
        {
            Spawn();
            totalEnemyTime = 0; // reset time so it can climb back up to the spawnerinterval
        }

        // Time.deltaTime counts time since last draw frame
        // this is important to keeping timing in the Update method consistent
        // NOTE: if you want to do this in FixedUpdate, you need to use Time.fixedDeltaTime
        totalEnemyTime += Time.deltaTime; 
    }

    void Spawn()
    {
        // Randomly decides the spawn position.
        float xPos = xVariation;
        if (Random.value > 0.5f) //Coin toss
            xPos = -xPos;
        float height = Random.Range(-heightVariation, heightVariation);

        // sets spawn position and spawns the enemy
        Vector3 SpawnPos = new Vector3(xPos, height, 0);
        GameObject spawnedEnemy = Instantiate(Prefab, SpawnPos, Quaternion.identity);
        spawnedEnemy.GetComponent<ObjectController>().Player = Player;
    }
}
