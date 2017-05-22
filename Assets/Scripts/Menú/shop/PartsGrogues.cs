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

	}

	void Start(){

		Button button = BotoGroc.GetComponent<Button> ();
		button.onClick.AddListener (click);

	}
}
