using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Marcador : MonoBehaviour {
	public Text texto_marcador;
	int goles = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (goles >= 5) {
			SceneManager.LoadScene ("Nave");
		
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.transform.name == "Balon"){
		 	goles += 1; // goles +1; (Es lo mismo)
			texto_marcador.text = goles + "";
		}
	}
}
