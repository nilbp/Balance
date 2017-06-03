using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartsTronjees: MonoBehaviour {

	public Button BotoTronja;
	public GameObject part;



	void click (){

		part.GetComponent<SpriteRenderer> ().color = new Color (0.8901f, 0.5607f, 0.3058f, 1f); 
	
	

		if (BotoTronja.name == "bottom tronja") {
			PlayerPrefs.SetInt ("Bottom", 2);
		}
		if (BotoTronja.name == "bigcup tronja") {
			PlayerPrefs.SetInt ("Bigcup", 2);
		}
		if (BotoTronja.name == "spike tronja") {
			PlayerPrefs.SetInt ("Spike", 2);
		}
		if (BotoTronja.name == "smallcup tronja") {
			PlayerPrefs.SetInt ("Smallcup", 2);
		}
		if (BotoTronja.name == "body tronja") {
			PlayerPrefs.SetInt ("Body", 2);
		}

	}
		
	void Update(){


		Button button1 = BotoTronja.GetComponent<Button> ();
		button1.onClick.AddListener (click);

	}
}
