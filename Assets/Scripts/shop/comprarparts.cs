using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class comprarparts : MonoBehaviour {



	public int check;

	public int money=10000;

	public Button button;
	public Text ButtonText;

	bool BCG;
	bool SCG;
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



		money = PlayerPrefs.GetInt ("COINS");

		BCG = true;
		SCG = true;
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


			PlayerPrefs.SetInt ("BCG", 0);
			PlayerPrefs.SetInt ("SCG", 0);
			PlayerPrefs.SetInt ("BMG", 0);
			PlayerPrefs.SetInt ("SPG", 0);
			PlayerPrefs.SetInt ("BDG", 0);

			PlayerPrefs.SetInt ("BCT", 0);
			PlayerPrefs.SetInt ("SCT", 0);
			PlayerPrefs.SetInt ("BMT", 0);
			PlayerPrefs.SetInt ("SPT", 0);
			PlayerPrefs.SetInt ("BDT", 0);

			PlayerPrefs.SetInt ("BCL", 0);
			PlayerPrefs.SetInt ("SCL", 0);
			PlayerPrefs.SetInt ("BML", 0);
			PlayerPrefs.SetInt ("SPL", 0);
			PlayerPrefs.SetInt ("BDL", 0);
		
	}


	void Update () {

		money = PlayerPrefs.GetInt ("COINS");


		if (button.name == "bigcup groc") {
			
			if (money >= 20 && PlayerPrefs.GetInt ("BCG") == 0) {
			
				button.onClick.AddListener (() => Cobrar (1));
				Levelunlocked ();
			} else if (PlayerPrefs.GetInt ("BCG") == 1) {
				Levelunlocked ();
				ButtonText.text = "OWNED";

			} else {
				Levellocked ();
			}
		}
		 else if (button.name == "smallcup groc") {
			if (money >= 30 && PlayerPrefs.GetInt ("SCG") == 0) {

				button.onClick.AddListener (() => Cobrar (2));
				Levelunlocked ();
			} else if (PlayerPrefs.GetInt ("SCG") == 1) {
				Levelunlocked ();
				ButtonText.text = "OWNED";
			} else {
				Levellocked ();
			}
		}

				
		else if (button.name == "bottom groc") {
			if (money >= 40 && PlayerPrefs.GetInt ("BMG") == 0) {

				button.onClick.AddListener (() => Cobrar (3));
				Levelunlocked ();
			} else if (PlayerPrefs.GetInt ("BMG") == 1) {
				Levelunlocked ();
				ButtonText.text = "OWNED";
			} else {
				Levellocked ();
			}
		}


		else if (button.name == "spike groc") {
			if (money >= 50 && PlayerPrefs.GetInt ("SPG") == 0) {

				button.onClick.AddListener (() => Cobrar (4));
				Levelunlocked ();
			} 

			else if (PlayerPrefs.GetInt ("SPG") == 1) {
				Levelunlocked ();
				ButtonText.text = "OWNED";
			} else {
				Levellocked ();
			}
		}

		 
		else if (button.name == "body groc") {
			if (money >= 70 && PlayerPrefs.GetInt ("BDG") == 0) {

				button.onClick.AddListener (() => Cobrar (5));
				Levelunlocked ();
			} else if (PlayerPrefs.GetInt ("BDG") == 1) {
				Levelunlocked ();
				ButtonText.text = "OWNED";
			}
		
			else {
			Levellocked ();
			}
		}
	


	//preu parts tronjes

		else if (button.name == "bigcup tronja") {
			

			if (money >= 200 && PlayerPrefs.GetInt ("BCT") == 0) {

				button.onClick.AddListener (() => Cobrar (11));
				Levelunlocked ();
			} 

			else if (PlayerPrefs.GetInt ("BCT") == 1) {
				Levelunlocked ();
				ButtonText.text = "OWNED";
			}
			else {
				Levellocked ();
			}
		}

		else if (button.name == "smallcup tronja") {
		 
			if (money >= 290 && PlayerPrefs.GetInt ("SCT") == 0) {

				button.onClick.AddListener (() => Cobrar (12));
				Levelunlocked ();
			}

			else if (PlayerPrefs.GetInt ("SCT") == 1) {
				Levelunlocked ();
				ButtonText.text = "OWNED";
			}
		
			else {
			Levellocked ();
			}
		}


			
		else if (button.name == "bottom tronja") {

			if (money >= 360 && PlayerPrefs.GetInt("BMT")==0) {

				button.onClick.AddListener (() => Cobrar(13));
				Levelunlocked ();
			}
			else if (PlayerPrefs.GetInt("BMT")==1){
				Levelunlocked ();
				ButtonText.text = "OWNED";
			}
		
			else {
			Levellocked ();
			}
		}

		else if (button.name == "spike tronja") {
	
			if (money >= 500 && PlayerPrefs.GetInt("SPT")==0) {

				button.onClick.AddListener (() => Cobrar(14));
				Levelunlocked ();
			}

			else if (PlayerPrefs.GetInt("SPT")==1){
				Levelunlocked ();
				ButtonText.text = "OWNED";
			}
		
			else {
			Levellocked ();
			}
		}
	
		else if (button.name == "body tronja") {
			
			if (money >= 600 && PlayerPrefs.GetInt("BDT")==0) {

				button.onClick.AddListener (() => Cobrar(15));
				Levelunlocked ();
			}

			else if (PlayerPrefs.GetInt("BDT")==1){
				Levelunlocked ();
				ButtonText.text = "OWNED";
			}
		
			else {
			Levellocked ();
			}
		}


	//preu parts liles

		else if (button.name == "bigcup lila") {

			if (money >= 740 && PlayerPrefs.GetInt("BCL")==0) {

				button.onClick.AddListener (() => Cobrar(21));
				Levelunlocked ();
			}

			else if (PlayerPrefs.GetInt("BCL")==1){
				Levelunlocked ();
				ButtonText.text = "OWNED";
			}
		
			else {
			Levellocked ();
			}
		}



		else if (button.name == "smallcup lila") {
			
			if (money >= 870 && PlayerPrefs.GetInt("SCL")==0) {

				button.onClick.AddListener (() => Cobrar(22));
				Levelunlocked ();
			}

			else if (PlayerPrefs.GetInt("SCL")==1){
				Levelunlocked ();
				ButtonText.text = "OWNED";
			}
		
			else {
			Levellocked ();
			}
		}


		else if (button.name == "bottom lila") {
			
			if (money >= 1000 && PlayerPrefs.GetInt("BML")==0) {

				button.onClick.AddListener (() => Cobrar(23));
				Levelunlocked ();
			}

			else if (PlayerPrefs.GetInt("BML")==1){
				Levelunlocked ();
				ButtonText.text = "OWNED";
			}
		
			else {
			Levellocked ();
			}
		}


		else if (button.name == "spike lila") {
			
			if (money >= 1300 && PlayerPrefs.GetInt("SPL")==0) {

				button.onClick.AddListener (() => Cobrar(24));
				Levelunlocked ();

			}

			else if (PlayerPrefs.GetInt("SPL")==1){
				Levelunlocked ();
				ButtonText.text = "OWNED";
			}
		
			else {
			Levellocked ();
			}
		}


		else if (button.name == "body lila") {

			if (money >= 2000 && PlayerPrefs.GetInt("BDL")==0) {

				button.onClick.AddListener (() => Cobrar(25));
				Levelunlocked ();
			}

			else if (PlayerPrefs.GetInt("BDL")==1){
				Levelunlocked ();
				ButtonText.text = "OWNED";
			}
		
			else {
			Levellocked ();
			}
		}
	}

	void Cobrar(int value){

		money = PlayerPrefs.GetInt ("COINS");

		if (value == 1 && BCG) {
			money = money - 20;
			BCG = false;
			PlayerPrefs.SetInt ("COINS", money);
			PlayerPrefs.SetInt ("BCG", 1);

		}

		else if (value == 2 && SCG) {
			money = money - 30;
			SCG = false;
			PlayerPrefs.SetInt ("COINS", money);
			PlayerPrefs.SetInt ("SCG", 1);

		}

		else if (value == 3 && BMG) {
			money = money - 40;
			BMG = false;
			PlayerPrefs.SetInt ("COINS", money);
			PlayerPrefs.SetInt ("BMG", 1);

		}
		else if (value == 4 && SPG) {
			money = money - 50;
			SPG = false;
			PlayerPrefs.SetInt ("COINS", money);
			PlayerPrefs.SetInt ("SPG", 1);

		}

		else if (value == 5 && BDG) {
			money = money - 70;
			BDG = false;
			PlayerPrefs.SetInt ("COINS", money);
			PlayerPrefs.SetInt ("BDG", 1);
		
		}

		else if (value == 11 && BCT) {
			money = money - 200;
			BCT = false;
			PlayerPrefs.SetInt ("COINS", money);
			PlayerPrefs.SetInt ("BCT", 1);
		}

		else if (value == 12 && SCT) {
			money = money - 290;
			SCT = false;
			PlayerPrefs.SetInt ("COINS", money);
			PlayerPrefs.SetInt ("SCT", 1);
		}

		else if (value == 13 && BMT) {
			money = money - 360;
			BMT = false;
			PlayerPrefs.SetInt ("COINS", money);
			PlayerPrefs.SetInt ("BMT", 1);
		}

		else if (value == 14 && SPT) {
			money = money - 500;
			SPT = false;
			PlayerPrefs.SetInt ("COINS", money);
			PlayerPrefs.SetInt ("SPT", 1);
		}

		else if (value == 15 && BDT) {
			money = money - 600;
			BDT = false;
			PlayerPrefs.SetInt ("COINS", money);
			PlayerPrefs.SetInt ("BDT", 1);
		}

		else if (value == 21 && BCL) {
			money = money - 740;
			BCL = false;
			PlayerPrefs.SetInt ("COINS", money);
			PlayerPrefs.SetInt ("BCL", 1);
		}

		else if (value == 22 && SCL) {
			money = money - 870;
			SCL = false;
			PlayerPrefs.SetInt ("COINS", money);
			PlayerPrefs.SetInt ("SCL", 1);
		}

		else if (value == 23 && BML) {
			money = money - 1000;
			BML = false;
			PlayerPrefs.SetInt ("COINS", money);
			PlayerPrefs.SetInt ("BML", 1);
		}

		else if (value == 24 && SPL) {
			money = money - 1300;
			SPL= false;
			PlayerPrefs.SetInt ("COINS", money);
			PlayerPrefs.SetInt ("SPL", 1);
		}

		else if (value == 25 && BDL) {
			money = money - 2000;
			BDL = false;
			PlayerPrefs.SetInt ("COINS", money);
			PlayerPrefs.SetInt ("BDL", 1);
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

		
}