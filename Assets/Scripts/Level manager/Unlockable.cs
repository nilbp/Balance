using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlockable : MonoBehaviour {

	int score = 200;

	void Start () {

		PlayerPrefs.SetInt("Level2", 1);
		PlayerPrefs.SetInt("Level1_score", score);
		StartCoroutine (Time ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Time()
	{
	
		yield return new WaitForSeconds (2f);
		Application.LoadLevel (5);
	}
}
