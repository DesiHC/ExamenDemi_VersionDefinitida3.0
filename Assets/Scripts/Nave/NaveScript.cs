using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NaveScript : MonoBehaviour {
	public float fuerza = 10f;
	public float giro = 0.5f;
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			rb.AddForce (transform.up * fuerza);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			rb.AddTorque (giro);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			rb.AddTorque (-giro);
		}
	}
}
	
