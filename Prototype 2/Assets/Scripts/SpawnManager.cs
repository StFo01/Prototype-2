using System.Numerics;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnPositionX = 20;
    public float spawnPositionZ = 20;
    public float startDelay = 2.0f;
    public float spawnInterval = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        UnityEngine.Vector3 spawnPosition = new UnityEngine.Vector3(Random.Range(-spawnPositionX, spawnPositionX), 0, spawnPositionZ);
        
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}
