using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartsTronjees: MonoBehaviour {

	public Button BotoTronja;
	public GameObject part;



	void click (){

		part.GetComponent<SpriteRenderer> ().color = new Color (0.8901f, 0.5607f, 0.3058f, 1f); 
	
	}
		
	void Start(){


		Button button1 = BotoTronja.GetComponent<Button> ();
		button1.onClick.AddListener (click);

	}
}
