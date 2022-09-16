using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRunner : MonoBehaviour
{
    public Rigidbody rigid_body;
    public float force;
    public float minX;
    public float maxX;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 playerPosition = transform.position;
        playerPosition.x = Mathf.Clamp(playerPosition.x, minX, maxX);
        transform.position = playerPosition;


        if (Input.GetKey(KeyCode.D)) 
        {
            transform.position = transform.position + new Vector3(force*Time.deltaTime, 0, 0);  
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-force * Time.deltaTime, 0, 0);
        }

        
           
    }
}
