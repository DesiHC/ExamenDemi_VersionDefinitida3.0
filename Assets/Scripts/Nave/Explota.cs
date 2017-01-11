using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explota : MonoBehaviour {
	public GameObject plataforma;
	public GameObject explosion;
	public Animator panel_animator;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter2D (Collision2D Col) {
		panel_animator.SetBool ("Visible", true);
		Instantiate (explosion, transform.position, transform.rotation); //La minúscula indica que es el Transform del objeto en sí, el objeto donde está este script
		Destroy (plataforma);
		Destroy (gameObject); //Lo mismo con gameObject en minúscula. Se refiere al objeto donde está este script.
	}
}
