using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class comprarparts : MonoBehaviour {


<<<<<<< HEAD
	public int money=50;
	public int check;
=======
	public int money;
>>>>>>> master
	public Button button;
	bool cobrar;

	public bool BCG;
	public bool SCG;
	bool BMG;
	bool SPG;
	bool BDG;

	bool BCT;
	bool SCT;
	bool BMT;
	bool SPT;
	bool BDT;

	bool BCL;
	bool SCL;
	bool BML;
	bool SPL;
	bool BDL;


	void Start(){
		cobrar = true;
		Levellocked ();
		money = PlayerPrefs.GetInt ("COINS");

		BMG=true;
		SPG=true;
		BDG=true;

		BCT=true;
		SCT=true;
		BMT=true;
		SPT=true;
		BDT=true;

		BCL=true;
		SCL=true;
		BML=true;
		SPL=true;
		BDL=true;
	
	}
	void Update () {



		if (button.name == "bigcup groc" && money >= 20 && cobrar) {
			Levelunlocked ();
<<<<<<< HEAD
			button.GetComponent<Button> ().onClick.AddListener (restarmoney);

=======

			if (BCG) {
				button.onClick.AddListener (() => Cobrar(20));
				BCG = false;

			}
>>>>>>> master
		}
	
		else if (button.name == "smallcup groc" && money>=30) {
			Levelunlocked();
			if (SCG) {
				button.onClick.AddListener (() => Cobrar (30));
				SCG = false;

			}
		} 
	
		else if (button.name == "bottom groc" && money>=40) {
			Levelunlocked();
			if (BMG) {
				button.onClick.AddListener (() => Cobrar (40));
				BMG = false;

			}
		} 
	
		else if (button.name == "spike groc" && money>=50) {
			Levelunlocked();
			if (SPG) {
				button.onClick.AddListener (() => Cobrar (50));
				SPG = false;
			}
		} 

		else if (button.name == "body groc" && money>=60) {
			Levelunlocked();
			if (BDG) {
				button.onClick.AddListener (() => Cobrar (60));
				BDG = false;
			}
		} 

	//preu parts tronjes

		else if (button.name == "bigcup tronja" && money>=80) {
			Levelunlocked();
			if (BCT) {
				button.onClick.AddListener (() => Cobrar (80));
				BCT = false;
			}
		} 

		else if (button.name == "smallcup tronja" && money>=90) {
			Levelunlocked();
			if (SCT) {
				button.onClick.AddListener (() => Cobrar (90));
				SCT = false;
			}
		} 
			
		else if (button.name == "bottom tronja" && money>=100) {
			Levelunlocked();
			if (BMT) {
				button.onClick.AddListener (() => Cobrar (100));
				BMT = false;
			}
		}

		else if (button.name == "spike tronja" && money>=110) {
			Levelunlocked();
			if (SPT) {
				button.onClick.AddListener (() => Cobrar (110));
				SPT = false;
			}
		} 
	
		else if (button.name == "body tronja" && money>=120) {
			Levelunlocked();
			if (BDT) {
				button.onClick.AddListener (() => Cobrar (120));
				BDT = false;
			}
		} 

	//preu parts liles

		else if (button.name == "bigcup lila" && money>=140) {
			Levelunlocked();
			if (BCL) {
				button.onClick.AddListener (() => Cobrar (140));
				BCL = false;
			}
		} 


		else if (button.name == "smallcup lila" && money>=160) {
			Levelunlocked();
			if (SCL) {
				button.onClick.AddListener (() => Cobrar (160));
				SCL = false;
			}
		} 

		else if (button.name == "bottom lila" && money>=180) {
			Levelunlocked ();
			if (BML) {
				button.onClick.AddListener (() => Cobrar (180));
				BML = false;
			}
		} 

		else if (button.name == "spike lila" && money>=190) {
			Levelunlocked ();
			if (SPL) {
				button.onClick.AddListener (() => Cobrar (190));
				SPL = false;
			}
		} 

		else if (button.name == "body lila" && money>=200) {
			Levelunlocked ();
			if (BDL) {
				button.onClick.AddListener (() => Cobrar (200));
				BDL = false;
			}
		} 


	}

	void Cobrar(int value){

		money = PlayerPrefs.GetInt ("COINS");
		money = money - value;
		PlayerPrefs.SetInt ("COINS", money);
	
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