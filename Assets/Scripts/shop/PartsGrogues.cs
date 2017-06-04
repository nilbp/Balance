﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartsGrogues: MonoBehaviour {


	public Button BotoGroc;
	public GameObject part;
	public GameObject Prefab;


	void Update(){

		BotoGroc.onClick.AddListener (pulsar);
	}

	void pulsar () 
	{
		part.GetComponent<SpriteRenderer> ().color = new Color (0.784f, 0.784f, 0.255f, 1f); 
		Prefab.GetComponent<SpriteRenderer> ().color = new Color (0.784f, 0.784f, 0.255f, 1f); 


		if (BotoGroc.name == "bottom groc") {
			
			PlayerPrefs.SetInt ("Bottom", 1);
		}
		if (BotoGroc.name == "bigcup groc") {
			
			PlayerPrefs.SetInt ("Bigcup", 1 );
		}
		if (BotoGroc.name == "spike groc") {

			PlayerPrefs.SetInt ("Spike", 1);
		}
		if (BotoGroc.name == "smallcup groc") {
			
			PlayerPrefs.SetInt ("Smallcup", 1);
		}
		if (BotoGroc.name == "body groc") {
			
			PlayerPrefs.SetInt ("Body", 1);
		}

	}




}
