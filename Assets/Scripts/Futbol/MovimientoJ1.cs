using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJ1 : MonoBehaviour {
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
		if(Input.GetKey(KeyCode.UpArrow)){
			vertical = 10;
		}

		if(Input.GetKey(KeyCode.DownArrow)){
			vertical = -10;
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			horizontal = -10;
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			horizontal = 10;
		}


		//--------------Get Key UP
		rb.velocity = new Vector2 (horizontal,vertical);


		if(Input.GetKeyUp(KeyCode.UpArrow)){
			vertical = 0;
		}

		if(Input.GetKeyUp(KeyCode.DownArrow)){
			vertical = 0;
		}
		if(Input.GetKeyUp(KeyCode.LeftArrow)){
			horizontal = 0;
		}
		if(Input.GetKeyUp(KeyCode.RightArrow)){
			horizontal = 0;
		}
	
	}
}
