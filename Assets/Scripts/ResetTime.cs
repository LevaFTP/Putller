using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResetTime : MonoBehaviour
{
    public float timeValue=100;
    public Text timeText;
	
    // Update is called once per frame
    void Update()
    {
	if(timeValue > 0)
	{
        	timeValue -= Time.deltaTime;
	}
	else
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

	}

	TimerDisplay(timeValue);

    }

    void TimerDisplay(float TimeDisplay)
    {
	if(TimeDisplay < 0)
	{
		TimeDisplay = 0;
	}

	float minutes = Mathf.FloorToInt(TimeDisplay / 60);
	float seconds = Mathf.FloorToInt(TimeDisplay % 60);

	timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);


    }
}
