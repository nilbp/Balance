using UnityEngine;
using System.Collections;

public class Torpe : MonoBehaviour {

	public float speed = 5.0f;
	public Rigidbody2D rb2D;

	void FixedUpdate()
	{
		rb2D.MoveRotation(rb2D.rotation + speed * Time.fixedDeltaTime);
	}
}
