using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    public GameObject columnPrefab;

    public float spawnRate = 3f;

    // Column min and max Y value
    public float columnMin = -2f;
    public float columnMax = 1f;

    // To keep track of the last spawn timer
    private float timeSinceLastSpawn;

    // Pooling variables
    public int sizeOfPool = 5;
    private GameObject[] columns;
    private float XSpawnPosition = 10f;
    private int currentColumn = 0;

    private Vector2 poolSpawnPosition = new Vector2(-15f, 0f);
    
    // Start is called before the first frame update
    void Start()
    {
        columns = new GameObject[sizeOfPool];
        for(int i = 0; i < sizeOfPool; i++)
        {
            columns[i] = Instantiate<GameObject>(columnPrefab, poolSpawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if(!GameController.instance.gameOver && timeSinceLastSpawn >= spawnRate)
        {
            timeSinceLastSpawn = 0;
            float randomY = Random.Range(columnMin, columnMax);
            columns[currentColumn].transform.position = new Vector2(XSpawnPosition, randomY);
            currentColumn++;

            if (currentColumn >= sizeOfPool) currentColumn = 0;
        }
    }
}
