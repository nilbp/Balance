using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicacolision : MonoBehaviour {

	public AudioClip sonido=null;
	float volumen=5.0f;
	protected Transform Posicion = null;

	void Start () {
		Posicion = transform;
	}
	
	public void OnCollisionEnter2D(Collision2D coll){

		if (sonido) AudioSource.PlayClipAtPoint (sonido, Posicion.position, volumen);
		Debug.Log ("ajefng");
	}
}
