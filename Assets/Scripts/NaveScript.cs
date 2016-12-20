﻿using UnityEngine;
using System.Collections;

public class NaveScript : MonoBehaviour {
	private GameControl gcs;
	public float power = 1f;
	private Rigidbody2D rb;
	public float giro = 1f;

	// Use this for initialization
	void Start () {
		gcs = GameObject.Find ("GameControl").GetComponent<GameControl> ();
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			rb.AddForce (new Vector2(0,power));
		}
		//if (Input.GetKey (KeyCode.RightArrow)) {
		//	rb.AddTorque (float giro);
		//}
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Asteroide") {
			gcs.respawn ();
		}
	}


}
	
