using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreLevels : MonoBehaviour {

	public Text button;

	void Start () {
		
	}
	

	void Update () {

		if (button.name == "Level1") {
			button.text = "High Score  " + PlayerPrefs.GetInt ("totalscore1");
		}
		if (button.name == "Level2") {
			button.text = "High Score  " + PlayerPrefs.GetInt ("totalscore2");
		}
		if (button.name == "Level3") {
			button.text = "High Score  " + PlayerPrefs.GetInt ("totalscore3");
		}
		if (button.name == "Level4") {
			button.text = "High Score  " +PlayerPrefs.GetInt ("totalscore4");
		}
		if (button.name == "Level5") {
			button.text = "High Score  " +PlayerPrefs.GetInt ("totalscore5");
		}
		if (button.name == "Level6") {
			button.text = "High Score  " +PlayerPrefs.GetInt ("totalscore6");
		}
		if (button.name == "Level7") {
			button.text = "High Score  " +PlayerPrefs.GetInt ("totalscore7");
		}
		if (button.name == "Level8") {
			button.text = "High Score  " +PlayerPrefs.GetInt ("totalscore8");
		}

	}
}
