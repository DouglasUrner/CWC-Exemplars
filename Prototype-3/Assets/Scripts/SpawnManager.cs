using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public float startDelay = 2;
    public float repeatRate = 2;

    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerController =
            GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void SpawnObstacle()
    {
        if (playerController.gameOver == false)
        {
            var obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
            Instantiate(obstaclePrefabs[obstacleIndex],
                spawnPos, obstaclePrefabs[obstacleIndex].transform.rotation);
        }
    }
}
