using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJ2 : MonoBehaviour {
	Rigidbody2D rb;
	float horizontal = 0f;
	float vertical = 0f;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}



	// Update is called once per frame
	void Update () {


		//--------------Get Key DOWN
		if(Input.GetKey(KeyCode.W)){
			vertical = 10;
		}

		if(Input.GetKey(KeyCode.S)){
			vertical = -10;
		}
		if(Input.GetKey(KeyCode.A)){
			horizontal = -10;
		}
		if(Input.GetKey(KeyCode.D)){
			horizontal = 10;
		}


		//--------------Get Key UP
		rb.velocity = new Vector2 (horizontal,vertical);


		if(Input.GetKeyUp(KeyCode.W)){
			vertical = 0;
		}

		if(Input.GetKeyUp(KeyCode.S)){
			vertical = 0;
		}
		if(Input.GetKeyUp(KeyCode.A)){
			horizontal = 0;
		}
		if(Input.GetKeyUp(KeyCode.D)){
			horizontal = 0;
		}

	}
}
