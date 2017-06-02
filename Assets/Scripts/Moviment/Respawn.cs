using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

	public int prova;
	public GameObject Bola;
	public GameObject empty;
	public Rigidbody2D pilota;
	bool contacto;

	void Start () {
		
	}
	

	void Update () {


	}


	void OnTriggerEnter2D (Collider2D other){

		if (other.tag == "floor" && contacto == false) {
		
			StartCoroutine (Delay ());
			contacto = true;
		}
	
		}

	IEnumerator Delay(){
	
		yield return new WaitForSeconds (1.5f);

		transform.position = new Vector3(8.7f,9.1f,0f);
		contacto = false;
		pilota.velocity = new Vector2 (0f, 0f);
		Bola.transform.rotation = Quaternion.identity;

	}
}
