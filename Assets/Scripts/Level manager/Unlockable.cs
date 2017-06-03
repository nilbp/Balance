using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlockable : MonoBehaviour {

	int score = 200;
	public int Highscore=200;
	public int check;

	void Start () {

		//PlayerPrefs.SetInt ("Level2", 0);


	}

	void Update () {
	

		if (Highscore == 200) {
			PlayerPrefs.SetInt ("Level2", 2);
			check = 2000;
		}

		PlayerPrefs.SetInt("Level1_score", score);


	}
}


