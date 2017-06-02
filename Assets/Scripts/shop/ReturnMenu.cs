using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReturnMenu : MonoBehaviour {


	public Button Button;

	void Update () {

		Button.onClick.AddListener(Back);
	}

	void Back(){
	
		Application.LoadLevel("MainMenu");
	}

}
