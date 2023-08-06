using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    public int progress;

    public void Next()
    {
        progress = PlayerPrefs.GetInt("progress");
        progress = progress + 1;
        SceneManager.LoadScene(progress);
        PlayerPrefs.SetInt("progress", progress);
    }
    
    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }

}
