using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelisPassed : MonoBehaviour
{
    public void Scene(int _scene)
    {
        SceneManager.LoadScene(_scene);
        GameHandler.NullScore();
        Time.timeScale = 1;
    }
}
