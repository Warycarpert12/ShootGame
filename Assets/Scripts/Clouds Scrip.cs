using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject cloudPrefab;
    public float spawnInterval = 1.0f;
    public float spawnHeight = 42.0f;
    public float spawnRangeMin = 100.0f;
    public float spawnRangeMax = 120.0f;
    public float despawnZ = 200.0f;

    private void Start()
    {
        StartCoroutine(SpawnClouds());
    }

    private IEnumerator SpawnClouds()
    {
        while (true)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(spawnRangeMin, spawnRangeMax), spawnHeight, transform.position.z + Random.Range(spawnRangeMin, spawnRangeMax));
            GameObject newCloud = Instantiate(cloudPrefab, spawnPosition, Quaternion.identity);

            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private void Update()
    {
        foreach (Transform child in transform)
        {
            if (child.position.z >= despawnZ)
            {
                Destroy(child.gameObject);
            }
        }
    }
}