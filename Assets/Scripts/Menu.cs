using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public int progress;

    public void PlayGame()
    {
        progress = PlayerPrefs.GetInt("progress");
        if (progress == 0)
        {
            progress = 1;
            PlayerPrefs.SetInt("progress", progress);
        }
        SceneManager.LoadScene(progress);
    }

    public void ExitGame()
    {
        Debug.Log("Game exit #1");
        Application.Quit();
    }
}
