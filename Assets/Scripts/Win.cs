using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Win : MonoBehaviour {
	public Text texto_marcador;
	int puntos = 0;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Caja"){
			Debug.Log ("Contacto");
			puntos += 1; // goles +1; (Es lo mismo)
			texto_marcador.text = puntos + "";
		}
	}
}
