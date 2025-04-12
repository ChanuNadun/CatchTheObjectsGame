using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject fallingObject;
    public float spawnRate = 1.5f;
    public float xRange = 8f;

    void Start()
    {
        InvokeRepeating("SpawnObject", 1f, spawnRate);
    }

    void SpawnObject()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-xRange, xRange), transform.position.y);
        Instantiate(fallingObject, spawnPos, Quaternion.identity);
    }
}
