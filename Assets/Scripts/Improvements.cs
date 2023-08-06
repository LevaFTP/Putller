using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Improvements : MonoBehaviour
{
    [SerializeField] int Money;
    public Text MoneyText;
    public int damage;
    public int status1;
    public int status2;
    public int a;
    void Update()
    {
        MoneyText.text = Money.ToString() + "$";

    }

    void Start()
    {
        Money = PlayerPrefs.GetInt("money");
        status1 = PlayerPrefs.GetInt("status1");
        status2 = PlayerPrefs.GetInt("status2");
        if (status1 == 1)
        {
            GameObject obj;
            obj = GameObject.Find("buy1_lvl1");
            obj.SetActive(false);
        }
        if (status1 == 2)
        {
            GameObject obj;
            obj = GameObject.Find("buy1_lvl1");
            obj.SetActive(false);
            obj = GameObject.Find("buy1_lvl2");
            obj.SetActive(false);
        }
        if (status1 == 3)
        {
            GameObject obj;
            obj = GameObject.Find("buy1_lvl1");
            obj.SetActive(false);
            obj = GameObject.Find("buy1_lvl2");
            obj.SetActive(false);
            obj = GameObject.Find("buy1_lvl3");
            obj.SetActive(false);
        }
        if (status2 == 1)
        {
            GameObject obj;
            obj = GameObject.Find("buy2_lvl1");
            obj.SetActive(false);
        }
        if (status2 == 2)
        {
            GameObject obj;
            obj = GameObject.Find("buy2_lvl1");
            obj.SetActive(false);
            obj = GameObject.Find("buy2_lvl2");
            obj.SetActive(false);
        }
        if (status2 == 3)
        {
            GameObject obj;
            obj = GameObject.Find("buy2_lvl1");
            obj.SetActive(false);
            obj = GameObject.Find("buy2_lvl2");
            obj.SetActive(false);
            obj = GameObject.Find("buy2_lvl3");
            obj.SetActive(false);
        }
    }

    public void buy1_lvl1()
    {
        Money = PlayerPrefs.GetInt("money");
        if (Money >= 20000)
        {
            Money = Money - 20000;
            PlayerPrefs.SetInt("money", Money);
            GameObject obj;
            obj = GameObject.Find("buy1_lvl1");
            obj.SetActive(false);
            status1 = 1;
            PlayerPrefs.SetInt("status1", status1);
        }
    }
    public void buy1_lvl2()
    {
        Money = PlayerPrefs.GetInt("money");
        if (Money >= 50000)
        {
            Money = Money - 50000;
            PlayerPrefs.SetInt("money", Money);
            GameObject obj;
            obj = GameObject.Find("buy1_lvl2");
            obj.SetActive(false);
            status1 = 2;
            PlayerPrefs.SetInt("status1", status1);
        }
    }
    public void buy1_lvl3()
    {
        Money = PlayerPrefs.GetInt("money");
        if (Money >= 100000)
        {
            Money = Money - 100000;
            PlayerPrefs.SetInt("money", Money);
            GameObject obj;
            obj = GameObject.Find("buy1_lvl3");
            obj.SetActive(false);
            status1 = 3;
            PlayerPrefs.SetInt("status1", status1);
        }
    }

    public void buy2_lvl1()
    {
        Money = PlayerPrefs.GetInt("money");
        if (Money >= 50000)
        {
            Money = Money - 50000;
            PlayerPrefs.SetInt("money", Money);
            GameObject obj;
            obj = GameObject.Find("buy2_lvl1");
            obj.SetActive(false);
            status2 = 1;
            PlayerPrefs.SetInt("status2", status2);
        }
    }
    public void buy2_lvl2()
    {
        Money = PlayerPrefs.GetInt("money");
        if (Money >= 100000)
        {
            Money = Money - 100000;
            PlayerPrefs.SetInt("money", Money);
            GameObject obj;
            obj = GameObject.Find("buy2_lvl2");
            obj.SetActive(false);
            status2 = 2;
            PlayerPrefs.SetInt("status2", status2);
        }
    }
    public void buy2_lvl3()
    {
        Money = PlayerPrefs.GetInt("money");
        if (Money >= 150000)
        {
            Money = Money - 150000;
            PlayerPrefs.SetInt("money", Money);
            GameObject obj;
            obj = GameObject.Find("buy2_lvl3");
            obj.SetActive(false);
            status2 = 3;
            PlayerPrefs.SetInt("status2", status2);
        }
    }

    public void ImpBack()
    {
        a = PlayerPrefs.GetInt("scena");
        SceneManager.LoadScene(a);
    }
}
