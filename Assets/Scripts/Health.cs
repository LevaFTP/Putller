using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int health;
    public int maxhealth;
    public int damage;
    public int status1;
    public int status2;
    public int progress;
    public Text healthText;

    public void TakeHit()
    {
        health -= damage;
        status1 = PlayerPrefs.GetInt("status1", status1);
        if(status1 == 1)
        {
            int rand = (int)Random.Range(1, 15);
            if(rand == 1)
            {
                health = health - (damage * 2);
            }
        }
        if (status1 == 2)
        {
            int rand = (int)Random.Range(1, 15);
            if (rand == 1)
            {
                health = health - (damage * 3);
            }
        }
        if (status1 == 3)
        {
            int rand = (int)Random.Range(1, 15);
            if (rand == 1)
            {
                health = health - (damage * 4);
            }
        }
        if (health <= 0)
        {
            health = 0;
            progress = progress + 1;
            PlayerPrefs.SetInt("progress", progress);
            SceneManager.LoadScene(progress);
        }
    }

    private void Start()
    {
        progress = PlayerPrefs.GetInt("progress");
        if (progress == 0)
        {
            progress = 1;
        }
        damage = PlayerPrefs.GetInt("damage");
        if (damage == 0)
        {
            damage = 1;
        }
        status2 = PlayerPrefs.GetInt("status2", status2);
        if(status2 == 1)
        {
            StartCoroutine(IdleFarm(5));
        }
        if (status2 == 2)
        {
            StartCoroutine(IdleFarm(4));
        }
        if (status2 == 3)
        {
            StartCoroutine(IdleFarm(3));
        }
    }

    void Update()
    {
        healthText.text = health.ToString();
    }
    IEnumerator IdleFarm(int a)
    {
        yield return new WaitForSeconds(5);
        damage = PlayerPrefs.GetInt("damage", damage);
        health = health - damage / a;
        if (health <= 0)
        {
            health = 0;
            progress = progress + 1;
            PlayerPrefs.SetInt("progress", progress);
            SceneManager.LoadScene(progress);
        }
        StartCoroutine(IdleFarm(a));
    }

}
