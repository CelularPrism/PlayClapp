using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    private float speed;
    private float distance;
    private float oldPosZ;

    private void Start()
    {
        oldPosZ = transform.position.z;
    }

    void FixedUpdate()
    {
        if (oldPosZ + distance > transform.position.z)
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed * Time.deltaTime);
        else
            Destroy(transform.gameObject);
    }

    public void SetParametres(float speed, float distance)
    {
        this.speed = speed;
        this.distance = distance;
    }
}
