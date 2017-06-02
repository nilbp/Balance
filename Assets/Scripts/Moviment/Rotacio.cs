using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacio : MonoBehaviour
{

    
    public float angle = 5f;
	public Rigidbody2D rigid;


    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
           transform.Rotate(-Vector3.back * angle);

        }
        if (Input.GetKey(KeyCode.D))
        {
           transform.Rotate(Vector3.back * angle);

        }
  

	}
}

