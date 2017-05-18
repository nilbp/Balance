using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parts: MonoBehaviour {



	public void parts(string hola)
	{
		GetComponent<SpriteRenderer> ().color = new Color (200f, 200f, 100f, 255f);
	}
}
