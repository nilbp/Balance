using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour {

	public GameObject panel;
	float timeLeft=6;

	void Start () {
		Time.timeScale = 1;
	}
	

	void Update () {
		Debug.Log (timeLeft);
		timeLeft -= Time.deltaTime;
		if ( timeLeft <= 0 )
		{
			Time.timeScale = 0;
			panel.SetActive (true);
		}
	}
}
