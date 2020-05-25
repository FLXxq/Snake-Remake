using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    private Text vText;
    public GameObject next;
    public GameObject exit;
    public AudioSource wmusic;
    private int score=0;

    private void Awake()
    {
        vText = transform.Find("Text").GetComponent<Text>();

    }
    private void Start()
    {
        wmusic = GetComponent<AudioSource>();
    }
    public void ANextLevel()
    {
        next = GameObject.Find("UI/Canvas/Next Level");
        exit = GameObject.Find("UI/Canvas/Exit");
        exit.SetActive(true);
        next.SetActive(true);
        wmusic.Play();
        
    }
    private void Update()
    {
        if (score < 300)
        {
            score = GameHandler.GetScore();
        }
        if (score == 300)
        {
            score += 1;

            vText.text = "Level is passed!";
            Time.timeScale = 0;
            ANextLevel();
        }
    }
}
