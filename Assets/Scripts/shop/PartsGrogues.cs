using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartsGrogues: MonoBehaviour {

	public static int colors;
	public Button BotoGroc;
	public GameObject part;

	void click () 
	{
		part.GetComponent<SpriteRenderer> ().color = new Color (0.78431f, 0.78431f, 0.255f, 1f); 

		GameObject thePlayer = GameObject.Find ("Publiccolors");
		PublicColors groc = thePlayer.GetComponent<PublicColors> ();


		if (BotoGroc.name == "bottom groc") {
			groc.Bottom = 1;
			PlayerPrefs.SetInt ("Bottom", 1);
		}
		if (BotoGroc.name == "bigcup groc") {
			groc.Bigcup = 1;
			PlayerPrefs.SetInt ("Bigcup", 1 );
		}
		if (BotoGroc.name == "spike groc") {
			groc.Spike = 1;
			PlayerPrefs.SetInt ("Spike", 1);
		}
		if (BotoGroc.name == "smallcup groc") {
			groc.Smallcup = 1;
			PlayerPrefs.SetInt ("Smallcup", 1);
		}
		if (BotoGroc.name == "body groc") {
			groc.Body = 1;
			PlayerPrefs.SetInt ("Body", 1);
		}

	}



	void Update(){


		Button button = BotoGroc.GetComponent<Button> ();
		button.onClick.AddListener (click);

	}
}
