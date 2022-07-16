using UnityEngine;

public class ItemSpawnerManager : MonoBehaviour
{
    public GameObject[] itemPrefabs; //Array to store items ships
    
    private float spawnRangeX = 22f;
    private float spawnPosZ = 20f;
    private float startDelay = 5f;
    private float spawnInterval = 6.5f;

   void Start()
    {
        InvokeRepeating("SpawnRandomItem", startDelay, spawnInterval);
    }


    
    void Update()
    {
        
    }

    void SpawnRandomItem()
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);
            int itemIndex = Random.Range(0,itemPrefabs.Length);
            Instantiate(itemPrefabs[itemIndex],spawnPos, itemPrefabs[itemIndex].transform.rotation);
        }
}
