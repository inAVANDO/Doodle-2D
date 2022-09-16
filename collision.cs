using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public MainCamer mainCameraScript;
    public CubeRunner cubeRunner;
    public GameController gameController;
    public GameObject scoreBoard;
    public ScoreText scoreTextScript;

    public float speed;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "friend")
        {
            Destroy(other.gameObject);
            scoreTextScript.addScore();
            scoreBoard.SetActive(true);
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            speed = 0;
            mainCameraScript.enabled = false;
            cubeRunner.enabled = false;
            gameController.GameOver();

        }
    }

    void Start()
    {
        
    }

   
    void Update()
    {
        transform.position = transform.position + new Vector3(0, 0, speed * Time.deltaTime);
        speed = speed + 0.001f;
    }
}
