using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour {

	public static float timeSinceLevelLoad=60;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(timeSinceLevelLoad==0){
			GameOver ();
	}
}

	void GameOver(){
		Application.LoadLevel ("FinishGame");
	}
}
