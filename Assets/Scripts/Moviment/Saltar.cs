using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Saltar : MonoBehaviour
{

    public float alturaSalto;
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, alturaSalto);
        }
    }
}