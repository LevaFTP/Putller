using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Achievement : MonoBehaviour
{
    [SerializeField] int Money;
    public int achivment;
    public int a;

    private void Start()
    {
        achivment = PlayerPrefs.GetInt("achivment");
        if (achivment == 0)
        {
            GameObject obj;
            obj = GameObject.Find("UnLocked1");
            obj.SetActive(false);
            obj = GameObject.Find("UnLocked2");
            obj.SetActive(false);
            obj = GameObject.Find("UnLocked3");
            obj.SetActive(false);
        }
        if (achivment == 1)
        {
            GameObject obj;
            obj = GameObject.Find("Locked1");
            obj.SetActive(false);
            obj = GameObject.Find("UnLocked2");
            obj.SetActive(false);
            obj = GameObject.Find("UnLocked3");
            obj.SetActive(false);
        }
        if (achivment == 2)
        {
            GameObject obj;
            obj = GameObject.Find("Locked1");
            obj.SetActive(false);
            obj = GameObject.Find("Locked2");
            obj.SetActive(false);
            obj = GameObject.Find("UnLocked3");
            obj.SetActive(false);
        }
        if (achivment == 3)
        {
            GameObject obj;
            obj = GameObject.Find("Locked1");
            obj.SetActive(false);
            obj = GameObject.Find("Locked2");
            obj.SetActive(false);
            obj = GameObject.Find("Locked3");
            obj.SetActive(false);
        }
    }

    

    public void AchievementBack()
    {
        a = PlayerPrefs.GetInt("scena");
        SceneManager.LoadScene(a);
    }
}
