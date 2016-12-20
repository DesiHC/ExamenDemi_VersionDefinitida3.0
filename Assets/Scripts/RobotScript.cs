using UnityEngine;
using System.Collections;

public class RobotScript : MonoBehaviour {
	Rigidbody2D rigi;
	public float fuerza = 1;
	private GameControl gcs;

	// Use this for initialization
	void Start () {
		
		rigi = GetComponent<Rigidbody2D>();
		gcs = GameObject.Find ("GameControl").GetComponent<GameControl> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			rigi.AddForce (transform.right * fuerza);
			transform.localScale = new Vector3 (1, 1, 1);
		}
			

		if (Input.GetKey (KeyCode.LeftArrow)) {
			rigi.AddForce (transform.right * -fuerza);
			transform.localScale = new Vector3 (-1, 1, 1);
		}
	}



	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "muerte") {
			gcs.respawn ();
		}
	}
}
