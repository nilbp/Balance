using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartsLiles: MonoBehaviour {


	public Button BotoLila;
	public GameObject part;
	public GameObject Prefab;

	void click(){

		part.GetComponent<SpriteRenderer> ().color = new Color (0.7882f, 0.5176f, 0.8823f, 1f); 
		Prefab.GetComponent<SpriteRenderer> ().color = new Color (0.7882f, 0.5176f, 0.8823f, 1f); 
			
		if (BotoLila.name == "bottom lila") {
			PlayerPrefs.SetInt ("Bottom", 3);
		}
		if (BotoLila.name == "bigcup lila") {
			PlayerPrefs.SetInt ("Bigcup", 3);
		}
		if (BotoLila.name == "spike lila") {
			PlayerPrefs.SetInt ("Spike", 3);
		}
		if (BotoLila.name == "smallcup lila") {
			PlayerPrefs.SetInt ("Smallcup",3);
		}
		if (BotoLila.name == "body lila") {
			PlayerPrefs.SetInt ("Body",3);
		}
	}

	void Update(){

	
		Button button2 = BotoLila.GetComponent<Button> ();
		button2.onClick.AddListener (click);
	}
}
