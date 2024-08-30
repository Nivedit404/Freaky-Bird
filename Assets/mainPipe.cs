using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainPipe : MonoBehaviour
{
    public float moveSpeed = 7f;


    void Start()
    {

    }

    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

    }
}
