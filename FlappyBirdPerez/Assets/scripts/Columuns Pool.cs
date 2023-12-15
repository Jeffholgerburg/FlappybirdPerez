using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumunsPool : MonoBehaviour
{
    public int ColumunsPoolSize = 5;
    public GameObject columunsPrefab;
    public float spawnRate = 4f;
    public float columnMin = -1f;
    public float columnMax = 3.5f;
    
    private GameObject[] columuns;
    private Vector2 objectPoolPosition = new Vector2 (-15, -25f);
    private float timesSinceLastSpawned;
    private float spawnXPosition = 10f;
    private int currentColumn = 0;

    // Start is called before the first frame update
    void Start()
    {
        columuns = new GameObject[ColumunsPoolSize];
        for (int i = 0; i < ColumunsPoolSize; i++)
        {
            columuns[i] = (GameObject) Instantiate(columunsPrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timesSinceLastSpawned += Time.deltaTime;

        if (GameControl.instance.GameOver == false && timesSinceLastSpawned < spawnRate)
        {
            timesSinceLastSpawned = 0;
            float spawnYPosition = Random.Range (columnMin, columnMax);
            columuns [currentColumn].transform.position = new Vector2 (spawnXPosition, spawnYPosition);
            currentColumn++;
            if (currentColumn >= ColumunsPoolSize)
            {
                currentColumn = 0;
            }
        }
    }
}
