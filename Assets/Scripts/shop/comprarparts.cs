using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class comprarparts : MonoBehaviour {

	/*public class level{
		public int unlocked;
		public bool isinsteractable;*/
	public int money;
	//public Image Image;
	public Button bigcupgroc;
	public Button bigcuptronja;
	public Button bigcuplila;

	void Start () {
		
		money = PlayerPrefs.GetInt ("money");

		Button btn = bigcupgroc.GetComponent<Button>();
		btn.onClick.AddListener(grogues);

		Button bttn = bigcuptronja.GetComponent<Button>();
		bttn.onClick.AddListener(tronjes);

		Button bbtn = bigcuplila.GetComponent<Button>();
		bbtn.onClick.AddListener(liles);

	}
	// Update is called once per frame
	void Update () {

	}
	void grogues(){

		if (money>=20) {
			Levelunlocked ();
		} else {
			Levellocked ();
		}
	}
	void tronjes(){

		if (money>=30) {
			Levelunlocked1();
		} else {
			Levellocked1 ();
		}
	}
	void liles(){

		if (money>=60) {
			Levelunlocked2 ();
		} else {
			Levellocked2 ();
		}
	}


void Levellocked()
{
		bigcupgroc.GetComponent<Button> ().interactable = false;
	//Image.enabled = true;
}
void Levelunlocked ()
{
		bigcupgroc.GetComponent<Button> ().interactable = true;
	//Image.enabled = false;
}

	void Levellocked1()
	{
		bigcuptronja.GetComponent<Button> ().interactable = false;
		//Image.enabled = true;
	}
	void Levelunlocked1 ()
	{
		bigcuptronja.GetComponent<Button> ().interactable = true;
		//Image.enabled = false;
	}

	void Levellocked2()
	{
		bigcuplila.GetComponent<Button> ().interactable = false;
		//Image.enabled = true;
	}
	void Levelunlocked2 ()
	{
		bigcuplila.GetComponent<Button> ().interactable = true;
		//Image.enabled = false;
	}
}