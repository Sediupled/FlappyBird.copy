using System.Timers;
using System.Threading;
using System.Security.Cryptography;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=UnityEngine.Random;

public class ColumnSpawner : MonoBehaviour
{
    public GameObject BarricadesPrefab;
    public float minY;
    public float maxY;
    public float time;
    public float maxTime;
    void Update()
    {
        time += Time.deltaTime;
        if(time>= maxTime)
        {
            SpawnColumn();
            time = 0;
        }
    }

    void SpawnColumn()
    {
        float randYPos = Random.Range(minY,maxY);
        GameObject newColumn = Instantiate(BarricadesPrefab);
        Destroy(newColumn,15);
        newColumn.transform.position = new Vector2(transform.position.x , randYPos);
    }
}
