using UnityEngine;
using System.Collections;

public class RobotScript : MonoBehaviour {
	Rigidbody2D rb;
	public float fuerza = 1;
	public float velocidad = 5f;
	private GameControl gcs;

	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody2D>();
		gcs = GameObject.Find ("GameControl").GetComponent<GameControl> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			rb.velocity = new Vector2(velocidad*fuerza,rb.velocity.y);
			transform.localScale = new Vector3(1, 1, 1);
		}
			

		if (Input.GetKey (KeyCode.LeftArrow)) {
			rb.velocity = new Vector2(-velocidad*fuerza,rb.velocity.y);
			transform.localScale = new Vector3(-1, 1, 1);
		}
	}



	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "muerte") {
			gcs.respawn ();
		}
	}
}

