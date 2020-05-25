using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class The_End : MonoBehaviour
{
    private Text vText;
    public GameObject next;
    public GameObject exit;
    public AudioSource theendsound;
    private int score = 0;

    private void Awake()
    {
        vText = transform.Find("Text").GetComponent<Text>();
    }
    private void Start()
    {
        theendsound = GetComponent<AudioSource>();
    }
    public void AQuitGame()
    {
        exit = GameObject.Find("UI/Canvas/Exit");
        exit.SetActive(true);
        theendsound.Play();
    }
    private void Update()
    {
        if (score < 800)
        {
            score = GameHandler.GetScore();
        }
       
        if (score == 800)
        {
            score += 1;
            vText.text = "WIN!";
            Time.timeScale = 0;
            AQuitGame();
        }
    }
}
