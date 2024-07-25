using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] spawnObject;
    public Transform[] spawnLocation;

    void Start()
    {
        for (int i = 0; i < spawnObject.Length; i++)
        {
            Instantiate(spawnObject[Random.Range(0, spawnObject.Length)], spawnLocation[i]);
        }
    }

}
