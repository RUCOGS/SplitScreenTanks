﻿using UnityEngine;
using System.Collections;

public class Shoot4 : MonoBehaviour
{
    public GameObject bullet1;
    int reloadtime1 = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (reloadtime1 > 0) { reloadtime1--; }
        if (Input.GetAxis("4RVert") >= 0f)
        {
            if (Mathf.Cos(Mathf.PI * transform.eulerAngles.z / 180) < Mathf.Cos(Mathf.PI * (transform.eulerAngles.z + 5) / 180))
                transform.Rotate(Vector3.forward, Space.Self);
        }
        if (Input.GetAxis("4RVert") < 0f)
        {
            if (Mathf.Cos(Mathf.PI * transform.eulerAngles.z / 180) > Mathf.Cos(Mathf.PI * (transform.eulerAngles.z - 5) / 180))
            {
                transform.Rotate(Vector3.back, Space.Self);
            }
        }
        if (Input.GetButton("4Fire") && reloadtime1 == 0)
        {
            Instantiate(bullet1, transform.position, transform.rotation);
            reloadtime1 = 150;
        }
    }
}