using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlockable : MonoBehaviour {


	public int Highscore=200;
	public int check;

	void Start () {



	}

	void Update () {
	

		if (PlayerPrefs.GetInt("totalscore1")> 100) {
			PlayerPrefs.SetInt ("Level2", 1);
			check = 200;

		}
		if (PlayerPrefs.GetInt("totalscore2")> 500) {
			PlayerPrefs.SetInt ("Level3", 1);

		}
		if (PlayerPrefs.GetInt("totalscore3")> 1000) {
			PlayerPrefs.SetInt ("Level4", 1);

		}
		if (PlayerPrefs.GetInt("totalscore4")> 1500) {
			PlayerPrefs.SetInt ("Level5", 1);

		}
		if (PlayerPrefs.GetInt("totalscore5")> 2000) {
			PlayerPrefs.SetInt ("Level6", 1);

		}
		if (PlayerPrefs.GetInt("totalscore6")> 3000) {
			PlayerPrefs.SetInt ("Level7", 1);

		}
		if (PlayerPrefs.GetInt("totalscore7")> 4000) {
			PlayerPrefs.SetInt ("Level8", 1);

		}
	}

}
