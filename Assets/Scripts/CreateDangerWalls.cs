﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateDangerWalls : MonoBehaviour
{
    public GameObject DangerWall;

    // Start is called before the first frame update
    void Start()
    {
        float[] x = { 4.0f, 4.0f, -5.0f };
        float[] y = { 0.5f, 0.5f, 0.5f };
        float[] z =
        {
            Random.Range(2.5f, 6.5f),
            Random.Range(-6.5f, -2.5f),
            Random.Range(-2.0f, 2.0f)
        };
        int[] rotationY = { 0, 0, 90 };

        for (int i = 0; i < x.Length; i++)
        {
            Instantiate(DangerWall,
            new Vector3(x[i], y[i], z[i]),
            Quaternion.Euler(0, rotationY[i], 0),
            this.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
