using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject[] spawnLocations;
    public GameObject X;

    private Vector2 respawnLocation;

   void Awake()
    {
        spawnLocations = GameObject.FindGameObjectsWithTag("spawnpoint");
    }

    void Start()
    {
        respawnLocation = X.transform.position;
        SpawnX();
    }

    private void SpawnX()
    {
        int spawn = Random.Range(0, spawnLocations.Length);
        GameObject.Instantiate(X, spawnLocations[spawn].transform.position, Quaternion.identity);
    }
}
