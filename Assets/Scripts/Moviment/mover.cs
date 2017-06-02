using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class mover : MonoBehaviour{

	public Vector3 gameObjectSreenPoint;
	public Vector3 mousePreviousLocation;
	public Vector3 mouseCurLocation;

	public Vector3 force;
	public Vector3 objectCurrentPosition;
	public Vector3 objectTargetPosition;
	public float topSpeed = 100;
	public Rigidbody2D rigid;
	public float speed=10;

	void OnMouseDown()
	{
		//This grabs the position of the object in the world and turns it into the position on the screen
		gameObjectSreenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		//Sets the mouse pointers vector3
		mousePreviousLocation = new Vector3(Input.mousePosition.x, Input.mousePosition.y, gameObjectSreenPoint.z);
	}

	void OnMouseDrag()
	{
		mouseCurLocation = new Vector3(Input.mousePosition.x, Input.mousePosition.y, gameObjectSreenPoint.z);
		force = mouseCurLocation - mousePreviousLocation;//Changes the force to be applied
		mousePreviousLocation = mouseCurLocation;


	}

	
	public void OnMouseUp()
	{
		
		force = new Vector2 (0, 0);
}

	public void FixedUpdate()
	{
		rigid.velocity = force * 1;
	}

}