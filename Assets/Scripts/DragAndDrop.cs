using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour {
	Vector3 gameMousePostion;
	Vector3 editorMousePosition;

	void OnMouseEnter(){
		Debug.Log ("Entrando");
	}
		
	void OnMouseExit(){
		Debug.Log ("Saliendo");
	}

	void OnMouseDown (){
		Debug.Log ("Pulsado");
	}

	void OnMouseUp(){
		Debug.Log ("Fin Pulsado");
	}

	void OnMouseDrag (){
		Debug.Log ("Arrastrando");
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
}
