using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; //Array to store UFO ships
    
    private float spawnRangeX = 22f;
    private float spawnPosZ = 20f;
    private float startDelay = 1f;
    private float spawnInterval = 2f;
    
    void Start()
    {
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }

    
    void Update()
    {
        
    }

    void SpawnRandomUFO()
    {
         Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ); // random location picker on x axis   
         int ufoIndex = Random.Range(0,ufoPrefabs.Length); // picks a random UFO from the array
         Instantiate(ufoPrefabs[ufoIndex],spawnPos, ufoPrefabs[ufoIndex].transform.rotation); //instantiates indexed UFO
    }
}
