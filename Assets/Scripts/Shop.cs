using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour
{
    public int a;
    public void ToShop()
    {
        a = (int)SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("scena", a);
        SceneManager.LoadScene(22);
    }

    public void ShopBack()
    {
        a = PlayerPrefs.GetInt("scena");
        SceneManager.LoadScene(a);
    }
}
