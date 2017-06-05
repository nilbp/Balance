using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

	public GameObject panel;
<<<<<<< Updated upstream
	public Text Timer;

	float timeLeft=50;
=======
	float timeLeft=60;
>>>>>>> Stashed changes

	void Start () {
		Time.timeScale = 1;
	}
	

	void Update () {
		Debug.Log (timeLeft);
		timeLeft -= Time.deltaTime;
		Timer.text = "Time Left "+ (int)timeLeft;
		if ( timeLeft <= 0 )
		{
			Time.timeScale = 0;
			panel.SetActive (true);
		}

	}
}
