using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetColors : MonoBehaviour {

	public Button Button;
	public GameObject PART1;
	public GameObject PART2;
	public GameObject PART3;
	public GameObject PART4;
	public GameObject PART5;

	public int check;
	public int check1;
	public int check2;
	public int check3;
	public int check4;

	void Update () {

		Button.onClick.AddListener (reset);
		check = PlayerPrefs.GetInt ("Bigcup");
		check1 = PlayerPrefs.GetInt ("Smallcup");
		check2 = PlayerPrefs.GetInt ("Spike");
		check3 = PlayerPrefs.GetInt ("Bottom");
		check4 = PlayerPrefs.GetInt ("Body");

	}

	void reset(){

		PART1.GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, 1f);
		PART2.GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, 1f);
		PART3.GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, 1f);
		PART4.GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, 1f);
		PART5.GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, 1f);

		PlayerPrefs.SetInt ("Bigcup", 0);
		PlayerPrefs.SetInt ("Smallcup", 0);
		PlayerPrefs.SetInt ("Bottom", 0);
		PlayerPrefs.SetInt ("Spike", 0);
		PlayerPrefs.SetInt ("Body", 0);


	}
}
