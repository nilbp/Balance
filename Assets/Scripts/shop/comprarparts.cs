using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class comprarparts : MonoBehaviour {


	public int money=50;
	public int check;
	public Button button;
	bool cobrar;

	void Start(){
		cobrar = true;
		Levellocked ();
	
	}
	void Update () {



		if (button.name == "bigcup groc" && money >= 20 && cobrar) {
			Levelunlocked ();
			button.GetComponent<Button> ().onClick.AddListener (restarmoney);

		}
	
		else if (button.name == "smallcup groc" && money>=30) {
			Levelunlocked();
		} 
	
		else if (button.name == "bottom groc" && money>=40) {
			Levelunlocked();
		} 
	
		else if (button.name == "spike groc" && money>=50) {
			Levelunlocked();

		} 

		else if (button.name == "body groc" && money>=60) {
			Levelunlocked();
		} 

	//preu parts tronjes

		else if (button.name == "bigcup tronja" && money>=80) {
			Levelunlocked();
		} 

		else if (button.name == "smallcup tronja" && money>=90) {
			Levelunlocked();
		} 
			
		else if (button.name == "bottom tronja" && money>=100) {
			Levelunlocked();
		}

		else if (button.name == "spike tronja" && money>=110) {
			Levelunlocked();
		} 
	
		else if (button.name == "body tronja" && money>=120) {
			Levelunlocked();
		} 

	//preu parts liles

		else if (button.name == "bigcup lila" && money>=140) {
			Levelunlocked();
		} 


		else if (button.name == "smallcup lila" && money>=160) {
			Levelunlocked();
		} 

		else if (button.name == "bottom lila" && money>=180) {
			Levelunlocked ();
		} 

		else if (button.name == "spike lila" && money>=190) {
			Levelunlocked ();
		} 

		else if (button.name == "body lila" && money>=200) {
			Levelunlocked ();
		} 
	}


void Levellocked()
{
		button.GetComponent<Button> ().interactable = false;
}
void Levelunlocked ()
{
		button.GetComponent<Button> ().interactable = true;
}
	void restarmoney (){
		money -= 20;

	}
		
}