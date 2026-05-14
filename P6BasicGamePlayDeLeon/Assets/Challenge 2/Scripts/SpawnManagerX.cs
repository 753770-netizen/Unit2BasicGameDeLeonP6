using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    void SpawnRandomBall()
    {
        // 1. Get a random horizontal screen position (0.0 = left edge, 1.0 = right edge)
        float randomX = Random.Range(0.1f, 0.9f);

        // 2. Define position at the top of the screen (1.0 = top edge)
        // Set the Z distance from the camera where you want the balls to spawn
        Vector3 screenPosition = new Vector3(randomX, 1.0f, 10f);

        // 3. Convert the screen coordinates into 3D world space coordinates
        Vector3 spawnPos = Camera.main.ViewportToWorldPoint(screenPosition);

        // 4. Instantiate a random ball prefab from the array at that position
        int index = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[index], spawnPos, ballPrefabs[index].transform.rotation);
    }
}
