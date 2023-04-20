using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> obstaclePrefabs;
    public GameObject spawnPoint;

    public float spawnInterval = 2f;
    public float spawnDelay = 2f;

    private bool isGameOver = false;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", spawnDelay, spawnInterval);
    }

    void SpawnObstacle()
    {
        int index = Random.Range(0, obstaclePrefabs.Count);
        GameObject obstaclePrefab = obstaclePrefabs[index];
        GameObject obstacle = Instantiate(obstaclePrefab);
        obstacle.transform.position = spawnPoint.transform.position;
    }

    public void GameOver()
    {
        if (!isGameOver)
        {
            isGameOver = true;
            Debug.Log("Game Over!");
            // Perform any other game over logic here (e.g. show a game over screen, stop spawning obstacles, etc.)
        }
    }
}
