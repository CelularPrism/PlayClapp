using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private InputField textSpeed;
    [SerializeField] private InputField textDistance;
    [SerializeField] private GameObject prefabCube;

    private float speed;
    private float distance;

    private void Start()
    {
        speed = float.Parse(textSpeed.text == "" ? "0" : textSpeed.text);
        distance = float.Parse(textDistance.text == "" ? "0" : textDistance.text);
    }

    private void FixedUpdate()
    {
        speed = float.Parse(textSpeed.text == "" ? "0" : textSpeed.text);
        distance = float.Parse(textDistance.text == "" ? "0" : textDistance.text);
    }

    public void Spawn(float zoneSpawn)
    {
        Vector3 newPos = new Vector3(Random.Range(-zoneSpawn, zoneSpawn), 1f, 0f);
        GameObject gameObject = Instantiate(prefabCube, newPos, new Quaternion(), transform);
        gameObject.GetComponent<Movement>().SetParametres(speed, distance);
    }
}
