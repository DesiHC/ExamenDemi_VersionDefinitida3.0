using UnityEngine;
using System.Collections;

public class NaveScript : MonoBehaviour {
	private GameControl gcs;


	// Use this for initialization
	void Start () {
		gcs = GameObject.Find ("GameControl").GetComponent<GameControl> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Asteroide") {
			gcs.respawn ();
		}
	}

}
