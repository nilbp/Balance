using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartsLiles: MonoBehaviour {


	public Button BotoLila;
	public GameObject part;

	void click(){


		part.GetComponent<SpriteRenderer> ().color = new Color (0.7882f, 0.5176f, 0.8823f, 1f); 
	}

	void Start(){

	
		Button button2 = BotoLila.GetComponent<Button> ();
		button2.onClick.AddListener (click);
	}
}
