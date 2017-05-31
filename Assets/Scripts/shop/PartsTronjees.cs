using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartsTronjees: MonoBehaviour {

	public Button BotoTronja;
	public GameObject part;



	void click (){

		part.GetComponent<SpriteRenderer> ().color = new Color (0.8901f, 0.5607f, 0.3058f, 1f); 
	
		GameObject thePlayer = GameObject.Find ("Publiccolors");
		PublicColors tronja = thePlayer.GetComponent<PublicColors> ();

		if (BotoTronja.name == "bottom tronja") {
			tronja.Bottom = 2;
			PlayerPrefs.SetInt ("Bottom", 2);
		}
		if (BotoTronja.name == "bigcup tronja") {
			tronja.Bigcup = 2;
			PlayerPrefs.SetInt ("Bigcup", 2);
		}
		if (BotoTronja.name == "spike tronja") {
			tronja.Spike = 2;
			PlayerPrefs.SetInt ("Spike", 2);
		}
		if (BotoTronja.name == "smallcup tronja") {
			tronja.Smallcup = 2;
			PlayerPrefs.SetInt ("Smallcup", 2);
		}
		if (BotoTronja.name == "body tronja") {
			tronja.Body = 2;
			PlayerPrefs.SetInt ("Body", 2);
		}

	}
		
	void Start(){


		Button button1 = BotoTronja.GetComponent<Button> ();
		button1.onClick.AddListener (click);

	}
}
