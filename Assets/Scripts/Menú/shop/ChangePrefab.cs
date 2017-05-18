using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePrefab : MonoBehaviour {


	public GameObject kendama2;

	void canvikendama () {
		GameObject kendamawood = (GameObject) Instantiate(kendama2, transform.position, transform.rotation);

	}

	// Calls the fire method when holding down ctrl or mouse
	void Update () {
		if (Input.GetKey(KeyCode.H))
		{
			canvikendama();
		}
	}
}