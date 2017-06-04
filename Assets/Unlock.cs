using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlock : MonoBehaviour {

	public Button button;
	public int level1;
	public int level2;
	public int level3;


	void Start(){

		if (button.name != "Level1") {
			
			button.GetComponent<Button> ().interactable = false;	
		}

	} 

	void Update () {


		if (button.name == "Level1") {
			
			button.GetComponent<Button> ().onClick.AddListener (() => Application.LoadLevel ("Level1"));
		} else if (button.name == "Level2" && PlayerPrefs.GetInt ("totalscore1") > 200) {
			button.GetComponent<Button> ().interactable = true;	
			button.GetComponent<Button> ().onClick.AddListener (() => Application.LoadLevel ("Level2"));
		} else if (button.name == "Level3" && PlayerPrefs.GetInt ("totalscore2") > 500) {
			button.GetComponent<Button> ().interactable = true;	
			button.GetComponent<Button> ().onClick.AddListener (() => Application.LoadLevel ("Level3"));		
		} else if (button.name == "Level4" && PlayerPrefs.GetInt ("totalscore3") > 1000) {
			button.GetComponent<Button> ().interactable = true;	
			button.GetComponent<Button> ().onClick.AddListener (() => Application.LoadLevel ("Level4"));
		} else if (button.name == "Level5" && PlayerPrefs.GetInt ("totalscore4") > 1900) {
			button.GetComponent<Button> ().interactable = true;	
			button.GetComponent<Button> ().onClick.AddListener (() => Application.LoadLevel ("Level5"));
		} else if (button.name == "Level6" && PlayerPrefs.GetInt ("totalscore5") > 3000) {
			button.GetComponent<Button> ().interactable = true;	
			button.GetComponent<Button> ().onClick.AddListener (() => Application.LoadLevel ("Level6"));
		} else if (button.name == "Level7" && PlayerPrefs.GetInt ("totalscore6") > 4500) {
			button.GetComponent<Button> ().interactable = true;	
			button.GetComponent<Button> ().onClick.AddListener (() => Application.LoadLevel ("Level7"));
		} else if (button.name == "Level8" && PlayerPrefs.GetInt ("totalscore7") > 6000) {
			button.GetComponent<Button> ().interactable = true;	
			button.GetComponent<Button> ().onClick.AddListener (() => Application.LoadLevel ("Level8"));
		} 

	
	
	}
}
