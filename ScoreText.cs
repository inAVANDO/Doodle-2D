using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject scorePanel;
    int score = 0;

   public void addScore()
    {
        score = score + 1;
    }
    void Start()
    {
        
    }

 
    void Update()
    {
        scoreText.text = score.ToString();
    }
}
