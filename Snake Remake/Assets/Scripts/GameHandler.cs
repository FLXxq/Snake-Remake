using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class GameHandler : MonoBehaviour {

    private static GameHandler instance;
    public static int score;
    public GameObject retry;
    public GameObject next;
    public GameObject exit;
    public GameObject canvas;
    public GameObject pause;
    private bool esc = false;
    


    [SerializeField] private Snake snake;
   

    private LevelGrid levelGrid;

    private void Awake()
    {
       
        instance = this;
       
    }

    private void Start() 
    {
        Debug.Log("GameHandler.Start");

        levelGrid = new LevelGrid(35, 35);
        snake.Setup(levelGrid);
        levelGrid.Setup(snake);

        retry = GameObject.Find("UI/Canvas/Retry");
        next = GameObject.Find("UI/Canvas/Next Level");
        exit = GameObject.Find("UI/Canvas/Exit");
        canvas = GameObject.Find("Canvas for PSTSP");
        pause = GameObject.Find("UI/Canvas/Pause");


        retry.SetActive(false);
        exit.SetActive(false);
        next.SetActive(false);
        pause.SetActive(false);

        canvas.SetActive(true);
        Time.timeScale = 0;
    }
    private void Update()
    {
        StartGame();
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (esc == false)
            {
                PauseEnter();
                esc = true;
            }
            else
            {
                PauseExit();
                esc = false;
            }
       

        }
    }
    public static int GetScore()
    {
        return score;
    }

    public static void AddScore()
    {
        score += 100;
       
    }
    public static void NullScore()
    {
        score = 0;
    }
    public void StartGame()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            canvas.SetActive(false);
            Time.timeScale = 1;
        }
    }
    public void PauseEnter()
    {
        retry = GameObject.Find("UI/Canvas/Retry");
        exit = GameObject.Find("UI/Canvas/Exit");
        exit.SetActive(true);
        retry.SetActive(true);
        pause.SetActive(true);  
        Time.timeScale = 0;

    }
    public void PauseExit()
    {
        retry = GameObject.Find("UI/Canvas/Retry");
        exit = GameObject.Find("UI/Canvas/Exit");
        exit.SetActive(false);
        retry.SetActive(false);
        pause.SetActive(false);
        Time.timeScale = 1;
    }

}
