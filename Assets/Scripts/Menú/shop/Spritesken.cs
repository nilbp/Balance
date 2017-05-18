using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spritesken : MonoBehaviour {

	public Sprite[] spriteList;

	void Start()
	{
		GetComponent<SpriteRenderer> ().sprite = spriteList [0];
	}
}
