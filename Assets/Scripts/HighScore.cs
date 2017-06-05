using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

	public Text Highscore;
	public Text Coins;
	public int score;
	

	void Update () {

		score = PlayerPrefs.GetInt ("totalscore");
		Highscore.text = " " + score;
		Coins.text = " " + score / 10;
		PlayerPrefs.SetInt ("COINS", score / 10 + PlayerPrefs.GetInt ("COINS"));
	}
}
