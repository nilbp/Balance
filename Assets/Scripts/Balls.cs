using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Balls : MonoBehaviour {

	public Sprite Bola;
	public Button Button;
	public GameObject bola;
	public GameObject BolaPrefab;

	void Update () {

		Button.onClick.AddListener (ChangeBalls);
	}



	void ChangeBalls(){


	
		if (Bola.name == "Bola1_0") {
		
			bola.GetComponent<SpriteRenderer> ().sprite = Bola;
			BolaPrefab.GetComponent<SpriteRenderer> ().sprite = Bola;
			PlayerPrefs.SetInt ("Bola", 1);
		}
		if (Bola.name == "Bola2_0") {
			
			bola.GetComponent<SpriteRenderer> ().sprite = Bola;
			BolaPrefab.GetComponent<SpriteRenderer> ().sprite = Bola;
			PlayerPrefs.SetInt ("Bola", 2);
		}
		if (Bola.name == "Bola3_0") {

			bola.GetComponent<SpriteRenderer> ().sprite = Bola;
			BolaPrefab.GetComponent<SpriteRenderer> ().sprite = Bola;
			PlayerPrefs.SetInt ("Bola", 3);
		}
		if (Bola.name == "Bola4_0") {

			bola.GetComponent<SpriteRenderer> ().sprite = Bola;
			BolaPrefab.GetComponent<SpriteRenderer> ().sprite = Bola;
			PlayerPrefs.SetInt ("Bola", 4);
		}
		if (Bola.name == "Bola5_0") {

			bola.GetComponent<SpriteRenderer> ().sprite = Bola;
			bola.GetComponent<SpriteRenderer> ().sprite = Bola;
			PlayerPrefs.SetInt ("Bola",5);
		}
		if (Bola.name == "Bola6_0") {

			bola.GetComponent<SpriteRenderer> ().sprite = Bola;
			BolaPrefab.GetComponent<SpriteRenderer> ().sprite = Bola;
			PlayerPrefs.SetInt ("Bola", 6);
		}
	}
}
