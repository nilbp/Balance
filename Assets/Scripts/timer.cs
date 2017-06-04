using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour {


	float timeLeft=60;

	void Start () {
		

	}

	// Update is called once per frame
	void Update()
	{
		Debug.Log (timeLeft);
		timeLeft -= Time.deltaTime;
		if ( timeLeft < 0 )
		{
			GameOver();
		}
	}
	void GameOver(){
		
	}
}
