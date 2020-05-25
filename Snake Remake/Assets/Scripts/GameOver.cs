using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    
    public void Scene(int _scene)
    {

        SceneManager.LoadScene(_scene);
        GameHandler.NullScore();
    }
}
    