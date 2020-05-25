using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    private Text scoreText;
    

    private void Awake()
    {
        scoreText = transform.Find("Text").GetComponent<Text>();
    }
    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "GameScene")
        {

            scoreText.text = GameHandler.GetScore().ToString() + "/300";
        }
        else if (SceneManager.GetActiveScene().name == "GameScene 2")
        {
            scoreText.text = GameHandler.GetScore().ToString() + "/500";
        }
        else if (SceneManager.GetActiveScene().name == "GameScene 3")   
        {
            
            scoreText.text = GameHandler.GetScore().ToString() + "/800";
        }
    }
}
