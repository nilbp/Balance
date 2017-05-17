using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{

    Vector3 dist;
	public Rigidbody2D rig;
    float posX;
    float posY;
	Vector2 sqr;

	void fixedupdate()
	{
		sqr=new Vector2( Input.mousePosition.x-posX, Input.mousePosition.y-posY );
		rig.AddForce (sqr);

	}
	void OnMouseDown()
    {
        dist = Camera.main.WorldToScreenPoint(transform.position);
        posX = Input.mousePosition.x - dist.x;
        posY = Input.mousePosition.y - dist.y;
    }

    void OnMouseDrag()
    {
		Vector2 sqr=new Vector2( Input.mousePosition.x-posX, Input.mousePosition.y-posY );
        //Vector3 curPos = new Vector3(Input.mousePosition.x - posX, Input.mousePosition.y - posY, dist.z);
        //Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
        //transform.position = worldPos;
		rig.AddForce (sqr);
    }

}

