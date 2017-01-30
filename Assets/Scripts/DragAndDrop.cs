using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour {
	Vector3 gameMousePostion;
	Vector3 editorMousePosition;

	void OnMouseEnter(){
	}
		
	void OnMouseExit(){
	}

	void OnMouseDown (){
	}

	void OnMouseUp(){
	}

	void OnMouseDrag (){
		gameMousePostion = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0);

		editorMousePosition = Camera.main.ScreenToWorldPoint (gameMousePostion);
	
		transform.position = new Vector3 (editorMousePosition.x, editorMousePosition.y, transform.position.z);
	}



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Quema") {
			Destroy (gameObject);
		}
		if (col.gameObject.tag == "Ganar") {
			Destroy (gameObject);
		}
	}
}
