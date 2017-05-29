using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    
	public float temps = 60f;
    public Text timer;
    void Update()
    {

       temps -= Time.deltaTime;
       
		timer.text = "Time left " + temps;

        if (temps < 0)
        {
            TimeEnded();
            
        }
    }

    void TimeEnded() {

        timer.text = " FINISH ";
        Application.Quit();

    }
}
