using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumunsPool : MonoBehaviour
{
    public int ColumunsPoolSize = 5;
    public GameObject columunsPrefab;
    public float spawnRate = 4f;
    
    private GameObject[] columuns;
    private Vector2 objectPoolPosition = new Vector2 (-15, -25f);
    private float timesSinceLastSpawned;


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
    }
}
