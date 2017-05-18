using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menú : MonoBehaviour {

	public GameObject loadingimage;

	public void LoadScene(int level) 
	{
		loadingimage.SetActive (true);
		Application.LoadLevel (level);
	}

}
