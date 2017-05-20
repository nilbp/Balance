using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangePrefab : MonoBehaviour {


	public Button YourButton;
	public GameObject partoriginal;
	public GameObject partcanviada;

	void canvikendama () {
		GameObject partoriginal = (GameObject) Instantiate(partcanviada, transform.position, transform.rotation);
		DestroyObject (partoriginal);
	}


	public void on_click () {
		Button button = YourButton.GetComponent <Button> ();
		button.onClick.AddListener (canvikendama);
	}
}