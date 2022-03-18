using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    
    [SerializeField] private InputField textTimeNextSpawn;
    [SerializeField] private SpawnManager spawnManager;
    [SerializeField] private Transform floor;
    [SerializeField] private Transform prefabCube;
    private float timeNextSpawn;
    private float timeSpawn;

    private void Start()
    {
        spawnManager = transform.GetComponent<SpawnManager>();
        timeNextSpawn = 0f;
        timeSpawn = 0f;
    }

    void FixedUpdate()
    {

        if (timeSpawn + timeNextSpawn < Time.time)
        {
            float zoneSpawn = floor.localScale.x / 2 - prefabCube.localScale.x / 2;
            spawnManager.Spawn(zoneSpawn);
            timeSpawn = Time.time;
        }
        timeNextSpawn = float.Parse(textTimeNextSpawn.text == "" ? "0" : textTimeNextSpawn.text);
    }
}
