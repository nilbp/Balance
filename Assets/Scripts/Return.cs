using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Return : MonoBehaviour {


	void Start () {
		
	}
	

	void Update () {

		if (Input.GetKey (KeyCode.Q)) 
		{
			Application.LoadLevel("Nivells");
		
		}
		
	}
}
