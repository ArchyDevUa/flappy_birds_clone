using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    public bool _isGameContinue = true;
    [SerializeField] private int score = 0;

    private void Start()
    {
        scoreText.text = "Score : " + score;
    }

    public void ChangeScore()
    {
        score++;
        scoreText.text = "Score : " + score;
    }
   
}
