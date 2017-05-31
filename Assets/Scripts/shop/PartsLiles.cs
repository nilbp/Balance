using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartsLiles: MonoBehaviour {


	public Button BotoLila;
	public GameObject part;

	void click(){

		part.GetComponent<SpriteRenderer> ().color = new Color (0.7882f, 0.5176f, 0.8823f, 1f); 


		GameObject thePlayer = GameObject.Find ("Publiccolors");
		PublicColors lila = thePlayer.GetComponent<PublicColors> ();
	
			
		if (BotoLila.name == "bottom lila") {
			lila.Bottom = 3;
			PlayerPrefs.SetInt ("Bottom", 3);
		}
		if (BotoLila.name == "bigcup lila") {
			lila.Bigcup = 3;
			PlayerPrefs.SetInt ("Bigcup", 3);
		}
		if (BotoLila.name == "spike lila") {
			lila.Spike = 3;
			PlayerPrefs.SetInt ("Spike", 3);
		}
		if (BotoLila.name == "smallcup lila") {
			lila.Smallcup = 3;
			PlayerPrefs.SetInt ("Smallcup",3);
		}
		if (BotoLila.name == "body lila") {
			lila.Body = 3;
			PlayerPrefs.SetInt ("Body",3);
		}
	}

	void Update(){

	
		Button button2 = BotoLila.GetComponent<Button> ();
		button2.onClick.AddListener (click);
	}
}
