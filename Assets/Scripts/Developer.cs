using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Developer : MonoBehaviour
{
    public int l;
	public int damage;
    public int status1;
    public int status2;
    public int achivment;
    public int progress;

    [SerializeField] int Money;



    // Start is called before the first frame update
    void Start()
    {
		Money = PlayerPrefs.GetInt("money");
		damage = PlayerPrefs.GetInt("damage");
        status1 = PlayerPrefs.GetInt("status1");
        status2 = PlayerPrefs.GetInt("status2");
        achivment = PlayerPrefs.GetInt("achivment");
        progress = PlayerPrefs.GetInt("progress");
    }

    // Update is called once per frame
    void Update()
    {

    }
	
	
	
    public void ToDelevoper()
    {
        l = 0;//(int)SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("scena", l);
        SceneManager.LoadScene(20);
    }

    public void DeveloperBack()
    {
        l = PlayerPrefs.GetInt("scena");
        SceneManager.LoadScene(l);
    }

	public void ResetProgress()
    {
        progress = 0;
        PlayerPrefs.SetInt("progress", progress);
    }

	
	public void ResetMoney()
    {
        Money = PlayerPrefs.GetInt("money");
        BuyD(Money);
        PlayerPrefs.SetInt("money", Money);
    }

	public void CheatMoney()
    {
        Money = PlayerPrefs.GetInt("money");
        BuyD(-100000);
        PlayerPrefs.SetInt("money", Money);
    }

    private void BuyD(int a)
    {
        if (Money >= a)
        {
            Money = Money - a;
        }
        else { }
    }
	
	public void ResetImp()
    {
        status1 = 0;
        status2 = 0;
        PlayerPrefs.SetInt("status1", status1);
        PlayerPrefs.SetInt("status2", status2);
    }
	
	public void ResetDamage()
    {
        damage = 1;
        PlayerPrefs.SetInt("damage", damage);
    }

    public void ResetAchievements()
    {
        achivment = 0;
        PlayerPrefs.SetInt("achivment", achivment);
    }

}


