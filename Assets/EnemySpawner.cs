using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float min;
    public float max;
    public float timer = 0;

    private Vector3 enemyPos;

    void Start()
    {
        
    }

    void Update()
    {
        timer = timer - Time.deltaTime;

        if (timer <= 0)
        {
            enemyPos = new Vector3(transform.position.x, Random.Range(min, max), 0);
            Instantiate(enemyPrefab, enemyPos, Quaternion.identity);
            timer = 1;
        }
    }
}
