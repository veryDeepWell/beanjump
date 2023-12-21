using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuPlay : MonoBehaviour
{
    public void OpenMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenSettings()
    { 
        SceneManager.LoadScene(4);
    }

    public void CloseTheGame()
    {
        Application.Quit();
    }
}
