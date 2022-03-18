using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstacle;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    public float startDelay = 2f;
    public float repeatRate = 2f;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = FindObjectOfType<PlayerController>();

        // Spawneamos obstáculos cada cierto intervalo de tiempo
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);

    }


    public void SpawnObstacle()
    {
        if (!playerControllerScript.gameOver)
        {
            Instantiate(obstacle, spawnPos, obstacle.transform.rotation);
        }
    }
}
