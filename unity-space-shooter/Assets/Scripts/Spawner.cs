using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Object
    public GameObject prefab;
    //Borders
    public Transform borderRight;
    public Transform borderLeft;
    //Spawn interval
    public float spawnInterval = 1f;
    //Spawn timer
    public float spawnTimer;

    // Update is called once per frame
    void Update()
    {
        //Update spawn timer
        spawnTimer -= Time.deltaTime;
        //On spawnTimer is less or equal than 0
        if (spawnTimer <= 0)
        {
            //Spawn object
            Spawn();
        }
    }

    //Spawn object
    void Spawn()
    {
        //Get random X position
        float randomX = Random.Range(borderLeft.position.x, borderRight.position.x);
        //Set new position
        Vector2 newPosition = transform.position;
        //Set new X value
        newPosition.x = randomX;
        //Generate new object
        Instantiate(prefab, newPosition, Quaternion.identity);
        //Reset spawn timer
        spawnTimer = spawnInterval;
    }
}
