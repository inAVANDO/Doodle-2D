using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamer : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0, 0, speed*Time.deltaTime);
        speed = speed + 0.001f;
    }
}
