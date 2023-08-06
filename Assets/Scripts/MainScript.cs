using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainScript : MonoBehaviour
{
    [SerializeField] int Money;
    public Text MoneyText;
    public int achivment;
    public int a;
    public int damage;
    public int progress;
    public GameObject effect;
    public GameObject button;

    private void Start()
    {
        progress = PlayerPrefs.GetInt("progress");
        if (progress == 0)
        {
            progress = 1;
            PlayerPrefs.SetInt("progress", progress);
        }
        Money = PlayerPrefs.GetInt("money");
        damage = PlayerPrefs.GetInt("damage");
        if (damage == 0)
        {
            damage = 1;
        }
        achivment = PlayerPrefs.GetInt("achivment");
    }

    public void ButtonClick()
    {
        Money++;
        Instantiate(effect, button.GetComponent<RectTransform>().position.normalized, Quaternion.identity);
        button.GetComponent<RectTransform>().localScale = new Vector3(0.95f, 0.95f, 0);
        PlayerPrefs.SetInt("money", Money);
        if (achivment != 3)
        {
            if(achivment == 0 & Money >= 100)
            {
                achivment = 1;
                Money = Money + 100;
                PlayerPrefs.SetInt("money", Money);
                PlayerPrefs.SetInt("achivment", achivment);
            }
            if(achivment == 1 & Money >= 1000)
            {
                achivment = 2;
                Money = Money + 1000;
                PlayerPrefs.SetInt("money", Money);
                PlayerPrefs.SetInt("achivment", achivment);
            }
            if (achivment == 2 & Money >= 10000)
            {
                achivment = 3;
                Money = Money + 10000;
                PlayerPrefs.SetInt("money", Money);
                PlayerPrefs.SetInt("achivment", achivment);
            }
        }
    }

    public void OnClickUP()
    {
        button.GetComponent<RectTransform>().localScale = new Vector3(1f, 1f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        MoneyText.text = Money.ToString() +"$";
        
    }

    public void Buy1()
    {
        if (Money >= 100)
        {
            Money = Money - 100;
            damage = damage + 1;
            PlayerPrefs.SetInt("money", Money);
            PlayerPrefs.SetInt("damage", damage);
        }
        else { }
        
    }

    public void Buy10()
    {
        if (Money >= 1000)
        {
            Money = Money - 1000;
            damage = damage + 12;
            PlayerPrefs.SetInt("money", Money);
            PlayerPrefs.SetInt("damage", damage);
        }
        else { }
    }

    public void Buy100()
    {
        if (Money >= 10000)
        {
            Money = Money - 10000;
            damage = damage + 112;
            PlayerPrefs.SetInt("money", Money);
            PlayerPrefs.SetInt("damage", damage);
        }
        else { }
    }

    private void Buy(int a)
    {
        if (Money >= a)
        {
            Money = Money - a;
        }
        else { }
    }

    public void ToAchievement()
    {
        a = (int)SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("scena", a);
        SceneManager.LoadScene(21);
    }

    public void ToImp()
    {
        a = (int)SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("scena", a);
        SceneManager.LoadScene(19);
    }

    public void ToMenu()
    {
        a = (int)SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("scena", a);
        SceneManager.LoadScene(0);
    }
}
